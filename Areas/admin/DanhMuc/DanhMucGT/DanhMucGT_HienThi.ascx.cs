using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_DanhMuc_DanhMucGT_DanhMuc_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.DanhMucGioiThieu.Thongtin_danhmucgt();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='madmgt' id='ma" + dt.Rows[i]["MaDMGT"] + @"'>
               
               <td >" + dt.Rows[i]["TenDMGT"] + @" </td>
                
            <td>
                <a href='Admin.aspx?dm=danhmuc&vt=dmgioithieu&cn=sua&id=" + dt.Rows[i]["MaDMGT"] + @"'>Sửa</a>
                <a href='javascript:XoaDanhMucGioiThieu(" + dt.Rows[i]["MaDMGT"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}