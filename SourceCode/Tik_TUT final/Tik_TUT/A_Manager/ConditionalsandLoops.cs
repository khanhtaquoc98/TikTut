using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_TUT.A_Manager
{
    public partial class ConditionalsandLoops : Form
    {
        private Conditionals_and_Loops.CLogicalOperators LogicalOperators;
        private Conditionals_and_Loops.CModule2 Module2;
        private Conditionals_and_Loops.CTheDoWhileLoop TheDoWhileLoop;
        private Conditionals_and_Loops.CTheElse TheElse;
        private Conditionals_and_Loops.CTheforLoop TheforLoop;
        private Conditionals_and_Loops.CTheIfState TheIfState;
        private Conditionals_and_Loops.CTheSwitch TheSwitch;
        private Conditionals_and_Loops.CTheWhileLoop TheWhileLoop;
        private Conditionals_and_Loops.CUsingaWhileLoop UsingaWhileLoop;

        public ConditionalsandLoops()
        {
            InitializeComponent();
        }
        public int s;
        public string _uname = "";
        //Load Form Conditional And Loops
        private void ConditionalsandLoops_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, User> entry in Form1.user)
            {
                DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                DataProvider.cn.Open();
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

                if (!Form1.user.ContainsKey(Form1.username)) { return; }
                _uname = entry.Key;
                try
                {
                    string sql = @"select _yourscore from _User where _username = '" + _uname + "'";
                    SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            s = reader.GetInt32(0);
                            // Important Compare
                            #region Compare 
                            if (s >= 14)
                            {                           
                                Form1.check_14 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 15)
                            {
                                Form1.check_14 = false; Form1.check_15 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 16)
                            {
                                Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 17)
                            {
                                Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false; Form1.check_17 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 18)
                            {
                                button1.BackColor = Color.GreenYellow;
                                button1.Enabled = true;
                                button2.Enabled = true;
                                Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false; Form1.check_17 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false; Form1.check_18 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 19)
                            {
                                Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false; Form1.check_17 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false; Form1.check_18 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false; Form1.check_19 = false;
                            }
                            if (s >= 20)
                            {
                                Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false; Form1.check_17 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false; Form1.check_18 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false; Form1.check_19 = false; Form1.check_20 = false;
                            }
                            if (s >= 21)
                            {
                                Form1.check_21 = false;
                                Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false; Form1.check_17 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false; Form1.check_18 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false; Form1.check_19 = false; Form1.check_20 = false;
                            }
                            if(s>=22)
                            {
                                Form1.check_22 = false;
                            }
                            if (s >= 23)
                            {
                                Form1.check_23 = false;
                            }
                            if (s >= 24)
                            {
                                button2.BackColor = Color.GreenYellow;
                                //button2.Enabled = false;
                                button3.Enabled = true;
                                Form1.check_24 = false;
                            }
                            if (s >= 25)
                            {
                                Form1.check_25 = false;
                            }
                            if (s >= 26)
                            {
                                Form1.check_26 = false;
                            }
                            if (s >= 27)
                            {
                                button3.BackColor = Color.GreenYellow;

                                button4.Enabled = true;
                                Form1.check_27 = false;
                            }
                            #endregion
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
                finally
                {
                    lb_3.Text = "Score: " + s;
                    lb_3.ForeColor = Color.Red;
                    lb_3.BackColor = Color.Transparent;
                    

                    DataProvider.cn.Close();
                    DataProvider.cn.Dispose();
                }
                break; 
                //Form1.check_1 = false;
            }
        }

        //Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            if (TheIfState == null || TheIfState.IsDisposed)
            {
                TheIfState = new Conditionals_and_Loops.CTheIfState(); this.Close();
                TheIfState.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TheElse == null || TheElse.IsDisposed)
            {
                TheElse = new Conditionals_and_Loops.CTheElse(); this.Close();
                TheElse.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TheWhileLoop == null || TheWhileLoop.IsDisposed)
            {
                TheWhileLoop = new Conditionals_and_Loops.CTheWhileLoop(); this.Close();
                TheWhileLoop.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (UsingaWhileLoop == null || UsingaWhileLoop.IsDisposed)
            {
                UsingaWhileLoop = new Conditionals_and_Loops.CUsingaWhileLoop(); this.Close();
                UsingaWhileLoop.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TheforLoop == null || TheforLoop.IsDisposed)
            {
                TheforLoop = new Conditionals_and_Loops.CTheforLoop(); this.Close();
                TheforLoop.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TheDoWhileLoop == null || TheDoWhileLoop.IsDisposed)
            {
                TheDoWhileLoop = new Conditionals_and_Loops.CTheDoWhileLoop(); this.Close();
                TheDoWhileLoop.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TheSwitch == null || TheSwitch.IsDisposed)
            {
                TheSwitch = new Conditionals_and_Loops.CTheSwitch(); this.Close();
                TheSwitch.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (LogicalOperators == null || LogicalOperators.IsDisposed)
            {
                LogicalOperators = new Conditionals_and_Loops.CLogicalOperators(); this.Close();
                LogicalOperators.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Module2 == null || Module2.IsDisposed)
            {
                Module2 = new Conditionals_and_Loops.CModule2(); this.Close();
                Module2.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
