using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucTin_DanhMucTin_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.DanhMucTin.Thongtin_danhmuctin();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='madmtin' id='ma" + dt.Rows[i]["MaDMTin"] + @"'>
               
               <td >" + dt.Rows[i]["TenDMTin"] + @" </td>
                <td >" + dt.Rows[i]["MaDMTinCha"] + @" </td>
                
            <td>
                <a href='Admin.aspx?dm=danhmuc&vt=danhmuctin&cn=sua&id=" + dt.Rows[i]["MaDMTin"] + @"'>Sửa</a>
                <a href='javascript:XoaDanhMucTin(" + dt.Rows[i]["MaDMTin"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}