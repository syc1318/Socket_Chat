using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace WinFormTest1
{
    public partial class GroupList : Form
    {
        Client client;
        List<string> grouplist;
        public GroupList(Client c)
        {
            this.client = c;

            InitializeComponent();
        }
        private void GroupList_Load(object sender, EventArgs e)
        {
            ShowGroup.Items.Clear();
            this.grouplist = client.groupShow();
            if (grouplist.Count == 0)
            {

            }
            else
            {
                for (int i = 0; i < grouplist.Count(); i++)
                {
                    ShowGroup.Items.Add(i + 1 + "번 방 : \" " + grouplist[i] + " \" ");
                }
            }
            this.FormClosed += Form_close;
        }
        private void ConnectGroup_Click(object sender, EventArgs e)
        {
            string sel;
            sel = ShowGroup.SelectedItem.ToString();
            int groupid = Int32.Parse(sel[0].ToString());
            if (client.connGroup(groupid) == groupid)
            {
                this.Visible = false;
                ChattingRoom showChat = new ChattingRoom(client, groupid);
                showChat.ShowDialog();
            }
        }

        private void mkGrp_Click(object sender, EventArgs e)
        {
            using (MkGroupName mk = new MkGroupName(client))
            {
                if (mk.ShowDialog() == DialogResult.OK)
                {
                    ShowGroup.Items.Clear();
                    this.grouplist = client.groupShow();
                    if (grouplist.Count == 0)
                    {

                    }
                    else
                    {
                        for(int i = 0; i < grouplist.Count(); i++)
                        {
                            ShowGroup.Items.Add( i+1 + "번 방 : \" " + grouplist[i] + " \" ");
                        }
                    }
                }
            }
        }



        //창닫기 액션
        public void Form_close(object sender, FormClosedEventArgs e)
        {
            this.Exit_Click(sender, e);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            client.sendMsg(0,"quit");  
            client.tcp.Close();

            MessageBox.Show(" *** 접속 종료. *** \n 안녕히 가십시오.");
            Application.Exit();
        }
    }

}
