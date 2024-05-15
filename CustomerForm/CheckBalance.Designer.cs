namespace CustomerForm
{
    partial class CheckBalance
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
            this.lblacNo = new System.Windows.Forms.Label();
            this.txtAcNoCheckB = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtBalanceCheckB = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblacNo
            // 
            this.lblacNo.AutoSize = true;
            this.lblacNo.Location = new System.Drawing.Point(162, 83);
            this.lblacNo.Name = "lblacNo";
            this.lblacNo.Size = new System.Drawing.Size(124, 13);
            this.lblacNo.TabIndex = 0;
            this.lblacNo.Text = "Enter a Account Number";
            // 
            // txtAcNoCheckB
            // 
            this.txtAcNoCheckB.Location = new System.Drawing.Point(304, 80);
            this.txtAcNoCheckB.Name = "txtAcNoCheckB";
            this.txtAcNoCheckB.Size = new System.Drawing.Size(156, 20);
            this.txtAcNoCheckB.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(500, 70);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(99, 38);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Balance";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtBalanceCheckB
            // 
            this.txtBalanceCheckB.Location = new System.Drawing.Point(304, 154);
            this.txtBalanceCheckB.Name = "txtBalanceCheckB";
            this.txtBalanceCheckB.ReadOnly = true;
            this.txtBalanceCheckB.Size = new System.Drawing.Size(156, 20);
            this.txtBalanceCheckB.TabIndex = 4;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(207, 154);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Balance ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(500, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 33);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // CheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBalanceCheckB);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAcNoCheckB);
            this.Controls.Add(this.lblacNo);
            this.Name = "CheckBalance";
            this.Text = "CheckBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblacNo;
        private System.Windows.Forms.TextBox txtAcNoCheckB;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtBalanceCheckB;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnClear;
    }
}