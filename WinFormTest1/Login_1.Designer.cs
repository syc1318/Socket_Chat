namespace WinFormTest1
{
    partial class Login_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputIP = new System.Windows.Forms.TextBox();
            this.inputPort = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(127, 27);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(191, 23);
            this.inputIP.TabIndex = 0;
            this.inputIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputIP_KeyPress);
            // 
            // inputPort
            // 
            this.inputPort.Location = new System.Drawing.Point(127, 56);
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(191, 23);
            this.inputPort.TabIndex = 1;
            this.inputPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPort_KeyPress);
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Font = new System.Drawing.Font("굴림", 10F);
            this.IP.Location = new System.Drawing.Point(26, 30);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(78, 14);
            this.IP.TabIndex = 2;
            this.IP.Text = "IP Address";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("굴림", 10F);
            this.Port.Location = new System.Drawing.Point(26, 60);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(34, 14);
            this.Port.TabIndex = 3;
            this.Port.Text = "Port";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(29, 106);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(136, 34);
            this.OK.TabIndex = 4;
            this.OK.Text = "Connect";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(183, 106);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(136, 34);
            this.No.TabIndex = 5;
            this.No.Text = "Cancel";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Login_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 153);
            this.Controls.Add(this.No);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.inputIP);
            this.Font = new System.Drawing.Font("굴림", 10F);
            this.MaximizeBox = false;
            this.Name = "Login_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP/Port";
            this.Load += new System.EventHandler(this.Login_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button No;
    }
}