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
    public partial class UCAdvanced : UserControl
    {
        private A_Manager.Functions Functions;
        private A_Manager.Objects Objects;

        public UCAdvanced()
        {
            InitializeComponent();
        }     
        

        private void cirticularButton11_Click(object sender, EventArgs e)
        {
            if (Functions == null || Functions.IsDisposed)
            {
                Functions = new A_Manager.Functions();
                Functions.Show();
            }
        }

        private void cirticularButton12_Click(object sender, EventArgs e)
        {
            if (Objects == null || Objects.IsDisposed)
            {
                Objects = new A_Manager.Objects();
                Objects.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmError.Show("OK");
        }
    }
}
