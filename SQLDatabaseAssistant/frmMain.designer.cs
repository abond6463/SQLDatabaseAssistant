namespace SQLDatabaseAssistant
{
    partial class frmMain
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
            this.txtBackupInstance = new System.Windows.Forms.TextBox();
            this.txtBackupUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBackupPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLstBackupInstanceDB = new System.Windows.Forms.CheckedListBox();
            this.btnDetach = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBackupLoadDB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBkpPath = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnDisAutoClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.Backup = new System.Windows.Forms.TabPage();
            this.Restore = new System.Windows.Forms.TabPage();
            this.Other = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOtherInstance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOtherUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOtherLoadDB = new System.Windows.Forms.Button();
            this.txtOtherPassword = new System.Windows.Forms.TextBox();
            this.chkLstOtherInstanceDB = new System.Windows.Forms.CheckedListBox();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkRestoreSubfolders = new System.Windows.Forms.CheckBox();
            this.txtRestorePassword = new System.Windows.Forms.TextBox();
            this.txtRestoreUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRestorePrefix = new System.Windows.Forms.TextBox();
            this.txtRestoreSuffix = new System.Windows.Forms.TextBox();
            this.txtRestoreInstance = new System.Windows.Forms.TextBox();
            this.txtRestoreLOGPath = new System.Windows.Forms.TextBox();
            this.txtRestoreDATAPath = new System.Windows.Forms.TextBox();
            this.txtRestoreBackupPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.fbdFolderPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBackupPathSelection = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.Backup.SuspendLayout();
            this.Restore.SuspendLayout();
            this.Other.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Server Instance:";
            // 
            // txtBackupInstance
            // 
            this.txtBackupInstance.Location = new System.Drawing.Point(131, 8);
            this.txtBackupInstance.Name = "txtBackupInstance";
            this.txtBackupInstance.Size = new System.Drawing.Size(264, 20);
            this.txtBackupInstance.TabIndex = 1;
            // 
            // txtBackupUsername
            // 
            this.txtBackupUsername.Location = new System.Drawing.Point(131, 34);
            this.txtBackupUsername.Name = "txtBackupUsername";
            this.txtBackupUsername.Size = new System.Drawing.Size(264, 20);
            this.txtBackupUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // txtBackupPassword
            // 
            this.txtBackupPassword.Location = new System.Drawing.Point(131, 63);
            this.txtBackupPassword.Name = "txtBackupPassword";
            this.txtBackupPassword.Size = new System.Drawing.Size(264, 20);
            this.txtBackupPassword.TabIndex = 5;
            this.txtBackupPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // chkLstBackupInstanceDB
            // 
            this.chkLstBackupInstanceDB.CheckOnClick = true;
            this.chkLstBackupInstanceDB.FormattingEnabled = true;
            this.chkLstBackupInstanceDB.Location = new System.Drawing.Point(19, 118);
            this.chkLstBackupInstanceDB.Name = "chkLstBackupInstanceDB";
            this.chkLstBackupInstanceDB.Size = new System.Drawing.Size(376, 169);
            this.chkLstBackupInstanceDB.Sorted = true;
            this.chkLstBackupInstanceDB.TabIndex = 14;
            // 
            // btnDetach
            // 
            this.btnDetach.Location = new System.Drawing.Point(401, 7);
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Size = new System.Drawing.Size(112, 23);
            this.btnDetach.TabIndex = 15;
            this.btnDetach.Text = "Detach";
            this.btnDetach.UseVisualStyleBackColor = true;
            this.btnDetach.Click += new System.EventHandler(this.btnDetach_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(567, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBackupLoadDB
            // 
            this.btnBackupLoadDB.Location = new System.Drawing.Point(271, 89);
            this.btnBackupLoadDB.Name = "btnBackupLoadDB";
            this.btnBackupLoadDB.Size = new System.Drawing.Size(124, 23);
            this.btnBackupLoadDB.TabIndex = 17;
            this.btnBackupLoadDB.Text = "Load Databases";
            this.btnBackupLoadDB.UseVisualStyleBackColor = true;
            this.btnBackupLoadDB.Click += new System.EventHandler(this.BtnBackupLoadDB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Backup Path:";
            // 
            // txtBkpPath
            // 
            this.txtBkpPath.Location = new System.Drawing.Point(131, 293);
            this.txtBkpPath.Name = "txtBkpPath";
            this.txtBkpPath.Size = new System.Drawing.Size(264, 20);
            this.txtBkpPath.TabIndex = 19;
            this.txtBkpPath.Text = "C:\\test\\";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(401, 6);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(112, 23);
            this.btnBackup.TabIndex = 20;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDisAutoClose
            // 
            this.btnDisAutoClose.Location = new System.Drawing.Point(401, 33);
            this.btnDisAutoClose.Name = "btnDisAutoClose";
            this.btnDisAutoClose.Size = new System.Drawing.Size(112, 23);
            this.btnDisAutoClose.TabIndex = 21;
            this.btnDisAutoClose.Text = "Disable Auto Close";
            this.btnDisAutoClose.UseVisualStyleBackColor = true;
            this.btnDisAutoClose.Click += new System.EventHandler(this.btnDisAutoClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(702, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgressBar1
            // 
            this.tsProgressBar1.Maximum = 10;
            this.tsProgressBar1.Name = "tsProgressBar1";
            this.tsProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.tsProgressBar1.Step = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Log:";
            // 
            // TabControl1
            // 
            this.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl1.Controls.Add(this.Backup);
            this.TabControl1.Controls.Add(this.Restore);
            this.TabControl1.Controls.Add(this.Other);
            this.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl1.ItemSize = new System.Drawing.Size(25, 150);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(680, 336);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabIndex = 25;
            this.TabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl1_DrawItem);
            // 
            // Backup
            // 
            this.Backup.Controls.Add(this.btnBackupPathSelection);
            this.Backup.Controls.Add(this.btnBackup);
            this.Backup.Controls.Add(this.label1);
            this.Backup.Controls.Add(this.txtBackupInstance);
            this.Backup.Controls.Add(this.label2);
            this.Backup.Controls.Add(this.txtBkpPath);
            this.Backup.Controls.Add(this.txtBackupUsername);
            this.Backup.Controls.Add(this.label4);
            this.Backup.Controls.Add(this.label3);
            this.Backup.Controls.Add(this.btnBackupLoadDB);
            this.Backup.Controls.Add(this.txtBackupPassword);
            this.Backup.Controls.Add(this.chkLstBackupInstanceDB);
            this.Backup.Location = new System.Drawing.Point(154, 4);
            this.Backup.Name = "Backup";
            this.Backup.Padding = new System.Windows.Forms.Padding(3);
            this.Backup.Size = new System.Drawing.Size(522, 328);
            this.Backup.TabIndex = 0;
            this.Backup.Text = "Backup";
            this.Backup.UseVisualStyleBackColor = true;
            // 
            // Restore
            // 
            this.Restore.Controls.Add(this.btnRestore);
            this.Restore.Controls.Add(this.chkRestoreSubfolders);
            this.Restore.Controls.Add(this.txtRestorePassword);
            this.Restore.Controls.Add(this.txtRestoreUsername);
            this.Restore.Controls.Add(this.label9);
            this.Restore.Controls.Add(this.label10);
            this.Restore.Controls.Add(this.txtRestorePrefix);
            this.Restore.Controls.Add(this.txtRestoreSuffix);
            this.Restore.Controls.Add(this.txtRestoreInstance);
            this.Restore.Controls.Add(this.txtRestoreLOGPath);
            this.Restore.Controls.Add(this.txtRestoreDATAPath);
            this.Restore.Controls.Add(this.txtRestoreBackupPath);
            this.Restore.Controls.Add(this.label11);
            this.Restore.Controls.Add(this.label12);
            this.Restore.Controls.Add(this.label13);
            this.Restore.Controls.Add(this.label14);
            this.Restore.Controls.Add(this.label15);
            this.Restore.Controls.Add(this.label16);
            this.Restore.Location = new System.Drawing.Point(154, 4);
            this.Restore.Name = "Restore";
            this.Restore.Padding = new System.Windows.Forms.Padding(3);
            this.Restore.Size = new System.Drawing.Size(684, 328);
            this.Restore.TabIndex = 1;
            this.Restore.Text = "Restore";
            this.Restore.UseVisualStyleBackColor = true;
            // 
            // Other
            // 
            this.Other.Controls.Add(this.label6);
            this.Other.Controls.Add(this.txtOtherInstance);
            this.Other.Controls.Add(this.label7);
            this.Other.Controls.Add(this.txtOtherUsername);
            this.Other.Controls.Add(this.label8);
            this.Other.Controls.Add(this.btnOtherLoadDB);
            this.Other.Controls.Add(this.txtOtherPassword);
            this.Other.Controls.Add(this.chkLstOtherInstanceDB);
            this.Other.Controls.Add(this.btnDetach);
            this.Other.Controls.Add(this.btnDisAutoClose);
            this.Other.Location = new System.Drawing.Point(154, 4);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(684, 328);
            this.Other.TabIndex = 2;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "SQL Server Instance:";
            // 
            // txtOtherInstance
            // 
            this.txtOtherInstance.Location = new System.Drawing.Point(131, 9);
            this.txtOtherInstance.Name = "txtOtherInstance";
            this.txtOtherInstance.Size = new System.Drawing.Size(264, 20);
            this.txtOtherInstance.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Username:";
            // 
            // txtOtherUsername
            // 
            this.txtOtherUsername.Location = new System.Drawing.Point(131, 35);
            this.txtOtherUsername.Name = "txtOtherUsername";
            this.txtOtherUsername.Size = new System.Drawing.Size(264, 20);
            this.txtOtherUsername.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Password:";
            // 
            // btnOtherLoadDB
            // 
            this.btnOtherLoadDB.Location = new System.Drawing.Point(271, 90);
            this.btnOtherLoadDB.Name = "btnOtherLoadDB";
            this.btnOtherLoadDB.Size = new System.Drawing.Size(124, 23);
            this.btnOtherLoadDB.TabIndex = 29;
            this.btnOtherLoadDB.Text = "Load Databases";
            this.btnOtherLoadDB.UseVisualStyleBackColor = true;
            this.btnOtherLoadDB.Click += new System.EventHandler(this.BtnOtherLoadDB_Click);
            // 
            // txtOtherPassword
            // 
            this.txtOtherPassword.Location = new System.Drawing.Point(131, 64);
            this.txtOtherPassword.Name = "txtOtherPassword";
            this.txtOtherPassword.Size = new System.Drawing.Size(264, 20);
            this.txtOtherPassword.TabIndex = 27;
            this.txtOtherPassword.UseSystemPasswordChar = true;
            // 
            // chkLstOtherInstanceDB
            // 
            this.chkLstOtherInstanceDB.CheckOnClick = true;
            this.chkLstOtherInstanceDB.FormattingEnabled = true;
            this.chkLstOtherInstanceDB.Location = new System.Drawing.Point(19, 119);
            this.chkLstOtherInstanceDB.Name = "chkLstOtherInstanceDB";
            this.chkLstOtherInstanceDB.Size = new System.Drawing.Size(376, 169);
            this.chkLstOtherInstanceDB.Sorted = true;
            this.chkLstOtherInstanceDB.TabIndex = 28;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Message});
            this.dgvLog.Location = new System.Drawing.Point(12, 369);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.Size = new System.Drawing.Size(549, 164);
            this.dgvLog.TabIndex = 26;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 120;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Time.Width = 120;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chkRestoreSubfolders
            // 
            this.chkRestoreSubfolders.AutoSize = true;
            this.chkRestoreSubfolders.Location = new System.Drawing.Point(131, 135);
            this.chkRestoreSubfolders.Name = "chkRestoreSubfolders";
            this.chkRestoreSubfolders.Size = new System.Drawing.Size(120, 17);
            this.chkRestoreSubfolders.TabIndex = 27;
            this.chkRestoreSubfolders.Text = "Include Subfolders?";
            this.chkRestoreSubfolders.UseVisualStyleBackColor = true;
            // 
            // txtRestorePassword
            // 
            this.txtRestorePassword.Location = new System.Drawing.Point(131, 63);
            this.txtRestorePassword.Name = "txtRestorePassword";
            this.txtRestorePassword.Size = new System.Drawing.Size(264, 20);
            this.txtRestorePassword.TabIndex = 22;
            this.txtRestorePassword.UseSystemPasswordChar = true;
            // 
            // txtRestoreUsername
            // 
            this.txtRestoreUsername.Location = new System.Drawing.Point(131, 36);
            this.txtRestoreUsername.Name = "txtRestoreUsername";
            this.txtRestoreUsername.Size = new System.Drawing.Size(264, 20);
            this.txtRestoreUsername.TabIndex = 20;
            this.txtRestoreUsername.Text = "censusapplication";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Username:";
            // 
            // txtRestorePrefix
            // 
            this.txtRestorePrefix.Location = new System.Drawing.Point(131, 210);
            this.txtRestorePrefix.Name = "txtRestorePrefix";
            this.txtRestorePrefix.Size = new System.Drawing.Size(135, 20);
            this.txtRestorePrefix.TabIndex = 30;
            // 
            // txtRestoreSuffix
            // 
            this.txtRestoreSuffix.Location = new System.Drawing.Point(131, 236);
            this.txtRestoreSuffix.Name = "txtRestoreSuffix";
            this.txtRestoreSuffix.Size = new System.Drawing.Size(135, 20);
            this.txtRestoreSuffix.TabIndex = 31;
            // 
            // txtRestoreInstance
            // 
            this.txtRestoreInstance.Location = new System.Drawing.Point(131, 9);
            this.txtRestoreInstance.Name = "txtRestoreInstance";
            this.txtRestoreInstance.Size = new System.Drawing.Size(264, 20);
            this.txtRestoreInstance.TabIndex = 18;
            // 
            // txtRestoreLOGPath
            // 
            this.txtRestoreLOGPath.Location = new System.Drawing.Point(131, 184);
            this.txtRestoreLOGPath.Name = "txtRestoreLOGPath";
            this.txtRestoreLOGPath.Size = new System.Drawing.Size(264, 20);
            this.txtRestoreLOGPath.TabIndex = 29;
            // 
            // txtRestoreDATAPath
            // 
            this.txtRestoreDATAPath.Location = new System.Drawing.Point(131, 158);
            this.txtRestoreDATAPath.Name = "txtRestoreDATAPath";
            this.txtRestoreDATAPath.Size = new System.Drawing.Size(264, 20);
            this.txtRestoreDATAPath.TabIndex = 28;
            // 
            // txtRestoreBackupPath
            // 
            this.txtRestoreBackupPath.Location = new System.Drawing.Point(131, 109);
            this.txtRestoreBackupPath.Name = "txtRestoreBackupPath";
            this.txtRestoreBackupPath.Size = new System.Drawing.Size(264, 20);
            this.txtRestoreBackupPath.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Add Prefix to DB name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Add Suffix to DB name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "SQL Server Instance:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "SQL LOG files path:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "SQL DATA files path:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Backup Folder Path:";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(401, 7);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(112, 23);
            this.btnRestore.TabIndex = 34;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // btnBackupPathSelection
            // 
            this.btnBackupPathSelection.Location = new System.Drawing.Point(401, 291);
            this.btnBackupPathSelection.Name = "btnBackupPathSelection";
            this.btnBackupPathSelection.Size = new System.Drawing.Size(75, 23);
            this.btnBackupPathSelection.TabIndex = 21;
            this.btnBackupPathSelection.Text = "...";
            this.btnBackupPathSelection.UseVisualStyleBackColor = true;
            this.btnBackupPathSelection.Click += new System.EventHandler(this.BtnBackupPathSelection_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 567);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmMain";
            this.Text = "SQL Database Assistant";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.Backup.ResumeLayout(false);
            this.Backup.PerformLayout();
            this.Restore.ResumeLayout(false);
            this.Restore.PerformLayout();
            this.Other.ResumeLayout(false);
            this.Other.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBackupInstance;
        private System.Windows.Forms.TextBox txtBackupUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBackupPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chkLstBackupInstanceDB;
        private System.Windows.Forms.Button btnDetach;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBackupLoadDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBkpPath;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnDisAutoClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage Backup;
        private System.Windows.Forms.TabPage Restore;
        private System.Windows.Forms.TabPage Other;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOtherInstance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOtherUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOtherLoadDB;
        private System.Windows.Forms.TextBox txtOtherPassword;
        private System.Windows.Forms.CheckedListBox chkLstOtherInstanceDB;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.CheckBox chkRestoreSubfolders;
        private System.Windows.Forms.TextBox txtRestorePassword;
        private System.Windows.Forms.TextBox txtRestoreUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRestorePrefix;
        private System.Windows.Forms.TextBox txtRestoreSuffix;
        private System.Windows.Forms.TextBox txtRestoreInstance;
        private System.Windows.Forms.TextBox txtRestoreLOGPath;
        private System.Windows.Forms.TextBox txtRestoreDATAPath;
        private System.Windows.Forms.TextBox txtRestoreBackupPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBackupPathSelection;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderPath;
    }
}

