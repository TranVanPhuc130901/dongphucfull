using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Menu
/// </summary>
namespace DongPhucKhanhLinh
{
    public class Menu
    {
        public static DataTable Thongtin_menu()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void menu_insert(string tenmenu, string link, string capmenu,  string thutu)
        {

            OleDbCommand cmd = new OleDbCommand("menu_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@ink", link);
            cmd.Parameters.AddWithValue("@capmenu", capmenu);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void menu_Update(string mamenu, string tenmenu, string link, string capmenu, string thutu)
        {

            OleDbCommand cmd = new OleDbCommand("menu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@ink", link);
            cmd.Parameters.AddWithValue("@capmenu", capmenu);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void menu_unactive(string mamenu, string trangthai)
        {

            OleDbCommand cmd = new OleDbCommand("menu_unactive");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
           
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_menu_id(string mamenu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_menu_capmenu(string capmenu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_capmenu");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@capmenu", capmenu);
            return SQLDatabase.GetData(cmd);
        }
        public static void menu_del(string mamenu)
        {
            OleDbCommand cmd = new OleDbCommand("menu_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}