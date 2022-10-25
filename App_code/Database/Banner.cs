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
    public class Banner
    {
        public static void banner_unactive(string mabanner, string trangthai)
        {

            OleDbCommand cmd = new OleDbCommand("banner_unactive");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mabanner", mabanner);

            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable Thongtin_Banner()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_banner");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void banner_insert(string anhbanner, string tenbanner)
        {

            OleDbCommand cmd = new OleDbCommand("banner_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenbanner", tenbanner);
            cmd.Parameters.AddWithValue("@anhbanner", anhbanner);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void banner_Update(string mabanner, string anhbanner, string tenbanner)
        {

            OleDbCommand cmd = new OleDbCommand("banner_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mabanner", mabanner);
            cmd.Parameters.AddWithValue("@tenbanner", tenbanner);
            cmd.Parameters.AddWithValue("@anhbanner", anhbanner);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_banner_id(string mabanner)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_banner_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mabanner", mabanner);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable banner_del_img(string anhbanner)
        {
            OleDbCommand cmd = new OleDbCommand("banner_del_img");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@anhbanner", anhbanner);
            return SQLDatabase.GetData(cmd);
        }
        public static void banner_del(string mabanner)
        {
            OleDbCommand cmd = new OleDbCommand("banner_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mabanner", mabanner);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}