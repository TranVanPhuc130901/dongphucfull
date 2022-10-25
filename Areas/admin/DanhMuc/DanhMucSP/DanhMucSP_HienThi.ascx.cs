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
        dt = DongPhucKhanhLinh.DanhMucSanPham.Thongtin_danhmucsp();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='madmsp' id='ma" + dt.Rows[i]["MaDMSP"] + @"'>
               
               <td >" + dt.Rows[i]["TenDMSP"] + @" </td>
                <td class='image'><img src='pic/DanhMucSP/" + dt.Rows[i]["AnhDM"] + @"'/></td>
                <td >" + dt.Rows[i]["Link"] + @" </td>
                <td >" + dt.Rows[i]["MaDMCha"] + @" </td>
                <td class='motagt'>" + dt.Rows[i]["MoTa"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=danhmuc&vt=dmsanpham&cn=sua&id=" + dt.Rows[i]["MaDMSP"] + @"'>Sửa</a>
                
                <a href=javascript:XoaDanhMucSanPham(" + dt.Rows[i]["MaDMSP"] + @",'" + dt.Rows[i]["AnhDM"] + @"')>Xoá</a></td>
         </tr>

";
        }
    }
}