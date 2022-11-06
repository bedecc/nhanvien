using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace quanlithuvien
{
    class ketnoi
    {
        
        
            private static string stringConnection = @"Data Source=DESKTOP-TRS7FFF;Initial Catalog=QLTV;Integrated Security=True";
            public static SqlConnection taoketnoi()
            {
                SqlConnection conn = new SqlConnection(stringConnection);
                conn.Open();
                return conn;
            }

            public static void thucthi(string sql)
            {
                SqlConnection con = ketnoi.taoketnoi();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }

            public static DataTable truyvan(string sql)
            {
                SqlConnection con = ketnoi.taoketnoi();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = con;
                //datatable là tập hợp các dòng
                // 33, 34,35 có thể thay bằng câu lệnh
                // SqlCommand cmd = new SqlCommand(sql,con)
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
       

}

