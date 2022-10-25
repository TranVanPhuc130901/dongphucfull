using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MenuCap2
/// </summary>
namespace DongPhucKhanhLinh
{
    public class MenuCap2
    {
        public static DataTable thongtin_menu_menucap2(string mamenu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_menucap2");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            return SQLDatabase.GetData(cmd);
        }

    }
}