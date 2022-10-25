using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for danhmuctincha
/// </summary>
namespace DongPhucKhanhLinh
{
    public class danhmuctincha
    {
        //public static void danhmuccha_insert(string tendmcha)
        //{

        //    OleDbCommand cmd = new OleDbCommand("danhmucha_insert");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@tendmcha", tendmcha);
        //    SQLDatabase.ExecuteNoneQuery(cmd);
        //}
        //public static void danhmuccha_Update(string madmcha, string tendmcha)
        //{

        //    OleDbCommand cmd = new OleDbCommand("danhmuccha_update");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@madmcha", madmcha);
        //    cmd.Parameters.AddWithValue("@tendmcha", tendmcha);
        //    SQLDatabase.ExecuteNoneQuery(cmd);
        //}
        //public static DataTable thongtin_danhmuccha_id(string madmcha)
        //{
        //    OleDbCommand cmd = new OleDbCommand("thongtin_danhmuccha_id");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@madmcha", madmcha);
        //    return SQLDatabase.GetData(cmd);
        //}
        //public static void danhmuccha_del(string madmcha)
        //{
        //    OleDbCommand cmd = new OleDbCommand("danhmuccha_del");
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@madmcha", madmcha);
        //    SQLDatabase.ExecuteNoneQuery(cmd);
        //}
        public static DataTable Thongtin_danhmuccha()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctincha");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}
