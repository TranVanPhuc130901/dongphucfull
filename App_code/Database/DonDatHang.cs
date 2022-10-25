using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DonDatHang
/// </summary>
namespace DongPhucKhanhLinh
{
    public class DonDatHang
    {
        public static void dondathang_insert(string ngaytao, string tinhtrangdonhang, string makh, string tenkh, string sdtkh, string email)
        {

            OleDbCommand cmd = new OleDbCommand("dondathang_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@tinhtrangdonhang", tinhtrangdonhang);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@email", email);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void Dondathang_Update(string madondathang, string ngaytao,  string tinhtrangdonhang, string makh, string tenkh, string sdtkh, string email)
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@tinhtrangdonhang", tinhtrangdonhang);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);

            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", email);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable Thongtin_dathang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_dondathang_id(string madondathang)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDonDatHang", madondathang);
            return SQLDatabase.GetData(cmd);
        }
    }
}
