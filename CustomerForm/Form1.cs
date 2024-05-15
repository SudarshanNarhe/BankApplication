using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerForm
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
            string connect = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(connect);
        }

        private void ClearForm()
        {
            txtcustid.Clear();
            txtCustname.Clear();
            txtcontact.Clear();
            txtCustAddress.Clear();
            txtcustAge.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into Customer values (@name, @contact, @email, @password, @age, @address, @gender, @user_role)";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtCustname.Text);
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@age", txtcustAge.Text);
                cmd.Parameters.AddWithValue("@address", txtCustAddress.Text);
                cmd.Parameters.AddWithValue("@user_role", txtUserRole.Text);

                string gender = string.Empty;

                if (radioMale.Checked)
                {
                    gender = "Male";
                }
                else if (radioFemale.Checked)
                {
                    gender = "Female";
                }

                cmd.Parameters.AddWithValue("@gender", gender);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("User Saved Successfully...!!!");
                    ClearForm();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Customer where cust_id = @id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtcustid.Text);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtCustname.Text = reader["customer_name"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtPassword.Text = reader["password"].ToString();
                        txtcustAge.Text = reader["age"].ToString();
                        txtCustAddress.Text = reader["address"].ToString();
                        txtcontact.Text = reader["contact"].ToString();
                        txtUserRole.Text = reader["user_role"].ToString();

                        string gender = reader["gender"].ToString();
                        if(gender == "Male")
                        {
                            radioMale.Checked = true;
                        }
                        else if(gender == "Female")
                        {
                            radioFemale.Checked = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update Customer set customer_name = @name, contact = @contact, email = @email, password = @password, age = @age, address = @address, gender = @gender, user_role = @userrole where cust_id = @id";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtCustname.Text);
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@age", txtcustAge.Text);
                cmd.Parameters.AddWithValue("@address", txtCustAddress.Text);
                cmd.Parameters.AddWithValue("@id", txtcustid.Text);
                cmd.Parameters.AddWithValue("@userrole", txtUserRole.Text);

                string gender = string.Empty;

                if (radioMale.Checked)
                {
                    gender = "Male";
                }
                else if (radioFemale.Checked)
                {
                    gender = "Female";
                }

                cmd.Parameters.AddWithValue("@gender", gender);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("User updated Successfully...!!!");
                    txtUserRole.Clear();
                    ClearForm();
                    
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

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            try 
            { 
                string query = "delete from Customer where cust_id = @id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtcustid.Text);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("User deleted Successfully...!!!");
                    txtUserRole.Clear();
                    ClearForm();
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

        private void btnAlldata_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Customer";
                cmd = new SqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;
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

        private void btnbackLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
