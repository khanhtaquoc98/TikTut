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

namespace Tik_TUT.Funtions
{
    public partial class FIntroductiontoFunctions : Form
    {
        public FIntroductiontoFunctions()
        {
            InitializeComponent();
            btSub_4.Visible = false;
            btSub_6.Visible = false;
            btSub_8.Visible = false;
            btSub_10.Visible = false;
            btSub_12.Visible = false;
            #region Save
            if (!Form1.check_39)
            {
                check_2.Checked = true;
                check_2.ForeColor = Color.GreenYellow;
                check_2.Enabled = false;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 39;
            }
            if (!Form1.check_40)
            {
                txtText_4.Text = "void";

                txtText_4.ForeColor = Color.GreenYellow;


                txtText_4.Enabled = false;

                btSub_4.Visible = false;
                btSub_6.Visible = true;
                Form1.bScore = 40;
            }
            if (!Form1.check_41)
            {
                check_6.Checked = true;
                check_6.ForeColor = Color.GreenYellow;
                check_6.Enabled = false;
                btSub_6.Visible = false;
                btSub_8.Visible = true;
                Form1.bScore = 41;
            }
            if (!Form1.check_42)
            {
                txtText1_8.Text = "void";
                txtText2_8.Text = "cout";
                txtText2_8.ForeColor = Color.GreenYellow;
                txtText1_8.ForeColor = Color.GreenYellow;
                txtText1_8.Enabled = false;
                txtText2_8.Enabled = false;
                btSub_8.Visible = false;
                btSub_10.Visible = true;
                Form1.bScore = 42;
            }
            if (!Form1.check_43)
            {
                check_10.Checked = true;
                check_10.ForeColor = Color.GreenYellow;
                check_10.Enabled = false;
                btSub_10.Visible = false;
                btSub_12.Visible = true;
                Form1.bScore = 43;
            }
 
            if (!Form1.check_44)
            {
                txtText1_12.Text = "some_func";
                txtText2_12.Text = "void";
                txtText2_12.ForeColor = Color.GreenYellow;
                txtText1_12.ForeColor = Color.GreenYellow;
                txtText1_12.Enabled = false;
                txtText2_12.Enabled = false;
                btSub_12.Visible = false;

                Form1.bScore = 44;
            }
            #endregion
        }
        public A_Manager.Functions f = new A_Manager.Functions();
        public string _uname = "";

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }
        //Event CLick
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


                            DialogResult reset = MessageBox.Show("Correct", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {



                            }

                            check_2.Checked = true;
                            check_2.ForeColor = Color.GreenYellow;
                            check_2.Enabled = false;
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 39;
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
            if (txtText_4.Text.Trim().Equals("void"))
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

                            txtText_4.Text = "void";

                            txtText_4.ForeColor = Color.GreenYellow;


                            txtText_4.Enabled = false;

                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            Form1.bScore = 40;
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
            if (check_6.Checked == true)
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

                            check_6.Checked = true;
                            check_6.ForeColor = Color.GreenYellow;
                            check_6.Enabled = false;
                            btSub_6.Visible = false;
                            btSub_8.Visible = true;
                            Form1.bScore = 41;
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

        private void btSub_8_Click(object sender, EventArgs e)
        {
            if (txtText1_8.Text.Trim().Equals("void") && txtText2_8.Text.Trim().Equals("cout"))
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

                            txtText1_8.Text = "void";
                            txtText2_8.Text = "cout";
                            txtText2_8.ForeColor = Color.GreenYellow;
                            txtText1_8.ForeColor = Color.GreenYellow;
                            txtText1_8.Enabled = false;
                            txtText2_8.Enabled = false;
                            btSub_8.Visible = false;
                            btSub_10.Visible = true;
                            Form1.bScore = 42;
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

        private void btSub_10_Click(object sender, EventArgs e)
        {
            if (check_10.Checked == true)
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

                            check_10.Checked = true;
                            check_10.ForeColor = Color.GreenYellow;
                            check_10.Enabled = false;
                            btSub_10.Visible = false;
                            btSub_12.Visible = true;
                            Form1.bScore = 43;
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

        private void btSub_12_Click(object sender, EventArgs e)
        {
            if (txtText1_12.Text.Trim().Equals("some_func") && txtText2_12.Text.Trim().Equals("void"))
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
                                this.Close();
                                f.Show();


                            }

                            txtText1_12.Text = "some_func";
                            txtText2_12.Text = "void";
                            txtText2_12.ForeColor = Color.GreenYellow;
                            txtText1_12.ForeColor = Color.GreenYellow;
                            txtText1_12.Enabled = false;
                            txtText2_12.Enabled = false;
                            btSub_12.Visible = false;

                            Form1.bScore = 44;
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
