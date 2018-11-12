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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_order_list = new System.Windows.Forms.DataGridView();
            this.tabChose = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.車種名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.変速機構の種別 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_list)).BeginInit();
            this.tabChose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_title.Location = new System.Drawing.Point(13, 13);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(120, 27);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "受注一覧";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 399);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "買注残";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_order_list);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "全体";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_order_list
            // 
            this.dgv_order_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.車種名,
            this.年式,
            this.型式,
            this.色,
            this.変速機構の種別});
            this.dgv_order_list.Location = new System.Drawing.Point(11, 15);
            this.dgv_order_list.Name = "dgv_order_list";
            this.dgv_order_list.RowTemplate.Height = 21;
            this.dgv_order_list.Size = new System.Drawing.Size(544, 378);
            this.dgv_order_list.TabIndex = 0;
            // 
            // tabChose
            // 
            this.tabChose.Controls.Add(this.tabPage2);
            this.tabChose.Controls.Add(this.tabPage1);
            this.tabChose.Location = new System.Drawing.Point(-1, 43);
            this.tabChose.Name = "tabChose";
            this.tabChose.SelectedIndex = 0;
            this.tabChose.Size = new System.Drawing.Size(575, 425);
            this.tabChose.TabIndex = 3;
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(544, 378);
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
            // PurchaseRemainingInformationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 475);
            this.Controls.Add(this.tabChose);
            this.Controls.Add(this.lb_title);
            this.Name = "PurchaseRemainingInformationList";
            this.Text = "受注一覧";
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_list)).EndInit();
            this.tabChose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_order_list;
        private System.Windows.Forms.TabControl tabChose;
        private System.Windows.Forms.DataGridViewTextBoxColumn 車種名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 色;
        private System.Windows.Forms.DataGridViewTextBoxColumn 変速機構の種別;
    }
}