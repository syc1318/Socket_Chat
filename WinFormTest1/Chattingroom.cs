using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace WinFormTest1
{

    public partial class ChattingRoom : Form
    {
        /*
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         */
        Client client;
        string groupName;
        int grpid;
        public ChattingRoom(Client c, int groupid)
        {
            InitializeComponent();
            this.client = c;
            this.grpid = groupid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = groupName;
            ChatString.ReadOnly = true;
            ChatString.AppendText("*** Chatting Client Connected *** \r\n");
            
            Thread t = new Thread(() => Run(client.tcp, client));

            t.Start();//메인 쓰레드 죽을때 같이 죽는지 확인.

            //comboBox 데이터 설정, 초기 콤보박스값 설정
            string[] data = { "All", "50", "100", "200", "500" };
            MsgLineCombo.Items.AddRange(data);
            MsgLineCombo.SelectedIndex = 0;
            this.FormClosed += Form_close;
        }
        
        
        private void Button1_Click(object sender, EventArgs e)
        {
            string msg = InputStringBox1.Text.ToString();
            
            if (msg == "/quit")
            {
                DialogResult quit = MessageBox.Show("종료 하시겠습니까?","종료 확인",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(quit == DialogResult.Yes)
                {
                    client.sendMsg(grpid,msg);
                    MessageBox.Show(" *** 접속 종료. *** \n 안녕히 가십시오.");
                    client.ns.Close();
                    client.tcp.Close();
                    Application.Exit();
                }
                else
                {

                }
            }

            /*
             * 귓속말 
             */
            //else if (msg.IndexOf("/to") == 0)
            //{
            //    int begin = msg.IndexOf(" ") + 1;
            //    int end = msg.IndexOf(" ", begin);
            //    string ids = null;
            //    string msgs = null;
            //    if (end != -1)
            //    {
            //        ids = msg.Substring(begin, end-begin);
            //        msgs = msg.Substring(end + 1);
            //    }
            //    client.sendMsg(msg);
            //    ChatString.AppendText("["+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+"] "+ids +"에게 >> " + msgs + "\r\n");
            //}

            //콤보박스 테스트용 
            else if (msg == "count")
            {
                for (int i = 0; i < 600; i++)
                {
                    client.sendMsg(grpid, i.ToString());
                    ChatString.AppendText("count is "+i.ToString()+"\r\n");
                }
            }
            else
            {
                client.sendMsg(grpid, msg);

                /*에코 기능이 아닌 자기자신은 제외하고 브로드캐스트 하고 
                 * 자기가 보낸 메세지는 바로 텍스트로 보내는 방식에서
                 * 자기 자신 포함해서 메세지를 전부 뿌리고
                 * 본인도 받아오는 에코기능으로 전환
                 */
                //ChatString.AppendText("[" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "] "+ "나(자신) >> " + msg + "\r\n");
            }
            InputStringBox1.Clear();
            this.MsgLineCombo_SelectionChangeCommitted(sender,e);
        }

        

        //엔터 입력시 버튼 클릭기능과 동일하게 동작
        private void InputStringBox1_KeyDown(object sender, KeyEventArgs e)
        {         
            if (e.KeyCode == Keys.Enter)
            {
                this.Button1_Click(sender, e);
            }
        }

        //메세지 수신 스레드
        private void Run(TcpClient c, Client client)
        {
            byte[] receiveData = client.recvMsg();
            if(BitConverter.ToInt32(client.readPck(receiveData, 3), 0) == grpid)
            {
                try
                {
                    while (receiveData != null)
                    {//폼을 만들어주는 스레드와 충돌..C#4.5 이상부터 다른 방식이 존재.
                        if (ChatString.InvokeRequired)
                        {
                            ChatString.Invoke(new MethodInvoker(delegate { ChatString.AppendText("[" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "] " + Encoding.Default.GetString(client.readPck(receiveData, 4))+ "\r\n"); }));
                        }
                        else
                        {
                            ChatString.AppendText("[" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "] " + Encoding.Default.GetString(client.readPck(receiveData, 4)) + "\r\n");
                        }
                        receiveData = client.recvMsg();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    try
                    {
                        c.Close();
                    }
                    catch (IOException e2)
                    {
                        Console.WriteLine(e2.Message);
                    }
                }
            }
        }

        //접속한 유저 리스트 받아오기
        private void ConnectedUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //보여주는 메세지 양 조절 콤보박스
        private void MsgLineCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int limitNum = 32767;
            string lim = MsgLineCombo.Text;
            if (lim == "All")
            {
                ChatString.SelectionStart = ChatString.Text.Length;
                ChatString.ScrollToCaret();
            }
            else
            {
                limitNum = int.Parse(MsgLineCombo.Text);
                if (ChatString.Lines.Length > limitNum)
                {
                    string[] newLines = new string[limitNum];
                    Array.Copy(ChatString.Lines, ChatString.Lines.Length-limitNum-1, newLines, 0, limitNum);
                    ChatString.Lines = newLines;
                }
                ChatString.SelectionStart = ChatString.Text.Length;
                ChatString.ScrollToCaret();
            }

        }

        //수직 스크롤 활성화
        private void ChatString_TextChanged(object sender, EventArgs e)
        {
            ChatString.ScrollBars = ScrollBars.Vertical;
        }

        //창닫기 액션
        public void Form_close(object sender, FormClosedEventArgs e)
        {
            client.sendMsg(grpid, "quit");
            MessageBox.Show(" *** 접속 종료. *** \n 안녕히 가십시오.");
            client.ns.Close();
            client.tcp.Close();
            Application.Exit();
        }

        //입력창 툴팁
        private void InputStringBox1_MouseHover(object sender, EventArgs e)
        {
            this.tool.SetToolTip(InputStringBox1, "count : 콤보 박스 테스트용 숫자입력");
        }
    }
}
