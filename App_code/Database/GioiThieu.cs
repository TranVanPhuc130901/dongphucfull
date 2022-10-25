using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Banner
/// </summary>
namespace DongPhucKhanhLinh
{
    public class GioiThieu
    {
        public static DataTable Thongtin_gioithieu()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_gioithieu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void gioithieu_insert(string tengioithieu, string ngaytao, string luotxem, string mota, string madmgt, string anhgt,string chitiet)
        {

            OleDbCommand cmd = new OleDbCommand("gioithieu_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tengioithieu", tengioithieu);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@luotxem", luotxem);
            cmd.Parameters.AddWithValue("@mota", mota);
            cmd.Parameters.AddWithValue("@madmgt", madmgt);
            cmd.Parameters.AddWithValue("@anhgt", anhgt);
            cmd.Parameters.AddWithValue("@chitiet", chitiet);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void gioithieu_Update(string magioithieu, string tengioithieu, string ngaytao, string luotxem, string mota, string madmgt, string anhgt, string chitiet)
        {

            OleDbCommand cmd = new OleDbCommand("gioithieu_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@magioithieu", magioithieu);
            cmd.Parameters.AddWithValue("@tengioithieu", tengioithieu);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@luotxem", luotxem);
            cmd.Parameters.AddWithValue("@mota", mota);
            cmd.Parameters.AddWithValue("@madmgt", madmgt);
            cmd.Parameters.AddWithValue("@anhgt", anhgt);
            cmd.Parameters.AddWithValue("@chitiet", chitiet);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_gioithieu_id(string magioithieu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_gioithieu_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@magioithieu", magioithieu);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_gioithieu_madmcha(string madmgt)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_gioithieu_dmcha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmgt", madmgt);
            return SQLDatabase.GetData(cmd);
        }
        public static void gioithieu_del(string magioithieu)
        {
            OleDbCommand cmd = new OleDbCommand("gioithieu_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@magioithieu", magioithieu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void CapNhatLuotXemGioiThieu(string magioithieu)
        {
            OleDbCommand cmd = new OleDbCommand("CapNhatLuotXemGioiThieu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@magioithieu", magioithieu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}