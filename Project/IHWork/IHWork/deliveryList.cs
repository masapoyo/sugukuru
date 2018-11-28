using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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

namespace IHWork
{
    public partial class deliveryList : Form
    {
        //フィールド
        private readonly String _dbCnctStr;
        private MySqlConnection _cnct;
        private List<Orders> _list;

        public deliveryList()
        {
            InitializeComponent();

            //コネクタの宣言
            this._dbCnctStr = ConfigurationManager.AppSettings["DbConKey"];
            this._cnct = new MySqlConnection(this._dbCnctStr);
        }

        private void deliveryList_Load(object sender, EventArgs e)
        {
            //デバッガーにヘッダーとして画面名を表示
            Debug.WriteLine("--[請求一覧画面]------");

            //dgvプロパティ設定
            dgvList.MultiSelect = false;
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ColumnCount = 6;

            //データ取得
            getData();
        }

        /// <summary>
        /// ダブルクリック
        /// </summary>
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// DBからデータを取得し、dgvに表示するメソッド
        /// </summary>
        private void getData()
        {
            //sqlの設定
            String sql = "SELECT " +
                    "* " +
                    "FROM v_orders " +
                    "WHERE cleared = true ";

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

                for (int i = 0; i < dsCustomers.Tables["v_orders"].Rows.Count; i++)
                {
                    //エンティティの初期化
                    Orders o = new Orders();

                    //エンティティに入れる
                    o.setNo(dsCustomers.Tables["v_orders"].Rows[i]["no"].ToString());
                    o.setCarName(dsCustomers.Tables["v_orders"].Rows[i]["car_name"].ToString());
                    o.setCarYear(dsCustomers.Tables["v_orders"].Rows[i]["car_year"].ToString());
                    o.setCarModel(dsCustomers.Tables["v_orders"].Rows[i]["car_model"].ToString());
                    o.setCarColor(dsCustomers.Tables["v_orders"].Rows[i]["car_color"].ToString());
                    o.setCarMileage(Double.Parse(dsCustomers.Tables["v_orders"].Rows[i]["car_mileage"].ToString()));
                    o.setBudget(Int32.Parse(dsCustomers.Tables["v_orders"].Rows[i]["budget"].ToString()));
                    o.setBudgetCategory(Boolean.Parse(dsCustomers.Tables["v_orders"].Rows[i]["budget_category"].ToString()));
                    o.setTransmission(Int32.Parse(dsCustomers.Tables["v_orders"].Rows[i]["transmission"].ToString()));
                    o.setNote(dsCustomers.Tables["v_orders"].Rows[i]["note"].ToString());
                    o.setReceivedAt(dsCustomers.Tables["v_orders"].Rows[i]["received_at"].ToString());
                    o.setCleared(Boolean.Parse(dsCustomers.Tables["v_orders"].Rows[i]["cleared"].ToString()));
                    o.setContracted(Int32.Parse(dsCustomers.Tables["v_orders"].Rows[i]["contracted"].ToString()));
                    o.setExpenses(Int32.Parse(dsCustomers.Tables["v_orders"].Rows[i]["expenses"].ToString()));
                    o.setCommision(Int32.Parse(dsCustomers.Tables["v_orders"].Rows[i]["commision"].ToString()));
                    o.setCustomer(dsCustomers.Tables["v_orders"].Rows[i]["customer_id"].ToString());
                    o.setRep(dsCustomers.Tables["v_orders"].Rows[i]["rep_id"].ToString());

                    //デバッガーに取得情報を表示
                    Debug.WriteLine("no: " + o.getNo() + " = name:" + o.getCarName());

                    //リストに追加
                    _list.Add(o);

                    //dgvに反映
                    dgvList.Rows.Add();
                    dgvList.Rows[i].Cells[0].Value = dsCustomers.Tables["v_orders"].Rows[i]["customer_name"].ToString();
                    dgvList.Rows[i].Cells[1].Value = o.getCarName();
                    dgvList.Rows[i].Cells[2].Value = o.getCarYear();
                    dgvList.Rows[i].Cells[3].Value = o.getCarModel();
                    dgvList.Rows[i].Cells[4].Value = o.getCarColor();
                    dgvList.Rows[i].Cells[5].Value = o.getReceivedAt();
                    switch (o.getTransmission())
                    {
                        case 1:
                            dgvList.Rows[i].Cells[4].Value = "AT";
                            break;
                        case 2:
                            dgvList.Rows[i].Cells[4].Value = "MT";
                            break;
                        case 3:
                            dgvList.Rows[i].Cells[4].Value = "CVT";
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

        /// <summary>
        /// 請求ボタン押下
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            invoiceFormat f = new invoiceFormat();
            ArrayList l = new ArrayList();
            for (int i = 0; i < this._list.Count; i++) {
                l.Add(this._list[i].getCustomer());
            }

            f.receiveData(_list, l);

            f.ShowDialog();

            this.Dispose();
        }
    }

    
}
