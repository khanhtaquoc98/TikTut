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
    public partial class FFunctionswithMultipleParameters : Form
    {
        public FFunctionswithMultipleParameters()
        {
            InitializeComponent(); btSub_4.Visible = false;
            btSub_6.Visible = false;
            btSub_8.Visible = false;
            #region Save
            if (!Form1.check_48)
            {
                txtText1_2.Text = "int";
                txtText1_2.ForeColor = Color.GreenYellow;
                txtText1_2.Enabled = false;
                txtText2_2.Text = ",";
                txtText2_2.ForeColor = Color.GreenYellow;
                txtText2_2.Enabled = false;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 49; 
            }
            if (!Form1.check_49)
            {
                txtText1_4.Text = "int";
                txtText1_4.ForeColor = Color.GreenYellow;
                txtText1_4.Enabled = false;
                txtText2_4.Text = "y";
                txtText2_4.ForeColor = Color.GreenYellow;
                txtText2_4.Enabled = false;
                txtText3_4.Text = "answer";
                txtText3_4.ForeColor = Color.GreenYellow;
                txtText3_4.Enabled = false;
                btSub_4.Visible = false;
                btSub_6.Visible = true;
                //Form1.bScore = 4;
                Form1.bScore = 49; 
            }
            if (!Form1.check_50)
            {
                txtText1_6.Text = "y";
                txtText1_6.ForeColor = Color.GreenYellow;
                txtText1_6.Enabled = false;
                txtText2_6.Text = "86";
                txtText2_6.ForeColor = Color.GreenYellow;
                txtText2_6.Enabled = false;
                txtText3_6.Text = "result";
                txtText3_6.ForeColor = Color.GreenYellow;
                txtText3_6.Enabled = false;
                btSub_6.Visible = false;
                btSub_8.Visible = true;
                //Form1.bScore = 4;
                Form1.bScore = 50;
             
            }
            if (!Form1.check_51)
            {
                check_8.Checked = true;
                check_8.ForeColor = Color.GreenYellow;
                btSub_8.Visible = false;
                Form1.bScore = 51;
            }
#endregion 

        }
        public A_Manager.Functions f = new A_Manager.Functions();
        public string _uname = "";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Show();
        }
        //Event CLick
        private void btSub_2_Click(object sender, EventArgs e)
        {
            if (txtText1_2.Text.Trim().Equals("int") && txtText2_2.Text.Trim().Equals(","))
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

                            txtText1_2.Text = "int";
                            txtText1_2.ForeColor = Color.GreenYellow;
                            txtText1_2.Enabled = false;
                            txtText2_2.Text = ",";
                            txtText2_2.ForeColor = Color.GreenYellow;
                            txtText2_2.Enabled = false;
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 48;
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
            if (txtText1_4.Text.Trim().Equals("int") && txtText2_4.Text.Trim().Equals("y") && txtText3_4.Text.Trim().Equals("anwser"))
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
                            txtText2_4.Text = "y";
                            txtText2_4.ForeColor = Color.GreenYellow;
                            txtText2_4.Enabled = false;
                            txtText3_4.Text = "answer";
                            txtText3_4.ForeColor = Color.GreenYellow;
                            txtText3_4.Enabled = false;
                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                            //Form1.bScore = 4;
                            Form1.bScore = 49;
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
            if (txtText1_6.Text.Trim().Equals("y") && txtText2_6.Text.Trim().Equals("86") && txtText3_6.Text.Trim().Equals("result"))
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

                            txtText1_6.Text = "y";
                            txtText1_6.ForeColor = Color.GreenYellow;
                            txtText1_6.Enabled = false;
                            txtText2_6.Text = "86";
                            txtText2_6.ForeColor = Color.GreenYellow;
                            txtText2_6.Enabled = false;
                            txtText3_6.Text = "result";
                            txtText3_6.ForeColor = Color.GreenYellow;
                            txtText3_6.Enabled = false;
                            btSub_6.Visible = false;
                            btSub_8.Visible = true;
                            //Form1.bScore = 4;
                            Form1.bScore = 50;

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


                            DialogResult reset = MessageBox.Show("Congratulations!! You can do More On Classes in Advanced", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {
                                this.Close();
                                f.Show();
                            }

                            check_8.Checked = true;
                            check_8.ForeColor = Color.GreenYellow;
                            btSub_8.Visible = false;
                            Form1.bScore = 51;
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
