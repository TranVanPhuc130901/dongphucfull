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
    public class DanhMucSanPham
    {
        public static DataTable Thongtin_danhmucsp()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmucsp");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void danhmucsp_insert(string tendmsp, string anhdmsp, string link, string madmcha, string mota)
        {

            OleDbCommand cmd = new OleDbCommand("danhmucsp_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendmsp", tendmsp);
            cmd.Parameters.AddWithValue("@anhdmsp", anhdmsp);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@madmcha", madmcha);
            cmd.Parameters.AddWithValue("@mota", mota);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void danhmucsp_Update(string madmsp, string tendmsp, string anhdmsp, string link, string madmcha, string mota)
        {

            OleDbCommand cmd = new OleDbCommand("danhmucsp_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmsp", madmsp);
            cmd.Parameters.AddWithValue("@tendmsp", tendmsp);
            cmd.Parameters.AddWithValue("@anhdmsp", anhdmsp);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@madmcha", madmcha);
            cmd.Parameters.AddWithValue("@mota", mota);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_danhmucsp_id(string madmsp)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmucsp_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmsp", madmsp);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_danhmucsp_cha(string madmcha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmucsp_cha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmcha", madmcha);
            return SQLDatabase.GetData(cmd);
        }
        public static void danhmucsp_del(string madmsp)
        {
            OleDbCommand cmd = new OleDbCommand("danhmucsp_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmsp", madmsp);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}