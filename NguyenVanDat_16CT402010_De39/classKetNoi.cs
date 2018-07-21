using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace NguyenVanDat_16CT402010_De39
{
    class classKetNoi
    {
        static SqlConnection conn;
        static SqlDataAdapter da;
        static SqlCommand cmd;

        static string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        //hàm kết nối
        static void KetNoi()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        //ham tra ve data lấy từ database
        public static DataTable getData(string sql)
        {
            KetNoi();
            da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        //hàm query sql
        public static void querySql(string sql)
        {
            KetNoi();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        //hàm lấy phần đui Mã các bảng
        public static string getMa(string sql)
        {
            string Ma;
            try
            {
                KetNoi();
                cmd = new SqlCommand(sql, conn);
                Ma = (string)cmd.ExecuteScalar();
                
            }
            catch (Exception)
            {
                Ma = "0";
            }
            conn.Close();
            return Ma;
        }

        //public static SqlDataReader rdr;
        //public static SqlDataReader getTenSP()
        //{
        //    KetNoi();
        //    cmd = new SqlCommand("select")
        //}
    }
}
