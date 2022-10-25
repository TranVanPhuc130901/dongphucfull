using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TaiKhoan
/// </summary>
namespace DongPhucKhanhLinh
{
    public class TaiKhoan
    {

        public static DataTable Thongtin_DangKy_by_id_matkhau(string tenkh, string matkhau)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_taikhoan_id_matkhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);

            return SQLDatabase.GetData(cmd);
        }

    }
}