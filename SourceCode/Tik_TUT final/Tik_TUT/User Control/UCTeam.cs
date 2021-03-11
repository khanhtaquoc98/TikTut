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
    public partial class UCTeam : UserControl
    {
        public UCTeam()
        {
            InitializeComponent();
        }
        
        int counter1 = 0;
        int len1 = 0;
        int counter2 = 0;
        int len2 = 0;
        int counter3 = 0;
        int len3 = 0;
        string txt1;
        string txt2;
        string txt3;


        private void UCTeam_Load(object sender, EventArgs e)
        {
            txt1 = label1.Text;
            len1 = txt1.Length;
            txt2 = label2.Text;
            len2 = txt2.Length;
            txt3 = label3.Text;
            len3 = txt3.Length;
            timer1.Start();            
            timer2.Start();            
            timer3.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1++;
            if (counter1 > len1)
            {
                counter1 = 0;
                label1.Text = "";
            }
            else
            {
                label1.Text = txt1.Substring(0, counter1);
                if (label1.ForeColor == Color.Black)
                {
                    label1.ForeColor = Color.Black;
                }
                else
                {
                    label1.ForeColor = Color.Black;
                }

            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter2++;
            if (counter2 > len2)
            {
                counter2 = 0;
                label2.Text = "";
            }
            else
            {
                label2.Text = txt2.Substring(0, counter2);
                if (label2.ForeColor == Color.Black)
                {
                    label2.ForeColor = Color.Black;
                }
                else
                {
                    label2.ForeColor = Color.Black;
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            counter3++;
            if (counter3 > len3)
            {
                counter3 = 0;
                label3.Text = "";
            }
            else
            {
                label3.Text = txt3.Substring(0, counter3);
                if (label3.ForeColor == Color.Black)
                {
                    label3.ForeColor = Color.Black;
                }
                else
                {
                    label3.ForeColor = Color.Black;
                }
            }
        }
    }
}

