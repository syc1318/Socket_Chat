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
    
    public partial class Login_1 : Form
    {
        const string IPPlaceholder = "IP 주소를 입력하세요.";
        const string PortPlaceholder = "Port 번호를 입력하세요.";
        public Client client;
        public string ip;
        public string port;
        bool loginChk = false;

        public Login_1()
        {
            InitializeComponent();
            this.Focus();
            inputIP.ForeColor = Color.DarkGray;
            inputIP.Text = IPPlaceholder;
            inputPort.ForeColor = Color.DarkGray;
            inputPort.Text = PortPlaceholder;
            inputIP.GotFocus += RemovePlaceholder;
            inputPort.GotFocus += RemovePlaceholder;
            inputIP.LostFocus += SetPlaceholder;
            inputPort.LostFocus += SetPlaceholder;

        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IPPlaceholder | txt.Text == PortPlaceholder)
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
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == inputIP)
                    txt.Text = IPPlaceholder;
                else if (txt == inputPort) {
                    txt.Text = PortPlaceholder;
                }
            }
        }

        private void No_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            ip = inputIP.Text.ToString();
            port = inputPort.Text.ToString();
            if (ip == IPPlaceholder || port == PortPlaceholder)
            {
                MessageBox.Show("입력 값이 부족합니다.");
                inputIP.Focus();
            }
            else
            {
                client = new Client(ip, port);

                loginChk = client.IPlogin();
                if (loginChk)
                {
                    this.Visible = false;
                    LoginID showNext = new LoginID(client);
                    showNext.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("잘못된 IP 및 Port 번호 입니다. \n 다시 한번 확인해 주세요.");
                    inputIP.Focus();
                }
            }
           
        }

        private void inputIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자+"."+ 백스페이스만 입력 가능하게 구현, 그러나 요구사항에 없는 내용으로 제외
            //if (!(char.IsDigit(e.KeyChar) ||e.KeyChar == 46|| e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            //{
            //    e.Handled = true;
            //}
        }

        private void inputPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }//입력 가능 범위 지정
        }

        private void Login_1_Load(object sender, EventArgs e)
        {
            this.FormClosed += Form_close;
        }
        public void Form_close(object sender, FormClosedEventArgs e)
        {
            this.No_Click(sender, e);
        }
    }
}
