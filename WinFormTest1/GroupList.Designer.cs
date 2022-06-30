namespace WinFormTest1
{
    partial class GroupList
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
            this.ShowGroup = new System.Windows.Forms.ListBox();
            this.mkGrp = new System.Windows.Forms.Button();
            this.ConnectGroup = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowGroup
            // 
            this.ShowGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowGroup.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowGroup.FormattingEnabled = true;
            this.ShowGroup.ItemHeight = 20;
            this.ShowGroup.Location = new System.Drawing.Point(12, 52);
            this.ShowGroup.Name = "ShowGroup";
            this.ShowGroup.Size = new System.Drawing.Size(363, 604);
            this.ShowGroup.TabIndex = 0;
            // 
            // mkGrp
            // 
            this.mkGrp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mkGrp.Location = new System.Drawing.Point(268, 23);
            this.mkGrp.Name = "mkGrp";
            this.mkGrp.Size = new System.Drawing.Size(106, 23);
            this.mkGrp.TabIndex = 1;
            this.mkGrp.Text = "Make Group";
            this.mkGrp.UseVisualStyleBackColor = true;
            this.mkGrp.Click += new System.EventHandler(this.mkGrp_Click);
            // 
            // ConnectGroup
            // 
            this.ConnectGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectGroup.Location = new System.Drawing.Point(13, 682);
            this.ConnectGroup.Name = "ConnectGroup";
            this.ConnectGroup.Size = new System.Drawing.Size(168, 50);
            this.ConnectGroup.TabIndex = 2;
            this.ConnectGroup.Text = "Connect";
            this.ConnectGroup.UseVisualStyleBackColor = true;
            this.ConnectGroup.Click += new System.EventHandler(this.ConnectGroup_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(208, 682);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(170, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(12, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(228, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "접속 가능한 그룹 리스트";
            // 
            // GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 740);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ConnectGroup);
            this.Controls.Add(this.mkGrp);
            this.Controls.Add(this.ShowGroup);
            this.Name = "GroupList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupList";
            this.Load += new System.EventHandler(this.GroupList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ShowGroup;
        private System.Windows.Forms.Button mkGrp;
        private System.Windows.Forms.Button ConnectGroup;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox1;
    }
}