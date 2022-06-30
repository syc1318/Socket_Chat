using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Collections;
using System.Text;


namespace WinFormTest1
{
    class Packet
    {
        public int length;
        public string option;
        public int groupId;
        public string MessageBody;

        public Packet(byte[] p)
        {

        }
    }
    public class Client
    {
        public const int FLAG_SIZE = 4;
        private string ip;
        private string port;
        public TcpClient tcp;
        private string id;
        public NetworkStream ns;
        public List<string> list;
        bool check = false;
        public byte[] packet=null;
        int bdsize;
        public byte[] header = new byte[sizeof(int)];
        public byte[] flag = new byte[FLAG_SIZE];
        public byte[] grFlag = new byte[FLAG_SIZE];
        public byte[] body = null;

        public Client(string i, string p)
        {
            this.ip = i;
            this.port = p;
        }

        public bool IPlogin()
        {
            try
            {
                //tcp = new TcpClient(ip, Int32.Parse(port));
                tcp = new TcpClient(ip, Int32.Parse(port));

                //tcp.Connect(ip, Int32.Parse(port));
                if (tcp.Connected)
                {
                    //this.ns = tcp.GetStream();
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception e)
            {
                return false;
            }

        }

        public bool IDlogin(string d)
        {
            //ID 입력 후 로그인
            this.id = d;
            //ns = tcp.GetStream();
            sendPck("IPID", 0, id);

            byte[] recv = new byte[1000000];
            int recvsize = ns.Read(recv, 0, recv.Length);
            //byte[] result = Encoding.Default.GetString(recv[0],)
            string opt = Encoding.Default.GetString(readPck(recv, 4));

            if ( opt == "same")
            {
                MessageBox.Show("중복된 아이디 입니다.");
                return false;
            }
            else if (opt == "long")
            {
                MessageBox.Show("잘못된 아이디 입니다.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<string> groupShow()
        {
            //서버에 쇼 그룹 요청
            sendPck("show", 0, "");

            list = new List<string>();

            byte[] recv = new byte[1000000];
            ns.Read(recv, 0, recv.Length);

            string recvmsg = Encoding.Default.GetString(readPck(recv, 4));
            if (recvmsg == "exist")
            {
                byte[] recv2 = new byte[1000000];
                ns.Read(recv2, 0, recv2.Length);
                string cnt = Encoding.Default.GetString(readPck(recv2, 4));
                int icnt = int.Parse(cnt);
                for(int i = 0; i < icnt; i++)
                {
                    byte[] recv3 = new byte[1000000];
                    ns.Read(recv3, 0, recv3.Length);
                    string lst = Encoding.Default.GetString(readPck(recv3, 4));
                    list.Add(lst);
                }
                
            }
            return list;
        }

        public void mkGroup(string grname)
        {
            //서버에 그룹 메이킹 요청
            sendPck("mkgr", 0, grname);
        }

        public int connGroup(int grid)
        {
            //서버에 그룹 연결 요청
            sendPck("conn", grid, grid.ToString());
            byte[] recv = new byte[1000000];
            ns.Read(recv, 0, recv.Length);
            return BitConverter.ToInt32(readPck(recv,3), 0);
        }

        public void sendMsg(int groupid, string msg)
        {
            //메세지 전송
            sendPck("chat",groupid, msg);
            
        }

        public byte[] recvMsg()
        {
            byte[] recv = new byte[1000000];
            int recvsize = ns.Read(recv, 0, recv.Length);
            return recv;
        }
        
        public void sendPck(string offset, int groupid ,string msg)
        {
            ns = tcp.GetStream();

            body = Encoding.Default.GetBytes(msg);
            grFlag = BitConverter.GetBytes(groupid);
            flag = Encoding.Default.GetBytes(offset);
            header = BitConverter.GetBytes(body.Length+8);

            Array.Reverse(grFlag);
            Array.Reverse(header);
            List<byte> sum = new List<byte>();
            sum.AddRange(header);
            sum.AddRange(flag);
            sum.AddRange(grFlag);
            sum.AddRange(body);
            packet = sum.ToArray();

            ns.Write(packet, 0, packet.Length);
            ns.Flush();
        }

        public byte[] readPck(byte[] pck,int option)
        {
            byte[] hd = sliceByteArray(pck, 0, 4);
            byte[] op = sliceByteArray(pck, 4, 4);
            byte[] gr = sliceByteArray(pck, 8, 4);
            //Array.Reverse(gr);
            byte[] bd = sliceByteArray(pck, 12, BitConverter.ToInt32(hd, 0));
            switch (option)
            {
                case 1:
                    return hd;
                case 2:
                    return op;
                case 3:
                    return gr;
                default:
                    return bd;

            }
        }

        public byte[] sliceByteArray(byte[] arr, int begin, int size)
        {
            byte[] temp = new byte[size];
            for (int i = 0; i < size; i++)
            {
                temp[i] = arr[begin];
                begin++;
            }
            return temp;
        }
    }
}
