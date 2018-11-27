using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHWork
{
    /// <summary>
    /// 受注情報詳細画面
    /// </summary>
    /// 
    /// <author>Yuki Yoshida</author>
    public partial class OrderInformationConfirmationScreen : Form
    {
        //定数
        /// <summary>
        /// 編集のみ
        /// </summary>
        public const int EDIT_MODE = 0;
        /// <summary>
        /// 納品書発行可
        /// </summary>
        public const int PRINTING_MODE = 1;

        //フィールド
        private Orders _order;
        private Employees _rep;
        private Customers _customer;
        private int _mode;

        public OrderInformationConfirmationScreen()
        {
            InitializeComponent();
        }

        private void OrderInformationConfirmationScreen_Load(object sender, EventArgs e)
        {
            //デバッガーにヘッダーとして画面名を表示
            Debug.WriteLine("--[受注情報詳細画面]------");

            //デバッガーに受信した情報を表示
            Debug.WriteLine("-----受信データ-----");
            Debug.WriteLine("no: " + this._order.getNo());

            // モードの変更
            switch (this._mode)
            {
                case EDIT_MODE:
                    gbContracted.Enabled = false;
                    btEdit.Enabled = true;
                    btPrint.Enabled = false;
                    break;
                case PRINTING_MODE:
                    gbContracted.Enabled = true;
                    btEdit.Enabled = true;
                    btPrint.Enabled = true;
                    break;
            }

            //右揃え
            lbWinning.TextAlign = ContentAlignment.BottomRight;
            lbExpen.TextAlign = ContentAlignment.BottomRight;
            lbBuy.TextAlign = ContentAlignment.BottomRight;
            lbSum.TextAlign = ContentAlignment.BottomRight;

            //代入
            lb_car_name.Text = this._order.getCarName();
            lb_medel_year.Text = this._order.getCarYear();
            lb_color.Text = this._order.getCarColor();
            lb_mileage.Text = this._order.getCarMileage().ToString() + " km";
            lb_budget.Text = this._order.getBudget().ToString() + " 円";
            switch (this._order.getTransmission())
            {
                case 1:
                    lb_transmission_fund_type.Text = "AT";
                    break;
                case 2:
                    lb_transmission_fund_type.Text = "MT";
                    break;
                case 3:
                    lb_transmission_fund_type.Text = "CVT";
                    break;
            }
            lb_remarks.Text = this._order.getNote();
            lb_rep.Text = this._rep.getName();
            lbWinning.Text = this._order.getContracted().ToString();
            lbExpen.Text = this._order.getExpenses().ToString();
            lbBuy.Text = this._order.getCommision().ToString();
            lbSum.Text = (this._order.getContracted() + this._order.getExpenses() + this._order.getCommision()).ToString();
        }

        /// <summary>
        /// 選択した受注情報を受け取るメソッド
        /// </summary>
        /// 
        /// <param name="order">選択した受注</param>
        internal void receiveOrder(Orders order)
        {
            this._order = order;
        }

        /// <summary>
        /// 選択した受注情報の担当者を受け取るメソッド
        /// </summary>
        /// 
        /// <param name="rep">担当者</param>
        internal void receiveRep(Employees rep)
        {
            this._rep = rep;
        }

        /// <summary>
        /// 選択した受注情報の依頼者（顧客）を受け取るメソッド
        /// </summary>
        /// 
        /// <param name="customer">顧客</param>
        internal void receiveCustomer(Customers customer)
        {
            this._customer = customer;
        }

        /// <summary>
        /// 編集のみ／納品書発行可を切り替えるメソッド
        /// </summary>
        /// 
        /// <param name="mode">編集のみ／納品書発行可の何れか</param>
        internal void receiveMode(int mode)
        {
            this._mode = mode;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

            //デバッガーに選択した情報を表示
            Debug.WriteLine("-----選択データ-----");
            Debug.WriteLine("no: " + this._order.getNo());

            //顧客情報を遷移先に格納
            OrderCheck f = new OrderCheck();
            this.Hide();

            f.receiveMode(OrderCheck.MODIFICATION_MODE);   //仕入れフェーズであることを明示
            f.receiveOrder(this._order);    //選択した依頼情報を送信
            f.receiveCustomer(this._customer);   //該当の顧客情報を送信
            f.receiveRep(this._rep);    //該当の担当者を送信
            f.ShowDialog();

            this.Dispose();
        }
    }
}
