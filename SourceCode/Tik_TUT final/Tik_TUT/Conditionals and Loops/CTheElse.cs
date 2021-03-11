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
    public partial class CTheElse : Form
    {
        public CTheElse()
        {
            InitializeComponent();
           #region Save
            //btSub_4.Visible = false;
            //btSub_6.Visible = false;
            //btSub_8.Visible = false;
            //btSub_10.Visible = false;
            //btSub_12.Visible = false;
            //if (!Form1.check_19)
            //{
            //    txtText1_2.Text = "if";
            //    txtText2_2.Text = "age";
            //    txtText1_2.ForeColor = Color.GreenYellow;
            //    txtText2_2.ForeColor = Color.GreenYellow;
            //    txtText1_2.Enabled = false;
            //    txtText2_2.Enabled = false;
            //    button2.Visible = false;
            //    btSub_4.Visible = true;
            //    Form1.bScore = 19;
            //    if (!Form1.check_20)
            //    {

            //        txtText1_4.Text = "if";
            //        txtText2_4.Text = "else";

            //        txtText1_4.ForeColor = Color.GreenYellow;
            //        txtText2_4.ForeColor = Color.GreenYellow;

            //        txtText1_4.Enabled = false;
            //        txtText2_4.Enabled = false;

            //        btSub_4.Visible = false;
            //        btSub_6.Visible = true;
            //        Form1.bScore = 20;
            //        if (!Form1.check_21)
            //        {
            //            check_6.Checked = true;
            //            check_6.ForeColor = Color.GreenYellow;
            //            check_6.Enabled = false;
            //            btSub_6.Visible = false;
            //            btSub_8.Visible = true;
            //            Form1.bScore = 21;
            //            if (!Form1.check_22)
            //            {
            //                txtText1_8.Text = "if";
            //                txtText1_8.Text = "cout";
            //                txtText2_8.ForeColor = Color.GreenYellow;
            //                txtText1_8.ForeColor = Color.GreenYellow;
            //                txtText1_8.Enabled = false;
            //                txtText2_8.Enabled = false;
            //                btSub_8.Visible = false;
            //                btSub_10.Visible = true;
            //                Form1.bScore = 22;
            //                if (!Form1.check_23)
            //                {
            //                    check_10.Checked = true;
            //                    check_10.ForeColor = Color.GreenYellow;
            //                    check_10.Enabled = false;
            //                    btSub_10.Visible = false;
            //                    btSub_12.Visible = true;
            //                    Form1.bScore = 23;
            //                    if (!Form1.check_24)
            //                    {
            //                        txtText1_12.Text = "x";
            //                        txtText1_12.Text = "y";
            //                        txtText2_12.ForeColor = Color.GreenYellow;
            //                        txtText1_12.ForeColor = Color.GreenYellow;
            //                        txtText1_12.Enabled = false;
            //                        txtText2_12.Enabled = false;
            //                        btSub_12.Visible = false;
            //                        // btSub_10.Visible = true;
            //                        Form1.bScore = 24;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtText1_2.Text.Trim().Equals("if") && txtText2_2.Text.Trim().Equals("age"))
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

                            txtText1_2.Text = "if";
                            txtText2_2.Text = "age";

                            txtText1_2.ForeColor = Color.GreenYellow;
                            txtText2_2.ForeColor = Color.GreenYellow;

                            txtText1_2.Enabled = false;
                            txtText2_2.Enabled = false;
                            button2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 19;
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
            if (txtText1_4.Text.Trim().Equals("if") && txtText2_4.Text.Trim().Equals("else"))
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

                            txtText1_4.Text = "if";
                            txtText2_4.Text = "else";

                            txtText1_4.ForeColor = Color.GreenYellow;
                            txtText2_4.ForeColor = Color.GreenYellow;

                            txtText1_4.Enabled = false;
                            txtText2_4.Enabled = false;

                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            Form1.bScore =20;
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


                            DialogResult reset = MessageBox.Show("Correct", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {



                            }

                            check_6.Checked = true;
                            check_6.ForeColor = Color.GreenYellow;
                            check_6.Enabled = false;
                            btSub_6.Visible = false;
                            btSub_8.Visible = true;
                            Form1.bScore = 21;
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
            if (txtText1_8.Text.Trim().Equals("if") && txtText2_8.Text.Trim().Equals("cout"))
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

                            txtText1_8.Text = "if";
                            txtText1_8.Text = "cout";
                            txtText2_8.ForeColor = Color.GreenYellow;
                            txtText1_8.ForeColor = Color.GreenYellow;
                            txtText1_8.Enabled = false;
                            txtText2_8.Enabled = false;
                            btSub_8.Visible = false;
                            btSub_10.Visible = true;
                            Form1.bScore = 22;
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


                            DialogResult reset = MessageBox.Show("Correct", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {



                            }

                            check_10.Checked = true;
                            check_10.ForeColor = Color.GreenYellow;
                            check_10.Enabled = false;
                            btSub_10.Visible = false;
                            btSub_12.Visible = true;
                            Form1.bScore = 23;
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
            if (txtText1_12.Text.Trim().Equals("x") && txtText2_8.Text.Trim().Equals("y"))
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
                                c.Show();

                            }

                            txtText1_12.Text = "x";
                            txtText1_12.Text = "y";
                            txtText2_12.ForeColor = Color.GreenYellow;
                            txtText1_12.ForeColor = Color.GreenYellow;
                            txtText1_12.Enabled = false;
                            txtText2_12.Enabled = false;
                            btSub_12.Visible = false;
                           // btSub_10.Visible = true;
                            Form1.bScore = 24;
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
        private void CTheElse_Load(object sender, EventArgs e)
        {
            #region Save
            btSub_4.Visible = false;
            btSub_6.Visible = false;
            btSub_8.Visible = false;
            btSub_10.Visible = false;
            btSub_12.Visible = false;
            if (!Form1.check_19)
            {
                txtText1_2.Text = "if";
                txtText2_2.Text = "age";
                txtText1_2.ForeColor = Color.GreenYellow;
                txtText2_2.ForeColor = Color.GreenYellow;
                txtText1_2.Enabled = false;
                txtText2_2.Enabled = false;
                button2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 19;
                if (!Form1.check_20)
                {

                    txtText1_4.Text = "if";
                    txtText2_4.Text = "else";

                    txtText1_4.ForeColor = Color.GreenYellow;
                    txtText2_4.ForeColor = Color.GreenYellow;

                    txtText1_4.Enabled = false;
                    txtText2_4.Enabled = false;

                    btSub_4.Visible = false;
                    btSub_6.Visible = true;
                    Form1.bScore = 20;
                    if (!Form1.check_21)
                    {
                        check_6.Checked = true;
                        check_6.ForeColor = Color.GreenYellow;
                        check_6.Enabled = false;
                        btSub_6.Visible = false;
                        btSub_8.Visible = true;
                        Form1.bScore = 21;
                        if (!Form1.check_22)
                        {
                            txtText1_8.Text = "if";
                            txtText1_8.Text = "cout";
                            txtText2_8.ForeColor = Color.GreenYellow;
                            txtText1_8.ForeColor = Color.GreenYellow;
                            txtText1_8.Enabled = false;
                            txtText2_8.Enabled = false;
                            btSub_8.Visible = false;
                            btSub_10.Visible = true;
                            Form1.bScore = 22;
                            if (!Form1.check_23)
                            {
                                check_10.Checked = true;
                                check_10.ForeColor = Color.GreenYellow;
                                check_10.Enabled = false;
                                btSub_10.Visible = false;
                                btSub_12.Visible = true;
                                Form1.bScore = 23;
                                if (!Form1.check_24)
                                {
                                    txtText1_12.Text = "x";
                                    txtText1_12.Text = "y";
                                    txtText2_12.ForeColor = Color.GreenYellow;
                                    txtText1_12.ForeColor = Color.GreenYellow;
                                    txtText1_12.Enabled = false;
                                    txtText2_12.Enabled = false;
                                    btSub_12.Visible = false;
                                    // btSub_10.Visible = true;
                                    Form1.bScore = 24;
                                }
                            }
                        }
                    }
                }
            }


            #endregion
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            c.Show();
        }
    }
}
