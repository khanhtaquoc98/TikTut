﻿using System;
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
    public partial class FTheRandFunction : Form
    {
        public FTheRandFunction()
        {
            InitializeComponent();
        }
        public A_Manager.Functions f = new A_Manager.Functions();
        public string _uname = "";
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }

        private void btSub_2_Click(object sender, EventArgs e)
        {
            if (check_2.Checked == true)
            {
                foreach (KeyValuePair<string, User> entry in Form1.user)
                {
                    if (!Form1.user.ContainsKey(Form1.username)) { return; }
                    {
                        _uname = entry.Key;
                        Form1.bScore++;
                        Form1.Correct = false;
                        //u.U_Score();
                        DataProvider.cn = new SqlConnection(DataProvider.cnStr);

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
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
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
            if (txtText1_4.Text.Trim().Equals("for") && txtText2_4.Text.Trim().Equals("rand"))
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

                            txtText1_4.Text = "for";
                            txtText1_4.ForeColor = Color.GreenYellow;
                            txtText1_4.Enabled = false;
                            txtText2_4.Text = "rand";
                            txtText2_4.ForeColor = Color.GreenYellow;
                            txtText2_4.Enabled = false;
                         
                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            //Form1.bScore = 4;
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
            if (txtText_6.Text.Trim().Equals("%"))
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

                            txtText_6.Text = "%";
                            txtText_6.ForeColor = Color.GreenYellow;
                            txtText_6.Enabled = false;
                        
                            btSub_6.Visible = false;
                            btSub_8.Visible = true;
                            //Form1.bScore = 4;
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
            if (check_8.Checked == true)
            {
                foreach (KeyValuePair<string, User> entry in Form1.user)
                {
                    if (!Form1.user.ContainsKey(Form1.username)) { return; }
                    {
                        _uname = entry.Key;
                        Form1.bScore++;
                        Form1.Correct = false;
                        //u.U_Score();
                        DataProvider.cn = new SqlConnection(DataProvider.cnStr);

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

                            check_8.Checked = true;
                            check_8.ForeColor = Color.GreenYellow;
                            btSub_8.Visible = false;
                            btSub_10.Visible = true;
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
            if (txtText1_10.Text.Trim().Equals("srand") && txtText2_10.Text.Trim().Equals("15"))
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

                            txtText1_10.Text = "srand";
                            txtText1_10.ForeColor = Color.GreenYellow;
                            txtText1_10.Enabled = false;
                            txtText2_10.Text = "15";
                            txtText2_10.ForeColor = Color.GreenYellow;
                            txtText2_10.Enabled = false;

                            btSub_10.Visible = false;
                        
                            //Form1.bScore = 4;
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
