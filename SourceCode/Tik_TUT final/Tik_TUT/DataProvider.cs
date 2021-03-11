using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_TUT
{
    class DataProvider
    {

        // Connection String thiết lập các thông số để kết nối.
        public static string cnStr = @"Data Source=.;Initial Catalog=Tik_Tut_3;Integrated Security=True";

        // Tạo kết nối
        public static SqlConnection cn = new SqlConnection(cnStr);

        static public DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable(); //Tạo Một Kho dữ liệu ảo
            cn = new SqlConnection(cnStr);
            SqlCommand cm = new SqlCommand(sql, cn); // Thực hiện câu lệnh truy vấn đến SQL
            SqlDataAdapter da = new SqlDataAdapter(cm); // Lưu dữ liệu lấy được vào đây 
            da.Fill(dt); //Đổ dữ liệu vào kho
            return dt;
        }
        //insert, update, delete
        static public int Change(string sql)
        {
            cn = new SqlConnection(cnStr);
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlCommand cm = new SqlCommand(sql, cn);
            int kq = cm.ExecuteNonQuery();
            cn.Close();
            return kq;

        }
    }
}
