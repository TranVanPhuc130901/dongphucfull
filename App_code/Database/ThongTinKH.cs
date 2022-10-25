using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KhachHang
/// </summary>
namespace DongPhucKhanhLinh
{
    public class ThongTinKH
    {
        public static void thongtinKH_insert(string tenkh, string diachi, string sdtkh, string email, string matkhau)
        {

            OleDbCommand cmd = new OleDbCommand("khachhang_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@diachikh", diachi);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }

        public static DataTable thongtin_khachhang_email(string email)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhang_email");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            return SQLDatabase.GetData(cmd);
        }
    }
}
