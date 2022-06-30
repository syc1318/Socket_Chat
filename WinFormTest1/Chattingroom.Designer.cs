namespace WinFormTest1
{
    partial class ChattingRoom
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EnterButton1 = new System.Windows.Forms.Button();
            this.InputStringBox1 = new System.Windows.Forms.TextBox();
            this.MsgLineCombo = new System.Windows.Forms.ComboBox();
            this.ConnectedUser = new System.Windows.Forms.ListBox();
            this.ChatString = new System.Windows.Forms.TextBox();
            this.tool = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // EnterButton1
            // 
            this.EnterButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterButton1.Location = new System.Drawing.Point(454, 399);
            this.EnterButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterButton1.Name = "EnterButton1";
            this.EnterButton1.Size = new System.Drawing.Size(148, 33);
            this.EnterButton1.TabIndex = 0;
            this.EnterButton1.Text = "입력";
            this.EnterButton1.UseVisualStyleBackColor = true;
            this.EnterButton1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InputStringBox1
            // 
            this.InputStringBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputStringBox1.Location = new System.Drawing.Point(110, 399);
            this.InputStringBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputStringBox1.Name = "InputStringBox1";
            this.InputStringBox1.Size = new System.Drawing.Size(338, 21);
            this.InputStringBox1.TabIndex = 1;
            this.InputStringBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputStringBox1_KeyDown);
            this.InputStringBox1.MouseHover += new System.EventHandler(this.InputStringBox1_MouseHover);
            // 
            // MsgLineCombo
            // 
            this.MsgLineCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MsgLineCombo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.MsgLineCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MsgLineCombo.FormattingEnabled = true;
            this.MsgLineCombo.Location = new System.Drawing.Point(12, 399);
            this.MsgLineCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MsgLineCombo.Name = "MsgLineCombo";
            this.MsgLineCombo.Size = new System.Drawing.Size(92, 20);
            this.MsgLineCombo.TabIndex = 10;
            this.MsgLineCombo.SelectionChangeCommitted += new System.EventHandler(this.MsgLineCombo_SelectionChangeCommitted);
            // 
            // ConnectedUser
            // 
            this.ConnectedUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectedUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConnectedUser.ItemHeight = 12;
            this.ConnectedUser.Location = new System.Drawing.Point(454, 12);
            this.ConnectedUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectedUser.Name = "ConnectedUser";
            this.ConnectedUser.Size = new System.Drawing.Size(148, 364);
            this.ConnectedUser.TabIndex = 11;
            this.ConnectedUser.TabStop = false;
            this.ConnectedUser.SelectedIndexChanged += new System.EventHandler(this.ConnectedUser_SelectedIndexChanged);
            // 
            // ChatString
            // 
            this.ChatString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatString.Location = new System.Drawing.Point(12, 8);
            this.ChatString.Multiline = true;
            this.ChatString.Name = "ChatString";
            this.ChatString.Size = new System.Drawing.Size(436, 368);
            this.ChatString.TabIndex = 12;
            this.ChatString.TabStop = false;
            this.ChatString.TextChanged += new System.EventHandler(this.ChatString_TextChanged);
            // 
            // tool
            // 
            this.tool.IsBalloon = true;
            this.tool.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tool.ToolTipTitle = "명령어";
            // 
            // ChattingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 443);
            this.Controls.Add(this.ChatString);
            this.Controls.Add(this.InputStringBox1);
            this.Controls.Add(this.ConnectedUser);
            this.Controls.Add(this.MsgLineCombo);
            this.Controls.Add(this.EnterButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChattingRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chattingroom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton1;
        private System.Windows.Forms.TextBox InputStringBox1;
        private System.Windows.Forms.ComboBox MsgLineCombo;
        private System.Windows.Forms.ListBox ConnectedUser;
        private System.Windows.Forms.TextBox ChatString;
        private System.Windows.Forms.ToolTip tool;
    }
}

