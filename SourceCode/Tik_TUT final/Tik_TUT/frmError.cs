using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_TUT
{
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }
        static frmError Error; static DialogResult result = DialogResult.No;
        public static DialogResult Show( string button1)
        {
            Error = new frmError();
            Error.button1.Text = "OK";
            Error.ShowDialog();
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
