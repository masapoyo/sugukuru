namespace IHWork
{
    partial class OrderFormat
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_car_name = new System.Windows.Forms.TextBox();
            this.tb_medel_year = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.tb_mileage = new System.Windows.Forms.TextBox();
            this.tb_budget = new System.Windows.Forms.TextBox();
            this.tb_remarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_registration = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.rbNear = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "依頼フォーマット";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "車両名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "年式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "型式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "色";
            // 
            // tb_car_name
            // 
            this.tb_car_name.Location = new System.Drawing.Point(119, 126);
            this.tb_car_name.Name = "tb_car_name";
            this.tb_car_name.Size = new System.Drawing.Size(279, 19);
            this.tb_car_name.TabIndex = 5;
            // 
            // tb_medel_year
            // 
            this.tb_medel_year.Location = new System.Drawing.Point(119, 151);
            this.tb_medel_year.Name = "tb_medel_year";
            this.tb_medel_year.Size = new System.Drawing.Size(279, 19);
            this.tb_medel_year.TabIndex = 6;
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(119, 176);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(279, 19);
            this.tb_model.TabIndex = 7;
            // 
            // tb_color
            // 
            this.tb_color.Location = new System.Drawing.Point(119, 201);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(279, 19);
            this.tb_color.TabIndex = 8;
            // 
            // tb_mileage
            // 
            this.tb_mileage.Location = new System.Drawing.Point(119, 226);
            this.tb_mileage.Name = "tb_mileage";
            this.tb_mileage.Size = new System.Drawing.Size(279, 19);
            this.tb_mileage.TabIndex = 9;
            // 
            // tb_budget
            // 
            this.tb_budget.Location = new System.Drawing.Point(119, 251);
            this.tb_budget.Name = "tb_budget";
            this.tb_budget.Size = new System.Drawing.Size(279, 19);
            this.tb_budget.TabIndex = 10;
            this.tb_budget.TextChanged += new System.EventHandler(this.tb_budget_TextChanged);
            // 
            // tb_remarks
            // 
            this.tb_remarks.Location = new System.Drawing.Point(119, 326);
            this.tb_remarks.MaxLength = 250;
            this.tb_remarks.Multiline = true;
            this.tb_remarks.Name = "tb_remarks";
            this.tb_remarks.Size = new System.Drawing.Size(279, 86);
            this.tb_remarks.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "走行距離";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "予算";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "変速機構の種別";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "備考";
            // 
            // bt_registration
            // 
            this.bt_registration.Location = new System.Drawing.Point(296, 439);
            this.bt_registration.Name = "bt_registration";
            this.bt_registration.Size = new System.Drawing.Size(102, 40);
            this.bt_registration.TabIndex = 19;
            this.bt_registration.Text = "登録";
            this.bt_registration.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 19);
            this.textBox1.TabIndex = 20;
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.Location = new System.Drawing.Point(119, 279);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(47, 16);
            this.rbLess.TabIndex = 21;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "以下";
            this.rbLess.UseVisualStyleBackColor = true;
            // 
            // rbNear
            // 
            this.rbNear.AutoSize = true;
            this.rbNear.Location = new System.Drawing.Point(172, 279);
            this.rbNear.Name = "rbNear";
            this.rbNear.Size = new System.Drawing.Size(47, 16);
            this.rbNear.TabIndex = 22;
            this.rbNear.TabStop = true;
            this.rbNear.Text = "付近";
            this.rbNear.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "顧客名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(117, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "sample";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "sample";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 422);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "担当者名";
            // 
            // OrderFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 491);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbNear);
            this.Controls.Add(this.rbLess);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_registration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_remarks);
            this.Controls.Add(this.tb_budget);
            this.Controls.Add(this.tb_mileage);
            this.Controls.Add(this.tb_color);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.tb_medel_year);
            this.Controls.Add(this.tb_car_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderFormat";
            this.Text = "依頼フォーマット画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_car_name;
        private System.Windows.Forms.TextBox tb_medel_year;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.TextBox tb_mileage;
        private System.Windows.Forms.TextBox tb_budget;
        private System.Windows.Forms.TextBox tb_remarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_registration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbNear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

