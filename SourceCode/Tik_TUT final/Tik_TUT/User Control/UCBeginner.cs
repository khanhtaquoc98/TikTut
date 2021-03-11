using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_TUT
{
    public partial class UCBeginner : UserControl
    {
        private A_Manager.BasicConcepts BasicConcepts;
        public UCBeginner()
        {
            InitializeComponent();
        }     

       

        private void cirticularButton11_Click(object sender, EventArgs e)
        {
            if (BasicConcepts == null || BasicConcepts.IsDisposed)
            {
                BasicConcepts = new A_Manager.BasicConcepts();
                BasicConcepts.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmError.Show("OK");
        }
    }
}
