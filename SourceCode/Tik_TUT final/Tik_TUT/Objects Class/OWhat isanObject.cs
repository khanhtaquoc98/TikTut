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
    public partial class OWhat_isanObject : Form
    {
        public OWhat_isanObject()
        {
            InitializeComponent(); btSub_4.Visible = false;
            btSub_6.Visible = false;
            btSub_8.Visible = false;
            if (!Form1.check_52)
            {
                check_2.Checked = true;
                check_2.ForeColor = Color.GreenYellow;
                check_2.Enabled = false;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 52;
            }
            if (!Form1.check_53)
            {

                check_4.Checked = true;
                check_4.ForeColor = Color.GreenYellow;
                check_4.Enabled = false;
                btSub_4.Visible = false;
                btSub_6.Visible = true;
                //Form1.bScore = 4;
                Form1.bScore = 53;
            }
            if (!Form1.check_54)
            {
                check_6.Checked = true;
                check_6.ForeColor = Color.GreenYellow;
                check_6.Enabled = false;
                btSub_6.Visible = false;
                btSub_8.Visible = true;
                //Form1.bScore = 4;
                Form1.bScore = 54;

            }
            if (!Form1.check_55)
            {
                check_8.Checked = true;
                check_8.ForeColor = Color.GreenYellow;
                check_8.Enabled = false;
                btSub_8.Visible = false;
                Form1.bScore = 55;
            }
        }
        public A_Manager.Objects o = new A_Manager.Objects();
        public string _uname = "";

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            o.Show();
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


                            DialogResult reset = MessageBox.Show("Correct", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {



                            }

                            check_2.Checked = true;
                            check_2.ForeColor = Color.GreenYellow;
                            check_2.Enabled = false;
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 52;
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


                            DialogResult reset = MessageBox.Show("Correct", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {



                            }

                            check_4.Checked = true;
                            check_4.ForeColor = Color.GreenYellow;
                            check_4.Enabled = false;
                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            //Form1.bScore = 4; 
                            Form1.bScore = 53;
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
                            //Form1.bScore = 4;
                            Form1.bScore = 54;
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
                                this.Close();
                                o.Show();


                            }

                            check_8.Checked = true;
                            check_8.ForeColor = Color.GreenYellow;
                            check_8.Enabled = false;
                            btSub_8.Visible = false;
                            //btSub_.Visible = true;
                            //Form1.bScore = 4;
                            Form1.bScore = 55;
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
