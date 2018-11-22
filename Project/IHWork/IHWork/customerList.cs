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
    public partial class customerList : Form
    {
        // フィールド。
        private String _dbCnctStr;
        private MySqlConnection _cnct;
        private String _customerName;
        private List<Customers> _list;

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
                _list = new List<Customers>();

                //エンティティに入れる

                for (int i = 0; i < dsCustomers.Tables["t_customers"].Rows.Count; i++)
                {
                    Customers c = new Customers();

                    c.setId(dsCustomers.Tables["t_customers"].Rows[i]["id"].ToString());
                    c.setPhonetic(dsCustomers.Tables["t_customers"].Rows[i]["phonetic"].ToString());
                    c.setName(dsCustomers.Tables["t_customers"].Rows[i]["name"].ToString());
                    c.setZipCode(dsCustomers.Tables["t_customers"].Rows[i]["zip_code"].ToString());
                    c.setAddress(dsCustomers.Tables["t_customers"].Rows[i]["address"].ToString());
                    c.setPhone(dsCustomers.Tables["t_customers"].Rows[i]["phone"].ToString());
                    c.setFax(dsCustomers.Tables["t_customers"].Rows[i]["fax"].ToString());
                    c.setCreditLimit(dsCustomers.Tables["t_customers"].Rows[i]["credit_limit"].ToString());
                    c.setCarryOver(dsCustomers.Tables["t_customers"].Rows[i]["carry_over"].ToString());

                    dgvCustomersList.Rows.Add(c.getName());
                    _list.Add(c);
                }

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
