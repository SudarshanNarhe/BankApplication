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
    public partial class Transaction : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public static decimal LastBalance;
        public Transaction()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(str);
            
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from Account where ac_no = @acNo";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@acNo", txtAcNo.Text);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        string status = reader.GetString(4);
                        if (status == "inactive")
                        {
                            MessageBox.Show("Your Account is inactive to Active it please Click on Active Account Button");
                        }
                        else
                        {
                            MessageBox.Show("Your Account is in active state you can make a payment");
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

        private void btnactive_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update Account set status = 'active' where ac_no = @acNo";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@acNo", txtAcNo.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Your Account is Activated You can make a Payments");
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

        private int GetCustomerId(string email)
        {
            int id = 0;
            try
            {
                
                string qry = "select * from Customer where email = @email";
                cmd = new SqlCommand(qry,con);
                cmd.Parameters.AddWithValue("@email",email);
               // con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        id = reader.GetInt32(0);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           /* finally
            {
                con.Close();
            }*/
            return id;
        }

        private void ClearForm()
        {
            txtAcNo.Clear();
            txtAmount.Clear();
            txtCustEmail.Clear();
            radioCredit.Checked = false;
            radioDebit.Checked = false;
        }
        private void btnpayment_Click(object sender, EventArgs e)
        {
            try
            {
               
                string query = "select * from Account where ac_no = @acNo";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@acNo", txtAcNo.Text);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                       string status = reader.GetString(4);
                       decimal balance = reader.GetDecimal(2);
                        LastBalance = balance;
                        if (status == "inactive")
                        {
                            MessageBox.Show("Your Account is inactive to Active it please Click on Active Account Button");
                            
                        }
                        else
                        {
                            string trans_type = string.Empty;
                            if (radioCredit.Checked)
                            {
                                trans_type = "Credit";
                            }
                            else if (radioDebit.Checked)
                            {

                                trans_type = "Debit";
                            }

                            if (trans_type == "Credit")
                            {
                                decimal creditAmt = Convert.ToDecimal(txtAmount.Text);
                                balance = balance + creditAmt;

                                string query1 = "update Account set balance = @amount where ac_no = @acNo";
                                SqlCommand cmd1 = new SqlCommand(query1, con);
                                cmd1.Parameters.AddWithValue("@amount", balance);
                                cmd1.Parameters.AddWithValue("@acNo",txtAcNo.Text);
                               // con.Open();
                                reader.Close();
                                int result = cmd1.ExecuteNonQuery();
                                if (result >= 1)
                                {
                                   
                                    string query3 = "insert into transactions values (@ac_no, @cust_id, @trans_type, @amount, @DateAndTime, @TotalBalance)";
                                   SqlCommand cmd5 = new SqlCommand(query3, con);
                                    cmd5.Parameters.AddWithValue("@ac_no", txtAcNo.Text);
                                    cmd5.Parameters.AddWithValue("@amount", txtAmount.Text);
                                    cmd5.Parameters.AddWithValue("@trans_type", "Credit");
                                    cmd5.Parameters.AddWithValue("@DateAndTime",DateTime.Now);
                                    decimal totalBalance = LastBalance + creditAmt;
                                    cmd5.Parameters.AddWithValue("@TotalBalance", totalBalance);
                                    int id = GetCustomerId(txtCustEmail.Text);
                                    if (id != 0)
                                    {
                                        cmd5.Parameters.AddWithValue("@cust_id", id);
                                    }
                                    reader.Close();
                                    cmd5.ExecuteNonQuery();
                               
                                    MessageBox.Show("Transaction Completed....");
                                    ClearForm();
                                }
                                else
                                {
                                    MessageBox.Show("Transaction Failed....");
                                }

                            }
                            else if(trans_type == "Debit")
                            {
                                decimal debitAmt = Convert.ToDecimal(txtAmount.Text);
                                if (debitAmt < balance )
                                {
                                    balance = balance - debitAmt;

                                    string query1 = "update Account set balance = @amount where ac_no = @acNo";
                                   SqlCommand cmd4 = new SqlCommand(query1, con);
                                    cmd4.Parameters.AddWithValue("@amount", balance);
                                    cmd4.Parameters.AddWithValue("@acNo", txtAcNo.Text);
                                    //  con.Open();
                                    reader.Close();
                                    int result = cmd4.ExecuteNonQuery();
                                    if (result >= 1)
                                    {
                                        
                                        string query3 = "insert into transactions values(@ac_no, @cust_id, @trans_type, @amount, @DateAndTime, @TotalBalance)";
                                       SqlCommand  cmd2 = new SqlCommand(query3, con);
                                        cmd2.Parameters.AddWithValue("@ac_no", txtAcNo.Text);
                                        cmd2.Parameters.AddWithValue("@amount", txtAmount.Text);
                                        cmd2.Parameters.AddWithValue("@trans_type", "Debit");
                                        cmd2.Parameters.AddWithValue("@DateAndTime", DateTime.Now);
                                        decimal totalBalance = LastBalance - debitAmt;
                                        cmd2.Parameters.AddWithValue("@TotalBalance",totalBalance);
                                        int id = GetCustomerId(txtCustEmail.Text);
                                        if (id != 0)
                                        {
                                            cmd2.Parameters.AddWithValue("@cust_id", id);
                                        }
                                        reader.Close();
                                        cmd2.ExecuteNonQuery();
                                       
                                        MessageBox.Show("Transaction Completed....");
                                        ClearForm();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Transaction Failed....");
                                    }

                                }
                            }
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
    }
}
