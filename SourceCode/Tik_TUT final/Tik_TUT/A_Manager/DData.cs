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
    public partial class DData : Form
    {
        private Data.DArrays Arrays;
        private Data.DArraysinCalculations ArraysinCalculations;
        private Data.DDynamicMemory DynamicMemory;
        private Data.DIntFloat IntFloat;
        private Data.DIntroduction Introduction;
        private Data.DIntroductiontoPointers IntroductiontoPointers;
        private Data.DModule3Quiz Module3Quiz;
        private Data.DMoreonPointers MoreonPointers;
        private Data.DMulti Multi;
        private Data.DString String;
        private Data.DTheSizeof TheSizeof;
        private Data.DUsingArrays UsingArrays;
        private Data.DVariableNaming VariableNaming;


        public DData()
        {
            InitializeComponent();
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
                            #region Save
                            if (s >= 28)
                            {
                                Form1.check_21 = false; Form1.check_22 = false; Form1.check_23 = false; Form1.check_24 = false; Form1.check_25 = false; Form1.check_26 = false; Form1.check_27 = false; Form1.check_28 = false;
                                Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false; Form1.check_17 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false; Form1.check_18 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false; Form1.check_19 = false; Form1.check_20 = false;
                                if (s >= 29)
                                {
                                    Form1.check_29 = false;
                                    if (s >= 30)
                                    {
                                        Form1.check_30 = false;
                                        if (s >= 31)
                                        {
                                            Form1.check_31 = false;
                                            if (s >= 32)
                                            {
                                                button1.BackColor = Color.GreenYellow;
                                                button1.Enabled = true;
                                                button2.Enabled = true;
                                                Form1.check_32 = false;
                                                if (s >= 33)
                                                {
                                                    Form1.check_33 = false;
                                                    if (s >= 34)
                                                    {
                                                        Form1.check_34 = false;
                                                        if (s >= 35)
                                                        {
                                                            button2.BackColor = Color.GreenYellow;
                                                            //button2.Enabled = false;
                                                            button3.Enabled = true;
                                                            Form1.check_35 = false;
                                                            if (s >= 36)
                                                            {
                                                                Form1.check_36 = false;
                                                                if (s >= 37)
                                                                {
                                                                    Form1.check_37 = false;
                                                                    if (s >= 38)
                                                                    {
                                                                        button3.BackColor = Color.GreenYellow;
                                                                        button4.Enabled = true;
                                                                        Form1.check_38 = false;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }


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
                    lb_3.Text = "Your Score: " + s;
                    lb_3.ForeColor = Color.Red;
                    lb_3.BackColor = Color.Transparent;

                    DataProvider.cn.Close();
                    DataProvider.cn.Dispose();
                }
                break;

                //Form1.check_1 = false;
            }

        }
        public int s;
        public string _uname = "";
        private void DData_Load(object sender, EventArgs e)
        {
            //foreach (KeyValuePair<string, User> entry in Form1.user)
            //{
            //    DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            //    DataProvider.cn.Open();
            //    button2.Enabled = false;
            //    button3.Enabled = false;
            //    button4.Enabled = false;
            //    button5.Enabled = false;
            //    button6.Enabled = false;
            //    button7.Enabled = false;
            //    button8.Enabled = false;
            //    button9.Enabled = false;

            //    if (!Form1.user.ContainsKey(Form1.username)) { return; }
            //    _uname = entry.Key;
            //    try
            //    {
            //        string sql = @"select _yourscore from _User where _username = '" + _uname + "'";
            //        SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            if (reader.Read())
            //            {
            //                s = reader.GetInt32(0);
            //                #region Save
            //                if (s>=28)
            //                   {
            //                      Form1.check_21 = false; Form1.check_22 = false; Form1.check_23 = false; Form1.check_24 = false; Form1.check_25 = false; Form1.check_26 = false; Form1.check_27 = false; Form1.check_28 = false;
            //                      Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false; Form1.check_17 = false;
            //                      Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
            //                      Form1.check_7 = false; Form1.check_6 = false; Form1.check_18 = false;
            //                      Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false; Form1.check_19 = false; Form1.check_20 = false;
            //                    if(s>=29)
            //                    {
            //                        Form1.check_29 = false;
            //                        if (s >= 30)
            //                        {
            //                            Form1.check_30 = false;
            //                            if (s >= 31)
            //                            {
            //                                Form1.check_31 = false;
            //                                if (s >= 32)
            //                                {
            //                                    button1.BackColor = Color.GreenYellow;
            //                                    button1.Enabled = true;
            //                                    button2.Enabled = true;
            //                                    Form1.check_32 = false;
            //                                    if (s >= 33)
            //                                    {
            //                                        Form1.check_33 = false;
            //                                        if (s >= 34)
            //                                        {
            //                                            Form1.check_34 = false;
            //                                            if (s >= 35)
            //                                            {
            //                                                button2.BackColor = Color.GreenYellow;
            //                                                //button2.Enabled = false;
            //                                                button3.Enabled = true;
            //                                                Form1.check_35 = false;
            //                                                if (s >= 36)
            //                                                {
            //                                                    Form1.check_36 = false;
            //                                                    if (s >= 37)
            //                                                    {
            //                                                        Form1.check_37 = false;
            //                                                        if (s >= 38)
            //                                                        {
            //                                                            button3.BackColor = Color.GreenYellow;
            //                                                            button4.Enabled = true;
            //                                                            Form1.check_38 = false;
            //                                                        }
            //                                                    }
            //                                                }
            //                                            }
            //                                        }
            //                                    }
            //                                }
            //                            }
            //                        }
            //                    }


            //                }
            //                #endregion
            //            }
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("ERROR");
            //    }
            //    finally
            //    {
            //        lb_3.Text = "Your Score: " + s;
            //        lb_3.ForeColor = Color.Red;
            //        lb_3.BackColor = Color.Transparent;

            //        DataProvider.cn.Close();
            //        DataProvider.cn.Dispose();
            //    }
            //    break;

            //    //Form1.check_1 = false;
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
                            #region Save
                            if (s >= 28)
                            {
                                Form1.check_21 = false; Form1.check_22 = false; Form1.check_23 = false; Form1.check_24 = false; Form1.check_25 = false; Form1.check_26 = false; Form1.check_27 = false; Form1.check_28 = false;
                                Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false; Form1.check_17 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false; Form1.check_18 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false; Form1.check_19 = false; Form1.check_20 = false;
                                if (s >= 29)
                                {
                                    Form1.check_28 = false;
                                    Form1.check_29 = false;
                                    if (s >= 30)
                                    {
                                        Form1.check_30 = false;
                                        if (s >= 31)
                                        {
                                            Form1.check_31 = false;
                                            if (s >= 32)
                                            {
                                                button1.BackColor = Color.GreenYellow;
                                                button1.Enabled = true;
                                                button2.Enabled = true;
                                                Form1.check_32 = false;
                                                if (s >= 33)
                                                {
                                                    Form1.check_33 = false;
                                                    if (s >= 34)
                                                    {
                                                        Form1.check_34 = false;
                                                        if (s >= 35)
                                                        {
                                                            button2.BackColor = Color.GreenYellow;
                                                            //button2.Enabled = false;
                                                            button3.Enabled = true;
                                                            Form1.check_35 = false;
                                                            if (s >= 36)
                                                            {
                                                                Form1.check_36 = false;
                                                                if (s >= 37)
                                                                {
                                                                    Form1.check_37 = false;
                                                                    if (s >= 38)
                                                                    {
                                                                        button3.BackColor = Color.GreenYellow;
                                                                        button4.Enabled = true;
                                                                        Form1.check_38 = false;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }


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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Introduction == null || Introduction.IsDisposed)
            {
                Introduction = new Data.DIntroduction();
                Introduction.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IntFloat == null || IntFloat.IsDisposed)
            {
                IntFloat = new Data.DIntFloat();
                IntFloat.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String == null || String.IsDisposed)
            {
                String = new Data.DString();
                String.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (VariableNaming == null || VariableNaming.IsDisposed)
            {
                VariableNaming = new Data.DVariableNaming();
                VariableNaming.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Arrays == null || Arrays.IsDisposed)
            {
                Arrays = new Data.DArrays();
                Arrays.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (UsingArrays == null || UsingArrays.IsDisposed)
            {
                UsingArrays = new Data.DUsingArrays();
                UsingArrays.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ArraysinCalculations == null || ArraysinCalculations.IsDisposed)
            {
                ArraysinCalculations = new Data.DArraysinCalculations();
                ArraysinCalculations.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Multi == null || Multi.IsDisposed)
            {
                Multi = new Data.DMulti();
                Multi.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (IntroductiontoPointers == null || IntroductiontoPointers.IsDisposed)
            {
                IntroductiontoPointers = new Data.DIntroductiontoPointers();
                IntroductiontoPointers.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MoreonPointers == null || MoreonPointers.IsDisposed)
            {
                MoreonPointers = new Data.DMoreonPointers();
                MoreonPointers.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (DynamicMemory == null || DynamicMemory.IsDisposed)
            {
                DynamicMemory = new Data.DDynamicMemory();
                DynamicMemory.Show();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (TheSizeof == null || TheSizeof.IsDisposed)
            {
                TheSizeof = new Data.DTheSizeof();
                TheSizeof.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Module3Quiz == null || Module3Quiz.IsDisposed)
            {
                Module3Quiz = new Data.DModule3Quiz();
                Module3Quiz.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
