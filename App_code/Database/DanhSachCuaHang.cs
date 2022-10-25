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
    public class DanhSachCuaHang
    {
        public static DataTable Thongtin_danhsachcuahang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_cuahang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void danhsachcuahang_insert(string diachi, string sodienthoai, string email, string link, string anhcuahang, string chucnang)
        {

            OleDbCommand cmd = new OleDbCommand("cuahang_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@sodienthoai", sodienthoai);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@anhcuahang", anhcuahang);
            cmd.Parameters.AddWithValue("@chucnang", chucnang);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void danhsachcuahang_Update(string macuahang, string diachi, string sodienthoai, string email, string link, string anhcuahang, string chucnang)
        {

            OleDbCommand cmd = new OleDbCommand("cuahang_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@macuahang", macuahang);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@sodienthoai", sodienthoai);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@anhcuahang", anhcuahang);
            cmd.Parameters.AddWithValue("@chucnang", chucnang);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_danhsachcuahang_id(string macuahang)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_cuahang_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@macuahang", macuahang);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_cuahang_cuahang(string chucnang)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_cuahang_cuahang");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@chucnang", chucnang);
            return SQLDatabase.GetData(cmd);
        }
        public static void danhsachcuahang_del(string macuahang)
        {
            OleDbCommand cmd = new OleDbCommand("cuahang_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@macuahang", macuahang);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}