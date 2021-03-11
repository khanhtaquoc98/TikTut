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
    public partial class FFunctionParameters : Form
    {
        public FFunctionParameters()
        {
            InitializeComponent(); btSub_4.Visible = false;
            btSub_6.Visible = false;
          
            #region Save
            if (!Form1.check_45)
            {
                txtText1_2.Text = "x";
                txtText1_2.ForeColor = Color.GreenYellow;
                txtText1_2.Enabled = false;
                txtText2_2.Text = "x";
                txtText2_2.ForeColor = Color.GreenYellow;
                txtText2_2.Enabled = false;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 45;
            }
            if (!Form1.check_46)
            {
                txtText1_4.Text = "int";
                txtText1_4.ForeColor = Color.GreenYellow;
                txtText1_4.Enabled = false;
                txtText2_4.Text = "20";
                txtText2_4.ForeColor = Color.GreenYellow;
                txtText2_4.Enabled = false;
                btSub_4.Visible = false;
                btSub_6.Visible = true;
                Form1.bScore = 46;
            }
            if (!Form1.check_47)
            {
                txtText1_6.Text = "4";
                txtText1_6.ForeColor = Color.GreenYellow;
                txtText1_6.Enabled = false;
                txtText2_6.Text = "5";
                txtText2_6.ForeColor = Color.GreenYellow;
                txtText2_6.Enabled = false;
                txtText3_6.Text = "6";
                txtText3_6.ForeColor = Color.GreenYellow;
                txtText3_6.Enabled = false;
                btSub_6.Visible = false;
                //btSub_4.Visible = true;
                Form1.bScore = 47;
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
        //Event Click
        private void btSub_2_Click(object sender, EventArgs e)
        {
            if (txtText1_2.Text.Trim().Equals("x") && txtText2_2.Text.Trim().Equals("x"))
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

                            txtText1_2.Text = "x";
                            txtText1_2.ForeColor = Color.GreenYellow;
                            txtText1_2.Enabled = false;
                            txtText2_2.Text = "x";
                            txtText2_2.ForeColor = Color.GreenYellow;
                            txtText2_2.Enabled = false;
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 45;
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
            if (txtText1_4.Text.Trim().Equals("int") && txtText2_4.Text.Trim().Equals("20"))
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

                            txtText1_4.Text = "int";
                            txtText1_4.ForeColor = Color.GreenYellow;
                            txtText1_4.Enabled = false;
                            txtText2_4.Text = "20";
                            txtText2_4.ForeColor = Color.GreenYellow;
                            txtText2_4.Enabled = false;
                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            Form1.bScore = 46;
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
            if (txtText1_6.Text.Trim().Equals("4") && txtText2_6.Text.Trim().Equals("5") && txtText3_6.Text.Trim().Equals("6"))
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

                            txtText1_6.Text = "4";
                            txtText1_6.ForeColor = Color.GreenYellow;
                            txtText1_6.Enabled = false;
                            txtText2_6.Text = "5";
                            txtText2_6.ForeColor = Color.GreenYellow;
                            txtText2_6.Enabled = false;
                            txtText3_6.Text = "6";
                            txtText3_6.ForeColor = Color.GreenYellow;
                            txtText3_6.Enabled = false;
                            btSub_6.Visible = false;
                            //btSub_4.Visible = true;
                            Form1.bScore = 47;
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
