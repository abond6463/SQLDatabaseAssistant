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
    public partial class Form1 : Form
    {
        private SQL mySQL;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            SqlConnection conn = mySQL.getSqlConnection();

            mySQL.detachDBs(conn,chkLstInstanceDB);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = mySQL.getSqlConnection();

            backupDBs(conn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySQL = new SQL();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            SqlConnection conn = mySQL.getSqlConnection();
            try
            {
                conn.Open();

                chkLstInstanceDB.Items.Clear();

                var da = new SqlDataAdapter("SELECT Name FROM master.sys.databases WHERE database_id > 4", conn);

                var ds = new DataSet();
                da.Fill(ds);
                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        chkLstInstanceDB.Items.Add(dr["name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        

        

        private void backupDBs(SqlConnection conn)
        {
            try
            {
                conn.Open();

                foreach (var DB in chkLstInstanceDB.CheckedItems)
                {
                    //Instantiate a SQL Command with an INSERT query
                    string filename = txtBkpPath.Text + DB.ToString() +"_" + DateTime.Now.ToString("yyyyddMMHHmmss") + ".bak";
                    SqlCommand comm = new SqlCommand("BACKUP DATABASE " + DB.ToString() + " TO DISK = '" + filename + "'", conn);
                    comm.CommandTimeout = 360;
                    //Execute the query
                    comm.ExecuteNonQuery();

                }
                MessageBox.Show("Backup complete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                conn.Open();

                foreach (var DB in chkLstInstanceDB.CheckedItems)
                {
                    //Set the AUTO_CLOSE property to OFF
                    SqlCommand comm = new SqlCommand("alter database " + DB.ToString() + " set auto_close off", conn);
                    comm.ExecuteNonQuery();
                }
                MessageBox.Show("Disabling Auto Close Complete!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDisAutoClose_Click(object sender, EventArgs e)
        {
            SqlConnection conn = mySQL.getSqlConnection();
            disableAutoClose(conn);
        }

        
    }
}
