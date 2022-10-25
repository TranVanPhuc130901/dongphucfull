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
    public class DanhMucGioiThieu
    {
        public static DataTable Thongtin_danhmucgt()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmucgioithieu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void danhmucgt_insert(string tendmgt, string link)
        {

            OleDbCommand cmd = new OleDbCommand("danhmucgioithieu_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendmgt", tendmgt);
            cmd.Parameters.AddWithValue("@link", link);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void danhmucgt_Update(string madmgt, string tensmgt, string link)
        {

            OleDbCommand cmd = new OleDbCommand("danhmucgioithieu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmgt", madmgt);
            cmd.Parameters.AddWithValue("@tensmgt", tensmgt);
            cmd.Parameters.AddWithValue("@link", link);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_danhmucgt_id(string madmgt)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmucgioithieu_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmgt", madmgt);
            return SQLDatabase.GetData(cmd);
        }
        public static void danhmucgioithieu_del(string madmgt)
        {
            OleDbCommand cmd = new OleDbCommand("danhmucgioithieu_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmgt", madmgt);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}