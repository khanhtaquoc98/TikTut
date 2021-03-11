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

namespace Tik_TUT.Basic_Concepts
{
    public partial class BCHelloWorld : Form
    {
        public A_Manager.BasicConcepts b1 = new A_Manager.BasicConcepts();
        public BCHelloWorld()
        {
            InitializeComponent();
           
            txtSub_4.Visible = false;
            txtSub_6.Visible = false;
            txtSub_8.Visible = false;
            txtSub_10.Visible = false;
            #region Save DB
            if (!Form1.check_2)
            {
                txtText_2.Text = "   iostream";
                txtText_2.ForeColor = Color.GreenYellow;
                txtText_2.BackColor = Color.GreenYellow;
                txtText_2.Enabled = false;
                txtSub_2.Visible = false;
                txtSub_4.Visible = true;
                Form1.bScore = 2;
                //Form1.check = true;
            }
            if(!Form1.check_3)
            {
                txtText1_4.Text = "using";
                txtText2_4.Text = " std";
                txtText2_4.ForeColor = Color.GreenYellow;
                txtText1_4.BackColor = Color.GreenYellow;
                txtText2_4.BackColor = Color.GreenYellow;
                txtText1_4.ForeColor = Color.GreenYellow;
                txtText2_4.Enabled = false;
                txtText1_4.Enabled = false;
                txtText1_4.ForeColor = Color.GreenYellow;
                txtSub_4.Visible = false;
                txtSub_6.Visible = true;
                Form1.bScore = 3;
                Form1.check = true;
            }
            if ( !Form1.check_4)
            {
                check_6.Checked = true;
                check_6.ForeColor = Color.GreenYellow;
                check_6.Enabled = false;
                txtSub_6.Visible = false;
                txtSub_8.Visible = true;
                Form1.bScore = 4;
                
            }
            if ( !Form1.check_5)
            {
                check_8.Checked = true;
                check_8.ForeColor = Color.GreenYellow;
                check_8.Enabled = false;
                txtSub_8.Visible = false;
                txtSub_10.Visible = true;
                Form1.bScore = 5;
              
            }
            if ( !Form1.check_6)
            {
                txtText_10.Text = "cout";
                txtText_10.ForeColor = Color.GreenYellow;
                txtText_10.BackColor = Color.GreenYellow;
                txtText_10.Enabled = false;
                txtSub_10.Visible = false;
                Form1.bScore = 6;
           
            }
            #endregion
        }
        public string _uname = "";

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            b1.Show();
        }
        //Xử lí với DB Khi Click Submit
        private void txtSub_2_Click(object sender, EventArgs e)
        {
            if(txtText_2.Text.Trim().Equals("iostream"))
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
                            txtText_2.Text = "iostream";
                            txtText_2.ForeColor = Color.GreenYellow;
                            txtText_2.BackColor = Color.GreenYellow;
                            txtText_2.Enabled = false;
                            txtSub_2.Visible = false;
                            txtSub_4.Visible = true;
                            Form1.bScore = 2;
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

        private void txtSub_4_Click(object sender, EventArgs e)
        {
            if (txtText1_4.Text.Trim().Equals("using") && txtText2_4.Text.Trim().Equals("std"))
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
                          
                            txtText1_4.Text = "using";
                            txtText2_4.Text = " std";
                            txtText2_4.ForeColor = Color.GreenYellow;
                            txtText1_4.BackColor = Color.GreenYellow;
                            txtText2_4.BackColor = Color.GreenYellow;
                            txtText1_4.ForeColor = Color.GreenYellow;
                            txtText2_4.Enabled  = false;
                            txtText1_4.Enabled = false;
                            txtText1_4.ForeColor = Color.GreenYellow;
                            txtSub_4.Visible = false;
                            txtSub_6.Visible = true;
                            Form1.bScore = 3;
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

        private void txtSub_6_Click(object sender, EventArgs e)
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
                            txtSub_6.Visible = false;
                            txtSub_8.Visible = true;
                            Form1.bScore = 4;
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

        private void txtSub_8_Click(object sender, EventArgs e)
        {
            if(check_8.Checked ==true)
            {
                foreach (KeyValuePair<string, User> entry in Form1.user)
                {
                    if (!Form1.user.ContainsKey(Form1.username)) { return; }
                    {
                        _uname = entry.Key;

                       // Form1.Correct = false;
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
                            
                            check_8.Checked = true;
                            check_8.ForeColor = Color.GreenYellow;
                            check_8.Enabled = false;
                            txtSub_8.Visible = false;
                            txtSub_10.Visible = true;
                            Form1.bScore = 5;
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

        private void txtSub_10_Click(object sender, EventArgs e)
        {
            if(txtText_10.Text.Trim().Equals("cout"))
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
                                b1.Show();

                            }
                            
                            txtText_10.Text = "cout";
                            txtText_10.ForeColor = Color.GreenYellow;
                            txtText_10.BackColor = Color.GreenYellow;
                            txtText_10.Enabled = false;
                            txtSub_10.Visible = false;
                            Form1.bScore = 6;
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
