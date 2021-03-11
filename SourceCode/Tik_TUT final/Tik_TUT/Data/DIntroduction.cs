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
    public partial class DIntroduction : Form
    {
        public DIntroduction()
        {
            InitializeComponent();
        }
        public A_Manager.DData c = new A_Manager.DData();
        public string _uname = "";
        //Load Form
        private void DIntroduction_Load(object sender, EventArgs e)
        {
            btSub_4.Visible = false;
            btSub_6.Visible = false;
            btSub_8.Visible = false;
            btSub_10.Visible = false;
       
            #region Important Save
            if (!Form1.check_28)
            {
                check_2.Checked = true;
                check_2.ForeColor = Color.GreenYellow;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 28;
                if (!Form1.check_29)
                {
                    check_4.Checked = true;
                    check_4.ForeColor = Color.GreenYellow;
                    btSub_4.Visible = false;
                    btSub_6.Visible = true;
                    Form1.bScore = 29;
                    if (!Form1.check_30)
                    {
                        check_6.Checked = true;
                        check_6.ForeColor = Color.GreenYellow;
                        btSub_6.Visible = false;
                        btSub_8.Visible = true;
                        Form1.bScore = 30;
                        if (!Form1.check_31)
                        {
                            check_8.Checked = true;
                            check_8.ForeColor = Color.GreenYellow;
                            btSub_8.Visible = false;
                            btSub_10.Visible = true;
                            Form1.bScore = 31;
                            if (!Form1.check_32)
                            {
                                txtText_10.Text = "true";
                                txtText_10.ForeColor = Color.GreenYellow;
                                txtText_10.BackColor = Color.GreenYellow;


                                txtText_10.Enabled = false;

                                btSub_10.Visible = false;
                                Form1.bScore = 32;                             
                            }
                        }
                    }
                }
            }
            #endregion
        }
        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            c.Show();
        }
        //Event Click
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
                            Form1.bScore = 28;
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

                            check_4.Checked = true;
                            check_4.ForeColor = Color.GreenYellow;
                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            Form1.bScore = 29;
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
                            btSub_8.Visible = true;
                            Form1.bScore = 30;
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
                            Form1.bScore = 31;
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
            if ((txtText_10.Text.Trim().Equals("true")))
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

                            txtText_10.Text = "true";                   
                            txtText_10.ForeColor = Color.GreenYellow;
                            txtText_10.BackColor = Color.GreenYellow;
                     

                            txtText_10.Enabled = false;

                            btSub_10.Visible = false;
                            Form1.bScore = 32;
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
