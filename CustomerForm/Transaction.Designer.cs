namespace CustomerForm
{
    partial class Transaction
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
            this.lblAcNo = new System.Windows.Forms.Label();
            this.txtAcNo = new System.Windows.Forms.TextBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnactive = new System.Windows.Forms.Button();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.lblEmailT = new System.Windows.Forms.Label();
            this.lblTransType = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.radioCredit = new System.Windows.Forms.RadioButton();
            this.radioDebit = new System.Windows.Forms.RadioButton();
            this.btnpayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAcNo
            // 
            this.lblAcNo.AutoSize = true;
            this.lblAcNo.Location = new System.Drawing.Point(190, 99);
            this.lblAcNo.Name = "lblAcNo";
            this.lblAcNo.Size = new System.Drawing.Size(115, 13);
            this.lblAcNo.TabIndex = 0;
            this.lblAcNo.Text = "Enter Account Number";
            // 
            // txtAcNo
            // 
            this.txtAcNo.Location = new System.Drawing.Point(353, 96);
            this.txtAcNo.Name = "txtAcNo";
            this.txtAcNo.Size = new System.Drawing.Size(242, 20);
            this.txtAcNo.TabIndex = 1;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(627, 89);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(133, 33);
            this.btnStatus.TabIndex = 2;
            this.btnStatus.Text = "Check Account Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnactive
            // 
            this.btnactive.Location = new System.Drawing.Point(12, 12);
            this.btnactive.Name = "btnactive";
            this.btnactive.Size = new System.Drawing.Size(177, 39);
            this.btnactive.TabIndex = 3;
            this.btnactive.Text = "Active Your Account";
            this.btnactive.UseVisualStyleBackColor = true;
            this.btnactive.Click += new System.EventHandler(this.btnactive_Click);
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(353, 153);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(242, 20);
            this.txtCustEmail.TabIndex = 5;
            // 
            // lblEmailT
            // 
            this.lblEmailT.AutoSize = true;
            this.lblEmailT.Location = new System.Drawing.Point(190, 153);
            this.lblEmailT.Name = "lblEmailT";
            this.lblEmailT.Size = new System.Drawing.Size(107, 13);
            this.lblEmailT.TabIndex = 4;
            this.lblEmailT.Text = "Enter Customer Email";
            // 
            // lblTransType
            // 
            this.lblTransType.AutoSize = true;
            this.lblTransType.Location = new System.Drawing.Point(190, 271);
            this.lblTransType.Name = "lblTransType";
            this.lblTransType.Size = new System.Drawing.Size(118, 13);
            this.lblTransType.TabIndex = 6;
            this.lblTransType.Text = "Enter Transaction Type";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(353, 208);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(242, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(190, 208);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Enter Amount";
            // 
            // radioCredit
            // 
            this.radioCredit.AutoSize = true;
            this.radioCredit.Location = new System.Drawing.Point(365, 269);
            this.radioCredit.Name = "radioCredit";
            this.radioCredit.Size = new System.Drawing.Size(52, 17);
            this.radioCredit.TabIndex = 10;
            this.radioCredit.TabStop = true;
            this.radioCredit.Text = "Credit";
            this.radioCredit.UseVisualStyleBackColor = true;
            // 
            // radioDebit
            // 
            this.radioDebit.AutoSize = true;
            this.radioDebit.Location = new System.Drawing.Point(458, 271);
            this.radioDebit.Name = "radioDebit";
            this.radioDebit.Size = new System.Drawing.Size(50, 17);
            this.radioDebit.TabIndex = 11;
            this.radioDebit.TabStop = true;
            this.radioDebit.Text = "Debit";
            this.radioDebit.UseVisualStyleBackColor = true;
            // 
            // btnpayment
            // 
            this.btnpayment.Location = new System.Drawing.Point(227, 334);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(350, 33);
            this.btnpayment.TabIndex = 12;
            this.btnpayment.Text = "Make a Payment";
            this.btnpayment.UseVisualStyleBackColor = true;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpayment);
            this.Controls.Add(this.radioDebit);
            this.Controls.Add(this.radioCredit);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTransType);
            this.Controls.Add(this.txtCustEmail);
            this.Controls.Add(this.lblEmailT);
            this.Controls.Add(this.btnactive);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.txtAcNo);
            this.Controls.Add(this.lblAcNo);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAcNo;
        private System.Windows.Forms.TextBox txtAcNo;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnactive;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.Label lblEmailT;
        private System.Windows.Forms.Label lblTransType;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.RadioButton radioCredit;
        private System.Windows.Forms.RadioButton radioDebit;
        private System.Windows.Forms.Button btnpayment;
    }
}