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
    public class HoTro
    {
        public static DataTable Thongtin_hotro()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_hotro");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void hotro_insert(string hoten, string sodienthoai, string email,string tieude,string noidung)
        {

            OleDbCommand cmd = new OleDbCommand("hotro_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@sodienthoai", sodienthoai);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@tieude", tieude);
            cmd.Parameters.AddWithValue("@noidung", noidung);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void hotro_Update(string mahotro, string hoten, string sodienthoai, string email, string tieude, string noidung)
        {

            OleDbCommand cmd = new OleDbCommand("hotro_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahotro", mahotro);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@sodienthoai", sodienthoai);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@tieude", tieude);
            cmd.Parameters.AddWithValue("@noidung", noidung);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_hotro_id(string mahotro)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_hotro_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahotro", mahotro);
            return SQLDatabase.GetData(cmd);
        }
        public static void hotro_del(string mahotro)
        {
            OleDbCommand cmd = new OleDbCommand("hotro_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahotro", mahotro);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}