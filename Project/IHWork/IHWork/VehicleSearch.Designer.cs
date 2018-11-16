namespace IHWork
{
    partial class VehicleSearch
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
            this.dgv_order_list = new System.Windows.Forms.DataGridView();
            this.車名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.変速機構の種別 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_car_name = new System.Windows.Forms.TextBox();
            this.tb_medel_year = new System.Windows.Forms.TextBox();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.tb_mileage = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.tb_budget = new System.Windows.Forms.TextBox();
            this.bt_find = new System.Windows.Forms.Button();
            this.tb_ansmission_fund_type = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.rb_less = new System.Windows.Forms.RadioButton();
            this.rb_near = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_order_list
            // 
            this.dgv_order_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.車名,
            this.年式,
            this.型式,
            this.色,
            this.変速機構の種別});
            this.dgv_order_list.Location = new System.Drawing.Point(12, 303);
            this.dgv_order_list.Name = "dgv_order_list";
            this.dgv_order_list.RowTemplate.Height = 21;
            this.dgv_order_list.Size = new System.Drawing.Size(608, 335);
            this.dgv_order_list.TabIndex = 0;
            // 
            // 車名
            // 
            this.車名.HeaderText = "車名";
            this.車名.Name = "車名";
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
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lb_title.Location = new System.Drawing.Point(13, 13);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(228, 27);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "一致車両情報表示";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "車両";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "年式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "型式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "走行距離";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "予算";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "変速機構の種別";
            // 
            // tb_car_name
            // 
            this.tb_car_name.Location = new System.Drawing.Point(391, 53);
            this.tb_car_name.Name = "tb_car_name";
            this.tb_car_name.Size = new System.Drawing.Size(229, 19);
            this.tb_car_name.TabIndex = 8;
            // 
            // tb_medel_year
            // 
            this.tb_medel_year.Location = new System.Drawing.Point(391, 79);
            this.tb_medel_year.Name = "tb_medel_year";
            this.tb_medel_year.Size = new System.Drawing.Size(229, 19);
            this.tb_medel_year.TabIndex = 9;
            // 
            // tb_color
            // 
            this.tb_color.Location = new System.Drawing.Point(391, 129);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(229, 19);
            this.tb_color.TabIndex = 10;
            // 
            // tb_mileage
            // 
            this.tb_mileage.Location = new System.Drawing.Point(391, 154);
            this.tb_mileage.Name = "tb_mileage";
            this.tb_mileage.Size = new System.Drawing.Size(229, 19);
            this.tb_mileage.TabIndex = 11;
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(391, 104);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(229, 19);
            this.tb_model.TabIndex = 12;
            // 
            // tb_budget
            // 
            this.tb_budget.Location = new System.Drawing.Point(391, 182);
            this.tb_budget.Name = "tb_budget";
            this.tb_budget.Size = new System.Drawing.Size(229, 19);
            this.tb_budget.TabIndex = 13;
            // 
            // bt_find
            // 
            this.bt_find.Location = new System.Drawing.Point(533, 262);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(87, 35);
            this.bt_find.TabIndex = 14;
            this.bt_find.Text = "検索";
            this.bt_find.UseVisualStyleBackColor = true;
            // 
            // tb_ansmission_fund_type
            // 
            this.tb_ansmission_fund_type.Location = new System.Drawing.Point(391, 229);
            this.tb_ansmission_fund_type.Name = "tb_ansmission_fund_type";
            this.tb_ansmission_fund_type.Size = new System.Drawing.Size(229, 19);
            this.tb_ansmission_fund_type.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(327, 132);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 28;
            this.label19.Text = "色";
            // 
            // rb_less
            // 
            this.rb_less.AutoSize = true;
            this.rb_less.Location = new System.Drawing.Point(391, 207);
            this.rb_less.Name = "rb_less";
            this.rb_less.Size = new System.Drawing.Size(47, 16);
            this.rb_less.TabIndex = 32;
            this.rb_less.Text = "以下";
            this.rb_less.UseVisualStyleBackColor = true;
            // 
            // rb_near
            // 
            this.rb_near.AutoSize = true;
            this.rb_near.Checked = true;
            this.rb_near.Location = new System.Drawing.Point(444, 206);
            this.rb_near.Name = "rb_near";
            this.rb_near.Size = new System.Drawing.Size(47, 16);
            this.rb_near.TabIndex = 33;
            this.rb_near.TabStop = true;
            this.rb_near.Text = "付近";
            this.rb_near.UseVisualStyleBackColor = true;
            // 
            // VehicleSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 650);
            this.Controls.Add(this.rb_near);
            this.Controls.Add(this.rb_less);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tb_ansmission_fund_type);
            this.Controls.Add(this.bt_find);
            this.Controls.Add(this.tb_budget);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.tb_mileage);
            this.Controls.Add(this.tb_color);
            this.Controls.Add(this.tb_medel_year);
            this.Controls.Add(this.tb_car_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.dgv_order_list);
            this.Name = "VehicleSearch";
            this.Text = "一致車両情報表示";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_order_list;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_car_name;
        private System.Windows.Forms.TextBox tb_medel_year;
        private System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.TextBox tb_mileage;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.TextBox tb_budget;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.TextBox tb_ansmission_fund_type;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn 車名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 色;
        private System.Windows.Forms.DataGridViewTextBoxColumn 変速機構の種別;
        private System.Windows.Forms.RadioButton rb_less;
        private System.Windows.Forms.RadioButton rb_near;
    }
}