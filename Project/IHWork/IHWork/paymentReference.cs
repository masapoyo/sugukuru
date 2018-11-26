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
using System.Collections;

namespace IHWork
{
    /*入金データ読み込み画面*/
    public partial class paymentReference : Form
    {
        public paymentReference()
        {
            InitializeComponent();
        }

        private void oFDReference_FileOk(object sender, CancelEventArgs e)
        {
         
        }

        //参照ボタン押下処理
        private void btReference_Click(object sender, EventArgs e)
        {
            DialogResult dr = oFDReference.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                tbReference.Text = oFDReference.FileName;
            }
        }

        //読み込みボタン押下処理
        private void btCheck_Click(object sender, EventArgs e)
        {
            string line = "";
            ArrayList bank = new ArrayList();

            //テキストファイル読み込み
            String txtPath = tbReference.Text.ToString();

            //テキストファイルの中身を一行ずつ読み込んで配列に格納
            using (StreamReader sr = new StreamReader( txtPath, Encoding.GetEncoding("UTF-8") ))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    bank.Add(line);
                }
            }
            
            //入金照会画面へ遷移
            paymentListAndInvoice pla = new paymentListAndInvoice();
            this.Hide();

            pla.receiveData(bank); //テキストファイルの中身を格納した配列を送信
            pla.ShowDialog();

            this.Dispose();
        }
    }
}
