using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHWork
{
    public partial class login : Form
    {
        private String _dbCnctStr;   // DB接続文字列を格納するフィールド。
        MySqlConnection _cnct;

        public login()
        {
            InitializeComponent();
        }

        
    }
}
