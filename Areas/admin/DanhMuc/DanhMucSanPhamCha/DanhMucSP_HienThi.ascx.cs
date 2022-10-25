using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucSP_DanhMucSP_GioiThieu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayCongNghe();
        }
    }

    private void LayCongNghe()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.danhmuccha.Thongtin_danhmuccha();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='madmcha' id='ma" + dt.Rows[i]["MaDMCha"] + @"'>
               
               <td >" + dt.Rows[i]["TenDMCha"] + @" </td>
                <td>" + dt.Rows[i]["MoTa"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=danhmuc&vt=dmsanphamcha&cn=sua&id=" + dt.Rows[i]["MaDMCha"] + @"'>Sửa</a>
                
                <a href=javascript:XoaDanhMucSanPham(" + dt.Rows[i]["MaDMCha"] + @")>Xoá</a></td>
         </tr>

";
        }
    }
}