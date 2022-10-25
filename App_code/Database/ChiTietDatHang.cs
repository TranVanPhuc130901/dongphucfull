using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ChiTietDatHang
/// </summary>
namespace DongPhucKhanhLinh
{
    public class ChiTietDatHang
    {
        public static void ctdathang_insert(string masp, string madondathang)
        {

            OleDbCommand cmd = new OleDbCommand("chitietdathang_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}