using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_TinTuc_TinTuc_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayBanner();
        }
    }

    private void LayBanner()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.TinTuc.Thongtin_tintuc();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='matintuc' id='ma" + dt.Rows[i]["MaTinTuc"] + @"'>
               <td >" + dt.Rows[i]["TenTinTuc"] + @" </td>
               <td >" + dt.Rows[i]["MoTa"] + @" </td>
             <td >" + dt.Rows[i]["MaDMTin"] + @" </td>
             <td >" + dt.Rows[i]["NgayTao"] + @" </td>
             <td >" + dt.Rows[i]["LuotXem"] + @" </td>
            <td class='image'><img src='pic/TinTuc/" + dt.Rows[i]["AnhTinTuc"] + @"'/></td>
            <td class='motatintuc' >" + dt.Rows[i]["ChiTietTin"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=tintuc&cn=sua&id=" + dt.Rows[i]["MaTinTuc"] + @"'>Sửa</a>
                <a href='javascript:XoaTinTuc(" + dt.Rows[i]["MaTinTuc"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}