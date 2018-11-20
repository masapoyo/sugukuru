namespace IHWork
{
    partial class paymentListAndInvoice
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
            this.gbDepositList = new System.Windows.Forms.GroupBox();
            this.dGVDepositList = new System.Windows.Forms.DataGridView();
            this.gbInvoiceList = new System.Windows.Forms.GroupBox();
            this.dGVInvoiceList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btCleaning = new System.Windows.Forms.Button();
            this.gbDepositList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepositList)).BeginInit();
            this.gbInvoiceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInvoiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDepositList
            // 
            this.gbDepositList.Controls.Add(this.dGVDepositList);
            this.gbDepositList.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbDepositList.Location = new System.Drawing.Point(17, 62);
            this.gbDepositList.Name = "gbDepositList";
            this.gbDepositList.Size = new System.Drawing.Size(543, 297);
            this.gbDepositList.TabIndex = 0;
            this.gbDepositList.TabStop = false;
            this.gbDepositList.Text = "入金一覧";
            // 
            // dGVDepositList
            // 
            this.dGVDepositList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDepositList.Location = new System.Drawing.Point(6, 26);
            this.dGVDepositList.Name = "dGVDepositList";
            this.dGVDepositList.RowTemplate.Height = 21;
            this.dGVDepositList.Size = new System.Drawing.Size(531, 265);
            this.dGVDepositList.TabIndex = 0;
            // 
            // gbInvoiceList
            // 
            this.gbInvoiceList.Controls.Add(this.dGVInvoiceList);
            this.gbInvoiceList.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbInvoiceList.Location = new System.Drawing.Point(17, 365);
            this.gbInvoiceList.Name = "gbInvoiceList";
            this.gbInvoiceList.Size = new System.Drawing.Size(543, 320);
            this.gbInvoiceList.TabIndex = 1;
            this.gbInvoiceList.TabStop = false;
            this.gbInvoiceList.Text = "請求一覧";
            // 
            // dGVInvoiceList
            // 
            this.dGVInvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInvoiceList.Location = new System.Drawing.Point(6, 26);
            this.dGVInvoiceList.Name = "dGVInvoiceList";
            this.dGVInvoiceList.RowTemplate.Height = 21;
            this.dGVInvoiceList.Size = new System.Drawing.Size(531, 288);
            this.dGVInvoiceList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "入金照合";
            // 
            // btCleaning
            // 
            this.btCleaning.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCleaning.Location = new System.Drawing.Point(457, 703);
            this.btCleaning.Name = "btCleaning";
            this.btCleaning.Size = new System.Drawing.Size(112, 34);
            this.btCleaning.TabIndex = 3;
            this.btCleaning.Text = "消込";
            this.btCleaning.UseVisualStyleBackColor = true;
            // 
            // paymentListAndInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 749);
            this.Controls.Add(this.btCleaning);
            this.Controls.Add(this.gbInvoiceList);
            this.Controls.Add(this.gbDepositList);
            this.Controls.Add(this.label1);
            this.Name = "paymentListAndInvoice";
            this.Text = "paymentListAndInvoice";
            this.Load += new System.EventHandler(this.paymentListAndInvoice_Load);
            this.gbDepositList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDepositList)).EndInit();
            this.gbInvoiceList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVInvoiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDepositList;
        private System.Windows.Forms.GroupBox gbInvoiceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVDepositList;
        private System.Windows.Forms.DataGridView dGVInvoiceList;
        private System.Windows.Forms.Button btCleaning;
    }
}