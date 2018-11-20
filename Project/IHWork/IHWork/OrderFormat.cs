using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHWork
{
    public partial class OrderFormat : Form
    {
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label14;
        private Label label15;
        private Label label16;
        private GroupBox groupBox1;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label9;
        private RadioButton rbNear;
        private RadioButton rbLess;
        private Button bt_Chenge;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox tb_remarks;
        private TextBox tb_transmission_fund_type;
        private TextBox tb_budget;
        private TextBox tb_mileage;
        private TextBox tb_color;
        private TextBox tb_model;
        private TextBox tb_medel_year;
        private TextBox tb_car_name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;

        public OrderFormat()
        {
            InitializeComponent();
        }

        private void tb_budget_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbNear = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.bt_Chenge = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_remarks = new System.Windows.Forms.TextBox();
            this.tb_transmission_fund_type = new System.Windows.Forms.TextBox();
            this.tb_budget = new System.Windows.Forms.TextBox();
            this.tb_mileage = new System.Windows.Forms.TextBox();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.tb_medel_year = new System.Windows.Forms.TextBox();
            this.tb_car_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(731, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 40);
            this.button2.TabIndex = 63;
            this.button2.Text = "受注消込";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 19);
            this.textBox1.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 19);
            this.textBox2.TabIndex = 40;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(279, 19);
            this.textBox3.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 38;
            this.label14.Text = "買手数料";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 12);
            this.label15.TabIndex = 37;
            this.label15.Text = "オークション諸経費";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "落札価格";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(435, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 228);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "取引後";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 61;
            this.label12.Text = "sample";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 415);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 60;
            this.label13.Text = "担当者名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 59;
            this.label11.Text = "sample";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 58;
            this.label9.Text = "顧客名";
            // 
            // rbNear
            // 
            this.rbNear.AutoSize = true;
            this.rbNear.Location = new System.Drawing.Point(210, 267);
            this.rbNear.Name = "rbNear";
            this.rbNear.Size = new System.Drawing.Size(47, 16);
            this.rbNear.TabIndex = 57;
            this.rbNear.TabStop = true;
            this.rbNear.Text = "付近";
            this.rbNear.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.Location = new System.Drawing.Point(121, 266);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(47, 16);
            this.rbLess.TabIndex = 56;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "以下";
            this.rbLess.UseVisualStyleBackColor = true;
            // 
            // bt_Chenge
            // 
            this.bt_Chenge.Location = new System.Drawing.Point(623, 466);
            this.bt_Chenge.Name = "bt_Chenge";
            this.bt_Chenge.Size = new System.Drawing.Size(102, 40);
            this.bt_Chenge.TabIndex = 55;
            this.bt_Chenge.Text = "変更";
            this.bt_Chenge.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 54;
            this.label10.Text = "備考";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 12);
            this.label8.TabIndex = 53;
            this.label8.Text = "変速機構の種別";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "予算";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 51;
            this.label6.Text = "走行距離";
            // 
            // tb_remarks
            // 
            this.tb_remarks.Location = new System.Drawing.Point(121, 315);
            this.tb_remarks.MaxLength = 250;
            this.tb_remarks.Multiline = true;
            this.tb_remarks.Name = "tb_remarks";
            this.tb_remarks.Size = new System.Drawing.Size(279, 86);
            this.tb_remarks.TabIndex = 50;
            // 
            // tb_transmission_fund_type
            // 
            this.tb_transmission_fund_type.Location = new System.Drawing.Point(121, 290);
            this.tb_transmission_fund_type.Name = "tb_transmission_fund_type";
            this.tb_transmission_fund_type.Size = new System.Drawing.Size(279, 19);
            this.tb_transmission_fund_type.TabIndex = 49;
            // 
            // tb_budget
            // 
            this.tb_budget.Location = new System.Drawing.Point(121, 240);
            this.tb_budget.Name = "tb_budget";
            this.tb_budget.Size = new System.Drawing.Size(279, 19);
            this.tb_budget.TabIndex = 48;
            // 
            // tb_mileage
            // 
            this.tb_mileage.Location = new System.Drawing.Point(121, 215);
            this.tb_mileage.Name = "tb_mileage";
            this.tb_mileage.Size = new System.Drawing.Size(279, 19);
            this.tb_mileage.TabIndex = 47;
            // 
            // tb_color
            // 
            this.tb_color.Location = new System.Drawing.Point(121, 190);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(279, 19);
            this.tb_color.TabIndex = 46;
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(121, 165);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(279, 19);
            this.tb_model.TabIndex = 45;
            // 
            // tb_medel_year
            // 
            this.tb_medel_year.Location = new System.Drawing.Point(121, 140);
            this.tb_medel_year.Name = "tb_medel_year";
            this.tb_medel_year.Size = new System.Drawing.Size(279, 19);
            this.tb_medel_year.TabIndex = 44;
            // 
            // tb_car_name
            // 
            this.tb_car_name.Location = new System.Drawing.Point(121, 115);
            this.tb_car_name.Name = "tb_car_name";
            this.tb_car_name.Size = new System.Drawing.Size(279, 19);
            this.tb_car_name.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 42;
            this.label5.Text = "色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "型式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "年式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "車両名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "依頼フォーマット";
            // 
            // OrderFormat
            // 
            this.ClientSize = new System.Drawing.Size(853, 532);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbNear);
            this.Controls.Add(this.rbLess);
            this.Controls.Add(this.bt_Chenge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_remarks);
            this.Controls.Add(this.tb_transmission_fund_type);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
