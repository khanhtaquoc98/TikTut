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
    public partial class UCIntermediate : UserControl
    {
        private A_Manager.ConditionalsandLoops ConditionalsandLoops;
        private A_Manager.DData Data;

        public UCIntermediate()
        {
            InitializeComponent();
        }       

        

        

        private void cirticularButton11_Click(object sender, EventArgs e)
        {
            if (ConditionalsandLoops == null || ConditionalsandLoops.IsDisposed)
            {
                ConditionalsandLoops = new A_Manager.ConditionalsandLoops();
                ConditionalsandLoops.Show();
            }
        }

        private void cirticularButton12_Click(object sender, EventArgs e)
        {
            if (Data == null || Data.IsDisposed)
            {
                Data = new A_Manager.DData();
                Data.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmError.Show("OK");
        }
    }
}
