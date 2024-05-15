namespace CustomerForm
{
    partial class Login
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
            this.lblemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnforget = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(222, 139);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(306, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(306, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(222, 189);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(194, 272);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(93, 30);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(320, 272);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(101, 30);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnforget
            // 
            this.btnforget.Location = new System.Drawing.Point(453, 272);
            this.btnforget.Name = "btnforget";
            this.btnforget.Size = new System.Drawing.Size(101, 30);
            this.btnforget.TabIndex = 6;
            this.btnforget.Text = "Forgot Password\r\n";
            this.btnforget.UseVisualStyleBackColor = true;
            this.btnforget.Click += new System.EventHandler(this.btnforget_Click);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(225, 329);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(302, 30);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "Register New User";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CustomerForm.Properties.Resources.fingerprint_identity_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnforget);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblemail);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnforget;
        private System.Windows.Forms.Button btnregister;
    }
}