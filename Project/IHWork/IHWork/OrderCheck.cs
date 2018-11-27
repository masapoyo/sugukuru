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
using MySql.Data.MySqlClient;

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
        private readonly String _dbCnctStr;
        MySqlConnection _cnct;
        private Customers _customer;
        private Orders _order;
        private int _mode;
        private Employees _rep;

        
        public OrderCheck()
        {
            InitializeComponent();
            this._dbCnctStr = ConfigurationManager.AppSettings["DbConKey"];
        }

        private void OrderCheck_Load(object sender, EventArgs e)
        {
            //デバッグ用
            this._rep.setId("aaaa0001".ToString());

            //デバッガーにヘッダーとして画面名を表示
            Debug.WriteLine("--[依頼情報入力／編集画面]------");

            //デバッガーに受信した情報を表示
            Debug.WriteLine("-----受信データ-----");
            Debug.WriteLine("顧客id: " + this._customer.getId());
            Debug.WriteLine("受注no: " + this._order.getNo());

            //AT・MTをコンボボックスに登録
            cbTransmission.Items.Add("");
            cbTransmission.Items.Add("AT");
            cbTransmission.Items.Add("MT");
            cbTransmission.Items.Add("CVT");

            //デバッガーに情報の種類を表示
            Debug.WriteLine("-----フェーズ-----");
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

            //AT・MTの選択
            rbLess.Checked = true;
            rbNear.Checked = false;

            cbTransmission.SelectedIndex = 0;
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

            //値を引き継ぐ
            tbCarName.Text = this._order.getCarName();
            tbCarYear.Text = this._order.getCarYear();
            tbModel.Text = this._order.getCarModel();
            tbColor.Text = this._order.getCarColor();
            tbMileage.Text = this._order.getCarMileage().ToString();
            tbBudget.Text = this._order.getBudget().ToString();
            if(this._order.isAround())
            {
                rbLess.Checked = false;
                rbNear.Checked = true;
            } else
            {
                rbLess.Checked = true;
                rbNear.Checked = false;
            }
            cbTransmission.SelectedIndex = this._order.getTransmission();
            tbNote.Text = this._order.getNote();
            tbContracted.Text = this._order.getContracted().ToString();
            tbExpenses.Text = this._order.getExpenses().ToString();
            tbCommision.Text = this._order.getCommision().ToString();
        }

        /// <summary>
        /// 決定／受注消込ボタン押下時のメソッド
        /// </summary>
        private void btSubmit_Click(object sender, EventArgs e)
        {
            inputOrder(true);
        }

        /// <summary>
        /// 変更ボタン押下時のメソッド
        /// </summary>
        private void btChange_Click(object sender, EventArgs e)
        {
            inputOrder(false);
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
        /// 入力・編集両方に必要な項目をエンティティに代入するメソッド
        /// </summary>
        /// 
        /// <param name="which">どちらのボタンが押されたか（FALSE=変更、TRUE=受注消込）</param>
        private void inputOrder(Boolean which)
        {
            this._cnct = new MySqlConnection(this._dbCnctStr);
            this._order = new Orders();

            //エンティティに設定
            this._order.setCarName(tbCarName.Text.ToString());
            this._order.setCarYear(tbCarYear.Text.ToString());
            this._order.setCarModel(tbModel.Text.ToString());
            this._order.setCarColor(tbColor.Text.ToString());
            this._order.setCarMileage(Double.Parse(tbMileage.Text.ToString()));
            this._order.setBudget(Int32.Parse(tbBudget.Text.ToString()));
            if (rbLess.Checked)
            {
                this._order.setBudgetCategory(false);
            }
            else if (rbNear.Checked)
            {
                this._order.setBudgetCategory(true);
            }
            this._order.setTransmission(cbTransmission.SelectedIndex);
            this._order.setNote(tbNote.Text.ToString());
            this._order.setContracted(Int32.Parse(tbContracted.Text.ToString()));
            this._order.setExpenses(Int32.Parse(tbExpenses.Text.ToString()));
            this._order.setCommision(Int32.Parse(tbCommision.Text.ToString()));

            //データベースに挿入
            String sql = "";
            switch (this._mode) {
                case INPUT_MODE:
                    sql = "INSERT INTO t_orders " +
                    "(customer, rep, car_name, car_year, car_model, car_color, car_mileage, budget, budget_category, transmission, note) " +
                    "VALUES " +
                    "(@customer, @rep, @carName, @carYear, @carModel, @carColor, @carMileage, @budget, @around, @transmission, @note)";
                    break;
                case MODIFICATION_MODE:
                    sql = "UPDATE t_orders SET " +
                    "customer = @customer, " +
                    "car_name = @carName, " +
                    "car_year = @carYear, " +
                    "car_model = @carModel, " +
                    "car_color = @carColor, " +
                    "car_mileage = @carMileage, " +
                    "budget = @budget, " +
                    "budget_category = @around, " +
                    "transmission = @transmission, " +
                    "note = @note, " +
                    "cleared = @which, " +
                    "contracted = @contracted, " +
                    "expenses = @expenses, " +
                    "commision = @commision " + 
                    "WHERE no = @no ";
                    break;
            }

            try
            {
                this._cnct.Open();

                MySqlCommand cmd = new MySqlCommand(sql, this._cnct);

                // インジェクション対策。
                cmd.Parameters.Add(new MySqlParameter("customer", this._customer.getId()));
                cmd.Parameters.Add(new MySqlParameter("rep", this._rep.getId()));
                cmd.Parameters.Add(new MySqlParameter("carName", this._order.getCarName()));
                cmd.Parameters.Add(new MySqlParameter("carYear", this._order.getCarYear()));
                cmd.Parameters.Add(new MySqlParameter("carModel", this._order.getCarModel()));
                cmd.Parameters.Add(new MySqlParameter("carColor", this._order.getCarColor()));
                cmd.Parameters.Add(new MySqlParameter("carMileage", this._order.getCarMileage()));
                cmd.Parameters.Add(new MySqlParameter("budget", this._order.getBudget()));
                cmd.Parameters.Add(new MySqlParameter("around", this._order.isAround()));
                cmd.Parameters.Add(new MySqlParameter("transmission", this._order.getTransmission()));
                cmd.Parameters.Add(new MySqlParameter("note", this._order.getNote()));

                if (this._mode == MODIFICATION_MODE)
                {
                    cmd.Parameters.Add(new MySqlParameter("no", this._order.getNo()));
                    cmd.Parameters.Add(new MySqlParameter("contracted", this._order.getContracted()));
                    cmd.Parameters.Add(new MySqlParameter("expenses", this._order.getExpenses()));
                    cmd.Parameters.Add(new MySqlParameter("commision", this._order.getCommision()));
                    cmd.Parameters.Add(new MySqlParameter("which", which));
                }

                int count = cmd.ExecuteNonQuery();
                Debug.WriteLine("更新件数: " + count.ToString());
                Debug.WriteLine("no: " + this._order.getNo().ToString());
            }
            catch (Exception ex)
            {
                Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
                Debug.WriteLine(Convert.ToString(ex));
            }
            finally
            {
                if (this._cnct != null)
                {
                    this._cnct.Close();
                }
            }
        }
    }
}
