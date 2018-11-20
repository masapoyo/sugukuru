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
    public partial class customerList : Form
    {
        // フィールド。
        private String _dbCnctStr;
        private MySqlConnection _cnct;
        private String _customerName;

        public customerList()
        {
            InitializeComponent();

            this._dbCnctStr = ConfigurationManager.AppSettings["dbCnctStrings"];
            this._cnct = new MySqlConnection(this._dbCnctStr);
        }

        private void customerList_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            String sql = "SELECT " +
                    "* " +
                    "FROM t_customers";

            DataSet dsCustomers = new DataSet("t_customers");
            try
            {
                this._cnct.Open();

                MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, _cnct);
                mAdp.Fill(dsCustomers, "t_customers");

                //エンティティに入れる NOT DATAGRID
                dgvCustomersList.DataSource = dsCustomers.Tables["t_customers"];

                /*
                dgvCustomersList.Columns[1].HeaderText = this._customerPhonetic;
                dgvCustomersList.Columns[2].HeaderText485455415554144154455
                4
                ]= this._customerName;
                dgvCustomersList.Columns[2].HeaderText = this._customerZipCode;
                dgvCustomersList.Columns[3].HeaderText = this._customerAddress;
                dgvCustomersList.Columns[4].HeaderText = this._customerPhone;
                dgvCustomersList.Columns[5].HeaderText = this._customerFax;
                dgvCustomersList.Columns[6].HeaderText = this._customerCreditLimit;
                dgvCustomersList.Columns[7].HeaderText = this._customerCarryOver;
                */

            }
            catch (Exception ex)
            {
                Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
                Debug.WriteLine(Convert.ToString(ex));
            }
            finally
            {
                this._cnct.Close();
            }
        }
    }
    
}
