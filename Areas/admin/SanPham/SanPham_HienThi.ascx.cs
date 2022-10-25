using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DongPhucKhanhLinh;
using Extensions;

public partial class Areas_admin_SanPham_SanPham_HienThi : UserControl
{
    private string _p = "1";
    protected void Page_Load(object sender, EventArgs e)
    {
        // Bắt request trang hiện tại trên URL
        if (Request.Params["p"] != null) _p = Request.Params["p"];
        if (IsPostBack) return;
        LayBanner();
    }

    private void LayBanner()
    {
        var pageSize = "2"; // Số sản phẩm trên 1 trang
        var condition = ""; // Điều kiện lấy sản phẩm, có thể lấy theo mã danh mục hoặc trạng thái on/off của sản phẩm
        var orderBy = ""; // Trường sắp xếp kết quả
        var ds = SanPham.GetDataPaging(_p, pageSize, condition, orderBy);
        var dt = ds.Tables[0];
        for (var i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='masp' id='ma" + dt.Rows[i]["MaSP"] + @"'>
               <td >" + dt.Rows[i]["TenSP"] + @" </td>
                <td >" + dt.Rows[i]["MaDMSP"] + @" </td>
                <td >" + dt.Rows[i]["MoTa"] + @" </td>
                <td >" + dt.Rows[i]["MauSac"] + @" </td>
                <td >" + dt.Rows[i]["Size"] + @" </td>
                <td >" + dt.Rows[i]["KhuyenMai"] + @" </td>
               <td class='image'><img src='pic/SanPham/" + dt.Rows[i]["AnhSP"] + @"'/></td>
                <td >" + NumberExtension.FormatNumber(dt.Rows[0]["Gia"].ToString(), true, "Liên hệ", "vnđ") + @" </td>
                <td >" + NumberExtension.FormatNumber(dt.Rows[0]["GiaKM"].ToString(), true, "Liên hệ", "vnđ") + @" </td>
              
            <td>
                <a href='Admin.aspx?dm=sanpham&cn=sua&id=" + dt.Rows[i]["MaSP"] + @"'>Sửa</a>
            <a href=javascript:XoaSanPham(" + dt.Rows[i]["MaSP"] + @",'" + dt.Rows[i]["AnhSP"] + @"')>Xoá</a></td>
         </tr>";
        }

        #region Get data paging

        var dtPager = ds.Tables[1];
        var totalRows = dtPager.Rows[0]["TotalRows"].ToString();
        ltrPaging.Text += PagingExtensions.SpilitPagesNoRewrite(Convert.ToInt32(totalRows), Convert.ToInt32(pageSize), Convert.ToInt32(_p), "/Admin.aspx?dm=sanpham", "active", "normal", "first", "last", "preview", "next");

        #endregion
    }
}