using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLDatabaseAssistant
{
    public partial class frmMain : Form
    {
        //private SQL mySQL;

        public frmMain()
        {
            this.InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (chkLstInstanceDB.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a database before triggering one of the functions.");
            }
            else
            {
                this.BackupDBs(this.GetSqlConnection());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            if (chkLstInstanceDB.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a database before triggering one of the functions.");
            }
            else
            {
                this.DetachDBs(this.GetSqlConnection());
            }
        }

        private void btnDisAutoClose_Click(object sender, EventArgs e)
        {
            if (chkLstInstanceDB.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a database before triggering one of the functions.");
            }
            else
            {
                this.DisableAutoClose(this.GetSqlConnection());
            }
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = this.GetSqlConnection();
            try
            {
                try
                {
                    sqlConnection.Open();
                    this.chkLstInstanceDB.Items.Clear();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Name FROM master.sys.databases WHERE database_id > 4", sqlConnection);
                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);
                    foreach (DataTable table in dataSet.Tables)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            this.chkLstInstanceDB.Items.Add(row["name"].ToString());
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
                ResetProgressBar(this.chkLstInstanceDB.CheckedItems.Count);
                conn.Open();
                foreach (object checkedItem in this.chkLstInstanceDB.CheckedItems)
                {
                    WriteLog("Backup start - " + checkedItem.ToString());
                    try
                    {
                        string[] text = new string[] { this.txtBkpPath.Text, checkedItem.ToString(), "_", null, null };
                        text[3] = DateTime.Now.ToString("yyyyddMMHHmmss");
                        text[4] = ".bak";
                        string str = string.Concat(text);
                        text = new string[] { "BACKUP DATABASE [", checkedItem.ToString(), "] TO DISK = '", str, "'" };
                        SqlCommand sqlCommand = new SqlCommand(string.Concat(text), conn)
                        {
                            CommandTimeout = 0x168
                        };
                        sqlCommand.ExecuteNonQuery();
                        WriteLog("Backup Successful");
                    }
                    catch (Exception exception)
                    {
                        //MessageBox.Show(exception.Message);
                        WriteLog("ERROR: " + exception.Message);
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
                ResetProgressBar(this.chkLstInstanceDB.CheckedItems.Count);
                
                conn.Open();
                foreach (object checkedItem in this.chkLstInstanceDB.CheckedItems)
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
                        WriteLog("ERROR: " + exception.Message);
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
                ResetProgressBar(this.chkLstInstanceDB.CheckedItems.Count);
                conn.Open();
                foreach (object checkedItem in this.chkLstInstanceDB.CheckedItems)
                {
                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand(string.Concat("alter database [", checkedItem.ToString(), "] set auto_close off"), conn);
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
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

        private void WriteLog(string myLog)
        {
            txtLog.AppendText(DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss") + " -- " + myLog + Environment.NewLine);
        }

        private SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            string[] text = new string[] { "Server=", this.txtInstance.Text, ";User Id=", this.txtUsername.Text, ";Password=", this.txtPassword.Text, ";" };
            sqlConnection.ConnectionString = string.Concat(text);
            return sqlConnection;
        }
    }
}
