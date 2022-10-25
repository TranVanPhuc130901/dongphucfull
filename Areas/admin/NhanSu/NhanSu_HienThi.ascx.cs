using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_NhanSu_NhanSu_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.NhanSu.Thongtin_nhansu();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='manhansu' id='ma" + dt.Rows[i]["MaNhanSu"] + @"'>
<td >" + dt.Rows[i]["MaNhanSu"] + @" </td>
               <td >" + dt.Rows[i]["TenNhanSu"] + @" </td>
               <td class='image'><img src='pic/NhanSu/" + dt.Rows[i]["AnhNhanSu"] + @"'/></td>
                <td >" + dt.Rows[i]["ViTri"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=nhansu&cn=sua&id=" + dt.Rows[i]["MaNhanSu"] + @"'>Sửa</a>
                <a href='javascript:XoaNhanSu(" + dt.Rows[i]["MaNhanSu"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }

    protected void btTimKiem_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.NhanSu.Thongtin_nhansu();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (tbtimkiem.Text == dt.Rows[i]["TenNhanSu"].ToString())
            {
                littimkiem.Text += @"
 <table>Kết Quả Tìm Kiếm
        <tr class='manhansu' style='margin-bottom: 40px' id='ma" + dt.Rows[i]["MaNhanSu"] + @"'>
<td >" + dt.Rows[i]["MaNhanSu"] + @" </td>
               <td >" + dt.Rows[i]["TenNhanSu"] + @" </td>
               <td class='image'><img src='pic/NhanSu/" + dt.Rows[i]["AnhNhanSu"] + @"'/></td>
                <td >" + dt.Rows[i]["ViTri"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=nhansu&cn=sua&id=" + dt.Rows[i]["MaNhanSu"] + @"'>Sửa</a>
                <a href='javascript:XoaNhanSu(" + dt.Rows[i]["MaNhanSu"] + @")'>Xoá</a></td>
         </tr>
</table>
";
            }
        }
    }

}