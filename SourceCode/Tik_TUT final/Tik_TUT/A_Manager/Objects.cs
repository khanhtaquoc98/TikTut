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
    public partial class Objects : Form
    {
        private Objects_Class.OAbstraction Abstraction;
        private Objects_Class.OConstructors Constructors;
        private Objects_Class.OEncapsulation Encapsulation;
        private Objects_Class.OExampleofaClass ExampleofaClass;
        private Objects_Class.OExampleofEncapsulation ExampleofEncapsulation;
        private Objects_Class.OModule_5_Quiz Module_5_Quiz;
        private Objects_Class.OWhatisaClass WhatisaClass;
        private Objects_Class.OWhat_isanObject What_isanObject;
        public int s;
        public string _uname = "";
        public Objects()
        {
            InitializeComponent();
           
        }
        //Event Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            if (What_isanObject == null || What_isanObject.IsDisposed)
            {
                What_isanObject = new Objects_Class.OWhat_isanObject();
                What_isanObject.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WhatisaClass == null || WhatisaClass.IsDisposed)
            {
                WhatisaClass = new Objects_Class.OWhatisaClass();
                WhatisaClass.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ExampleofaClass == null || ExampleofaClass.IsDisposed)
            {
                ExampleofaClass = new Objects_Class.OExampleofaClass();
                ExampleofaClass.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Abstraction == null || Abstraction.IsDisposed)
            {
                Abstraction = new Objects_Class.OAbstraction();
                Abstraction.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Encapsulation == null || Encapsulation.IsDisposed)
            {
                Encapsulation = new Objects_Class.OEncapsulation();
                Encapsulation.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ExampleofEncapsulation == null || ExampleofEncapsulation.IsDisposed)
            {
                ExampleofEncapsulation = new Objects_Class.OExampleofEncapsulation();
                ExampleofEncapsulation.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Constructors == null || Constructors.IsDisposed)
            {
                Constructors = new Objects_Class.OConstructors();
                Constructors.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Module_5_Quiz == null || Module_5_Quiz.IsDisposed)
            {
                Module_5_Quiz = new Objects_Class.OModule_5_Quiz();
                Module_5_Quiz.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Load Form Objects
        private void Objects_Load(object sender, EventArgs e)
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
                            if (s >= 52)
                            {
                                Form1.check_51 = false;
                                Form1.check_52 = false;
                                if (s >= 53)
                                {
                                    Form1.check_53 = false;
                                    if (s >= 54)
                                    {
                                        Form1.check_54 = false;
                                        if (s >= 55)
                                        {
                                            button1.BackColor = Color.GreenYellow;
                                            button1.Enabled = true;
                                            button2.Enabled = true;
                                            Form1.check_55 = false;
                                            if (s >= 56)
                                            {

                                                Form1.check_56 = false;
                                                if (s >= 57)
                                                {
                                                    Form1.check_57 = false;
                                                    if (s >= 58)
                                                    {
                                                        button2.BackColor = Color.GreenYellow;
                                                        //button2.Enabled = false;
                                                        button3.Enabled = true;
                                                        Form1.check_58 = false;
                                                        if (s >= 59)
                                                        {

                                                            Form1.check_59 = false;
                                                            if (s >= 60)
                                                            {
                                                                Form1.check_60 = false;
                                                                if (s >= 61)
                                                                {
                                                                    button3.BackColor = Color.GreenYellow;
                                                                    //button2.Enabled = false;
                                                                    button4.Enabled = true;
                                                                    Form1.check_61 = false;

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

        
    }
}
