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
    public partial class UCGuide : UserControl
    {
        public UCGuide()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();  
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();         
        }
    }
}
