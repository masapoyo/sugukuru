using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace IHWork
{
    /// <summary>
    /// 顧客情報一覧画面
    /// </summary>
    /// 
    /// <author>Yuki Yoshida</author>
    public partial class customerList : Form
    {
        //フィールド
        private readonly String _dbCnctStr;
        private String _customerName;
        private MySqlConnection _cnct;
        private List<Customers> _list;

        public customerList()
        {
            InitializeComponent();

            //コネクタの宣言
            this._dbCnctStr = ConfigurationManager.AppSettings["DbConKey"];
            this._cnct = new MySqlConnection(this._dbCnctStr);
        }

        private void customerList_Load(object sender, EventArgs e)
        {
            //デバッガーにヘッダーとして画面名を表示
            Debug.WriteLine("--[顧客情報一覧画面]------");

            //dgvプロパティ設定
            dgvCustomersList.MultiSelect = false;
            dgvCustomersList.ReadOnly = true;
            dgvCustomersList.RowHeadersVisible = false;
            dgvCustomersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomersList.ColumnCount = 1;

            //データ取得
            getData();
        }

        /// <summary>
        /// DBからデータを取得し、dgvに表示するメソッド
        /// </summary>
        private void getData()
        {
            //sqlの設定
            String sql = "SELECT " +
                    "* " +
                    "FROM t_customers";

            //データセットの設定
            DataSet dsCustomers = new DataSet("t_customers");
            try
            {
                this._cnct.Open();

                //DBからデータを取得
                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, _cnct);
                mAdp.Fill(dsCustomers, "t_customers");

                //リストの宣言
                _list = new List<Customers>();

                //デバッガーに情報の種類を表示
                Debug.WriteLine("-----取得データ-----");

                for (int i = 0; i < dsCustomers.Tables["t_customers"].Rows.Count; i++)
                {
                    //エンティティの初期化
                    Customers c = new Customers();
                    
                    //エンティティに入れる
                    c.setId(dsCustomers.Tables["t_customers"].Rows[i]["id"].ToString());
                    c.setPhonetic(dsCustomers.Tables["t_customers"].Rows[i]["phonetic"].ToString());
                    c.setName(dsCustomers.Tables["t_customers"].Rows[i]["name"].ToString());
                    c.setZipCode(dsCustomers.Tables["t_customers"].Rows[i]["zip_code"].ToString());
                    c.setAddress(dsCustomers.Tables["t_customers"].Rows[i]["address"].ToString());
                    c.setPhone(dsCustomers.Tables["t_customers"].Rows[i]["phone"].ToString());
                    c.setFax(dsCustomers.Tables["t_customers"].Rows[i]["fax"].ToString());
                    c.setCreditLimit(dsCustomers.Tables["t_customers"].Rows[i]["credit_limit"].ToString());
                    c.setCarryOver(dsCustomers.Tables["t_customers"].Rows[i]["carry_over"].ToString());
                    
                    //デバッガーに取得情報を表示
                    Debug.WriteLine("id: " + c.getId() + " = name:" + c.getName());

                    //リストに追加
                    _list.Add(c);

                    //dgvに反映
                    dgvCustomersList.Rows.Add(c.getName());
                }

            }
            catch (Exception ex)
            {
                //デバッガーに例外の詳細を出力
                Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
                Debug.WriteLine(Convert.ToString(ex));
            }
            finally
            {
                //コネクタの切断
                if (this._cnct != null)
                {
                    this._cnct.Close();
                }
            }
        }

        /// <summary>
        /// 行をダブルクリックした時のイベントハンドラ
        /// </summary>
        private void dgvCustomersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //選択された顧客情報を抽出
            Customers c = _list[dgvCustomersList.SelectedRows[0].Index];

            //デバッガーに選択した情報を表示
            Debug.WriteLine("-----選択データ-----");
            Debug.WriteLine("id: " + c.getId());

            //顧客情報を遷移先に格納
            OrderCheck f = new OrderCheck();
            this.Hide();

            f.receiveMode(OrderCheck.INPUT_MODE);   //受注フェーズであることを明示
            f.receiveCustomer(c);   //選択した顧客情報を送信
            f.ShowDialog();

            this.Dispose();
        }
    }
    
}
