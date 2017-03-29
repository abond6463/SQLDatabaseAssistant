namespace SQLDatabaseAssistant
{
    partial class Form1
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
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLstInstanceDB = new System.Windows.Forms.CheckedListBox();
            this.btnDetach = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBkpPath = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnDisAutoClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Server Instance:";
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(127, 23);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(184, 20);
            this.txtInstance.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(127, 49);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(127, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // chkLstInstanceDB
            // 
            this.chkLstInstanceDB.CheckOnClick = true;
            this.chkLstInstanceDB.FormattingEnabled = true;
            this.chkLstInstanceDB.Location = new System.Drawing.Point(15, 133);
            this.chkLstInstanceDB.Name = "chkLstInstanceDB";
            this.chkLstInstanceDB.Size = new System.Drawing.Size(296, 169);
            this.chkLstInstanceDB.Sorted = true;
            this.chkLstInstanceDB.TabIndex = 14;
            // 
            // btnDetach
            // 
            this.btnDetach.Location = new System.Drawing.Point(326, 21);
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Size = new System.Drawing.Size(112, 23);
            this.btnDetach.TabIndex = 15;
            this.btnDetach.Text = "Detach";
            this.btnDetach.UseVisualStyleBackColor = true;
            this.btnDetach.Click += new System.EventHandler(this.btnDetach_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(326, 306);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Location = new System.Drawing.Point(187, 104);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(124, 23);
            this.btnLoadDB.TabIndex = 17;
            this.btnLoadDB.Text = "Load Databases";
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Backup Path:";
            // 
            // txtBkpPath
            // 
            this.txtBkpPath.Location = new System.Drawing.Point(127, 308);
            this.txtBkpPath.Name = "txtBkpPath";
            this.txtBkpPath.Size = new System.Drawing.Size(184, 20);
            this.txtBkpPath.TabIndex = 19;
            this.txtBkpPath.Text = "C:\\test\\";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(326, 52);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(112, 23);
            this.btnBackup.TabIndex = 20;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDisAutoClose
            // 
            this.btnDisAutoClose.Location = new System.Drawing.Point(326, 82);
            this.btnDisAutoClose.Name = "btnDisAutoClose";
            this.btnDisAutoClose.Size = new System.Drawing.Size(112, 23);
            this.btnDisAutoClose.TabIndex = 21;
            this.btnDisAutoClose.Text = "Disable Auto Close";
            this.btnDisAutoClose.UseVisualStyleBackColor = true;
            this.btnDisAutoClose.Click += new System.EventHandler(this.btnDisAutoClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 367);
            this.Controls.Add(this.btnDisAutoClose);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtBkpPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoadDB);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetach);
            this.Controls.Add(this.chkLstInstanceDB);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInstance);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SQL Database Detacher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chkLstInstanceDB;
        private System.Windows.Forms.Button btnDetach;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBkpPath;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnDisAutoClose;
    }
}

