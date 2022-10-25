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
    public class KhachHangDanhGia
    {
        public static DataSet GetDataPaging(string pageIndex, string pageSize, string whereClause, string orderBy)
        {
            var cmd = new OleDbCommand("KhachHang_GetDataPaging") { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
            cmd.Parameters.AddWithValue("@pageSize", pageSize);
            cmd.Parameters.AddWithValue("@whereClause", whereClause);
            cmd.Parameters.AddWithValue("@orderBy", orderBy);
            return SQLDatabase.GetData_OverDataset(cmd);
        }
        public static DataTable Thongtin_khachhangdanhgia()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhangdanhgia");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void khachhangdanhgia_insert(string tendanhgia, string anhdanhgia, string link)
        {

            OleDbCommand cmd = new OleDbCommand("khachhangdanhgia_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendanhgia", tendanhgia);
            cmd.Parameters.AddWithValue("@anhdanhgia", anhdanhgia);
            cmd.Parameters.AddWithValue("@link", link);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void khachhangdanhgia_Update(string madanhgia, string tendanhgia, string anhdanhgia, string link)
        {

            OleDbCommand cmd = new OleDbCommand("khachhangdanhgia_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madanhgia", madanhgia);
            cmd.Parameters.AddWithValue("@tendanhgia", tendanhgia);
            cmd.Parameters.AddWithValue("@anhdanhgia", anhdanhgia);
            cmd.Parameters.AddWithValue("@link", link);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_khachhangdanhgia_id(string madanhgia)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhangdanhgia_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madanhgia", madanhgia);
            return SQLDatabase.GetData(cmd);
        }
        public static void khachhangdanhgia_del(string madanhgia)
        {
            OleDbCommand cmd = new OleDbCommand("khachhangdanhgia_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madanhgia", madanhgia);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}