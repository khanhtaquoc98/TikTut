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

namespace Tik_TUT.Data
{
    public partial class DString : Form
    {
        public DString()
        {
            InitializeComponent();
            #region Save
            //btSub_4.Visible = false;
            //btSub_6.Visible = false;
            //if (!Form1.check_36)
            //{
            //    txtText_2.Text = "string";
            //    txtText_2.ForeColor = Color.GreenYellow;
            //    txtText_2.BackColor = Color.GreenYellow;


            //    txtText_2.Enabled = false;

            //    btSub_2.Visible = false;
            //    btSub_4.Visible = false;
            //    Form1.bScore = 36;
            //    if (!Form1.check_37)
            //    {
            //        txtText1_4.Text = "char";
            //        txtText1_4.ForeColor = Color.GreenYellow;
            //        txtText1_4.BackColor = Color.GreenYellow;
            //        txtText1_4.Enabled = false;
            //        txtText2_4.Text = "var";
            //        txtText2_4.ForeColor = Color.GreenYellow;
            //        txtText2_4.BackColor = Color.GreenYellow;
            //        txtText2_4.Enabled = false;
            //        btSub_4.Visible = false;
            //        btSub_6.Visible = false;
            //        Form1.bScore = 37;
            //        if (!Form1.check_38)
            //        {
            //            txtText1_6.Text = "bool";
            //            txtText1_6.ForeColor = Color.GreenYellow;
            //            txtText1_6.BackColor = Color.GreenYellow;
            //            txtText1_6.Enabled = false;
            //            txtText2_6.Text = "true";
            //            txtText2_6.ForeColor = Color.GreenYellow;
            //            txtText2_6.BackColor = Color.GreenYellow;
            //            txtText2_6.Enabled = false;
            //            btSub_6.Visible = false;

            //            Form1.bScore = 38;
            //        }
            //    }
            //}
            #endregion
        }
        public A_Manager.DData c = new A_Manager.DData();
        public string _uname = "";
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            c.Show();
        }
        //Event Click
        private void btSub_2_Click(object sender, EventArgs e)
        {
            if ((txtText_2.Text.Trim().Equals("string")))
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

                            txtText_2.Text = "string";
                            txtText_2.ForeColor = Color.GreenYellow;
                            txtText_2.BackColor = Color.GreenYellow;


                            txtText_2.Enabled = false;

                            btSub_2.Visible = false;
                            btSub_4.Visible = false;
                                Form1.bScore = 36;
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
            if ((txtText1_4.Text.Trim().Equals("char") && txtText2_4.Text.Trim().Equals("var")))
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

                            txtText1_4.Text = "char";
                            txtText1_4.ForeColor = Color.GreenYellow;
                            txtText1_4.BackColor = Color.GreenYellow;
                            txtText1_4.Enabled = false;
                            txtText2_4.Text = "var";
                            txtText2_4.ForeColor = Color.GreenYellow;
                            txtText2_4.BackColor = Color.GreenYellow;
                            txtText2_4.Enabled = false;
                            btSub_4.Visible = false;
                            btSub_6.Visible = false;
                                Form1.bScore = 37;
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
            if ((txtText1_6.Text.Trim().Equals("bool") && txtText2_6.Text.Trim().Equals("true")))
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


                            DialogResult reset = MessageBox.Show("Congratulations!! You can do Function in Advanced", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {
                                this.Close();
                                c.Show();

                            }

                            txtText1_6.Text = "bool";
                            txtText1_6.ForeColor = Color.GreenYellow;
                            txtText1_6.BackColor = Color.GreenYellow;
                            txtText1_6.Enabled = false;
                            txtText2_6.Text = "true";
                            txtText2_6.ForeColor = Color.GreenYellow;
                            txtText2_6.BackColor = Color.GreenYellow;
                            txtText2_6.Enabled = false;
                            btSub_6.Visible = false;
                         
                                Form1.bScore = 38;
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
        //Load Form
        private void DString_Load(object sender, EventArgs e)
        {
            btSub_4.Visible = false;
            btSub_6.Visible = false;
            if (!Form1.check_36)
            {
                txtText_2.Text = "string";
                txtText_2.ForeColor = Color.GreenYellow;
                txtText_2.BackColor = Color.GreenYellow;


                txtText_2.Enabled = false;

                btSub_2.Visible = false;
                btSub_4.Visible = false;
                Form1.bScore = 36;
                if (!Form1.check_37)
                {
                    txtText1_4.Text = "char";
                    txtText1_4.ForeColor = Color.GreenYellow;
                    txtText1_4.BackColor = Color.GreenYellow;
                    txtText1_4.Enabled = false;
                    txtText2_4.Text = "var";
                    txtText2_4.ForeColor = Color.GreenYellow;
                    txtText2_4.BackColor = Color.GreenYellow;
                    txtText2_4.Enabled = false;
                    btSub_4.Visible = false;
                    btSub_6.Visible = false;
                    Form1.bScore = 37;
                    if (!Form1.check_38)
                    {
                        txtText1_6.Text = "bool";
                        txtText1_6.ForeColor = Color.GreenYellow;
                        txtText1_6.BackColor = Color.GreenYellow;
                        txtText1_6.Enabled = false;
                        txtText2_6.Text = "true";
                        txtText2_6.ForeColor = Color.GreenYellow;
                        txtText2_6.BackColor = Color.GreenYellow;
                        txtText2_6.Enabled = false;
                        btSub_6.Visible = false;

                        Form1.bScore = 38;
                    }
                }
            }
        }
    }
}
