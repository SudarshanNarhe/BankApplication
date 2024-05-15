using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerForm
{
    public partial class MDI : Form
    {   
        Login login = new Login();
        Form1 form1 = new Form1();
        Transaction trans = new Transaction();
        TransactionDetails details = new TransactionDetails();
        CheckBalance CheckBalance = new CheckBalance();
        public MDI()
        {
            InitializeComponent();
         //   login.Show();
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            form1.Hide();
            trans.Hide();
            details.Hide();
            CheckBalance.Hide();
        }

        private void registerNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form1.Show();
            login.Hide();
            trans.Hide();
            details.Hide();
            CheckBalance.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            form1.Hide();
            trans.Hide();
            details.Hide();
            CheckBalance.Hide();
        }

        private void makeAPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Hide();
            form1.Hide();
            trans.Show();
            details.Hide();
            CheckBalance.Hide();
        }

        private void transactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Hide();
            form1.Hide();
            trans.Hide();
            details.Show();
            CheckBalance.Hide();
        }

        private void checkBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Hide();
            form1.Hide();
            trans.Hide();
            details.Hide();
            CheckBalance.Show();
        }

    }
}
