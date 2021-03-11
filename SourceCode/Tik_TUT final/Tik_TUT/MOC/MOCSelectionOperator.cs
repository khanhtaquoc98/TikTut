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

namespace Tik_TUT.MOC
{
    public partial class MOCSelectionOperator : Form
    {
        //Important
        public MOCSelectionOperator()
        {
            InitializeComponent();
       
            btSub_4.Visible = false;
            btSub_6.Visible = false;
            btSub_8.Visible = false;
            btSub_10.Visible = false;
            if(!Form1.check_72)
            {
                check_2.Checked = true;
                check_2.ForeColor = Color.GreenYellow;
                check_2.Enabled = false;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 72;
            }
            if (!Form1.check_73)
            {
                txtText1_4.Text = "class";
                txtText1_4.ForeColor = Color.GreenYellow;
                txtText1_4.Enabled = false;
                txtText2_4.Text = "public";
                txtText2_4.ForeColor = Color.GreenYellow;
                txtText2_4.Enabled = false;
                txtText3_4.Text = "myPrint";
                txtText3_4.ForeColor = Color.GreenYellow;
                txtText3_4.Enabled = false;
                btSub_4.Visible = false;
                btSub_6.Visible = true;
                Form1.bScore = 73;
            }
            if (!Form1.check_74)
            {
                txtText1_6.Text = "Sally";
                txtText1_6.ForeColor = Color.GreenYellow;
                txtText1_6.Enabled = false;
                txtText2_6.Text = "obj";
                txtText2_6.ForeColor = Color.GreenYellow;
                txtText2_6.Enabled = false;
                txtText3_6.Text = "myPrint()";
                txtText3_6.ForeColor = Color.GreenYellow;
                txtText3_6.Enabled = false;
                btSub_6.Visible = false;
                btSub_8.Visible = true;
                Form1.bScore = 74;
            }
            if (!Form1.check_75)
            {
                txtText1_8.Text = "*";
                txtText1_8.ForeColor = Color.GreenYellow;
                txtText1_8.Enabled = false;
                txtText2_8.Text = "&";
                txtText2_8.ForeColor = Color.GreenYellow;
                txtText2_8.Enabled = false;


                btSub_8.Visible = false;
                btSub_10.Visible = true;
                Form1.bScore = 75;
            }
            if (!Form1.check_76)
            {
                txtText_10.Text = "->";
                txtText_10.ForeColor = Color.GreenYellow;
                txtText_10.Enabled = false;
                Form1.bScore = 76;
            }
        }
        public A_Manager.MoreOnClasses m = new A_Manager.MoreOnClasses();
        public string _uname = "";
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
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
                        Form1.bScore = 71;
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
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 72;
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
            if (txtText1_4.Text.Trim().Equals("class") && txtText2_4.Text.Trim().Equals("public") && txtText3_4.Text.Trim().Equals("myPrint"))
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

                            txtText1_4.Text = "class";
                            txtText1_4.ForeColor = Color.GreenYellow;
                            txtText1_4.Enabled = false;
                            txtText2_4.Text = "public";
                            txtText2_4.ForeColor = Color.GreenYellow;
                            txtText2_4.Enabled = false;
                            txtText3_4.Text = "myPrint";
                            txtText3_4.ForeColor = Color.GreenYellow;
                            txtText3_4.Enabled = false;
                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            Form1.bScore = 73;
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
            if (txtText1_6.Text.Trim().Equals("Sally") && txtText2_6.Text.Trim().Equals("obj") && txtText3_6.Text.Trim().Equals("myPrint()"))
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

                            txtText1_6.Text = "Sally";
                            txtText1_6.ForeColor = Color.GreenYellow;
                            txtText1_6.Enabled = false;
                            txtText2_6.Text = "obj";
                            txtText2_6.ForeColor = Color.GreenYellow;
                            txtText2_6.Enabled = false;
                            txtText3_6.Text = "myPrint()";
                            txtText3_6.ForeColor = Color.GreenYellow;
                            txtText3_6.Enabled = false;
                            btSub_6.Visible = false;
                            btSub_8.Visible = true;
                            Form1.bScore = 74;
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
            if (txtText1_8.Text.Trim().Equals("*") && txtText2_8.Text.Trim().Equals("&"))
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

                            txtText1_8.Text = "*";
                            txtText1_8.ForeColor = Color.GreenYellow;
                            txtText1_8.Enabled = false;
                            txtText2_8.Text = "&";
                            txtText2_8.ForeColor = Color.GreenYellow;
                            txtText2_8.Enabled = false;
                         
                         
                            btSub_8.Visible = false;
                            btSub_10.Visible = true;
                            Form1.bScore = 75;
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
            if (txtText_10.Text.Trim().Equals("->"))
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
                                m.Show();

                            }

                            txtText_10.Text = "->";
                            txtText_10.ForeColor = Color.GreenYellow;
                            txtText_10.Enabled = false;                           
                            Form1.bScore = 76;
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
