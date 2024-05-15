namespace CustomerForm
{
    partial class Form1
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
            this.lblcustid = new System.Windows.Forms.Label();
            this.lblcustname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.txtCustname = new System.Windows.Forms.TextBox();
            this.txtcustAge = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAlldata = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.lblcontact = new System.Windows.Forms.Label();
            this.txtUserRole = new System.Windows.Forms.TextBox();
            this.lblUserrole = new System.Windows.Forms.Label();
            this.btnbackLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcustid
            // 
            this.lblcustid.AutoSize = true;
            this.lblcustid.Location = new System.Drawing.Point(57, 31);
            this.lblcustid.Name = "lblcustid";
            this.lblcustid.Size = new System.Drawing.Size(63, 13);
            this.lblcustid.TabIndex = 0;
            this.lblcustid.Text = "Customer Id";
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Location = new System.Drawing.Point(57, 78);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(82, 13);
            this.lblcustname.TabIndex = 1;
            this.lblcustname.Text = "Customer Name";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(57, 238);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(26, 13);
            this.lblage.TabIndex = 2;
            this.lblage.Text = "Age";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(57, 270);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(45, 13);
            this.lbladdress.TabIndex = 3;
            this.lbladdress.Text = "Address";
            // 
            // txtcustid
            // 
            this.txtcustid.Location = new System.Drawing.Point(156, 28);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.Size = new System.Drawing.Size(219, 20);
            this.txtcustid.TabIndex = 5;
            // 
            // txtCustname
            // 
            this.txtCustname.Location = new System.Drawing.Point(156, 75);
            this.txtCustname.Name = "txtCustname";
            this.txtCustname.Size = new System.Drawing.Size(219, 20);
            this.txtCustname.TabIndex = 6;
            // 
            // txtcustAge
            // 
            this.txtcustAge.Location = new System.Drawing.Point(156, 231);
            this.txtcustAge.Name = "txtcustAge";
            this.txtcustAge.Size = new System.Drawing.Size(219, 20);
            this.txtcustAge.TabIndex = 7;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(156, 263);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(219, 20);
            this.txtCustAddress.TabIndex = 8;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(58, 351);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Gender";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(157, 347);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 9;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(261, 347);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 10;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 34);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(157, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 34);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(291, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 34);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(413, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 28);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAlldata
            // 
            this.btnAlldata.Location = new System.Drawing.Point(523, 406);
            this.btnAlldata.Name = "btnAlldata";
            this.btnAlldata.Size = new System.Drawing.Size(180, 34);
            this.btnAlldata.TabIndex = 15;
            this.btnAlldata.Text = "Show All Data";
            this.btnAlldata.UseVisualStyleBackColor = true;
            this.btnAlldata.Click += new System.EventHandler(this.btnAlldata_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 307);
            this.dataGridView1.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(156, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 20);
            this.txtPassword.TabIndex = 20;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(57, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 19;
            this.lblPassword.Text = "Password";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(156, 122);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(219, 20);
            this.txtcontact.TabIndex = 22;
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Location = new System.Drawing.Point(57, 125);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(44, 13);
            this.lblcontact.TabIndex = 21;
            this.lblcontact.Text = "Contact";
            // 
            // txtUserRole
            // 
            this.txtUserRole.Location = new System.Drawing.Point(156, 305);
            this.txtUserRole.Name = "txtUserRole";
            this.txtUserRole.Size = new System.Drawing.Size(219, 20);
            this.txtUserRole.TabIndex = 24;
            this.txtUserRole.Text = "User";
            // 
            // lblUserrole
            // 
            this.lblUserrole.AutoSize = true;
            this.lblUserrole.Location = new System.Drawing.Point(57, 312);
            this.lblUserrole.Name = "lblUserrole";
            this.lblUserrole.Size = new System.Drawing.Size(49, 13);
            this.lblUserrole.TabIndex = 23;
            this.lblUserrole.Text = "User role";
            // 
            // btnbackLogin
            // 
            this.btnbackLogin.Location = new System.Drawing.Point(596, 28);
            this.btnbackLogin.Name = "btnbackLogin";
            this.btnbackLogin.Size = new System.Drawing.Size(180, 34);
            this.btnbackLogin.TabIndex = 25;
            this.btnbackLogin.Text = "Back To Login Page";
            this.btnbackLogin.UseVisualStyleBackColor = true;
            this.btnbackLogin.Click += new System.EventHandler(this.btnbackLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnbackLogin);
            this.Controls.Add(this.txtUserRole);
            this.Controls.Add(this.lblUserrole);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAlldata);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtcustAge);
            this.Controls.Add(this.txtCustname);
            this.Controls.Add(this.txtcustid);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblcustname);
            this.Controls.Add(this.lblcustid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcustid;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.TextBox txtCustname;
        private System.Windows.Forms.TextBox txtcustAge;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAlldata;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label lblcontact;
        private System.Windows.Forms.TextBox txtUserRole;
        private System.Windows.Forms.Label lblUserrole;
        private System.Windows.Forms.Button btnbackLogin;
    }
}

