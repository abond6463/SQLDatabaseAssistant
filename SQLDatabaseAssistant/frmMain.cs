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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void backupDBs(SqlConnection conn)
        {
            try
            {
                try
                {
                    conn.Open();
                    foreach (object checkedItem in this.chkLstInstanceDB.CheckedItems)
                    {
                        string[] text = new string[] { this.txtBkpPath.Text, checkedItem.ToString(), "_", null, null };
                        text[3] = DateTime.Now.ToString("yyyyddMMHHmmss");
                        text[4] = ".bak";
                        string str = string.Concat(text);
                        text = new string[] { "BACKUP DATABASE ", checkedItem.ToString(), " TO DISK = '", str, "'" };
                        SqlCommand sqlCommand = new SqlCommand(string.Concat(text), conn)
                        {
                            CommandTimeout = 0x168
                        };
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Backup complete!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            this.backupDBs(this.getSqlConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            this.detachDBs(this.getSqlConnection());
        }

        private void btnDisAutoClose_Click(object sender, EventArgs e)
        {
            this.disableAutoClose(this.getSqlConnection());
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = this.getSqlConnection();
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

        private void detachDBs(SqlConnection conn)
        {
            try
            {
                try
                {
                    conn.Open();
                    foreach (object checkedItem in this.chkLstInstanceDB.CheckedItems)
                    {
                        SqlCommand sqlCommand = new SqlCommand(string.Concat("alter database ", checkedItem.ToString(), " set offline with rollback immediate"), conn);
                        sqlCommand.ExecuteNonQuery();
                        sqlCommand = new SqlCommand(string.Concat("sp_detach_db @dbname='", checkedItem.ToString(), "'"), conn);
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Detaching complete!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void disableAutoClose(SqlConnection conn)
        {
            try
            {
                try
                {
                    conn.Open();
                    foreach (object checkedItem in this.chkLstInstanceDB.CheckedItems)
                    {
                        SqlCommand sqlCommand = new SqlCommand(string.Concat("alter database ", checkedItem.ToString(), " set auto_close off"), conn);
                        sqlCommand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Disabling Auto Close Complete!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private SqlConnection getSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            string[] text = new string[] { "Server=", this.txtInstance.Text, ";User Id=", this.txtUsername.Text, ";Password=", this.txtPassword.Text, ";" };
            sqlConnection.ConnectionString = string.Concat(text);
            return sqlConnection;
        }
    }
}
