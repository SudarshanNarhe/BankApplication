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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CustomerForm
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public Login()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(str);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Customer where email = @email";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email",txtEmail.Text);
                con.Open();
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                   if(reader.Read())
                    {
                        string password = reader.GetString(4);
                        if (txtPassword.Text == password)
                        {
                            MessageBox.Show("Login Successful...");
                            MDI mdi = new MDI();
                            mdi.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("User Not Found..");
                        }
                    }
                   
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

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnforget_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
            this.Hide();
        }
    }
}
