using Entities;
using MySql.Data.MySqlClient;
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
    public partial class PurchaseRemainingInformationList : Form
    {
        //フィールド
        private readonly String _dbCnctStr;
        private MySqlConnection _cnct;
        private List<Orders> _list;

        public PurchaseRemainingInformationList()
        {
            InitializeComponent();
        }

        private void PurchaseRemainingInformationList_Load(object sender, EventArgs e)
        {
            //デバッガーにヘッダーとして画面名を表示
            Debug.WriteLine("--[依頼情報一覧画面]------");

            //dgvプロパティ設定
            dgvOrdersList.MultiSelect = false;
            dgvOrdersList.ReadOnly = true;
            dgvOrdersList.RowHeadersVisible = false;
            dgvOrdersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdersList.ColumnCount = 5;

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
                    "FROM v_orders";

            //データセットの設定
            DataSet dsCustomers = new DataSet("v_orders");
            try
            {
                this._cnct.Open();

                //DBからデータを取得
                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, _cnct);
                mAdp.Fill(dsCustomers, "v_orders");

                //リストの宣言
                _list = new List<Orders>();

                //デバッガーに情報の種類を表示
                Debug.WriteLine("-----取得データ-----");

                for (int i = 0; i < dsCustomers.Tables["t_customers"].Rows.Count; i++)
                {
                    //エンティティの初期化
                    Orders o = new Orders();

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
                    Debug.WriteLine("no: " + o.getNo() + " = name:" + o.getCarName());

                    //リストに追加
                    _list.Add(o);

                    //dgvに反映
                    dgvOrdersList.Rows.Add();
                    dgvOrdersList.Rows[i].Cells[0].Value = o.getCarName();
                    dgvOrdersList.Rows[i].Cells[1].Value = o.getCarYear();
                    dgvOrdersList.Rows[i].Cells[2].Value = o.getCarModel();
                    dgvOrdersList.Rows[i].Cells[3].Value = o.getCarColor();
                    switch (o.getTransmission()) {
                        case 1:
                            dgvOrdersList.Rows[i].Cells[4].Value = "AT";
                            break;
                        case 2:
                            dgvOrdersList.Rows[i].Cells[4].Value = "MT";
                            break;
                    }
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
    }
}
