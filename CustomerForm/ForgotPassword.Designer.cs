namespace CustomerForm
{
    partial class ForgotPassword
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
            this.btnreset = new System.Windows.Forms.Button();
            this.btnGetPass = new System.Windows.Forms.Button();
            this.txtnameFP = new System.Windows.Forms.TextBox();
            this.lblnameFP = new System.Windows.Forms.Label();
            this.txtEmailFP = new System.Windows.Forms.TextBox();
            this.lblemailFP = new System.Windows.Forms.Label();
            this.txtContactFP = new System.Windows.Forms.TextBox();
            this.lblContactFP = new System.Windows.Forms.Label();
            this.btnbackLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(431, 298);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(101, 30);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnGetPass
            // 
            this.btnGetPass.Location = new System.Drawing.Point(280, 298);
            this.btnGetPass.Name = "btnGetPass";
            this.btnGetPass.Size = new System.Drawing.Size(93, 30);
            this.btnGetPass.TabIndex = 10;
            this.btnGetPass.Text = "Get Password";
            this.btnGetPass.UseVisualStyleBackColor = true;
            this.btnGetPass.Click += new System.EventHandler(this.btnGetPass_Click);
            // 
            // txtnameFP
            // 
            this.txtnameFP.Location = new System.Drawing.Point(346, 194);
            this.txtnameFP.Name = "txtnameFP";
            this.txtnameFP.Size = new System.Drawing.Size(221, 20);
            this.txtnameFP.TabIndex = 9;
            // 
            // lblnameFP
            // 
            this.lblnameFP.AutoSize = true;
            this.lblnameFP.Location = new System.Drawing.Point(262, 194);
            this.lblnameFP.Name = "lblnameFP";
            this.lblnameFP.Size = new System.Drawing.Size(63, 13);
            this.lblnameFP.TabIndex = 8;
            this.lblnameFP.Text = "Enter Name";
            // 
            // txtEmailFP
            // 
            this.txtEmailFP.Location = new System.Drawing.Point(346, 144);
            this.txtEmailFP.Name = "txtEmailFP";
            this.txtEmailFP.Size = new System.Drawing.Size(221, 20);
            this.txtEmailFP.TabIndex = 7;
            // 
            // lblemailFP
            // 
            this.lblemailFP.AutoSize = true;
            this.lblemailFP.Location = new System.Drawing.Point(262, 144);
            this.lblemailFP.Name = "lblemailFP";
            this.lblemailFP.Size = new System.Drawing.Size(60, 13);
            this.lblemailFP.TabIndex = 6;
            this.lblemailFP.Text = "Enter Email";
            // 
            // txtContactFP
            // 
            this.txtContactFP.Location = new System.Drawing.Point(346, 239);
            this.txtContactFP.Name = "txtContactFP";
            this.txtContactFP.Size = new System.Drawing.Size(221, 20);
            this.txtContactFP.TabIndex = 13;
            // 
            // lblContactFP
            // 
            this.lblContactFP.AutoSize = true;
            this.lblContactFP.Location = new System.Drawing.Point(262, 239);
            this.lblContactFP.Name = "lblContactFP";
            this.lblContactFP.Size = new System.Drawing.Size(72, 13);
            this.lblContactFP.TabIndex = 12;
            this.lblContactFP.Text = "Enter Contact";
            // 
            // btnbackLogin
            // 
            this.btnbackLogin.Location = new System.Drawing.Point(318, 353);
            this.btnbackLogin.Name = "btnbackLogin";
            this.btnbackLogin.Size = new System.Drawing.Size(180, 34);
            this.btnbackLogin.TabIndex = 26;
            this.btnbackLogin.Text = "Back To Login Page";
            this.btnbackLogin.UseVisualStyleBackColor = true;
            this.btnbackLogin.Click += new System.EventHandler(this.btnbackLogin_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbackLogin);
            this.Controls.Add(this.txtContactFP);
            this.Controls.Add(this.lblContactFP);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnGetPass);
            this.Controls.Add(this.txtnameFP);
            this.Controls.Add(this.lblnameFP);
            this.Controls.Add(this.txtEmailFP);
            this.Controls.Add(this.lblemailFP);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnGetPass;
        private System.Windows.Forms.TextBox txtnameFP;
        private System.Windows.Forms.Label lblnameFP;
        private System.Windows.Forms.TextBox txtEmailFP;
        private System.Windows.Forms.Label lblemailFP;
        private System.Windows.Forms.TextBox txtContactFP;
        private System.Windows.Forms.Label lblContactFP;
        private System.Windows.Forms.Button btnbackLogin;
    }
}