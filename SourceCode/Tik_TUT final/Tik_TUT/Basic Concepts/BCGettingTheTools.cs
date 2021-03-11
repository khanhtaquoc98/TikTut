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
    public partial class BCGettingTheTools : Form
    {
        public BCGettingTheTools()
        {
            InitializeComponent();
            btSub_4.Visible = false;
            if(!Form1.check_7)
            {
                check_2.Checked = true;
                check_2.ForeColor = Color.GreenYellow;
                check_2.Enabled = false;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 7;
            }
            if (!Form1.check_8)
            {
                check_4.Checked = true;
                check_4.ForeColor = Color.GreenYellow;
                check_4.Enabled = false;
                btSub_4.Visible = false;
                Form1.bScore = 8;
            }
        }
        public A_Manager.BasicConcepts b2 = new A_Manager.BasicConcepts();
        public string _uname = "";

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            b2.Show();
        }

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


                            DialogResult reset = MessageBox.Show("Correct", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {



                            }

                            check_2.Checked = true;
                            check_2.ForeColor = Color.GreenYellow;
                            check_2.Enabled = false;
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 7;
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
                                this.Close();
                                b2.Show();

                            }

                            check_4.Checked = true;
                            check_4.ForeColor = Color.GreenYellow;
                            check_4.Enabled = false;
                            Form1.bScore = 8;
                            btSub_4.Visible = false;
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
