using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for Banner
/// </summary>
namespace DongPhucKhanhLinh
{
    public class SanPham
    {
        public static DataSet GetDataPaging(string pageIndex, string pageSize, string whereClause, string orderBy)
        {
            var cmd = new OleDbCommand("SanPham_GetDataPaging"){ CommandType = CommandType.StoredProcedure};
            cmd.Parameters.AddWithValue("@pageIndex", pageIndex);
            cmd.Parameters.AddWithValue("@pageSize", pageSize);
            cmd.Parameters.AddWithValue("@whereClause", whereClause);
            cmd.Parameters.AddWithValue("@orderBy", orderBy);
            return SQLDatabase.GetData_OverDataset(cmd);
        }
        public static DataTable Thongtin_sanpham()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
        public static void sanpham_insert(string tensp, string madmsp, string mota, string mausac, string size, string khuyenmai, string anhsp, string gia, string giakm)
        {

            OleDbCommand cmd = new OleDbCommand("sanpham_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@madmsp", madmsp);
            cmd.Parameters.AddWithValue("@mota", mota);
            cmd.Parameters.AddWithValue("@mausac", mausac);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@khuyenmai", khuyenmai);
            cmd.Parameters.AddWithValue("@anhsp", anhsp);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@giakm", giakm);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static void sanpham_Update(string masp, string tensp, string madmsp, string mota, string mausac, string size, string khuyenmai, string anhsp, string gia, string giakm)
        {

            OleDbCommand cmd = new OleDbCommand("sanpham_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@madmsp", madmsp);
            cmd.Parameters.AddWithValue("@mota", mota);
            cmd.Parameters.AddWithValue("@mausac", mausac);
            cmd.Parameters.AddWithValue("@size", size);
            cmd.Parameters.AddWithValue("@khuyenmai", khuyenmai);
            cmd.Parameters.AddWithValue("@anhsp", anhsp);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@giakm", giakm);

            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public static DataTable thongtin_sanpham_id(string masp)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_sanpham_dmsp(string madmsp, string id)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_dmsp");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmsp", madmsp);
            cmd.Parameters.AddWithValue("@id", id);
            return SQLDatabase.GetData(cmd);
        }

        
        public static DataTable thongtin_sanpham_by_dmid(string madmsp, string SoSPHienThi)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_dmid");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmsp", madmsp);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            return SQLDatabase.GetData(cmd);
        }
        public static DataTable thongtin_sanpham_by_dmid_4(string madmsp, string SoSPHienThi)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_dmid_4");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madmsp", madmsp);
            cmd.Parameters.AddWithValue("@SoSPHienThi", SoSPHienThi);
            return SQLDatabase.GetData(cmd);
        }
        public static void sanpham_del(string masp)
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_del");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}