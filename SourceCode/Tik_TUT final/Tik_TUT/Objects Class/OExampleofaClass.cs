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

namespace Tik_TUT.Objects_Class
{
    public partial class OExampleofaClass : Form
    {
        public OExampleofaClass()
        {
            InitializeComponent();
            A();
        }
        public A_Manager.Objects o = new A_Manager.Objects();
        public string _uname = "";
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            o.Show();
        }
        //Event CLick
        public void A()
        {
            btSub_4.Visible = false;
            btSub_6.Visible = false;
            if (!Form1.check_59)
            {
                txtText_2.Text = "class";
                txtText_2.ForeColor = Color.GreenYellow;
                txtText_2.Enabled = false;
                btSub_4.Visible = false;
                btSub_6.Visible = true;
                Form1.bScore = 59;
            }
            if (!Form1.check_60)
            {
                check_4.Checked = true;
                check_4.ForeColor = Color.GreenYellow;
                check_4.Enabled = false;
                btSub_4.Visible = false;
                btSub_6.Visible = true;

                Form1.bScore = 60;
            }
            if (!Form1.check_61)
            {
                txtText1_6.Text = "class";
                txtText1_6.ForeColor = Color.GreenYellow;
                txtText1_6.Enabled = false;
                txtText2_6.Text = "public";
                txtText2_6.ForeColor = Color.GreenYellow;
                txtText2_6.Enabled = false;
                txtText3_6.Text = "cout";
                txtText3_6.ForeColor = Color.GreenYellow;
                txtText3_6.Enabled = false;
                btSub_6.Visible = false;
                // btSub_6.Visible = true;
                Form1.bScore = 61;
            }
        }
        private void btSub_2_Click(object sender, EventArgs e)
        {
            if (txtText_2.Text.Trim().Equals("class"))
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

                            txtText_2.Text = "class";
                            txtText_2.ForeColor = Color.GreenYellow;
                            txtText_2.Enabled = false;
                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            Form1.bScore = 59;
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
            if (check_4.Checked == true)
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

                            check_4.Checked = true;
                            check_4.ForeColor = Color.GreenYellow;
                            check_4.Enabled = false;
                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                          
                            Form1.bScore = 60;
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
            if (txtText1_6.Text.Trim().Equals("class") && txtText2_6.Text.Trim().Equals("public") && txtText3_6.Text.Trim().Equals("cout"))
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


                            DialogResult reset = MessageBox.Show("Congratulations!! You can do More On Classes in Proficient", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {
                                this.Close();
                                o.Show();

                            }

                            txtText1_6.Text = "class";
                            txtText1_6.ForeColor = Color.GreenYellow;
                            txtText1_6.Enabled = false;
                            txtText2_6.Text = "public";
                            txtText2_6.ForeColor = Color.GreenYellow;
                            txtText2_6.Enabled = false;
                            txtText3_6.Text = "cout";
                            txtText3_6.ForeColor = Color.GreenYellow;
                            txtText3_6.Enabled = false;
                            btSub_6.Visible = false;
                           // btSub_6.Visible = true;
                            Form1.bScore = 61;
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
