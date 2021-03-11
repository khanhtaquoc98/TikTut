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
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }
        int len = 0;
        int counter = 0;
        string txt;


        private void UCHome_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label1.Text = "";
            }
            else
            {
                label1.Text = txt.Substring(0, counter);
                if (label1.ForeColor == Color.White)
                {
                    label1.ForeColor = Color.White;
                }
                else
                {
                    label1.ForeColor = Color.White;
                }

            }

        }
    }
    }
