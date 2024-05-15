namespace CustomerForm
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerNewUserToolStripMenuItem,
            this.makeAPaymentToolStripMenuItem,
            this.transactionDetailsToolStripMenuItem,
            this.checkBalanceToolStripMenuItem,
            this.existToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 2, 4);
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerNewUserToolStripMenuItem
            // 
            this.registerNewUserToolStripMenuItem.Name = "registerNewUserToolStripMenuItem";
            this.registerNewUserToolStripMenuItem.Size = new System.Drawing.Size(114, 19);
            this.registerNewUserToolStripMenuItem.Text = "Register New User";
            this.registerNewUserToolStripMenuItem.Click += new System.EventHandler(this.registerNewUserToolStripMenuItem_Click);
            // 
            // makeAPaymentToolStripMenuItem
            // 
            this.makeAPaymentToolStripMenuItem.Name = "makeAPaymentToolStripMenuItem";
            this.makeAPaymentToolStripMenuItem.Size = new System.Drawing.Size(107, 19);
            this.makeAPaymentToolStripMenuItem.Text = "Make a Payment";
            this.makeAPaymentToolStripMenuItem.Click += new System.EventHandler(this.makeAPaymentToolStripMenuItem_Click);
            // 
            // transactionDetailsToolStripMenuItem
            // 
            this.transactionDetailsToolStripMenuItem.Name = "transactionDetailsToolStripMenuItem";
            this.transactionDetailsToolStripMenuItem.Size = new System.Drawing.Size(117, 19);
            this.transactionDetailsToolStripMenuItem.Text = "Transaction Details";
            this.transactionDetailsToolStripMenuItem.Click += new System.EventHandler(this.transactionDetailsToolStripMenuItem_Click);
            // 
            // checkBalanceToolStripMenuItem
            // 
            this.checkBalanceToolStripMenuItem.Name = "checkBalanceToolStripMenuItem";
            this.checkBalanceToolStripMenuItem.Size = new System.Drawing.Size(96, 19);
            this.checkBalanceToolStripMenuItem.Text = "Check Balance";
            this.checkBalanceToolStripMenuItem.Click += new System.EventHandler(this.checkBalanceToolStripMenuItem_Click);
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
            this.existToolStripMenuItem.Text = "Exist";
            this.existToolStripMenuItem.Click += new System.EventHandler(this.existToolStripMenuItem_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CustomerForm.Properties.Resources.BankApplication1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome To Banking Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existToolStripMenuItem;
    }
}