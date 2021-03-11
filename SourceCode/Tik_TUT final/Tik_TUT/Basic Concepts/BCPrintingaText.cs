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
    public partial class BCPrintingaText : Form
    {
        public A_Manager.BasicConcepts b1 = new A_Manager.BasicConcepts();
        public string _uname = "";
        public BCPrintingaText()
        {
            InitializeComponent();
            btSub_4.Visible = false;
            btSub_6.Visible = false;
            btSub_8.Visible = false;
            btSub_10.Visible = false;
            #region Save
            if(!Form1.check_9)
            {
                txtText1_2.Text = "cout";
                txtText2_2.Text = ";";
                txtText2_2.ForeColor = Color.GreenYellow;
                txtText1_2.BackColor = Color.GreenYellow;
                txtText2_2.BackColor = Color.GreenYellow;
                txtText1_2.ForeColor = Color.GreenYellow;
                txtText2_2.Enabled = false;
                txtText1_2.Enabled = false;
                txtText1_2.ForeColor = Color.GreenYellow;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 9;
            }
            if (!Form1.check_10)
            {
                check_4.Checked = true;
                check_4.ForeColor = Color.GreenYellow;
                check_4.Enabled = false;
                btSub_4.Visible = false;
                btSub_6.Visible = true;
                Form1.bScore = 10;
            }
            if (!Form1.check_11)
            {
                check_6.Checked = true;
                check_6.ForeColor = Color.GreenYellow;
                check_6.Enabled = false;
                btSub_6.Visible = false;
                btSub_8.Visible = true;
                Form1.bScore = 11;
            }
            if (!Form1.check_12)
            {
                txtText1_8.Text = "cout";
                txtText2_8.Text = "user";
                txtText3_8.Text = "<<";
                txtText2_8.ForeColor = Color.GreenYellow;
                txtText1_8.BackColor = Color.GreenYellow;
                txtText3_8.BackColor = Color.GreenYellow;
                txtText2_8.BackColor = Color.GreenYellow;
                txtText1_8.ForeColor = Color.GreenYellow;
                txtText3_8.ForeColor = Color.GreenYellow;
                txtText2_8.Enabled = false;
                txtText1_8.Enabled = false;
                txtText3_8.Enabled = false;
                btSub_8.Visible = false;
                btSub_10.Visible = true;
                Form1.bScore = 12;
            }
            if (!Form1.check_13)
            {
                txtText1_10.Text = "<<endl<<";
                txtText2_10.Text = "<<endl";
                txtText2_10.ForeColor = Color.GreenYellow;
                txtText1_10.BackColor = Color.GreenYellow;

                txtText2_10.BackColor = Color.GreenYellow;
                txtText1_10.ForeColor = Color.GreenYellow;

                txtText2_10.Enabled = false;
                txtText1_10.Enabled = false;

                btSub_10.Visible = false;
                Form1.bScore = 13;
            }
            #endregion
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            b1.Show();
        }

        private void btSub_2_Click(object sender, EventArgs e)
        {
            if (txtText1_2.Text.Trim().Equals("cout") && txtText2_2.Text.Trim().Equals(";"))
            {
                foreach (KeyValuePair<string, User> entry in Form1.user)
                {
                    if (!Form1.user.ContainsKey(Form1.username)) { return; }
                    {
                        
                        _uname = entry.Key;
                        Form1.bScore = 8;
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

                            txtText1_2.Text = "cout";
                            txtText2_2.Text = ";";
                            txtText2_2.ForeColor = Color.GreenYellow;
                            txtText1_2.BackColor = Color.GreenYellow;
                            txtText2_2.BackColor = Color.GreenYellow;
                            txtText1_2.ForeColor = Color.GreenYellow;
                            txtText2_2.Enabled = false;
                            txtText1_2.Enabled = false;
                            txtText1_2.ForeColor = Color.GreenYellow;
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 9;
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
                            Form1.bScore = 10;
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
                            Form1.bScore = 11;
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
            if (txtText1_8.Text.Trim().Equals("cout") && txtText3_8.Text.Trim().Equals("<<"))
            {
                    if (txtText2_8.Text.Trim().Equals("user"))
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

                                    txtText1_8.Text = "cout";
                                    txtText2_8.Text = "user";
                                    txtText3_8.Text = "<<";
                                    txtText2_8.ForeColor = Color.GreenYellow;
                                    txtText1_8.BackColor = Color.GreenYellow;
                                    txtText3_8.BackColor = Color.GreenYellow;
                                    txtText2_8.BackColor = Color.GreenYellow;
                                    txtText1_8.ForeColor = Color.GreenYellow;
                                    txtText3_8.ForeColor = Color.GreenYellow;
                                    txtText2_8.Enabled = false;
                                    txtText1_8.Enabled = false;
                                    txtText3_8.Enabled = false;
                                    btSub_8.Visible = false;
                                    btSub_10.Visible = true;
                                Form1.bScore = 12;
                                DataProvider.cn.Close();
                                }
                            }

                            break;
                        }
                    }
                    else { MessageBox.Show("ERROR", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            
            }
            else
            {
                MessageBox.Show("ERROR", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btSub_10_Click(object sender, EventArgs e)
        {

            if ((txtText1_10.Text.Trim().Equals("<< endl<<") || txtText1_10.Text.Trim().Equals("<<endl<<") || txtText1_10.Text.Trim().Equals("<<endl <<")) && (txtText2_10.Text.Trim().Equals("<<endl") || txtText2_10.Text.Trim().Equals("<< endl") || txtText2_10.Text.Trim().Equals("<<endl ")))
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


                            DialogResult reset = MessageBox.Show("Congratulations!! You can do Conditional and Loops in Intermediate", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {
                                this.Close();
                                b1.Show();

                            }

                            txtText1_10.Text = "<<endl<<";
                            txtText2_10.Text = "<<endl";                       
                            txtText2_10.ForeColor = Color.GreenYellow;
                            txtText1_10.BackColor = Color.GreenYellow;
                          
                            txtText2_10.BackColor = Color.GreenYellow;
                            txtText1_10.ForeColor = Color.GreenYellow;
                         
                            txtText2_10.Enabled = false;
                            txtText1_10.Enabled = false;
                     
                            btSub_10.Visible = false;
                            Form1.bScore = 13;
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
