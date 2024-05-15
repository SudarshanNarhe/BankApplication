using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerForm
{
    public partial class CheckBalance : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public CheckBalance()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(str);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Account where ac_no = @AcNo";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AcNo", txtAcNoCheckB.Text);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                       txtBalanceCheckB.Text = reader.GetDecimal(2).ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAcNoCheckB.Clear();
            txtBalanceCheckB.Clear();
        }
    }
}
