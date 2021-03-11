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
    public partial class MoreOnClasses : Form
    {
        private MOC.MOCSeperateFile frmMOCSeperateFiles;
        private MOC.MOCDestructure frmMOCDestructors;
        private MOC.MOCSelectionOperator frmMOCSelectionOperator;
        private MOC.MOCConstObjects frmMOCConstObjects;
        private MOC.MOCMemberInit frmMOCMemberInit;
        private MOC.MOCComposition1 frmMOCComposition1;
        private MOC.MOCComposition2 frmMOCComposition2;
        private MOC.MOCTheFriend frmMOCTheFriend;
        private MOC.MOCTheThis frmMOCTheThis;
        private MOC.MOCOverloading frmMOCOverloading;
       // private MOC.MOCQuiz6 frmMOCQuiz6;
        public MoreOnClasses()
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
                            if (s >= 62)
                            {
                                Form1.check_62 = false;
                            }
                            if (s >= 63)
                            {
                                Form1.check_63 = false;
                            }
                            if (s >= 64)
                            {
                                button1.BackColor = Color.GreenYellow;

                                button2.Enabled = true;
                                Form1.check_64 = false;
                            }
                            if (s >= 65)
                            {
                                Form1.check_65 = false;
                            }
                            if (s >= 66)
                            {
                                Form1.check_66 = false;
                            }
                            if (s >= 67)
                            {
                                button2.BackColor = Color.GreenYellow;

                                button3.Enabled = true;
                                Form1.check_67 = false;
                            }
                            if (s >= 68)
                            {
                                
                                Form1.check_68 = false;
                                Form1.bScore = 68;
                            }
                            if (s == 72)
                            {
                               // Form1.check_71 = false;
                                Form1.check_72 = false;
                            }
                            if (s == 73)
                            {
                                Form1.check_73 = false;
                            }
                            if (s == 74)
                            {
                                Form1.check_74 = false;
                            }
                            if (s == 75)
                            {
                                Form1.check_75 = false;
                            }
                            if (s == 76)
                            {
                                button3.BackColor = Color.GreenYellow;
                                button4.Enabled = true;
                                Form1.check_75 = false;
                            }
                            #endregion
                        }
                        lb_2.Text = "Score: " + s;
                        lb_2.ForeColor = Color.Red;
                        lb_2.BackColor = Color.Transparent;

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
        public string _uname1 = "";
        public int s;
        private void button1_Click(object sender, EventArgs e)
        {
            if (frmMOCSeperateFiles == null || frmMOCSeperateFiles.IsDisposed)
            {
                frmMOCSeperateFiles = new MOC.MOCSeperateFile();
                this.Close();
                frmMOCSeperateFiles.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frmMOCDestructors == null || frmMOCDestructors.IsDisposed)
            {
                frmMOCDestructors = new MOC.MOCDestructure(); this.Close();
                frmMOCDestructors.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (frmMOCSelectionOperator == null || frmMOCSelectionOperator.IsDisposed)
            {
                frmMOCSelectionOperator = new MOC.MOCSelectionOperator();
                this.Close();
                frmMOCSelectionOperator.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (frmMOCConstObjects == null || frmMOCConstObjects.IsDisposed)
            {
                frmMOCConstObjects = new MOC.MOCConstObjects(); this.Close();
                frmMOCConstObjects.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (frmMOCMemberInit == null || frmMOCMemberInit.IsDisposed)
            {
                frmMOCMemberInit = new MOC.MOCMemberInit();
                frmMOCMemberInit.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (frmMOCComposition1 == null || frmMOCComposition1.IsDisposed)
            {
                frmMOCComposition1 = new MOC.MOCComposition1();
                frmMOCComposition1.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (frmMOCComposition2 == null || frmMOCComposition2.IsDisposed)
            {
                frmMOCComposition2 = new MOC.MOCComposition2();
                frmMOCComposition2.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (frmMOCTheFriend == null || frmMOCTheFriend.IsDisposed)
            {
                frmMOCTheFriend = new MOC.MOCTheFriend();
                frmMOCTheFriend.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (frmMOCTheThis == null || frmMOCTheThis.IsDisposed)
            {
                frmMOCTheThis = new MOC.MOCTheThis();
                frmMOCTheThis.Show();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (frmMOCOverloading == null || frmMOCOverloading.IsDisposed)
            {
                frmMOCOverloading = new MOC.MOCOverloading();
                frmMOCOverloading.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //if (frmMOCQuiz6 == null || frmMOCQuiz6.IsDisposed)
            //{
            //    frmMOCQuiz6 = new MOC.MOCQuiz6();
            //    frmMOCQuiz6.Show();
            //}
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoreOnClasses_Load(object sender, EventArgs e)
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
                            if (s >= 62)
                            {
                                Form1.check_62 = false;
                            }
                            if (s >= 63)
                            {
                                Form1.check_63 = false;
                            }
                            if (s >= 64)
                            {
                                button1.BackColor = Color.GreenYellow;

                                button2.Enabled = true;
                                Form1.check_64 = false;
                            }
                            if (s >= 65)
                            {
                                Form1.check_65 = false;
                            }
                            if (s >= 66)
                            {
                                Form1.check_66 = false;
                            }
                            if (s >= 67)
                            {
                                button2.BackColor = Color.GreenYellow;

                                button3.Enabled = true;
                                Form1.check_67 = false;
                            }
                            if (s >= 68)
                            {
                                Form1.check_68 = false;
                                Form1.bScore = 68;
                            }
                            if (s >= 72)
                            {
                                Form1.check_71 = false;
                                Form1.check_72 = false;
                            }
                            if (s >= 73)
                            {
                                Form1.check_73 = false;
                            }
                            if (s >= 74)
                            {
                                Form1.check_74 = false;
                            }
                            if (s >= 75)
                            {
                                Form1.check_75 = false;
                            }
                            if (s >= 76)
                            {
                                button3.BackColor = Color.GreenYellow;
                                button4.Enabled = true;
                                Form1.check_75 = false;
                            }
                            #endregion
                        }
                        lb_2.Text = " Score: " + s;
                        lb_2.ForeColor = Color.Red;
                        lb_2.BackColor = Color.Transparent;
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
    }
}

    