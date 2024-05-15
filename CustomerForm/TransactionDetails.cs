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
    public partial class TransactionDetails : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public TransactionDetails()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(str);
        }

      

        private void btnShowData_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select t.ac_no as 'Account Number' , customer_name as 'Customer Name', " +
                    "trans_type as 'Transaction Type', amount as 'Amount', TotalBalance as'Balance', DateAndTime\r\n" +
                    "from transactions t, Customer c\r\nwhere t.cust_id=c.cust_id and t.ac_no=@acNO";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@acNo", txtAcNo.Text);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(reader);

                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No Record Founds");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
