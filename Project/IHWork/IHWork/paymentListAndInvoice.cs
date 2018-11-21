using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace IHWork
{
    /*入金照合画面*/
    public partial class paymentListAndInvoice : Form
    {
        //テキストファイル受け取り用変数
        private ArrayList _bank;
        private paymentReference pr;

        public paymentListAndInvoice()
        {
            this._bank = new ArrayList();
            this.pr = new paymentReference();
            InitializeComponent();
        }

        //値受け取り用処理メソッド
        public void receiveData(ArrayList bank)
        {
            this._bank = bank;
        }

        //フォームロード時
        private void paymentListAndInvoice_Load(object sender, EventArgs e)
        {
            string bankData = "";
            string transferer = "";
            string transferMoney = "";
            string transferDate = "";

            //カラム数を指定
            dGVDepositList.ColumnCount = 3;

            //カラム名を指定
            dGVDepositList.Columns[0].HeaderText = "振込依頼人";
            dGVDepositList.Columns[1].HeaderText = "金額";
            dGVDepositList.Columns[2].HeaderText = "勘定日";

            //*** DataGridView PROPERTY設定
            dGVDepositList.MultiSelect = false;
            dGVDepositList.ReadOnly = true;
            dGVDepositList.RowHeadersVisible = false;

            //遷移元から送られてきた配列を表示（一行目はヘッダーレコードのためスキップ）
            for (int i = 1; i < this._bank.Count; i++)
            {
                //Console.WriteLine(this._bank[i]);

                //配列の中身の一部を取り出し
                bankData = this._bank[i].ToString();
                transferDate = bankData.Substring(7, 6); //勘定日
                transferMoney = bankData.Substring(19, 10); //金額
                transferer = bankData.Substring(49); //振込依頼人

                //データを追加
                dGVDepositList.Rows.Add(transferer, transferMoney, transferDate);
            }
        }
    }
}
