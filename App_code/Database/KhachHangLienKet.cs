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
    public class KhachHangLienKet
    {
        public static DataTable Thongtin_khachhanglienket()
        {
            OleDbCommand cmd = new OleDbCommand("Thongtin_khachhanglienket");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void khachhanglienket_insert(string tenkhlienket, string anhkhlienket, string link)
        {

            OleDbCommand cmd = new OleDbCommand("khachhanglienket_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenkhlienket", tenkhlienket);
            cmd.Parameters.AddWithValue("@anhkhlienket", anhkhlienket);
            cmd.Parameters.AddWithValue("@link", link);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void khachhanglienket_Update(string makhlienket, string tenkhlienket, string anhkhlienket, string link)
        {

            OleDbCommand cmd = new OleDbCommand("khachhanglienket_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makhlienket", makhlienket);
            cmd.Parameters.AddWithValue("@tenkhlienket", tenkhlienket);
            cmd.Parameters.AddWithValue("@anhkhlienket", anhkhlienket);
            cmd.Parameters.AddWithValue("@link", link);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_khachhanglienket_id(string makhlienket)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhanglienket_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makhlienket", makhlienket);
            return SQLDatabase.GetData(cmd);
        }
        public static void khachhanglienket_del(string makhlienket)
        {
            OleDbCommand cmd = new OleDbCommand("khachhanglienket_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makhlienket", makhlienket);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}