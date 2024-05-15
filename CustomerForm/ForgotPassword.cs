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
    public partial class ForgotPassword : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public ForgotPassword()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(str);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtContactFP.Clear();
            txtEmailFP.Clear();
            txtnameFP.Clear();
        }

        private void btnGetPass_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Customer where email = @email";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", txtEmailFP.Text);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        string name = reader.GetString(1);
                        string contact = reader.GetString(2);
                        if (txtnameFP.Text.ToLower() == name.ToLower() && txtContactFP.Text == contact)
                        {
                            string password = reader.GetString(4);
                            MessageBox.Show($"Password -->> {password}");
                            txtContactFP.Clear();
                            txtEmailFP.Clear();
                            txtnameFP.Clear();
                        }
                        else
                        {
                            MessageBox.Show("User Not Found.Enter Valid Email");
                        }
                    }

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

        private void btnbackLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
