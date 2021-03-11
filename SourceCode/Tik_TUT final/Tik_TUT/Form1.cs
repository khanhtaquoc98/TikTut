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

namespace Tik_TUT
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, User> user = null;
        public static string username = "";
        public static int uscore,fscore;
        public static string login = "";
        public static bool NoLogin = true;
        public static bool home = true;
        public static bool Correct = true;
        public static bool Test = false, Important =false;
        public static int _c1, _c2, _c3;
        public static int bScore = 1;
        public static bool check_76 = true;
        #region check
        public static bool check = true; 
        public static bool check_2 = true;
        public static bool check_3 = true;
        public static bool check_4 = true;
        public static bool check_5 = true;
        public static bool check_6 = true;
        public static bool check_7 = true;
        public static bool check_8 = true;
        public static bool check_9 = true;
        public static bool check_10 = true;
        public static bool check_11= true;
        public static bool check_12= true;
        public static bool check_13= true;
        public static bool check_14= true;
        public static bool check_15= true;
        public static bool check_16= true;
        public static bool check_17= true;
        public static bool check_18= true;
        public static bool check_19= true;
        public static bool check_20= true;
        public static bool check_21= true;
        public static bool check_22 = true;
        public static bool check_23 = true;
        public static bool check_24 = true;
        public static bool check_25 = true;
        public static bool check_26 = true;
        public static bool check_27 = true;
        public static bool check_28 = true;
        public static bool check_29 = true;
        public static bool check_30= true;
        public static bool check_31 = true;
        public static bool check_32 = true;
        public static bool check_33 = true;
        #endregion
        public Form1()
        {
            InitializeComponent();
            user = new Dictionary<string, User>();
            //   uC_Profile = new User_Control.UC_Profile();
            //account();
        }
        public void account()
        {
            if (NoLogin)
            {
                return;
            }
            pictureBox2.Visible = false;

        }
        #region Check2
        public static bool check_34 = true;
        public static bool check_35 = true;
        public static bool check_36 = true;
        public static bool check_37 = true;
        public static bool check_38 = true;
        public static bool check_39 = true;
        public static bool check_40 = true;
        public static bool check_41 = true;
        public static bool check_42 = true;
        public static bool check_43 = true;
        public static bool check_44 = true;
        public static bool check_45 = true;
        public static bool check_46 = true;
        public static bool check_47 = true;
        public static bool check_48 = true;
        public static bool check_49 = true;
        public static bool check_50 = true;
        public static bool check_51 = true;
        public static bool check_52 = true;
        public static bool check_53 = true;
        public static bool check_54 = true;
        public static bool check_55 = true;
        public static bool check_56 = true;
        public static bool check_57 = true;
        public static bool check_58 = true;
        public static bool check_59 = true;
        public static bool check_60 = true;
        public static bool check_61 = true;
        public static bool check_62 = true;
        public static bool check_63 = true;
        public static bool check_64 = true;
        public static bool check_65 = true;
        public static bool check_66 = true;
        public static bool check_67 = true;
        public static bool check_68 = true;
        public static bool check_69 = true;
        public static bool check_70 = true;
        public static bool check_71 = true;
        public static bool check_72 = true;
        public static bool check_73 = true;
        public static bool check_74 = true;
        public static bool check_75 = true;
        #endregion

        #region     " Click Button Beginner "
        private void button3_Click(object sender, EventArgs e)
        {
            if (NoLogin)
            {
                MessageBox.Show("You have to Login first!"); return;                
            }
            ucBeginner1.BringToFront();            
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            ucHome1.BringToFront();
        }
        #region " Click Button Intermediate"
        private void button6_Click(object sender, EventArgs e)
        {
            if (NoLogin)
            {
                MessageBox.Show("You have to Login first!"); return;
            }
            DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            DataProvider.cn.Open();

            try            {

                //int b = int.Parse(cmd2.ExecuteScalar().ToString());
                uC_Profile.U_Score();
                uC_Profile.IM_Score();
                if (fscore <= uscore)
                {
                    ucIntermediate1.BringToFront();
                }
                else
                {
                    MessageBox.Show(" You have to pass section Printing a Text in Beginner!");
                }
            }
            catch
            {
                MessageBox.Show(" ERROR");
            }
            finally
            {
                DataProvider.cn.Close();
                DataProvider.cn.Dispose();
            }          
            
        }
        #endregion
        #region " Click Button Advanced"
        private void button4_Click(object sender, EventArgs e)
        {
            if (NoLogin)
            {
               
                MessageBox.Show("You have to Login first!"); return;
            }
            // ucAdvanced1.BringToFront();
            DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            DataProvider.cn.Open();

            try
            {
                uC_Profile.U_Score();
                uC_Profile.AD_Score();
                if (fscore < uscore)
                {
                    ucAdvanced1.BringToFront();
                }
                else
                {
                    MessageBox.Show(" You have to pass section (String, Bool, Char) in DataType");
                }
            }
            catch
            {
                MessageBox.Show(" ERROR");
            }
            finally
            {
                DataProvider.cn.Close();
                DataProvider.cn.Dispose();
            }
        }
        #endregion
        #region " Click Button Proficient"
        private void button8_Click(object sender, EventArgs e)
        {
            if (NoLogin)
            {
                MessageBox.Show("You have to Login first!");
                    return;                
            }
            //usProficient1.BringToFront();
            DataProvider.cn = new SqlConnection(DataProvider.cnStr);
            DataProvider.cn.Open();

            try
            {
                uC_Profile.U_Score();
                uC_Profile.Pro_Score();
                if (fscore < uscore)
                {
                    usProficient1.BringToFront();
                }
                else
                {
                    MessageBox.Show(" You have to pass Advanced");
                }
            }
            catch
            {
                MessageBox.Show(" ERROR");
            }
            finally
            {
                DataProvider.cn.Close();
                DataProvider.cn.Dispose();
            }
            
        }
        #endregion
        private void Button_Close_Click(object sender, EventArgs e)
        {
            //this.Close();
            DialogResult reset = MessageBox.Show("Do you really want to exit TikTut?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (reset == DialogResult.OK)
            {
                Application.Exit();
            }
            if (reset == DialogResult.Cancel)
            {
                
            }
            
        }
        #region Event Click
        private void Button_StarLearning_Click(object sender, EventArgs e)
        {
            ucBeginner1.BringToFront();
        }

        private void Button_Proflie_Click(object sender, EventArgs e)
        {
            uC_Profile.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // if (NoLogin)
            //{
              //  MessageBox.Show("Please Login First!!! If You Don't Account, You Will Create Account"); return;

//            }
            uc_CTutorial.BringToFront();           
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            uC_Profile.BringToFront();
        }        

        private void button9_Click(object sender, EventArgs e)
        {
            ucGuide1.BringToFront();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ucTeam1.BringToFront();
        }
        #endregion

        //Load Form1
        private void Form1_Load(object sender, EventArgs e)
        {                  
            ucHome1.BringToFront();
            account();           
        }
      

        private void button5_Click(object sender, EventArgs e)
        {
            ucAbout1.BringToFront();
        }
        #region Dang Xuat
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (NoLogin) return;
            DialogResult reset = MessageBox.Show("Do you want to log out ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(reset == DialogResult.OK)
            {
                NoLogin = true;
                Form1 f = new Form1();
                //this.home = true;
                f.Show();
            }
            if (reset == DialogResult.Cancel)
            {

            }
        }
        #endregion
    }
}
