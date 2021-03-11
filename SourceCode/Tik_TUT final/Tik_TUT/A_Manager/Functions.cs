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
    public partial class Functions : Form
    {
        private Funtions.FDefaultArguments DefaultArguments;
        private Funtions.FFunctionParameters FunctionParameters;
        private Funtions.FFunctionswithMultipleParameters FunctionswithMultipleParameters;
        private Funtions.FFunction_Overloading Function_Overloading;
        private Funtions.FIntroductiontoFunctions IntroductiontoFunctions;
        private Funtions.FModule4Quiz Module4Quiz;
        private Funtions.FPassbyReference PassbyReference;
        private Funtions.FPassingArrays PassingArrays;
        private Funtions.FRecursion Recursion;
        private Funtions.FTheRandFunction TheRandFunction;
        public int s;
        public string _uname = "";
        public Functions()
        {
            InitializeComponent();
           
        }
        //Event Click
        private void button1_Click(object sender, EventArgs e)
        {
            if (IntroductiontoFunctions == null || IntroductiontoFunctions.IsDisposed)
            {
                IntroductiontoFunctions = new Funtions.FIntroductiontoFunctions();
                IntroductiontoFunctions.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FunctionParameters == null || FunctionParameters.IsDisposed)
            {
                FunctionParameters = new Funtions.FFunctionParameters();
                FunctionParameters.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FunctionswithMultipleParameters == null || FunctionswithMultipleParameters.IsDisposed)
            {
                FunctionswithMultipleParameters = new Funtions.FFunctionswithMultipleParameters();
                FunctionswithMultipleParameters.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TheRandFunction == null || TheRandFunction.IsDisposed)
            {
                TheRandFunction = new Funtions.FTheRandFunction();
                TheRandFunction.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DefaultArguments == null || DefaultArguments.IsDisposed)
            {
                DefaultArguments = new Funtions.FDefaultArguments();
                DefaultArguments.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Function_Overloading == null || Function_Overloading.IsDisposed)
            {
                Function_Overloading = new Funtions.FFunction_Overloading();
                Function_Overloading.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Recursion == null || Recursion.IsDisposed)
            {
                Recursion = new Funtions.FRecursion();
                Recursion.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (PassingArrays == null || PassingArrays.IsDisposed)
            {
                PassingArrays = new Funtions.FPassingArrays();
                PassingArrays.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (PassbyReference == null || PassbyReference.IsDisposed)
            {
                PassbyReference = new Funtions.FPassbyReference();
                PassbyReference.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Module4Quiz == null || Module4Quiz.IsDisposed)
            {
                Module4Quiz = new Funtions.FModule4Quiz();
                Module4Quiz.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Load Form Functions
        private void Functions_Load(object sender, EventArgs e)
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
                            #region Save
                            if (s >= 39)
                            {
                                Form1.check_39 = false; Form1.check_38 = false; Form1.check_37 = false; Form1.check_36 = false; Form1.check_35 = false; Form1.check_33 = false;
                                Form1.check_29 = false; Form1.check_30 = false; Form1.check_31 = false; Form1.check_32 = false; Form1.check_34 = false;
                                Form1.check_21 = false; Form1.check_22 = false; Form1.check_23 = false; Form1.check_24 = false; Form1.check_25 = false; Form1.check_26 = false; Form1.check_27 = false; Form1.check_28 = false;
                                Form1.check_14 = false; Form1.check_15 = false; Form1.check_16 = false; Form1.check_17 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false; Form1.check_18 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false; Form1.check_19 = false; Form1.check_20 = false;
                                if (s >= 40)
                                {
                                    Form1.check_40 = false;
                                    if (s >= 41)
                                    {
                                        Form1.check_41 = false;
                                        if (s >= 42)
                                        {
                                            Form1.check_42 = false;
                                            if (s >= 43)
                                            {
                                                Form1.check_43 = false;
                                                if (s >= 44)
                                                {
                                                    button1.BackColor = Color.GreenYellow;
                                                    button1.Enabled = true;
                                                    button2.Enabled = true;
                                                    Form1.check_44 = false;
                                                    if (s >= 45)
                                                    {
                                                        Form1.check_45 = false;
                                                        if (s >= 46)
                                                        {
                                                            Form1.check_46 = false;
                                                            if (s >= 47)
                                                            {
                                                                button2.BackColor = Color.GreenYellow;
                                                                //button2.Enabled = false;
                                                                button3.Enabled = true;
                                                                Form1.check_47 = false;
                                                                if (s >= 48)
                                                                {
                                                                    Form1.check_48 = false;
                                                                    if (s >= 49)
                                                                    {
                                                                        Form1.check_49 = false;
                                                                        if (s >= 50)
                                                                        {
                                                                            Form1.check_50 = false;
                                                                            if (s >= 51)
                                                                            {
                                                                                button3.BackColor = Color.GreenYellow;

                                                                                button4.Enabled = true;
                                                                                Form1.check_51 = false;
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
    }
}
