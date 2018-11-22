using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using MySql.Data.MySqlClient;

namespace IHWork
{
    public partial class login : Form
    {
        MySqlConnection cnct;
        Employees emp;
        public login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            cnct = new MySqlConnection();
            emp = new Employees();
            //入力値チェック
            if (!"".Equals(tbUserId.Text.ToString()) && !"".Equals(tbPassword.Text.ToString()))
            {
                try
                {
                    //テキスト取得    
                    String id = tbUserId.Text.ToString();
                    String pass = tbPassword.Text.ToString();
                    //emp = this.cnct.CheckLogin(id, pass);
                    MessageBox.Show("ログイン完了 " + emp.getName(), "OK");
                }
                catch
                {
                    MessageBox.Show("ユーザー名もしくはパスワードが正しくありません ", "OK");
                    return;
                }

                customerList cL = new customerList();
                this.Hide();
                cL.ShowDialog();
                this.Close();
                //オブジェクトが閉じたら
                cL.Dispose();
                
            }
            else
            {
                MessageBox.Show( "ユーザー名もしくはパスワードが入力されていません", "エラー");
                return;
            }
            
        }
    }
}
