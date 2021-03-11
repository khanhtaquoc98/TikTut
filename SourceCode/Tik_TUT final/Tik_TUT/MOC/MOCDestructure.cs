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
    public partial class MOCDestructure : Form
    {
        public MOCDestructure()
        {
            InitializeComponent();
            btSub_3.Visible = false;
            btSub_6.Visible = false;
            if (!Form1.check_65) {
                txtText1_2.Text = "const";
                txtText1_2.ForeColor = Color.GreenYellow;
                txtText1_2.Enabled = false;
                txtText2_2.Text = "var";
                txtText2_2.ForeColor = Color.GreenYellow;
                txtText2_2.Enabled = false;

                btSub_1.Visible = false;
                btSub_3.Visible = true;
                Form1.bScore = 65;
            }
            if (!Form1.check_66)
            {
                txtText1_4.Text = "class";
                txtText1_4.ForeColor = Color.GreenYellow;
                txtText1_4.Enabled = false;
                txtText2_4.Text = "const";
                txtText2_4.ForeColor = Color.GreenYellow;
                txtText2_4.Enabled = false;

                btSub_3.Visible = false;
                btSub_6.Visible = true;
                Form1.bScore = 66;
            }
            if (!Form1.check_67)
            {
                check_6.Checked = true;
                check_6.ForeColor = Color.GreenYellow;
                btSub_6.Visible = false;
                Form1.bScore = 67;
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
        private void btSub_6_Click(object sender, EventArgs e)
        {
            if (check_6.Checked == true)
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
                                this.Close();
                                m.Show();
                            }

                            check_6.Checked = true;
                            check_6.ForeColor = Color.GreenYellow;
                            btSub_6.Visible = false;
                            Form1.bScore = 67;
                            //btSub_4.Visible = true;
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

        private void btSub_1_Click(object sender, EventArgs e)
        {
            if (txtText1_2.Text.Trim().Equals("const") && txtText2_2.Text.Trim().Equals("var"))
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

                            txtText1_2.Text = "const";
                            txtText1_2.ForeColor = Color.GreenYellow;
                            txtText1_2.Enabled = false;
                            txtText2_2.Text = "var";
                            txtText2_2.ForeColor = Color.GreenYellow;
                            txtText2_2.Enabled = false;

                            btSub_1.Visible = false;
                            btSub_3.Visible = true;
                            Form1.bScore = 65;
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

        private void btSub_3_Click(object sender, EventArgs e)
        {
            if (txtText1_4.Text.Trim().Equals("class") && txtText2_4.Text.Trim().Equals("const"))
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
                            txtText2_4.Text = "const";
                            txtText2_4.ForeColor = Color.GreenYellow;
                            txtText2_4.Enabled = false;

                            btSub_3.Visible = false;
                            btSub_6.Visible = true;
                            Form1.bScore =66;
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
