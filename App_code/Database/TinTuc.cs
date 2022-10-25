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
    public class TinTuc
    {
        public static DataSet GetDataPaging(string pageIndex, string pageSize, string whereClause, string orderBy)
        {
            var cmd = new OleDbCommand("TinTuc_GetDataPaging") { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
            cmd.Parameters.AddWithValue("@pageSize", pageSize);
            cmd.Parameters.AddWithValue("@whereClause", whereClause);
            cmd.Parameters.AddWithValue("@orderBy", orderBy);
            return SQLDatabase.GetData_OverDataset(cmd);
        }
        public static DataTable Thongtin_tintuc()
        {
            OleDbCommand cmd = new OleDbCommand("Thongtin_tintuc");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void tintuc_insert(string tentintuc, string mota, string madmtin, string ngaytao, string luotxem, string link, string anhtintuc, string chitiettin)
        {

            OleDbCommand cmd = new OleDbCommand("tintuc_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tentintuc", tentintuc);
            cmd.Parameters.AddWithValue("@mota", mota);
            cmd.Parameters.AddWithValue("@madmtin", madmtin);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@luotxem", luotxem);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@anhtintuc", anhtintuc);
            cmd.Parameters.AddWithValue("@chitiettin", chitiettin);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        
        public static void tintuc_Update(string matintuc, string tentintuc, string mota, string madmtin, string ngaytao, string luotxem, string link, string anhtintuc, string chitiettin)
        {

            OleDbCommand cmd = new OleDbCommand("tintuc_Update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@matintuc", matintuc);
            cmd.Parameters.AddWithValue("@tentintuc", tentintuc);
            cmd.Parameters.AddWithValue("@mota", mota);
            cmd.Parameters.AddWithValue("@madmtin", madmtin);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@luotxem", luotxem);
            cmd.Parameters.AddWithValue("@link", link);
            cmd.Parameters.AddWithValue("@anhtintuc", anhtintuc);
            cmd.Parameters.AddWithValue("@chitiettin", chitiettin);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_tintuc_id(string matintuc)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@matintuc", matintuc);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_tintuc_madmtin(string madmtin, string matintuc)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_dmsp");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmtin", madmtin);
            cmd.Parameters.AddWithValue("@matintuc", matintuc);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_tintuc_4(string madmtin, string SoTinHienThi)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_4");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmtin", madmtin);
            cmd.Parameters.AddWithValue("@SoTinHienThi", SoTinHienThi);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_tintuc_1(string madmtin, string SoTinHienThi)
        {
            OleDbCommand cmd = new OleDbCommand("tintuc_1");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmtin", madmtin);
            cmd.Parameters.AddWithValue("@SoTinHienThi", SoTinHienThi);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_tintuc_5()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_5");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }

        public static void tintuc_del(string matintuc)
        {
            OleDbCommand cmd = new OleDbCommand("tintuc_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@matintuc", matintuc);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void CapNhatLuotXemTinTuc(string matintuc)
        {
            OleDbCommand cmd = new OleDbCommand("CapNhatLuotXemTinTuc");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@matintuc", matintuc);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}