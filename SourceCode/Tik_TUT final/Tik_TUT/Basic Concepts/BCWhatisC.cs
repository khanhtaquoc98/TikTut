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
    public partial class BCWhatisC : Form
    {
        public static Dictionary<string, Button> btn = new Dictionary<string, Button>();
        public string _uname = "";
        public int a;
        
        public BCWhatisC()
        {
            InitializeComponent();
            if (!Form1.check)
            {
                materialRadioButton1.Checked = true;
                materialRadioButton1.ForeColor = Color.GreenYellow;
                materialRadioButton1.Enabled = false;
                txtSub.Visible = false;
                Form1.check = true;
            }
         
        }
        private User_Control.UC_Profile u = new User_Control.UC_Profile();
        private A_Manager.BasicConcepts b = new A_Manager.BasicConcepts();
        
        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            b.Show();
        }
        public bool BC_C()
        {
            return Form1.Correct;
        }
        private void txtSub_Click(object sender, EventArgs e)
        {
           
            if (materialRadioButton1.Checked == true)
            {

                //DataProvider.cn = new SqlConnection(DataProvider.cnStr);
                //DataProvider.cn.Open();
                //    string sql = "Select _yourscore from dbo._User where _username = @_username and _password = @_password; ";
                //    SqlCommand cmd = new SqlCommand(sql, DataProvider.cn);
                //  //  cmd.Parameters.Add("@_yourscore", SqlDbType.Int).Value = 1;

                //    // Tao mot doi tuong Parameter, luu tru gia tri tra ve
                //    SqlParameter resultParam = new SqlParameter("@_yourscore", SqlDbType.Int);
                //    resultParam.Direction = ParameterDirection.ReturnValue;
                //    Form1.uscore++;
                //    Form1.uscore = resultParam.Value; 
                //    cmd.Parameters.Add(resultParam);
                //    int rowCount = cmd.ExecuteNonQuery();
                //  Form1.user[_uname].username;

                //  a = Form1.user[Form1.username].score_;

                foreach (KeyValuePair<string, User> entry in Form1.user)
                {
                    if (!Form1.user.ContainsKey(Form1.username)) { return; }
                    {
                        _uname = entry.Key;

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
                            materialRadioButton1.Checked = true;
                            materialRadioButton1.ForeColor = Color.GreenYellow;
                            materialRadioButton1.Enabled = false;
                            
                            DialogResult reset = MessageBox.Show("Correct", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (reset == DialogResult.OK)
                            {
                                Form1.home = false;
                                this.Close();
                                b.Show();
                            }
                            //if (reset == DialogResult.Cancel)
                            //{

                            //}
                            DataProvider.cn.Close();
                        }
                    }

                    break;
                }

            }
            }

        
   }
}

