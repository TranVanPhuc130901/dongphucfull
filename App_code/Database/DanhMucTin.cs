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
    public class DanhMucTin
    {
        public static DataTable Thongtin_danhmuctin()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctin");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void danhmuctin_insert(string tendmtin, string madmtincha)
        {

            OleDbCommand cmd = new OleDbCommand("danhmuctin_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendmtin", tendmtin);
            cmd.Parameters.AddWithValue("@madmtincha", madmtincha);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void danhmuctin_Update(string madmtin, string tendmtin, string madmtincha)
        {

            OleDbCommand cmd = new OleDbCommand("danhmuctin_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmtin", madmtin);
            cmd.Parameters.AddWithValue("@tendmtin", tendmtin);
            cmd.Parameters.AddWithValue("@madmtincha", madmtincha);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_danhmuctin_id(string madmtin)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctin_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmtin", madmtin);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_danhmuctin_cha(string madmtincha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctin_cha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmtincha", madmtincha);
            return SQLDatabase.GetData(cmd);
        }

        public static DataTable thongtin_tintuc_1(string madmtin, string SoTinHienThi)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_1");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmtin", madmtin);
            cmd.Parameters.AddWithValue("@SoTinHienThi", SoTinHienThi);
            return SQLDatabase.GetData(cmd);
        }
        public static void danhmuctin_del(string madmtin)
        {
            OleDbCommand cmd = new OleDbCommand("danhmuctin_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmtin", madmtin);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}