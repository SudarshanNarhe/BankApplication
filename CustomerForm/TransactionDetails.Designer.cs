namespace CustomerForm
{
    partial class TransactionDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAcNo = new System.Windows.Forms.Label();
            this.txtAcNo = new System.Windows.Forms.TextBox();
            this.btnShowData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblAcNo
            // 
            this.lblAcNo.AutoSize = true;
            this.lblAcNo.Location = new System.Drawing.Point(102, 36);
            this.lblAcNo.Name = "lblAcNo";
            this.lblAcNo.Size = new System.Drawing.Size(118, 13);
            this.lblAcNo.TabIndex = 1;
            this.lblAcNo.Text = "Enter Account Number ";
            // 
            // txtAcNo
            // 
            this.txtAcNo.Location = new System.Drawing.Point(236, 33);
            this.txtAcNo.Name = "txtAcNo";
            this.txtAcNo.Size = new System.Drawing.Size(200, 20);
            this.txtAcNo.TabIndex = 2;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(474, 25);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(125, 34);
            this.btnShowData.TabIndex = 3;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.txtAcNo);
            this.Controls.Add(this.lblAcNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TransactionDetails";
            this.Text = "TransactionDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAcNo;
        private System.Windows.Forms.TextBox txtAcNo;
        private System.Windows.Forms.Button btnShowData;
    }
}