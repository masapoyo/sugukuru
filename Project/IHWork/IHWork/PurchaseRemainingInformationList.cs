using Entities;
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

namespace IHWork
{
    /// <summary>
    /// 受注一覧画面
    /// </summary>
    /// 
    /// <author>Yuki Yoshida</author>
    public partial class PurchaseRemainingInformationList : Form
    {
        //フィールド
        private readonly String _dbCnctStr;
        private MySqlConnection _cnct;
        private List<Orders> _list;

        public PurchaseRemainingInformationList()
        {
            InitializeComponent();

            //コネクタの宣言
            this._dbCnctStr = ConfigurationManager.AppSettings["DbConKey"];
            this._cnct = new MySqlConnection(this._dbCnctStr);
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
                    "FROM v_orders " +
                    "WHERE cleared = false ";

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
                        case 3:
                            dgvOrdersList.Rows[i].Cells[4].Value = "CVT";
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

        private void dgvOrdersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //選択された受注情報を抽出
            Orders o = _list[dgvOrdersList.SelectedRows[0].Index];

            //デバッガーに選択した情報を表示
            Debug.WriteLine("-----選択データ-----");
            Debug.WriteLine("no: " + o.getNo());

            //受注情報を遷移先に格納
            OrderInformationConfirmationScreen f = new OrderInformationConfirmationScreen();
            this.Hide();

            f.receiveMode(OrderInformationConfirmationScreen.EDIT_MODE);    //編集のみのモードに移行
            f.receiveOrder(o);   //選択した受注情報を送信
            f.receiveRep(getRep(o));
            f.receiveCustomer(getCustomer(o));
            f.ShowDialog();

            this.Dispose();
        }

        /// <summary>
        /// 受注情報から担当者データを取得するメソッド
        /// </summary>
        /// 
        /// <param name="order">受注情報</param>
        private Employees getRep(Orders order)
        {
            //sqlの設定
            String sql = "SELECT " +
                    "* " +
                    "FROM v_orders " +
                    "WHERE no = " + order.getNo() + " ";

            //データセットの設定
            DataSet dsCustomers = new DataSet("v_orders");

            Employees r = new Employees();
            try
            {
                this._cnct.Open();

                //DBからデータを取得
                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, _cnct);
                mAdp.Fill(dsCustomers, "v_orders");

                //リストの宣言
                _list = new List<Orders>();

                //デバッガーに情報の種類を表示
                Debug.WriteLine("-----選択された受注の担当者-----");

                for (int i = 0; i < dsCustomers.Tables["v_orders"].Rows.Count; i++)
                {
                    //エンティティの初期化
                    r = new Employees();

                    //エンティティに入れる
                    r.setId(dsCustomers.Tables["v_orders"].Rows[i]["rep_id"].ToString());
                    r.setName(dsCustomers.Tables["v_orders"].Rows[i]["rep_name"].ToString());
                    r.setPhonetic(dsCustomers.Tables["v_orders"].Rows[i]["rep_phonetic"].ToString());
                    r.setGender(Boolean.Parse(dsCustomers.Tables["v_orders"].Rows[i]["rep_gender"].ToString()));
                    r.setBirthday(dsCustomers.Tables["v_orders"].Rows[i]["rep_birthday"].ToString());

                    //デバッガーに取得情報を表示
                    Debug.WriteLine("id: " + r.getId());
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

            return r;
        }

        /// <summary>
        /// 受注情報から依頼者（顧客）情報を取得するメソッド
        /// </summary>
        /// 
        /// <param name="order">依頼情報</param>
        private Customers getCustomer(Orders order)
        {
            //sqlの設定
            String sql = "SELECT " +
                    "* " +
                    "FROM v_orders " +
                    "WHERE no = " + order.getNo() + " ";

            //データセットの設定
            DataSet dsCustomers = new DataSet("v_orders");

            Customers c = new Customers();
            try
            {
                this._cnct.Open();

                //DBからデータを取得
                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, _cnct);
                mAdp.Fill(dsCustomers, "v_orders");

                //リストの宣言
                _list = new List<Orders>();

                //デバッガーに情報の種類を表示
                Debug.WriteLine("-----選択された受注の依頼者（顧客）-----");

                for (int i = 0; i < dsCustomers.Tables["v_orders"].Rows.Count; i++)
                {
                    //エンティティの初期化
                    c = new Customers();

                    //エンティティに入れる
                    c.setId(dsCustomers.Tables["v_orders"].Rows[i]["customer_id"].ToString());
                    c.setName(dsCustomers.Tables["v_orders"].Rows[i]["customer_name"].ToString());
                    c.setPhonetic(dsCustomers.Tables["v_orders"].Rows[i]["customer_phonetic"].ToString());

                    //デバッガーに取得情報を表示
                    Debug.WriteLine("id: " + c.getId());
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

            return c;
        }
    }
}
