using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SQLDatabaseAssistant
{
    public partial class frmMain : Form
    {
        //private SQL mySQL;
        private enum LogType { Log, Error, Warning };

        public frmMain()
        {
            this.InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)

        {

            Graphics g = e.Graphics;

            Brush _textBrush;



            // Get the item from the collection.

            TabPage _tabPage = TabControl1.TabPages[e.Index];



            // Get the real bounds for the tab rectangle.

            Rectangle _tabBounds = TabControl1.GetTabRect(e.Index);



            if (e.State == DrawItemState.Selected)

            {



                // Draw a different background color, and don't paint a focus rectangle.

                _textBrush = new SolidBrush(Color.White);

                g.FillRectangle(Brushes.DarkOrange, e.Bounds);

            }

            else

            {

                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);

                e.DrawBackground();

            }



            // Use our own font.

            Font _tabFont = new Font("Microsoft Sans Serif", (float)12.0, FontStyle.Bold, GraphicsUnit.Pixel);



            // Draw string. Center the text.

            StringFormat _stringFlags = new StringFormat();

            _stringFlags.Alignment = StringAlignment.Center;

            _stringFlags.LineAlignment = StringAlignment.Center;

            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));



        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (chkLstBackupInstanceDB.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a database before triggering one of the functions.");
            }
            else
            {
                ClearLog();
                this.BackupDBs(this.GetSqlConnection(txtBackupInstance.Text, txtBackupUsername.Text, txtBackupPassword.Text));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            if (chkLstOtherInstanceDB.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a database before triggering one of the functions.");
            }
            else
            {
                ClearLog();
                this.DetachDBs(this.GetSqlConnection(txtOtherInstance.Text, txtOtherUsername.Text, txtOtherPassword.Text));
            }
        }

        private void btnDisAutoClose_Click(object sender, EventArgs e)
        {
            if (chkLstOtherInstanceDB.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a database before triggering one of the functions.");
            }
            else
            {
                ClearLog();
                this.DisableAutoClose(this.GetSqlConnection(txtOtherInstance.Text, txtOtherUsername.Text, txtOtherPassword.Text));
            }
        }

        private void BtnBackupLoadDB_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = this.GetSqlConnection(txtBackupInstance.Text, txtBackupUsername.Text, txtBackupPassword.Text);
            try
            {
                try
                {
                    sqlConnection.Open();
                    this.chkLstBackupInstanceDB.Items.Clear();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Name FROM master.sys.databases WHERE database_id > 4", sqlConnection);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);
                    foreach (DataTable table in dataSet.Tables)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            this.chkLstBackupInstanceDB.Items.Add(row["name"].ToString());
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void BackupDBs(SqlConnection conn)
        {
            try
            {
                ResetProgressBar(this.chkLstBackupInstanceDB.CheckedItems.Count);
                conn.Open();
                foreach (object DB in this.chkLstBackupInstanceDB.CheckedItems)
                {
                    WriteLog("Backup start - " + DB.ToString());
                    try
                    {
                        //Generate filename
                        string filename;
                        if(txtBkpPath.Text.Substring(txtBkpPath.Text.Length-1, 1) != @"\")
                        {
                            filename = txtBkpPath.Text + @"\" + DB.ToString() + @"_" + DateTime.Now.ToString("yyyyddMMHHmmss") + @".bak";
                        }
                        else
                        {
                            filename = txtBkpPath.Text + DB.ToString() + @"_" + DateTime.Now.ToString("yyyyddMMHHmmss") + @".bak";
                        }
                        //Instantiate a SQL Command with an INSERT query
                        SqlCommand comm = new SqlCommand("BACKUP DATABASE [" + DB.ToString() + "] TO DISK = '" + filename + "'", conn)
                        {
                            CommandTimeout = 360
                        };
                        //Execute the query
                        comm.ExecuteNonQuery();

                        WriteLog("Backup Successful");
                    }
                    catch (Exception exception)
                    {
                        //MessageBox.Show(exception.Message);
                        WriteLog("ERROR: " + exception.Message, LogType.Error);
                    }
                    finally
                    {
                        UpdateProgressBar();
                    }
                }
                //MessageBox.Show("Backup complete!");
                WriteLog("BACKUP COMPLETE!");

            }
            finally
            {
                conn.Close();
            }
        }

        private void DetachDBs(SqlConnection conn)
        {
            try
            {
                ResetProgressBar(this.chkLstOtherInstanceDB.CheckedItems.Count);
                
                conn.Open();
                foreach (object checkedItem in this.chkLstOtherInstanceDB.CheckedItems)
                {
                    WriteLog("Detach start - " + checkedItem.ToString());
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand(string.Concat("alter database [", checkedItem.ToString(), "] set offline with rollback immediate"), conn);
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand = new SqlCommand(string.Concat("sp_detach_db @dbname='", checkedItem.ToString(), "'"), conn);
                        sqlCommand.ExecuteNonQuery();
                        WriteLog("Detach Successful");
                    }
                    catch (Exception exception)
                    {
                        //MessageBox.Show(exception.Message);
                        WriteLog("ERROR: " + exception.Message, LogType.Error);
                    }
                    finally
                    {
                        UpdateProgressBar();
                    }
                }
                //MessageBox.Show("Detaching complete!");
                WriteLog("DETACHING COMPLETE!");
                
            }
            finally
            {
                conn.Close();
            }
        }

        private void DisableAutoClose(SqlConnection conn)
        {
            try
            {
                ResetProgressBar(this.chkLstOtherInstanceDB.CheckedItems.Count);
                conn.Open();
                foreach (object checkedItem in this.chkLstOtherInstanceDB.CheckedItems)
                {
                    WriteLog("Disabling Auto Close - " + checkedItem.ToString());
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand(string.Concat("alter database [", checkedItem.ToString(), "] set auto_close off"), conn);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        //MessageBox.Show(exception.Message);
                        WriteLog("ERROR: " + exception.Message, LogType.Error);
                    }
                    finally
                    {
                        UpdateProgressBar();
                    }
                }
                //MessageBox.Show("Disabling Auto Close Complete!");
                WriteLog("DISABLE AUTO CLOSE COMPLETE!");
            }
            finally
            {
                conn.Close();
            }
        }

        private void ResetProgressBar(int max)
        {
            tsProgressBar1.Maximum = max;
            tsProgressBar1.Value = 0;
        }

        private void UpdateProgressBar()
        {
            tsProgressBar1.PerformStep();
        }

        private void WriteLog(string myLog, LogType myLogType = LogType.Log)
        {
            //txtLog.AppendText(DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss") + " -- " + myLog + Environment.NewLine);
            var row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss") });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = myLog + Environment.NewLine });
            if (myLogType == LogType.Error)
            {
                row.DefaultCellStyle.BackColor = Color.DarkRed;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else if (myLogType == LogType.Warning)
            {
                row.DefaultCellStyle.BackColor = Color.DarkOrange;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            dgvLog.Rows.Add(row);
        }

        private void ClearLog()
        {
            //txtLog.Clear();
            dgvLog.Rows.Clear();
        }

        private SqlConnection GetSqlConnection(string connInstance, string connUsername, string connPassword)
        {
            SqlConnection sqlConnection = new SqlConnection();
            string[] text = new string[] { "Server=", connInstance, ";User Id=", connUsername, ";Password=", connPassword, ";" };
            sqlConnection.ConnectionString = string.Concat(text);
            return sqlConnection;
        }

        private bool SQLDBExists(string databaseName, SqlConnection conn)
        {
            bool result = false;

            try
            {

                string sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name  = '{0}'", databaseName);
                using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, conn))
                {
                    object resultObj = sqlCmd.ExecuteScalar();

                    int databaseID = 0;

                    if (resultObj != null)
                    {
                        int.TryParse(resultObj.ToString(), out databaseID);
                    }

                    result = (databaseID > 0);
                }

            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        private void BtnOtherLoadDB_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = this.GetSqlConnection(txtOtherInstance.Text, txtOtherUsername.Text, txtOtherPassword.Text);
            try
            {
                try
                {
                    sqlConnection.Open();
                    this.chkLstOtherInstanceDB.Items.Clear();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Name FROM master.sys.databases WHERE database_id > 4", sqlConnection);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);
                    foreach (DataTable table in dataSet.Tables)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            this.chkLstOtherInstanceDB.Items.Add(row["name"].ToString());
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            ClearLog();
            RestoreDB(GetSqlConnection(txtRestoreInstance.Text, txtRestoreUsername.Text, txtRestorePassword.Text));
        }

        private void RestoreDB(SqlConnection conn)
        {
            try
            {
                //ResetProgressBar(this.chkLstInstanceDB.CheckedItems.Count);
                string dataFilePath = txtRestoreDATAPath.Text;
                string logFilePath = txtRestoreLOGPath.Text;
                string prefix = txtRestorePrefix.Text;
                string suffix = txtRestoreSuffix.Text;
                string[] files;

                //Retrieve a list of backups to restore
                if (chkRestoreSubfolders.Checked)
                {
                    files = Directory.GetFileSystemEntries(txtRestoreBackupPath.Text, "*.bak", SearchOption.AllDirectories);
                }
                else
                {
                    files = Directory.GetFileSystemEntries(txtRestoreBackupPath.Text, "*.bak", SearchOption.TopDirectoryOnly);
                }

                if (dataFilePath.Substring(dataFilePath.Length - 1, 1) != @"\")
                {
                    dataFilePath = dataFilePath + @"\";
                }

                if (logFilePath.Substring(logFilePath.Length - 1, 1) != @"\")
                {
                    logFilePath = dataFilePath + @"\";
                }


                conn.Open();
                //WriteLog(files.Length.ToString());
                foreach (object File in files)
                {
                    string logicalDataName = "";
                    string logicalLogName = "";
                    string databaseName = "";

                    WriteLog("Restore start - " + File.ToString());
                    try
                    {
                        // 1 -- Start by retrieving the logical file names
                        string SQLQuery_Filelist = @"RESTORE FILELISTONLY FROM DISK = N'" + File.ToString() + "'";

                        SqlCommand comm = new SqlCommand(SQLQuery_Filelist, conn)
                        {
                            CommandTimeout = 360
                        };

                        //Execute the query
                        SqlDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            string type = reader["Type"].ToString();
                            switch (type)
                            {
                                case "D":
                                    logicalDataName = reader["LogicalName"].ToString();
                                    break;
                                case "L":
                                    logicalLogName = reader["LogicalName"].ToString();
                                    break;
                            }
                        }
                        reader.Close();

                        // 2 -- Retrieve the Database name from the header
                        string SQLQuery_Header = @"RESTORE HEADERONLY FROM DISK = N'" + File.ToString() + "'";
                        comm = new SqlCommand(SQLQuery_Header, conn)
                        {
                            CommandTimeout = 360
                        };
                        reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            databaseName = reader["DatabaseName"].ToString();
                        }
                        reader.Close();

                        // 3 -- Check if DB exists already
                        bool doesDBExist = SQLDBExists(prefix + databaseName + suffix, conn);

                        // 4 -- Perform the restoration

                        if (doesDBExist)
                        {
                            //Set Database to be SINGLE_USER and force existing connections to close
                            string SQLQuery_SetSingleUser = @"ALTER DATABASE [" + prefix + databaseName + suffix + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                            comm = new SqlCommand(SQLQuery_SetSingleUser, conn)
                            {
                                CommandTimeout = 7200
                            };
                            comm.ExecuteNonQuery();
                        }

                        string SQLQuery_Restore = @"RESTORE DATABASE [" + prefix + databaseName + suffix + "] FROM DISK = N'" + File.ToString() + "' WITH REPLACE, MOVE N'" + logicalDataName + "' TO N'" + dataFilePath + prefix + databaseName + suffix + ".mdf', MOVE N'" + logicalLogName + "' TO N'" + logFilePath + prefix + databaseName + "_log" + suffix + ".ldf'";
                        comm = new SqlCommand(SQLQuery_Restore, conn)
                        {
                            CommandTimeout = 7200
                        };
                        comm.ExecuteNonQuery();

                        if (doesDBExist)
                        {
                            //Set Database back to MULTI_USER
                            string SQLQuery_SetSingleUser = @"ALTER DATABASE [" + prefix + databaseName + suffix + "] SET MULTI_USER";
                            comm = new SqlCommand(SQLQuery_SetSingleUser, conn)
                            {
                                CommandTimeout = 7200
                            };
                            comm.ExecuteNonQuery();
                        }

                        WriteLog("Restore Successful");
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(exception.Message);
                        WriteLog("ERROR: " + ex.Message, LogType.Error);
                    }
                    finally
                    {
                        //UpdateProgressBar();
                    }
                }
                //MessageBox.Show("Backup complete!");
                WriteLog("BACKUP COMPLETE!");

            }
            finally
            {
                conn.Close();
            }
        }

        private void BtnBackupPathSelection_Click(object sender, EventArgs e)
        {
            using (fbdFolderPath)
            {
                DialogResult result = fbdFolderPath.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbdFolderPath.SelectedPath))
                {
                    //string[] files = Directory.GetFiles(fbdFolderPath.SelectedPath);

                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

                    txtBkpPath.Text = fbdFolderPath.SelectedPath;
                }
            }
        }
    }
}
