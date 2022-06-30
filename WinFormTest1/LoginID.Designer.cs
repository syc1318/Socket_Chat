namespace WinFormTest1
{
    partial class LoginID
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputID = new System.Windows.Forms.TextBox();
            this.No = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // inputID
            // 
            this.inputID.Location = new System.Drawing.Point(60, 45);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(200, 21);
            this.inputID.TabIndex = 1;
            // 
            // No
            // 
            this.No.Location = new System.Drawing.Point(163, 98);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(130, 31);
            this.No.TabIndex = 7;
            this.No.Text = "Cancel";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click_1);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 98);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(130, 31);
            this.OK.TabIndex = 6;
            this.OK.Text = "Connect";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click_1);
            // 
            // LoginID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 141);
            this.Controls.Add(this.No);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.inputID);
            this.Controls.Add(this.label1);
            this.Name = "LoginID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginID";
            this.Load += new System.EventHandler(this.LoginID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button OK;
    }
}