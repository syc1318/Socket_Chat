namespace WinFormTest1
{
    partial class MkGroupName
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
            this.Groupname = new System.Windows.Forms.Label();
            this.inputGroupName = new System.Windows.Forms.TextBox();
            this.Ok_group = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Groupname
            // 
            this.Groupname.AutoSize = true;
            this.Groupname.Font = new System.Drawing.Font("굴림", 15F);
            this.Groupname.Location = new System.Drawing.Point(12, 20);
            this.Groupname.Name = "Groupname";
            this.Groupname.Size = new System.Drawing.Size(115, 20);
            this.Groupname.TabIndex = 0;
            this.Groupname.Text = "Group Name";
            // 
            // inputGroupName
            // 
            this.inputGroupName.Font = new System.Drawing.Font("굴림", 12F);
            this.inputGroupName.Location = new System.Drawing.Point(15, 54);
            this.inputGroupName.Name = "inputGroupName";
            this.inputGroupName.Size = new System.Drawing.Size(277, 26);
            this.inputGroupName.TabIndex = 1;
            // 
            // Ok_group
            // 
            this.Ok_group.Location = new System.Drawing.Point(15, 96);
            this.Ok_group.Name = "Ok_group";
            this.Ok_group.Size = new System.Drawing.Size(110, 33);
            this.Ok_group.TabIndex = 2;
            this.Ok_group.Text = "만들기";
            this.Ok_group.UseVisualStyleBackColor = true;
            this.Ok_group.Click += new System.EventHandler(this.Ok_group_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(182, 96);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(110, 33);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MkGroupName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 141);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok_group);
            this.Controls.Add(this.inputGroupName);
            this.Controls.Add(this.Groupname);
            this.Name = "MkGroupName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakingGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Groupname;
        private System.Windows.Forms.TextBox inputGroupName;
        private System.Windows.Forms.Button Ok_group;
        private System.Windows.Forms.Button Cancel;
    }
}