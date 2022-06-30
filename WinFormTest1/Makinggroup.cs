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
    public partial class MkGroupName : Form
    {
        Client client;
        public MkGroupName(Client c)
        {
            InitializeComponent();
            this.client = c;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ok_group_Click(object sender, EventArgs e)
        {
            string gr = inputGroupName.Text;
            client.mkGroup(gr);
            
            this.DialogResult = DialogResult.OK;
            this.Visible = false;
        }
    }
}
