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
    public partial class BasicConcepts : Form
    {     
        private Basic_Concepts.BCWhatisC WhatisC;
        private Basic_Concepts.BCAssignment Assignment;
        private Basic_Concepts.BCBasicArithmetic BasicArithmetic;
        private Basic_Concepts.BCComments Comments;
        private Basic_Concepts.BCGettingTheTools GettingTheTools;
        private Basic_Concepts.BCModule1 Module1;
        private Basic_Concepts.BCHelloWorld HelloWorld;
        private Basic_Concepts.BCMoreonVariables MoreonVariables;
        private Basic_Concepts.BCPrintingaText PrintingaText;
        private Basic_Concepts.BCVariables Variables;
        private Basic_Concepts.BCWorkingwVariables WorkingwVariables;
        public A_Manager.MoreOnClasses m = new A_Manager.MoreOnClasses();
       
        public bool _c = true;
       
        //public static int bScore = 1;
        public BasicConcepts()
        { 
            InitializeComponent();
            //if(!Form1.home)
            // {
            //     button1.BackColor = Color.GreenYellow;
            //     button1.Enabled = true;    
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
                button10.Enabled = false;
                button11.Enabled = false;
                if (!Form1.user.ContainsKey(Form1.username)) { return; }
                _uname1 = entry.Key;
                try
                {
                    string sql = @"select _yourscore from _User where _username = '" + _uname1 + "'";
                    SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            s = reader.GetInt32(0);
                            // Comments.Compare2();
                            //SelectCompare();
                            #region Check
                            if (s >= 1)
                            {
                                button1.BackColor = Color.GreenYellow;
                                button1.Enabled = true;
                                button2.Enabled = true;
                                Form1.check = false;
                                //Form1.check_1 = false;
                            }
                            if (s >= 2)
                            {
                                Form1.check_2 = false;
                                // Form1.check = false;

                            }
                            if (s >= 3)
                            {
                                Form1.check_3 = false;
                                //  Form1.check = false;
                            }
                            if (s >= 4)
                            { Form1.check_4 = false; Form1.check_3 = false; }
                            if (s >= 5)
                            { Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false; }
                            if (s >= 7)
                            {
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 9)
                            {
                                Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 10)
                            {
                                Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 11)
                            {
                                Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; ; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 12)
                            {
                                Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 6)
                            {
                                button2.BackColor = Color.GreenYellow;
                                //button2.Enabled = false;
                                button3.Enabled = true;
                                Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 8)
                            {
                                button3.BackColor = Color.GreenYellow;
                                
                                button4.Enabled = true;
                                
                                Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 13)
                            {
                                button4.BackColor = Color.GreenYellow;
                                //button4.Enabled = false;
                                button5.Enabled = true;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                                //Important
                                //Form1.Test = false;
                            }
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
                            if (s >= 16) //&& Form1.Important == true)
                            {

                                //if (Form1.Test)
                                //{
                                button4.BackColor = Color.GreenYellow;
                                //button5.Enabled = false;
                                button5.Enabled = true;
                                Form1.check_16 = false; Form1.check_14 = false; Form1.check_15 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;

                            }
                            if (s >= 69)
                            {
                                Form1.check_67 = false;
                                Form1.check_68 = false;
                                Form1.check_69 = false;
                                Form1.bScore = 69;
                            }
                            if (s >= 70)
                            {
                                Form1.check_69 = false;
                                Form1.check_70 = false;
                                Form1.bScore = 70;
                            }
                            if (s >= 71)
                            {
                                Form1.check_70 = false;
                                button5.BackColor = Color.GreenYellow;
                                button6.Enabled = true;
                                Form1.bScore = 71;
                                Form1.check_71 = false;
                            }
                            lb_2.Text = "Your Score: " + s;
                            lb_2.ForeColor = Color.Red;
                            lb_2.BackColor = Color.Transparent;

                        }
                        #endregion
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
                finally
                {

                    DataProvider.cn.Close();
                    DataProvider.cn.Dispose();
                }
                break;
            }
        }
        //Button Click
        private void button1_Click(object sender, EventArgs e)
        {            
            if (WhatisC == null || WhatisC.IsDisposed)
            {
                WhatisC = new Basic_Concepts.BCWhatisC();
                this.Close();
                WhatisC.Show();                
            }          

        }

        private void whatisc()
        {
            if (!Form1.Correct)
            {              
                return;
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (HelloWorld == null || HelloWorld.IsDisposed)
            {
                HelloWorld = new Basic_Concepts.BCHelloWorld();
                this.Close();
                HelloWorld.Show();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GettingTheTools == null || GettingTheTools.IsDisposed)
            {
                GettingTheTools = new Basic_Concepts.BCGettingTheTools();
                this.Close();
                GettingTheTools.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PrintingaText == null || PrintingaText.IsDisposed)
            {
                PrintingaText = new Basic_Concepts.BCPrintingaText();
                this.Close();
                PrintingaText.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Comments == null || Comments.IsDisposed)
            {
                Comments = new Basic_Concepts.BCComments();
                this.Close();
                Comments.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Variables == null || Variables.IsDisposed)
            {
                Variables = new Basic_Concepts.BCVariables();
                this.Close();
                Variables.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {    
            if (WorkingwVariables == null || WorkingwVariables.IsDisposed)
            {
                WorkingwVariables = new Basic_Concepts.BCWorkingwVariables();
                this.Close();
                WorkingwVariables.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
             if (MoreonVariables == null || MoreonVariables.IsDisposed)
            {
                MoreonVariables = new Basic_Concepts.BCMoreonVariables();
                this.Close();
                MoreonVariables.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (BasicArithmetic == null || BasicArithmetic.IsDisposed)
            {
                BasicArithmetic = new Basic_Concepts.BCBasicArithmetic();
                this.Close();
                BasicArithmetic.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Assignment == null || Assignment.IsDisposed)
            {
                Assignment = new Basic_Concepts.BCAssignment();
                this.Close();
                Assignment.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Module1 == null || Module1.IsDisposed)
            {
                Module1 = new Basic_Concepts.BCModule1();
                Module1.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        public string _uname1 = "";
        public int s;

        //Load Form Basic
        private void BasicConcepts_Load(object sender, EventArgs e)
        {
            //   whatisc();
            //// So Sanh Gia Tri Diem Va Luu Lai
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
                button10.Enabled = false;
                button11.Enabled = false;
                if (!Form1.user.ContainsKey(Form1.username)) { return; }
                _uname1 = entry.Key;
                try
                {
                    string sql = @"select _yourscore from _User where _username = '" + _uname1 + "'";
                    SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            s = reader.GetInt32(0);
                            // Comments.Compare2();
                            //SelectCompare();
                            #region Check
                            if (s >= 1)
                            {
                                button1.BackColor = Color.GreenYellow;
                                button1.Enabled = true;
                                button2.Enabled = true;
                                Form1.check = false;
                                //Form1.check_1 = false;
                            }
                            if (s >= 2)
                            {
                                Form1.check_2 = false;
                                // Form1.check = false;

                            }
                            if (s >= 3)
                            {
                                Form1.check_3 = false;
                                //  Form1.check = false;
                            }
                            if (s >= 4)
                            { Form1.check_4 = false; Form1.check_3 = false; }
                            if (s >= 5)
                            { Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false; }
                            if (s >= 7)
                            {
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 9)
                            {
                                Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 10)
                            {
                                Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 11)
                            {
                                Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; ; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 12)
                            {
                                Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 6)
                            {
                                button2.BackColor = Color.GreenYellow;
                                //button2.Enabled = false;
                                button3.Enabled = true;
                                Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 8)
                            {
                                button3.BackColor = Color.GreenYellow;

                                button4.Enabled = true;
                                Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                            }
                            if (s >= 13)
                            {
                                button4.BackColor = Color.GreenYellow;
                                //button4.Enabled = false;
                                button5.Enabled = true;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;
                                //Important
                                //Form1.Test = false;
                            }
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
                            if (s >= 16) //&& Form1.Important == true)
                            {

                                //if (Form1.Test)
                                //{
                                button4.BackColor = Color.GreenYellow;
                                //button5.Enabled = false;
                                button5.Enabled = true;
                                Form1.check_16 = false; Form1.check_14 = false; Form1.check_15 = false;
                                Form1.check_13 = false; Form1.check_12 = false; Form1.check_11 = false; Form1.check_10 = false; Form1.check_9 = false; Form1.check_8 = false;
                                Form1.check_7 = false; Form1.check_6 = false;
                                Form1.check_5 = false; Form1.check_4 = false; Form1.check_3 = false;

                            }
                            if (s >= 69)
                            {
                                Form1.check_67 = false;
                                Form1.check_68 = false;
                                Form1.check_69 = false;
                                Form1.bScore = 69;
                            }
                            if (s >= 70)
                            {
                                Form1.check_69 = false;
                                Form1.check_70 = false;
                                Form1.bScore = 70;
                            }
                            if (s >= 71)
                            {
                                Form1.check_70 = false;
                                button5.BackColor = Color.GreenYellow;
                                button6.Enabled = true;
                                Form1.bScore = 71;
                                Form1.check_71 = false;
                            }
                            lb_2.Text = "Your Score: " + s;
                            lb_2.ForeColor = Color.Red;
                            lb_2.BackColor = Color.Transparent;

                        }
                        #endregion

                    }
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
                finally
                {
                    DataProvider.cn.Close();
                    DataProvider.cn.Dispose();
                }
                break;
            }
        }
        public int k;
        public void SelectCompare()
        {
            foreach (KeyValuePair<string, User> entry in Form1.user)
            {
                DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                DataProvider.cn.Open();
                if (!Form1.user.ContainsKey(Form1.username)) { return; }
                _uname1 = entry.Key;
                try
                {
                    string sql = @"select _compare from _User where _username = '" + _uname1 + "'";
                    SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                             k = reader.GetInt32(0);
                            Form1._c1 = k;
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    DataProvider.cn.Close();
                    DataProvider.cn.Dispose();
                }
                break;
            }
        }
    }
}
