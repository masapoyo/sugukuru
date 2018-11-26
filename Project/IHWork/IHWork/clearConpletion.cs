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
    /*消込完了後の画面*/
    public partial class clearConpletion : Form
    {
        //データベース接続文字列格納用変数
        private string ConStr;

        //SQL文格納用変数
        private string _sql;

        //未払い件数格納用の配列
        private ArrayList _unpaid;

        //顧客ID格納用の変数
        private string _customerId;

        public clearConpletion()
        {
            InitializeComponent();
            this.ConStr = ConfigurationManager.AppSettings["DbConKey"];
            this._sql = "";
            this._unpaid = new ArrayList();
            this._customerId = "";
        }

        //値受け取り用処理メソッド
        public void receiveData(ArrayList unpaid, string customerId)
        {
            this._unpaid = unpaid; 
            this._customerId = customerId; 
        }

        //データベースから顧客情報（顧客名、繰越金額）を抽出しDataGridViewに表示する処理メソッド
        private void SelectCustomer(string id)
        {
            //顧客情報を格納する配列
            ArrayList customerList = new ArrayList();

            //SQL
            this._sql = "SELECT name, carry_over FROM t_customers WHERE id = " + id + ";";

            //抽出データを格納するデータセット作成
            DataSet dSet = new DataSet("t_customers");

            //データベース接続オブジェクト作成
            MySqlConnection con = new MySqlConnection(this.ConStr);

            //データベース接続
            con.Open();

            //データアダプタ生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(this._sql, con);

            //データ抽出＆取得
            mAdp.Fill(dSet, "t_customers");

            //データベース切断
            con.Close();

            //データテーブルとDataGridViewの関連付け
            dGVCarryOverList.DataSource = dSet.Tables["t_customers"];

            //*** DataGridView PROPERTY設定
            dGVCarryOverList.MultiSelect = false;
            dGVCarryOverList.ReadOnly = true;
            dGVCarryOverList.RowHeadersVisible = false;
            dGVCarryOverList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //カラム名を指定
            dGVCarryOverList.Columns[0].HeaderText = "顧客名";
            dGVCarryOverList.Columns[1].HeaderText = "未払金額";
        }

        //フォームロード時
        private void clearConpletion_Load(object sender, EventArgs e)
        {
            lbUnpaid.Text = this._unpaid.Count.ToString();
            SelectCustomer(this._customerId);
        }

        //閉じるボタン押下時の処理メソッド
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
