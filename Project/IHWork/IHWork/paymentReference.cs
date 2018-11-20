using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IHWork
{
    public partial class paymentReference : Form
    {
        private String _fileName = "";  //読み込んだファイル名。
        private List<String> _bankDataList;

        public paymentReference()
        {
            InitializeComponent();
        }

        private void oFDReference_FileOk(object sender, CancelEventArgs e)
        {
            //ファイルをList<String>に変換
            StreamReader reader = new StreamReader(this._fileName, Encoding.GetEncoding("utf-8"));
            this._bankDataList.Add(reader.ReadLine());
            while(!reader.EndOfStream)
            {
                this._bankDataList.Add(reader.ReadLine());
            }
            reader.Close();
        }

        private void btReference_Click(object sender, EventArgs e)
        {
            DialogResult dr = oFDReference.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this._fileName = oFDReference.FileName;
                tbReference.Text = this._fileName;
            }
        }
    }
}
