using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MenuCap1
/// </summary>
namespace DongPhucKhanhLinh
{
    public class MenuCap1
    {
        public static DataTable thongtin_menu_masubmenu2(string masubmenu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_masubmenu2");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masubmenu", masubmenu);
            return SQLDatabase.GetData(cmd);
        }
    }
}