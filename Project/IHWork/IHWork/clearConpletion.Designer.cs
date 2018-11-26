namespace IHWork
{
    partial class clearConpletion
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
            this.lb_ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dGVCarryOverList = new System.Windows.Forms.DataGridView();
            this.lbUnpaid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarryOverList)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_
            // 
            this.lb_.AutoSize = true;
            this.lb_.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_.Location = new System.Drawing.Point(12, 9);
            this.lb_.Name = "lb_";
            this.lb_.Size = new System.Drawing.Size(178, 20);
            this.lb_.TabIndex = 0;
            this.lb_.Text = "消込が完了しました。\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "未払い件数:\r\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(397, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "閉じる";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dGVCarryOverList
            // 
            this.dGVCarryOverList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCarryOverList.Location = new System.Drawing.Point(12, 64);
            this.dGVCarryOverList.Name = "dGVCarryOverList";
            this.dGVCarryOverList.RowTemplate.Height = 21;
            this.dGVCarryOverList.Size = new System.Drawing.Size(491, 247);
            this.dGVCarryOverList.TabIndex = 3;
            // 
            // lbUnpaid
            // 
            this.lbUnpaid.AutoSize = true;
            this.lbUnpaid.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbUnpaid.Location = new System.Drawing.Point(127, 41);
            this.lbUnpaid.Name = "lbUnpaid";
            this.lbUnpaid.Size = new System.Drawing.Size(0, 20);
            this.lbUnpaid.TabIndex = 4;
            // 
            // clearConpletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 368);
            this.Controls.Add(this.lbUnpaid);
            this.Controls.Add(this.dGVCarryOverList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_);
            this.Name = "clearConpletion";
            this.Text = "clearConpletion";
            this.Load += new System.EventHandler(this.clearConpletion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarryOverList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dGVCarryOverList;
        private System.Windows.Forms.Label lbUnpaid;
    }
}