using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLDatabaseAssistant
{
    class SQL
    {
        private string connString;


        public SqlConnection getSqlConnection()
        {
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Server=" + txtInstance.Text + ";User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";";
            conn.ConnectionString = connString;

            return conn;
        }

        public void setSqlConnectionString(string instanceName, string userName, string password)
        {
            connString = @"Server=" + instanceName + ";User Id=" + userName + ";Password=" + password + ";";
        }


        public void detachDBs(SqlConnection conn, CheckedListBox chkDBList)
        {
            try
            {
                conn.Open();

                foreach (var DB in chkDBList.CheckedItems)
                {
                    //Forcibly disconnect any connections to the database
                    SqlCommand comm = new SqlCommand("alter database " + DB.ToString() + " set offline with rollback immediate", conn);
                    comm.ExecuteNonQuery();

                    //Detach the database
                    comm = new SqlCommand("sp_detach_db @dbname='" + DB.ToString() + "'", conn);
                    comm.ExecuteNonQuery();

                }
                MessageBox.Show("Detaching complete!");
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
    }
}
