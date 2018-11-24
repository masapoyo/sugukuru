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
using Entities;
using Mysql.Data;

namespace IHWork
{
    /// <summary>
    /// 依頼情報入力／編集画面
    /// </summary>
    /// 
    /// <author>Yuki Yoshida</author>
    public partial class OrderCheck : Form
    {
        //定数
        /// <summary>
        /// 受注フェーズ（入力画面）
        /// </summary>
        public const int INPUT_MODE = 0;
        /// <summary>
        /// 仕入フェーズ（編集画面）
        /// </summary>
        public const int MODIFICATION_MODE = 1;

        //フィールド
        private String _dbCnctStr;   // DB接続文字列を格納するフィールド。
        MySqlConnection _cnct;
        private Customers _customer;
        private Orders _order;
        private int _mode;

        
        public OrderCheck()
        {
            InitializeComponent();
        }

        private void OrderCheck_Load(object sender, EventArgs e)
        {
            //デバッガーにヘッダーとして画面名を表示
            Debug.WriteLine("--[依頼情報入力／編集画面]------");

            //デバッガーに受信した情報を表示
            Debug.WriteLine("-----受信データ-----");
            Debug.WriteLine("id: " + this._customer.getId());

            //デバッガーに情報の種類を表示
            Debug.WriteLine("-----受信データ-----");
            switch (this._mode)
            {
                case INPUT_MODE:    //受注フェーズの場合
                    Debug.WriteLine("フェーズ: 受注");   //デバッガーに現在のフェーズを表示

                    onCreateInputView();

                    break;
                case MODIFICATION_MODE: //仕入フェーズの場合
                    Debug.WriteLine("フェーズ: 仕入");   //デバッガーに現在のフェーズを表示

                    onCreateModificationView();

                    break;
            }

            //顧客名を表示
            lbCustomer.Text = this._customer.getName();
        }

        /// <summary>
        /// 入力画面（受注フェーズ）を生成するメソッド
        /// </summary>
        private void onCreateInputView()
        {
            this.Text = "依頼情報入力画面";
            lbForm.Text = "依頼情報入力画面";
            //this.Size = new Size(852, 540);
            gbContracted.Enabled = false;
            btChange.Visible = false;
            btSubmit.Enabled = true;
            btSubmit.Text = "決定";
        }

        /// <summary>
        /// 編集画面（仕入フェーズ）を生成するメソッド
        /// </summary>
        private void onCreateModificationView()
        {
            this.Text = "依頼情報編集画面";
            lbForm.Text = "依頼情報編集画面";
            //this.Size = new Size(852, 540);
            gbContracted.Enabled = true;
            btChange.Visible = true;
            btSubmit.Enabled = true;
            btSubmit.Text = "受注消込";
        }

        /// <summary>
        /// 決定／受注消込ボタン押下時のメソッド
        /// </summary>
        private void btSubmit_Click(object sender, EventArgs e)
        {
            this._order = new Orders();

            //エンティティに設定
            this._order.setCarName(tbCarName.Text);
            this._order.setCarYear(tbCarYear.Text);
            //this._order.setCarModel(tbMode.Text);
            this._order.setCarColor(tbColor.Text);
            this._order.setCarMileage(Double.Parse(tbMileage.Text));
            this._order.setBudget(Int32.Parse(tbBudget.Text));
            if(rbLess.Checked)
            {
                this._order.setBudgetCategory(false);
            } else if(rbNear.Checked)
            {
                this._order.setBudgetCategory(true);
            }
            //this._order.setTransmission();
            this._order.setNote(tbNote.Text);
            //this._order.setRep();

            //データベースに挿入

        }

        /// <summary>
        /// 選択した顧客情報を受け取るメソッド
        /// </summary>
        /// 
        /// <param name="customer">選択した顧客</param>
        internal void receiveCustomer(Customers customer)
        {
            this._customer = customer;
        }

        /// <summary>
        /// 受注／仕入フェーズを切り替えるメソッド
        /// </summary>
        /// 
        /// <param name="mode">受注フェーズ／仕入フェーズの何れか</param>
        internal void receiveMode(int mode)
        {
            this._mode = mode;
        }

        /// <summary>
        /// 選択した顧客情報を受け取るメソッド
        /// </summary>
        /// 
        /// <param name="order">選択した受注</param>
        internal void receiveOrder(Orders order)
        {
            this._order = order;
        }
    }
}
