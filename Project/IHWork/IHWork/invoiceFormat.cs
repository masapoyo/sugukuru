using Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IHWork
{

    public partial class invoiceFormat : Form
    {
        //入力用値格納
        //ボタン２次元配列
        private List<TextBox[]> al2Text = new List<TextBox[]>();
        private TextBox[] tbTbl;
        //行数
        private int num = 7;
        //消費税
        private int taxp = 8;
        //前画面からの情報
        private List<Orders> _alOrder = new List<Orders>();
        private System.Collections.ArrayList alId = new System.Collections.ArrayList();

        //税額
        private int tax = 0;
        private int allMoney = 0;

        private OurCompany oc;
        private List<Orders> invo;
        //コンストラクト
        public invoiceFormat()
        {
            InitializeComponent();
        }

        internal void receiveData(List<Orders> invo, System.Collections.ArrayList ids)
        {
            _alOrder = invo;
            alId = ids;
        }
       

        //ボタンの設定
        private void invoiceFormat_Load(object sender, EventArgs e)
        {
            //画面設定
            //画面の表示を停止
            this.SuspendLayout();
            //Textboxの配置
            for (int i = 0; i < num; i++)
            {
                //TextBoxコントロールの作成
                this.tbTbl = new TextBox[5];
                this.tbTbl[0] = new TextBox();
                this.tbTbl[0].Name = "name" + i;
                this.tbTbl[0].Text = "";
                this.tbTbl[0].Font = new Font("MS UI Gothic", 16);
                this.tbTbl[0].Size = new Size(249, 27);
                this.tbTbl[0].Location = new Point(54, 191 + 35 * i);
                this.tbTbl[0].TextAlign = HorizontalAlignment.Center;
                this.tbTbl[0].BorderStyle = System.Windows.Forms.BorderStyle.None;
                //数量
                this.tbTbl[1] = new TextBox();
                this.tbTbl[1].Name = "num" + i;
                this.tbTbl[1].Text = "";
                this.tbTbl[1].Size = new Size(62, 27);
                this.tbTbl[1].Font = new Font("MS UI Gothic", 16);
                this.tbTbl[1].Location = new Point(317, 191 + 35 * i);
                this.tbTbl[1].TextAlign = HorizontalAlignment.Right;
                this.tbTbl[1].BorderStyle = System.Windows.Forms.BorderStyle.None;
                //単価
                this.tbTbl[2] = new TextBox();
                this.tbTbl[2].Name = "price" + i;
                this.tbTbl[2].Text = "";
                this.tbTbl[2].Size = new Size(62, 27);
                this.tbTbl[2].Font = new Font("MS UI Gothic", 16);
                this.tbTbl[2].Location = new Point(399, 191 + 35 * i);
                this.tbTbl[2].TextAlign = HorizontalAlignment.Right;
                this.tbTbl[2].BorderStyle = System.Windows.Forms.BorderStyle.None;
                //金額
                this.tbTbl[3] = new TextBox();
                this.tbTbl[3].Name = "allPrice" + i;
                this.tbTbl[3].Text = "";
                this.tbTbl[3].Size = new Size(148, 27);
                this.tbTbl[3].Font = new Font("MS UI Gothic", 16);
                this.tbTbl[3].Location = new Point(472, 191 + 35 * i);
                this.tbTbl[3].TextAlign = HorizontalAlignment.Right;
                this.tbTbl[3].BorderStyle = System.Windows.Forms.BorderStyle.None;
                //摘要
                this.tbTbl[4] = new TextBox();
                this.tbTbl[4].Name = "Summary" + i;
                this.tbTbl[4].Text = "";
                this.tbTbl[4].Size = new Size(148, 27);
                this.tbTbl[4].Font = new Font("MS UI Gothic", 16);
                this.tbTbl[4].Location = new Point(626, 191 + 35 * i);
                this.tbTbl[4].TextAlign = HorizontalAlignment.Center;
                this.tbTbl[4].BorderStyle = System.Windows.Forms.BorderStyle.None;
                //出力１列分
                this.Controls.AddRange(this.tbTbl);
                al2Text.Add(tbTbl);
            }
            //受け取った値を設定する。
            for (int i = 0; i < _alOrder.Count(); i++)
            {
                tbTbl = al2Text[i];
                Orders order = _alOrder[i];
                //名前
                tbTbl[0].Text = order.getCarName();
                //個数
                tbTbl[1].Text = "";
                //単価
                tbTbl[2].Text = order.getContracted().ToString();
                //価格
                tbTbl[3].Text = (order.getContracted() + order.getExpenses()).ToString();
                allMoney += order.getContracted() + order.getExpenses();
                //摘要
                tbTbl[4].Text = order.getNote();
                //取引先名
                tbWho.Text = _alOrder[0].getRep();
            }

            tax = (allMoney * taxp) / 100;
            tbTax.TextAlign = HorizontalAlignment.Right; 
            tbTax.Text = tax.ToString();
            tbAllPrice.TextAlign = HorizontalAlignment.Right;
            tbAllPrice.Text = allMoney.ToString();
            tbAllPriceTax.TextAlign = HorizontalAlignment.Right;
            tbAllPriceTax.Text = (allMoney + tax).ToString();
            DateTime dt = System.DateTime.Now;

            tbYear.TextAlign = HorizontalAlignment.Right;
            tbYear.Text = dt.ToShortDateString().Substring(0,4);
            tbYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbMonth.TextAlign = HorizontalAlignment.Right;
            tbMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbMonth.Text = dt.ToShortDateString().Substring(5, 2);
            tbDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbDay.TextAlign = HorizontalAlignment.Right;
            tbDay.Text = dt.ToShortDateString().Substring(8, 2);

            this.getOurCompany();
            tbCOName.Text = oc.getName();
            tbPost.Text = oc.getZipCode();
            tbAddres.Text = oc.getAddress();
            tbNumber.Text = oc.getPhone() + oc.getFac();
            
            pbInvoice.SendToBack();
            //画面の表示再開
            this.ResumeLayout(false);
        }

        public void getOurCompany()
        {
            MySqlConnections conc = new MySqlConnections();
            oc = conc.getCompany();
            if(oc == null)
            {
                oc = new OurCompany();
            }

        }

        private void btPrin_Click(object sender, EventArgs e)
        {
            MySqlConnections conc = new MySqlConnections();
            conc.insertBills(alId);
            //画面出力
            paymentReference pr = new paymentReference();
            this.Hide();
            pr.ShowDialog();
            this.Close();
            //オブジェクトが閉じたら
            pr.Dispose();
        }

    }
}
