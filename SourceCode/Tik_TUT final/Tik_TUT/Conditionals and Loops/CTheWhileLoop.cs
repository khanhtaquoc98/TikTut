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

namespace Tik_TUT.Conditionals_and_Loops
{
    public partial class CTheWhileLoop : Form
    {
        public CTheWhileLoop()
        {
            InitializeComponent(); btSub_4.Visible = false;
            btSub_6.Visible = false;

            //Important
            #region Save
            if (!Form1.check_25)
            {
                check_2.Checked = true;
                check_2.ForeColor = Color.GreenYellow;
                check_2.Enabled = false;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 25;
                if (!Form1.check_26)
                {
                    txtText1_4.Text = "while";
                    txtText2_4.Text = "x";

                    txtText1_4.ForeColor = Color.GreenYellow;
                    txtText2_4.ForeColor = Color.GreenYellow;

                    txtText1_4.Enabled = false;
                    txtText2_4.Enabled = false;

                    btSub_4.Visible = false;
                    btSub_6.Visible = true;
                    Form1.bScore = 26;
                    if (!Form1.check_27)
                    {
                        txtText1_6.Text = "while";
                        txtText2_6.Text = "for";

                        txtText1_6.ForeColor = Color.GreenYellow;
                        txtText2_6.ForeColor = Color.GreenYellow;

                        txtText1_6.Enabled = false;
                        txtText2_6.Enabled = false;

                        btSub_6.Visible = false;
                        //btSub_6.Visible = true;
                        Form1.bScore = 27;
                    }
                }
            }
            #endregion
        }
        public A_Manager.ConditionalsandLoops c = new A_Manager.ConditionalsandLoops();
        public string _uname = "";

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            c.Show();
        }
        //Event Click
        private void btSub_2_Click(object sender, EventArgs e)
        {
            if (check_2.Checked == true)
            {
                foreach (KeyValuePair<string, User> entry in Form1.user)
                {
                    if (!Form1.user.ContainsKey(Form1.username)) { return; }
                    {
                        _uname = entry.Key;

                        Form1.Correct = false;
                        //u.U_Score();
                        DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                        Form1.bScore++;
                        string sqlupdate = @"Update _User set _yourscore = " + Form1.bScore + " where _username = '" + _uname + " '";
                        SqlCommand cmdUpdate = new SqlCommand(sqlupdate, DataProvider.cn);
                        try
                        {
                            // Mở kết nối
                            DataProvider.cn.Open();
                            cmdUpdate.ExecuteNonQuery();

                        }
                        catch
                        {
                            MessageBox.Show("Lỗi thực thi!");
                        }
                        finally
                        {
                            // đóng kết nối


                            DialogResult reset = MessageBox.Show("Correct", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {



                            }

                            check_2.Checked = true;
                            check_2.ForeColor = Color.GreenYellow;
                            check_2.Enabled = false;
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 25;
                            DataProvider.cn.Close();
                        }
                    }

                    break;
                }
            }
            else
            {
                MessageBox.Show("ERROR", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btSub_4_Click(object sender, EventArgs e)
        {
            if (txtText1_4.Text.Trim().Equals("while") && txtText2_4.Text.Trim().Equals("x"))
            {
                foreach (KeyValuePair<string, User> entry in Form1.user)
                {
                    if (!Form1.user.ContainsKey(Form1.username)) { return; }
                    {
                        _uname = entry.Key;

                        Form1.Correct = false;
                        //u.U_Score();
                        DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                        Form1.bScore++;
                        string sqlupdate = @"Update _User set _yourscore = " + Form1.bScore + " where _username = '" + _uname + " '";
                        SqlCommand cmdUpdate = new SqlCommand(sqlupdate, DataProvider.cn);
                        try
                        {
                            // Mở kết nối
                            DataProvider.cn.Open();
                            cmdUpdate.ExecuteNonQuery();

                        }
                        catch
                        {
                            MessageBox.Show("Lỗi thực thi!");
                        }
                        finally
                        {
                            // đóng kết nối


                            DialogResult reset = MessageBox.Show("Correct", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {



                            }

                            txtText1_4.Text = "while";
                            txtText2_4.Text = "x";

                            txtText1_4.ForeColor = Color.GreenYellow;
                            txtText2_4.ForeColor = Color.GreenYellow;

                            txtText1_4.Enabled = false;
                            txtText2_4.Enabled = false;

                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            Form1.bScore = 26;
                            DataProvider.cn.Close();
                        }
                    }

                    break;
                }
            }
            else
            {
                MessageBox.Show("ERROR", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btSub_6_Click(object sender, EventArgs e)
        {
            if (txtText1_6.Text.Trim().Equals("while") && txtText2_6.Text.Trim().Equals("total"))
            {
                foreach (KeyValuePair<string, User> entry in Form1.user)
                {
                    if (!Form1.user.ContainsKey(Form1.username)) { return; }
                    {
                        _uname = entry.Key;

                        Form1.Correct = false;
                        //u.U_Score();
                        DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                        Form1.bScore++;
                        string sqlupdate = @"Update _User set _yourscore = " + Form1.bScore + " where _username = '" + _uname + " '";
                        SqlCommand cmdUpdate = new SqlCommand(sqlupdate, DataProvider.cn);
                        try
                        {
                            // Mở kết nối
                            DataProvider.cn.Open();
                            cmdUpdate.ExecuteNonQuery();

                        }
                        catch
                        {
                            MessageBox.Show("Lỗi thực thi!");
                        }
                        finally
                        {
                            // đóng kết nối


                            DialogResult reset = MessageBox.Show("Congratulations!! You can do Data Type in Intermediate", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {
                                this.Close();
                                c.Show();


                            }

                            txtText1_6.Text = "while";
                            txtText2_6.Text = "for";

                            txtText1_6.ForeColor = Color.GreenYellow;
                            txtText2_6.ForeColor = Color.GreenYellow;

                            txtText1_6.Enabled = false;
                            txtText2_6.Enabled = false;

                            btSub_6.Visible = false;
                            //btSub_6.Visible = true;
                            Form1.bScore = 27;
                            DataProvider.cn.Close();
                        }
                    }

                    break;
                }
            }
            else
            {
                MessageBox.Show("ERROR", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
