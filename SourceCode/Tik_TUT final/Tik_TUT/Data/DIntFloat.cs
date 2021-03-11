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
    public partial class DIntFloat : Form
    {
        public DIntFloat()
        {
            InitializeComponent(); btSub_4.Visible = false;
            btSub_6.Visible = false;
          
            #region Important Save
            //if (!Form1.check_33)
            //{
            //    check_2.Checked = true;
            //    check_2.ForeColor = Color.GreenYellow;
            //    btSub_2.Visible = false;
            //    btSub_4.Visible = true;
            //    Form1.bScore = 33;
            //}
            //if (!Form1.check_34)
            //{
            //    check_6.Checked = true;
            //    check_6.ForeColor = Color.GreenYellow;
            //    btSub_6.Visible = false;
            //    Form1.bScore = 34;
            //}
            //if (!Form1.check_35)
            //{
            //    txtText_4.Text = "unsigned";
            //    txtText_4.ForeColor = Color.GreenYellow;
            //    txtText_4.BackColor = Color.GreenYellow;


            //    txtText_4.Enabled = false;

            //    btSub_4.Visible = false;
            //    btSub_6.Visible = false;
            //    Form1.bScore = 35;
            //}
            #endregion
        }
        public A_Manager.DData  c = new A_Manager.DData();
        public string _uname = "";
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            c.Show();
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
                            Form1.bScore = 33;
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

                            check_6.Checked = true;
                            check_6.ForeColor = Color.GreenYellow;
                            btSub_6.Visible = false;
                            Form1.bScore = 34;
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
            if ((txtText_4.Text.Trim().Equals("unsigned")))
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
                                c.Show();

                            }

                            txtText_4.Text = "unsigned";
                            txtText_4.ForeColor = Color.GreenYellow;
                            txtText_4.BackColor = Color.GreenYellow;


                            txtText_4.Enabled = false;

                            btSub_4.Visible = false;
                            btSub_6.Visible = false;
                            Form1.bScore = 35;
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
        //Form Load
        private void DIntFloat_Load(object sender, EventArgs e)
        {
            btSub_4.Visible = false;
            btSub_6.Visible = false;
            #region  Save
            if (!Form1.check_33)
            {
                check_2.Checked = true;
                check_2.ForeColor = Color.GreenYellow;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 33;
            }
            if (!Form1.check_34)
            {
                check_6.Checked = true;
                check_6.ForeColor = Color.GreenYellow;
                btSub_6.Visible = false;
                Form1.bScore = 34;
            }
            if (!Form1.check_35)
            {
                txtText_4.Text = "unsigned";
                txtText_4.ForeColor = Color.GreenYellow;
                txtText_4.BackColor = Color.GreenYellow;


                txtText_4.Enabled = false;

                btSub_4.Visible = false;
                btSub_6.Visible = false;
                Form1.bScore = 35;
            }
        }
        #endregion
    }
}
