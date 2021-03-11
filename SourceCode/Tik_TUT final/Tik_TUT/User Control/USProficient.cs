using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_TUT.User_Control
{
    public partial class USProficient : UserControl
    {
        private A_Manager.MoreOnClasses frmMOC;
        public USProficient()
        {
            InitializeComponent();
        }

        private void cirticularButton11_Click(object sender, EventArgs e)
        {
            if (frmMOC == null || frmMOC.IsDisposed)
            {
                frmMOC = new A_Manager.MoreOnClasses();
                frmMOC.Show();
            }
        }

        private void cirticularButton12_Click(object sender, EventArgs e)
        {
            
            frmError.Show("OK");
        }

        private void cirticularButton13_Click(object sender, EventArgs e)
        {
            frmError.Show("OK");
        }

        private void cirticularButton14_Click(object sender, EventArgs e)
        {
            frmError.Show("OK");
        }
    }
}
