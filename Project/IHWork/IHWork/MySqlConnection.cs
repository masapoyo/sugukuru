using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHWork
{
    class MySqlConnection
    {

        String ConStr;
        DataSet dset;
        MySql.Data.MySqlClient.MySqlConnection con;
        int rcnt;

        public MySqlConnection()
        {
            this.dset = new DataSet("cp32testdb");
            this.ConStr = ConfigurationManager.AppSettings["DdConKey"];
            this.con = new MySql.Data.MySqlClient.MySqlConnection();
        }


        public int GetGakuseki(String val)
        {
            //SQL作成
            String sql = "select gno, gname, zip, addr from gakuseki" +
                         " where gno = '" + val + "'";

            //DB接続
            con.Open();
            // データアダプター作成
            MySqlDataAdapter mAdp = new MySqlDataAdapter(sql, con);

            // データ抽出＆取得
            mAdp.Fill(dset, "gakuseki");

            con.Close();

            this.rcnt = dset.Tables["gakuseki"].Rows.Count;

            return rcnt;
        }

        public void CheckLogin(String id, String pass)
        {

            String sql = "select ";



            try {
                this.con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, this.con);

            }

        }


    }
}
