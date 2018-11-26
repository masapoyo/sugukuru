namespace IHWork
{
    partial class PurchaseRemainingInformationList
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
            this.lb_title = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvOrdersList = new System.Windows.Forms.DataGridView();
            this.車種名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.変速機構の種別 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabChose = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).BeginInit();
            this.tabChose.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_title.Location = new System.Drawing.Point(17, 17);
            this.lb_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(151, 34);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "受注一覧";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(759, 538);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "買注残";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(15, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(725, 504);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "車名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "年式（和暦）";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "型式";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "色";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "変速機構の種別";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvOrdersList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(759, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "全体";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvOrdersList
            // 
            this.dgvOrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.車種名,
            this.年式,
            this.型式,
            this.色,
            this.変速機構の種別});
            this.dgvOrdersList.Location = new System.Drawing.Point(15, 20);
            this.dgvOrdersList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrdersList.Name = "dgvOrdersList";
            this.dgvOrdersList.RowTemplate.Height = 21;
            this.dgvOrdersList.Size = new System.Drawing.Size(725, 504);
            this.dgvOrdersList.TabIndex = 0;
            // 
            // 車種名
            // 
            this.車種名.HeaderText = "車種名";
            this.車種名.Name = "車種名";
            // 
            // 年式
            // 
            this.年式.HeaderText = "年式（和暦）";
            this.年式.Name = "年式";
            // 
            // 型式
            // 
            this.型式.HeaderText = "型式";
            this.型式.Name = "型式";
            // 
            // 色
            // 
            this.色.HeaderText = "色";
            this.色.Name = "色";
            // 
            // 変速機構の種別
            // 
            this.変速機構の種別.HeaderText = "変速機構の種別";
            this.変速機構の種別.Name = "変速機構の種別";
            // 
            // tabChose
            // 
            this.tabChose.Controls.Add(this.tabPage2);
            this.tabChose.Controls.Add(this.tabPage1);
            this.tabChose.Location = new System.Drawing.Point(-1, 57);
            this.tabChose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabChose.Name = "tabChose";
            this.tabChose.SelectedIndex = 0;
            this.tabChose.Size = new System.Drawing.Size(767, 567);
            this.tabChose.TabIndex = 3;
            // 
            // PurchaseRemainingInformationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 633);
            this.Controls.Add(this.tabChose);
            this.Controls.Add(this.lb_title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PurchaseRemainingInformationList";
            this.Text = "受注一覧";
            this.Load += new System.EventHandler(this.PurchaseRemainingInformationList_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersList)).EndInit();
            this.tabChose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvOrdersList;
        private System.Windows.Forms.TabControl tabChose;
        private System.Windows.Forms.DataGridViewTextBoxColumn 車種名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 色;
        private System.Windows.Forms.DataGridViewTextBoxColumn 変速機構の種別;
    }
}