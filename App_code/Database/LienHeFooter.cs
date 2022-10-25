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
    public class LienHe_Footer
    {
        public static DataTable Thongtin_lienhe_footer()
        {
            OleDbCommand cmd = new OleDbCommand("Thongtin_lienhe_footer");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void lienhe_footer_insert(string diachi, string email, string sodienthoai, string diachiweb)
        {

            OleDbCommand cmd = new OleDbCommand("lienhe_footer_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sodienthoai", sodienthoai);
            cmd.Parameters.AddWithValue("@diachiweb", diachiweb);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void lienhe_footer_Update(string malienhe, string diachi, string email, string sodienthoai, string diachiweb)
        {

            OleDbCommand cmd = new OleDbCommand("lienhe_footer_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malienhe", malienhe);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@sodienthoai", sodienthoai);
            cmd.Parameters.AddWithValue("@diachiweb", diachiweb);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_lienhe_footer_id(string malienhe)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_lienhe_footer_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malienhe", malienhe);
            return SQLDatabase.GetData(cmd);
        }
        public static void lienhe_footer_del(string malienhe)
        {
            OleDbCommand cmd = new OleDbCommand("lienhe_footer_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@malienhe", malienhe);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}