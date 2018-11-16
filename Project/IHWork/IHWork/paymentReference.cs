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
    public partial class paymentReference : Form
    {
        public paymentReference()
        {
            InitializeComponent();
        }

        private void oFDReference_FileOk(object sender, CancelEventArgs e)
        {
         
        }

        private void btReference_Click(object sender, EventArgs e)
        {
            DialogResult dr = oFDReference.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                tbReference.Text = oFDReference.FileName;
            }
        }
    }
}
