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
    public partial class BCComments : Form
    {
        public bool bc = false;
        public int c1, c2, c3;
        public BCComments()
        {
            InitializeComponent();
            btSub_4.Visible = false;
            btSub_6.Visible = false;
            #region Save
            if (!Form1.check_69)
            {
                check_2.Checked = true;
                check_2.ForeColor = Color.GreenYellow;
                check_2.Enabled = false;
                btSub_2.Visible = false;
                btSub_4.Visible = true;
                Form1.bScore = 69;
            }
            if (!Form1.check_70)
            {
                txtText1_4.Text = "/*";
                txtText2_4.Text = "*/";
                txtText1_4.Enabled = false;
                txtText2_4.Enabled = false;
                txtText1_4.ForeColor = Color.GreenYellow;
                txtText2_4.ForeColor = Color.GreenYellow;

                btSub_4.Visible = false;
                btSub_6.Visible = true;
                  Form1.bScore = 70;
            }
            if (!Form1.check_71)
            {
                check_6.Checked = true;
                check_6.ForeColor = Color.GreenYellow;
                check_6.Enabled = false;
                btSub_6.Visible = false; Form1.bScore = 71;
            }
            #endregion
        }
        public A_Manager.BasicConcepts b = new A_Manager.BasicConcepts();
        public string _uname = "";

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            b.Show();
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
                      //  Form1.bScore = 68;
                        Form1.bScore++;
                        string sqlupdate = @"Update _User set _yourscore = " + Form1.bScore + " where _username = '" + _uname + " '";
                        SqlCommand cmdUpdate = new SqlCommand(sqlupdate, DataProvider.cn);
                        try
                        {
                            // Mở kết nối
                            DataProvider.cn.Open();
                            cmdUpdate.ExecuteNonQuery();
                          // c1 = 1;
                          // Compare1();
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
                            Form1.Important = true;
                            check_2.Checked = true;
                            check_2.ForeColor = Color.GreenYellow;
                            check_2.Enabled = false;
                            btSub_2.Visible = false;
                            btSub_4.Visible = true;
                            Form1.bScore = 69;
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
            if (txtText1_4.Text.Trim().Equals("/*") && txtText2_4.Text.Trim().Equals("*/"))
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
                         //   c1 = 2;
                         //   Compare1();
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
                            txtText1_4.Text = "/*";
                            txtText2_4.Text = "*/";
                            txtText1_4.Enabled = false;
                            txtText2_4.Enabled = false;
                            txtText1_4.ForeColor = Color.GreenYellow;
                            txtText2_4.ForeColor = Color.GreenYellow;

                            btSub_4.Visible = false;
                            btSub_6.Visible = true;
                              Form1.bScore = 70;
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
                       //    c1 = 3;
                     //      Compare1();

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
                                b.Show();

                            }
                            Form1.Important = true;
                            check_6.Checked = true;
                            check_6.ForeColor = Color.GreenYellow;
                            check_6.Enabled = false;
                            btSub_6.Visible = false;

                            Form1.bScore = 71;
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

        public void Compare1()
        {
            foreach (KeyValuePair<string, User> entry in Form1.user)
            {
                if (!Form1.user.ContainsKey(Form1.username)) { return; }
                {
                    _uname = entry.Key;
                    DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                    DataProvider.cn.Open();
                    try
                    {
                        //Câu lệnh Insert
                        string sql = "Insert into dbo._Bool(_username, _compare) " + " values ('"+ _uname+"' , '"+ c1 +"'); ";

                        SqlCommand cmd = DataProvider.cn.CreateCommand();
                        cmd.CommandText = sql;
                      
                        // Thực thi Command (Dùng cho delete, insert, update).
                        // int rowCount = cmd.ExecuteNonQuery();

                        //Thực thi thủ tục
                        int rowCount = cmd.ExecuteNonQuery();                   
                    }
                    catch
                    {
                        
                    }
                    finally
                    {
                       
                        DataProvider.cn.Close();
                        DataProvider.cn.Dispose();
                        DataProvider.cn = null;
                    }

                }
                break;
            }

        }
        public void Compare2()
        {
            foreach (KeyValuePair<string, User> entry in Form1.user)
            {
                if (!Form1.user.ContainsKey(Form1.username)) { return; }
                {
                    _uname = entry.Key;
                    DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                    DataProvider.cn.Open();
                    try
                    {
                        Form1._c2 = 0;
                        //Câu lệnh Insert
                        string sql = "Insert into dbo._Bool(_username, _compare) " + " values ('" + _uname + "' , '" + Form1._c2 + "'); ";

                        SqlCommand cmd = DataProvider.cn.CreateCommand();
                        cmd.CommandText = sql;

                        // Thực thi Command (Dùng cho delete, insert, update).
                        // int rowCount = cmd.ExecuteNonQuery();

                        //Thực thi thủ tục
                        int rowCount = cmd.ExecuteNonQuery();
                    }
                    catch
                    {

                    }
                    finally
                    {

                        DataProvider.cn.Close();
                        DataProvider.cn.Dispose();
                        DataProvider.cn = null;
                    }

                }
                break;
            }
        }
        public void Compare3()
        {
            foreach (KeyValuePair<string, User> entry in Form1.user)
            {
                if (!Form1.user.ContainsKey(Form1.username)) { return; }
                {
                    _uname = entry.Key;
                    DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                    DataProvider.cn.Open();
                    try
                    {
                        //Câu lệnh Insert
                        string sql = "Insert into dbo._Bool(_username, _compare) " + " values ('" + _uname + "' , '" + Form1._c3 + "'); ";

                        SqlCommand cmd = DataProvider.cn.CreateCommand();
                        cmd.CommandText = sql;

                        // Thực thi Command (Dùng cho delete, insert, update).
                        // int rowCount = cmd.ExecuteNonQuery();

                        //Thực thi thủ tục
                        int rowCount = cmd.ExecuteNonQuery();
                    }
                    catch
                    {

                    }
                    finally
                    {

                        DataProvider.cn.Close();
                        DataProvider.cn.Dispose();
                        DataProvider.cn = null;
                    }

                }
                break;
            }
        }
    }
    
}
