namespace IHWork
{
    partial class paymentAll
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPayableList = new System.Windows.Forms.DataGridView();
            this.lbFormName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayableList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "一括請求";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvPayableList
            // 
            this.dgvPayableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayableList.Location = new System.Drawing.Point(16, 118);
            this.dgvPayableList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayableList.Name = "dgvPayableList";
            this.dgvPayableList.RowTemplate.Height = 21;
            this.dgvPayableList.Size = new System.Drawing.Size(975, 532);
            this.dgvPayableList.TabIndex = 4;
            // 
            // lbFormName
            // 
            this.lbFormName.AutoSize = true;
            this.lbFormName.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFormName.Location = new System.Drawing.Point(16, 14);
            this.lbFormName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFormName.Name = "lbFormName";
            this.lbFormName.Size = new System.Drawing.Size(219, 34);
            this.lbFormName.TabIndex = 3;
            this.lbFormName.Text = "請求可能一覧";
            // 
            // paymentAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPayableList);
            this.Controls.Add(this.lbFormName);
            this.Name = "paymentAll";
            this.Text = "請求可能一覧";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayableList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPayableList;
        private System.Windows.Forms.Label lbFormName;
    }
}