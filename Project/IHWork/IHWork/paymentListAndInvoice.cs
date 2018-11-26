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
        
        //データベース接続文字列格納用変数
        private string ConStr;

        //SQL文格納用変数
        private string _sql;

        //消込対象の請求データの主キーを格納する配列
        private ArrayList _clearBills;

        //未払い分格納用変数
        private int _unpaid;

        //顧客ID格納用変数
        private string _customerId;

        public paymentListAndInvoice()
        {
            InitializeComponent();
            this._bank = new ArrayList();
            this.pr = new paymentReference();
            this.ConStr = ConfigurationManager.AppSettings["DbConKey"];
            this._sql = "";
            this._clearBills = new ArrayList();
            this._unpaid = 0;
            this._customerId = "";
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
            int transferMoney = 0;
            string transferDate = "";
            
            //カラム数を指定
            dGVDepositList.ColumnCount = 3;

            //カラム名を指定
            dGVDepositList.Columns[0].HeaderText = "振込依頼人";
            dGVDepositList.Columns[1].HeaderText = "金額";
            dGVDepositList.Columns[2].HeaderText = "勘定日";

            for(int i = 0; i < dGVDepositList.ColumnCount; i++)
            {
                dGVDepositList.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
            //*** DataGridView PROPERTY設定
            dGVDepositList.MultiSelect = false;
            dGVDepositList.ReadOnly = true;
            dGVDepositList.RowHeadersVisible = false;
            dGVDepositList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //DataGridViewの表示幅に合わせて列幅自動調整
            dGVDepositList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            //遷移元から送られてきた配列を表示（一行目はヘッダーレコードのためスキップ）
            for (int i = 1; i < this._bank.Count; i++)
            {
                //Console.WriteLine(this._bank[i]);

                //配列の中身の一部を取り出し
                bankData = this._bank[i].ToString();
                transferDate = bankData.Substring(7, 6); //勘定日
                transferMoney = int.Parse(bankData.Substring(19, 10)); //金額
                transferer = bankData.Substring(49); //振込依頼人

                //データを追加
                dGVDepositList.Rows.Add(transferer, transferMoney, transferDate);
            }

            //v_biilsからデータ抽出
            this._sql = "SELECT no, phonetic, price, carry_over, printed_at, customer_id FROM v_bills WHERE cleared = false;";
            DbSelectData(this._sql);
        }

        //データベースからデータ抽出するクラス
        private void DbSelectData(string sql)
        {
            //抽出データを格納するデータセット作成
            DataSet dSet = new DataSet("v_bills");

            //データベース接続オブジェクト作成
            MySqlConnection con = new MySqlConnection(this.ConStr);

            //データベース接続
            con.Open();

            //データアダプタ生成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            //データ抽出＆取得
            mAdp.Fill(dSet, "v_bills");

            //データベース切断
            con.Close();

            //データテーブルとDataGridViewの関連付け
            dGVInvoiceList.DataSource = dSet.Tables["v_bills"];

            //*** DataGridView PROPERTY設定
            dGVInvoiceList.MultiSelect = false;
            dGVInvoiceList.ReadOnly = true;
            dGVInvoiceList.RowHeadersVisible = false;
            dGVInvoiceList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //カラム名を指定
            dGVInvoiceList.Columns[0].HeaderText = "No";
            dGVInvoiceList.Columns[1].HeaderText = "顧客名";
            dGVInvoiceList.Columns[2].HeaderText = "請求金額";
            dGVInvoiceList.Columns[3].HeaderText = "うち繰越金額";
            dGVInvoiceList.Columns[4].HeaderText = "請求書発行日";
            dGVInvoiceList.Columns[5].HeaderText = "顧客ID";

            //DataGridViewの表示幅に合わせて列幅自動調整
            dGVInvoiceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dGVInvoiceList.Columns[0].Width = 0;
            dGVInvoiceList.Columns[5].Width = 0;

            //抽出件数チェック
            int cnt = dSet.Tables["v_bills"].Rows.Count;
            
            //データセットの中身を確認→InvoiceMatchDepositに顧客名、金額を送信
            for (int i = 0; i < cnt; i++)
            {
                InvoiceMatchDeposit(
                    dSet.Tables["v_bills"].Rows[i]["no"].ToString(),
                    dSet.Tables["v_bills"].Rows[i]["phonetic"].ToString(),
                    dSet.Tables["v_bills"].Rows[i]["price"].ToString(),
                    dSet.Tables["v_bills"].Rows[i]["customer_id"].ToString(),
                    this._bank
                    );
            }
        }

        //請求データと一致する入金データを検索する処理メソッド
        private void InvoiceMatchDeposit(string no, string phonetic, string price, string customerId, ArrayList bank)
        {
            string bankData = "";
            string transferer = "";
            int transferMoney = 0;

            this._customerId = customerId; //顧客ID
            int priceInt = int.Parse(price); //請求額

            //配列の中身確認処理（一行目はヘッダーレコードのためスキップ）
            for (int i = 1; i < bank.Count; i++)
            {
                //配列の中身の一部を取り出し（一レコードずつ）
                bankData = bank[i].ToString();
                transferMoney = int.Parse( bankData.Substring(19, 10) ); //金額
                transferer = bankData.Substring(49); //振込依頼人

                //請求データ（顧客名＋金額）と一致しているかの判断処理
                //一致している場合：その行をグレーアウト＆一致する請求Noを配列に格納
                if (phonetic.Equals(transferer) && priceInt == transferMoney)
                {
                    this._clearBills.Add(no);
                    dGVDepositList.Rows[i-1].DefaultCellStyle.BackColor = Color.Gray;
                    break;
                }
                //金額が一致しない場合
                else if(phonetic.Equals(transferer) && priceInt != transferMoney)
                {
                    //請求額＞入金額の場合……未払い分算出
                    if(priceInt > transferMoney)
                    {
                        //未払い分算出
                        _unpaid = priceInt - transferMoney;
                        AtCarryOver(this._customerId, _unpaid);
                    }
                    
                }
            }

        }

        //未払い分を繰り越し分として顧客テーブルに追加（あるいは更新）する処理メソッド
        private void AtCarryOver(string customerId, int unpaid)
        {
            this._sql = "UPDATE t_customers SET carry_over = " + unpaid + " WHERE id = " + customerId + ";"; 

            //データベース接続オブジェクト作成
            MySqlConnection con = new MySqlConnection(this.ConStr);

            //データベース接続
            con.Open();

            //SQL発行準備
            MySqlCommand cmd = new MySqlCommand(this._sql, con);

            //SQL実行
            cmd.ExecuteNonQuery();

            //データベース切断
            con.Close();
        }

        //削除フラグを立てる処理メソッド
        private void ClearProcess(string no)
        {
            this._sql = "UPDATE t_bills SET cleared = true WHERE no = " + no + ";";

            //データベース接続オブジェクト作成
            MySqlConnection con = new MySqlConnection(this.ConStr);

            //データベース接続
            con.Open();

            //SQL発行準備
            MySqlCommand cmd = new MySqlCommand(this._sql, con);

            //SQL実行
            cmd.ExecuteNonQuery();

            //データベース切断
            con.Close();
        }

        //消込ボタン押下時の処理メソッド
        private void btCleaning_Click(object sender, EventArgs e)
        {
            //消込対象の請求レコードの削除フラグを立てる
            for(int i = 0; i < this._clearBills.Count; i++)
            {
                ClearProcess(this._clearBills[i].ToString());
            }

            this.Hide();
            clearConpletion cc = new clearConpletion();
            cc.receiveData(this._clearBills, this._customerId);
            cc.ShowDialog();
            this.Dispose();
        }
    }
    
}
