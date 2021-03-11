using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tik_TUT.User_Control
{
    public partial class UC_Profile : UserControl
    {
        public Form1 parentForm { get; set; }
        static public Form1 form = new Form1();
        public string _uname = "";
        public UC_Profile()
        {
            InitializeComponent();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            txtLoginUser.Text = "";
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            txtLoginPass.Text = "";
            txtLoginPass.PasswordChar = '*';
        }      

        private void materialSingleLineTextField1_Leave(object sender, EventArgs e)
        {
            if (txtLoginUser.Text =="")
            txtLoginUser.Text = "             Username";
        }
        private void materialSingleLineTextField2_Leave(object sender, EventArgs e)
        {
            if (txtLoginPass.Text == "")
                txtLoginPass.Text = "              Password";
        }
        private void materialSingleLineTextField4_Click(object sender, EventArgs e)
        {
            txtRegisterPass.Text = "";
            txtRegisterPass.PasswordChar = '*';
                

        }
        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {
            txtRegisterCPass.Text = "";
            txtRegisterCPass.PasswordChar = '*';
        }
        private void materialSingleLineTextField6_Click(object sender, EventArgs e)
        {
            txtRegisterName.Text = "";
        }
        private void materialSingleLineTextField7_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";
        }
        private void materialSingleLineTextField3_Leave(object sender, EventArgs e)
        {
            if (txtRegisterUser.Text == "")
                txtRegisterUser.Text = "             Username";
        }
        private void materialSingleLineTextField4_Leave(object sender, EventArgs e)
        {
            if (txtRegisterPass.Text == "")
                txtRegisterPass.Text = "              Password";
        }
        private void materialSingleLineTextField5_Leave(object sender, EventArgs e)
        {
            if (txtRegisterCPass.Text == "")
                txtRegisterCPass.Text = "       Confirm Password";
        }
        private void materialSingleLineTextField6_Leave(object sender, EventArgs e)
        {
            if (txtRegisterName.Text == "")
                txtRegisterName.Text = "               Fullname";
        }
        private void materialSingleLineTextField7_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
                txtPhone.Text = "            Phone number";
        }
       // string a, b, c, d;
        //Xử Lí Hàm Đăng Kí
        private void btRegister_Click(object sender, EventArgs e)
        {
            // Điều Kiện Để Trong Form Đăng Kí Không Có Ô nào được trống
            string pass1 = txtRegisterPass.Text;
            string pass2 = txtRegisterCPass.Text;
            if(txtRegisterUser.Text.Trim().Equals("")|| txtRegisterPass.Text.Trim().Equals("")||txtRegisterCPass.Text.Trim().Equals("")||txtRegisterName.Text.Trim().Equals("")||txtPhone.Text.Trim().Equals(""))
            {
                if (txtRegisterUser.Text.Trim().Equals("")) { errorProvider1.SetError(this.txtRegisterUser, "Username can't be null"); }
                if (txtRegisterPass.Text.Trim().Equals("")) { errorProvider2.SetError(this.txtRegisterPass, "Password can't be null"); }
                if (txtRegisterCPass.Text.Trim().Equals("")) { errorProvider3.SetError(this.txtRegisterCPass, "Confirm Password is not the same as password"); }
                if (txtRegisterName.Text.Trim().Equals("")) { errorProvider4.SetError(this.txtRegisterName, "Full Name can't be null"); }
                if (txtPhone.Text.Trim().Equals("")) { errorProvider5.SetError(this.txtPhone, "Phone Number can't be null"); }
            }
            else
            {
                // Test Pass và Confirm Pass xem có giống nhau không
                if (String.Compare(pass1, pass2) == 0)
                {
                    // kết nối database
                    DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                    DataProvider.cn.Open();
                    try
                    {
                        //Câu lệnh Insert
                        string sql = "Insert into dbo._User(_username, _password, _name, _phone, _role, _yourscore) " + " values (@_username, @_password, @_name, @_phone, @_role , @_yourscore); ";

                        SqlCommand cmd = DataProvider.cn.CreateCommand();
                        cmd.CommandText = sql;
                        int score = 0;
                        // Thực thi Command (Dùng cho delete, insert, update).
                       // int rowCount = cmd.ExecuteNonQuery();

                        cmd.Parameters.Add("@_username", SqlDbType.NChar).Value = txtRegisterUser.Text;
                        cmd.Parameters.Add("@_password", SqlDbType.NChar).Value = txtRegisterPass.Text;
                        cmd.Parameters.Add("@_name", SqlDbType.NChar).Value = txtRegisterName.Text;
                        cmd.Parameters.Add("@_phone", SqlDbType.NChar).Value = (string)txtPhone.Text;
                        cmd.Parameters.Add("@_role", SqlDbType.NChar).Value = "......User......";
                        cmd.Parameters.Add("@_yourscore", SqlDbType.NChar).Value = score;
                       
                        //Thực thi thủ tục
                      int  rowCount = cmd.ExecuteNonQuery();
                       
                        bunifuCustomLabel1.ForeColor = Color.Green;
                        bunifuCustomLabel1.Text = "Register Complete!";
                    }
                    catch
                    {
                        bunifuCustomLabel1.ForeColor = Color.Red;
                        bunifuCustomLabel1.Text = "The account is already exist!";
                    }
                    finally
                    {
                        this.txtRegisterUser.Text = "";
                        this.txtRegisterName.Text = "";
                        this.txtPhone.Text = "";
                        DataProvider.cn.Close();
                        DataProvider.cn.Dispose();
                        DataProvider.cn = null;
                    }
                }
                else
                {
                    bunifuCustomLabel1.ForeColor = Color.Red;
                    bunifuCustomLabel1.Text = "Confirm Password is not correct!";
                }
                
            }
        }

        public void form_close(object sender, EventArgs e)
        {
            
            //this.Show();
        }
        //Xử Lí Hàm Đăng Nhập
        public int score,Ascore;
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUser.Text.Trim().Equals("") || txtLoginPass.Text.Trim().Equals(""))
            {
                if (txtLoginUser.Text.Trim().Equals("")) { errorProvider6.SetError(this.txtLoginUser, "Username can't be null"); }
                if (txtLoginPass.Text.Trim().Equals("")) { errorProvider7.SetError(this.txtLoginPass, "Password  can't be null"); }
            }
            else
            {
                DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                DataProvider.cn.Open();
                try
                {
                    string sql = "Select _role from dbo._User where _username = @_username and _password = @_password; ";
                    SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                    cmd.Parameters.Add("@_username", SqlDbType.NChar).Value = txtLoginUser.Text;
                    cmd.Parameters.Add("@_password", SqlDbType.NChar).Value = txtLoginPass.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            string role = reader.GetString(0);
                            string _user = txtLoginUser.Text.Trim();
                            //Khoas chinh trong DB
                            Form1.username = _user;
                            Form1.user.ContainsKey(_user);
                            User kh = new User();
                            Form1.user.Add(Form1.username, kh);
                            Form1.NoLogin = false;
                            
                            if (String.Compare(role.Trim(), "......User......") == 0)
                            {
                               // form.FormClosed += new FormClosedEventHandler(form_close);
                                this.Hide();                               
                                form.Show();                                
                            }
                        }
                        else
                        {
                            bunifuCustomLogin.ForeColor = Color.Red;
                            bunifuCustomLogin.Text = "Username or Password is incorrect!";
                        }
                    }
                }
                catch
                {
                    bunifuCustomLogin.ForeColor = Color.Red;
                    bunifuCustomLogin.Text = "ERROR!";
                }
                finally
                {
                    this.txtLoginUser.Text = "";
                    this.txtLoginPass.Text = "";
                    DataProvider.cn.Close();
                    DataProvider.cn.Dispose();
                }
            }
        }
        //Hàm để sử dụng trong so sánh
        public void U_Score()
        {
            // foreach (KeyValuePair<string, User> entry in Form1.user) Dung De Lap lai Dictionary
            foreach (KeyValuePair<string, User> entry in Form1.user)
            {
                DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                DataProvider.cn.Open();
                if (!Form1.user.ContainsKey(Form1.username)) { return; }
                _uname = entry.Key;
                try
                {
                    string sql = @"select _yourscore from _User where _username = '" + _uname + "'";
                    SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            score = reader.GetInt32(0);
                            Form1.uscore = score;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR!");
                }
                finally
                {

                    DataProvider.cn.Close();
                    DataProvider.cn.Dispose();
                }
                break;
            }
        
        }
        // Across Beginner - 16 points
        #region Button IM IM_Score 
        public void IM_Score()
        {
            DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            DataProvider.cn.Open();
            try
            {
                string sql = "Select _LocationScrore from dbo._Score where _idScore  = 'BS001'; ";
                SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                //cmd.Parameters.Add("@_username", SqlDbType.NChar).Value = txtLoginUser.Text;
                //cmd.Parameters.Add("@_password", SqlDbType.NChar).Value = txtLoginPass.Text;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int score_S = reader.GetInt32(0);
                        //string _user = txtLoginUser.Text.Trim();
                        //Form1.username = _user;
                        Form1.fscore = score_S;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            finally
            {
                this.txtLoginUser.Text = "";
                DataProvider.cn.Close();
                DataProvider.cn.Dispose();
            }
        }
        #endregion
        // Across Conditional - 27 points
        #region DataType
        public void DT_Score()
        {
            DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            DataProvider.cn.Open();
            try
            {
                string sql = "Select _LocationScrore from dbo._Score where _idScore  = 'BS002'; ";
                SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                //cmd.Parameters.Add("@_username", SqlDbType.NChar).Value = txtLoginUser.Text;
                //cmd.Parameters.Add("@_password", SqlDbType.NChar).Value = txtLoginPass.Text;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int score_S = reader.GetInt32(0);
                        //string _user = txtLoginUser.Text.Trim();
                        //Form1.username = _user;
                        Form1.fscore = score_S;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            finally
            {
                this.txtLoginUser.Text = "";
                DataProvider.cn.Close();
                DataProvider.cn.Dispose();
            }
        }
        #endregion
        
        // Across DataType - 47 points
        #region Button Advance AD_Score
        public void AD_Score()
        {
            DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            DataProvider.cn.Open();
            try
            {
                string sql = "Select _LocationScrore from dbo._Score where _idScore  = 'BS003'; ";
                SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                //cmd.Parameters.Add("@_username", SqlDbType.NChar).Value = txtLoginUser.Text;
                //cmd.Parameters.Add("@_password", SqlDbType.NChar).Value = txtLoginPass.Text;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int score_S = reader.GetInt32(0);
                        //string _user = txtLoginUser.Text.Trim();
                        //Form1.username = _user;
                        Form1.fscore = score_S;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            finally
            {
                this.txtLoginUser.Text = "";
                DataProvider.cn.Close();
                DataProvider.cn.Dispose();
            }
        }
        #endregion

        // Across Function - 65 points
        #region Button Procident
        public void Pro_Score()
        {
            DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            DataProvider.cn.Open();
            try
            {
                string sql = "Select _LocationScrore from dbo._Score where _idScore  = 'BS005'; ";
                SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                //cmd.Parameters.Add("@_username", SqlDbType.NChar).Value = txtLoginUser.Text;
                //cmd.Parameters.Add("@_password", SqlDbType.NChar).Value = txtLoginPass.Text;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int score_S = reader.GetInt32(0);
                        //string _user = txtLoginUser.Text.Trim();
                        //Form1.username = _user;
                        Form1.fscore = score_S;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fail");
            }
            finally
            {
                this.txtLoginUser.Text = "";
                DataProvider.cn.Close();
                DataProvider.cn.Dispose();
            }
        }
        #endregion
        private void txtRegisterUser_Click(object sender, EventArgs e)
        { 
            txtRegisterUser.Clear();
        }
    
    }
}
