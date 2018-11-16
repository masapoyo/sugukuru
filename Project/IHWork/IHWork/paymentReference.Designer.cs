namespace IHWork
{
    partial class paymentReference
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
            this.label1 = new System.Windows.Forms.Label();
            this.btReference = new System.Windows.Forms.Button();
            this.oFDReference = new System.Windows.Forms.OpenFileDialog();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "入金データ読み込み";
            // 
            // btReference
            // 
            this.btReference.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReference.Location = new System.Drawing.Point(449, 152);
            this.btReference.Name = "btReference";
            this.btReference.Size = new System.Drawing.Size(75, 29);
            this.btReference.TabIndex = 1;
            this.btReference.Text = "参照";
            this.btReference.UseVisualStyleBackColor = true;
            this.btReference.Click += new System.EventHandler(this.btReference_Click);
            // 
            // oFDReference
            // 
            this.oFDReference.FileName = "openFileDialog1";
            this.oFDReference.FileOk += new System.ComponentModel.CancelEventHandler(this.oFDReference_FileOk);
            // 
            // tbReference
            // 
            this.tbReference.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbReference.Location = new System.Drawing.Point(34, 154);
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(409, 27);
            this.tbReference.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(436, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "読み込み";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // paymentReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbReference);
            this.Controls.Add(this.btReference);
            this.Controls.Add(this.label1);
            this.Name = "paymentReference";
            this.Text = "paymentReference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReference;
        private System.Windows.Forms.OpenFileDialog oFDReference;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.Button button1;
    }
}