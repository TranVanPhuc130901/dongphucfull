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
    public class AnhSP
    {
        public static DataTable Thongtin_anhsp()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_anhsp");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void anhsp_insert(string masp, string anhsp)
        {

            OleDbCommand cmd = new OleDbCommand("anhsp_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@anhsp", anhsp);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void anhsp_Update(string maanhsp, string masp, string anhsp)
        {

            OleDbCommand cmd = new OleDbCommand("anhsp_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maanhsp", maanhsp);
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@anhsp", anhsp);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_anhsp_id(string maanhsp)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_anhsp_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maanhsp", maanhsp);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtinanhsanpham_masp(string masp)
        {
            OleDbCommand cmd = new OleDbCommand("thongtinanhsanpham_masp");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            return SQLDatabase.GetData(cmd);
        }
        public static void anhsp_del(string maanhsp)
        {
            OleDbCommand cmd = new OleDbCommand("anhsp_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maanhsp", maanhsp);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}