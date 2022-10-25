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
    public class CongNghe
    {
        public static DataTable Thongtin_congnghe()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_congnghe");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void congnghe_insert(string tencn, string motacn, string link)
        {

            OleDbCommand cmd = new OleDbCommand("congnghe_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tencn", tencn);
            cmd.Parameters.AddWithValue("@motacn", motacn);
            cmd.Parameters.AddWithValue("@link", link);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void congnghe_Update(string macn, string tencn, string motacn, string link)
        {

            OleDbCommand cmd = new OleDbCommand("congnghe_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@macn", macn);
            cmd.Parameters.AddWithValue("@tencn", tencn);
            cmd.Parameters.AddWithValue("@motacn", motacn);
            cmd.Parameters.AddWithValue("@link", link);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_congnghe_id(string macn)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_congnghe_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@macn", macn);
            return SQLDatabase.GetData(cmd);
        }
        public static void congnghe_del(string macn)
        {
            OleDbCommand cmd = new OleDbCommand("congnghe_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@macn", macn);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}