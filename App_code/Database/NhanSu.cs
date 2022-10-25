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
    public class NhanSu
    {
        public static DataTable Thongtin_nhansu()
        {
            OleDbCommand cmd = new OleDbCommand("Thongtin_nhansu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void nhansu_insert(string tennhansu, string vitri, string anhnhansu)
        {

            OleDbCommand cmd = new OleDbCommand("nhansu_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennhansu", tennhansu);
            cmd.Parameters.AddWithValue("@anhnhansu", anhnhansu);
            cmd.Parameters.AddWithValue("@vitri", vitri);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void nhansu_Update(string manhansu, string tennhansu, string vitri, string anhnhansu)
        {

            OleDbCommand cmd = new OleDbCommand("nhansu_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhansu", manhansu);
            cmd.Parameters.AddWithValue("@tennhansu", tennhansu);
            cmd.Parameters.AddWithValue("@anhnhansu", anhnhansu);
            cmd.Parameters.AddWithValue("@vitri", vitri);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_nhansu_id(string manhansu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhansu_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhansu", manhansu);
            return SQLDatabase.GetData(cmd);
        }
        public static void nhansu_del(string manhansu)
        {
            OleDbCommand cmd = new OleDbCommand("nhansu_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhansu", manhansu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}