using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest1
{
    public partial class LoginID : Form
    {
        const string IdPlaceholder = "ID를 입력하세요.";
        Client client;
        bool idchk;
        public LoginID(Client c)
        {
            InitializeComponent();
            this.Focus();
            this.client = c;
            inputID.ForeColor = Color.DarkGray;
            inputID.Text = IdPlaceholder;
            inputID.GotFocus += RemovePlaceholder;
            inputID.LostFocus += SetPlaceholder;
        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
            }
        }
        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = IdPlaceholder;
            }
        }


        private void OK_Click_1(object sender, EventArgs e)
        {
            string id = inputID.Text.ToString();
            if(id == IdPlaceholder)
            {
                MessageBox.Show("ID를 입력해주세요.");
                inputID.Focus();
            }
            else
            {
                idchk = client.IDlogin(id);
                if (idchk)
                {
                    this.Visible = false;
                    GroupList showGroup = new GroupList(client);
                    showGroup.ShowDialog();
                    //ChattingRoom showChat = new ChattingRoom(client);
                    //showChat.ShowDialog();
                }
                else
                {
                    
                    inputID.Focus();
                }
            }
            
            
        }

        private void No_Click_1(object sender, EventArgs e)
        {
            client.IDlogin("guest quit");
            client.sendMsg(0,"quit");
            client.tcp.Close();
            Application.Exit();
        }

        private void LoginID_Load(object sender, EventArgs e)
        {
            this.FormClosed += Form_close;
        }
        public void Form_close(object sender, FormClosedEventArgs e)
        {
            this.No_Click_1(sender, e);
        }
    }
}
