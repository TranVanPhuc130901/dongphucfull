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
    public class Logo
    {
        public static DataTable Thongtin_Logo()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_logo");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void logo_insert(string tenlogo, string anhlogo)
        {

            OleDbCommand cmd = new OleDbCommand("logo_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@anhlogo", anhlogo);
            cmd.Parameters.AddWithValue("@tenlogo", tenlogo);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void logo_Update(string malogo, string tenlogo, string anhlogo)
        {

            OleDbCommand cmd = new OleDbCommand("logo_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malogo", malogo);
            cmd.Parameters.AddWithValue("@anhlogo", anhlogo);
            cmd.Parameters.AddWithValue("@tenlogo", tenlogo);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_logo_id(string malogo)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_logo_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malogo", malogo);
            return SQLDatabase.GetData(cmd);
        }
        public static void logo_del(string malogo)
        {
            OleDbCommand cmd = new OleDbCommand("logo_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malogo", malogo);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}