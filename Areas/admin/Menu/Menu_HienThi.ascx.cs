using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_Menu_Menu_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.Menu.Thongtin_menu();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            var trangthai = dt.Rows[i]["TrangThai"].ToString();
            litbanner.Text += @"
            
        <tr class='mamenu' id='ma" + dt.Rows[i]["MaMenu"] + @"'>
               <td >" + dt.Rows[i]["TenMenu"] + @"</td>
                <td >" + dt.Rows[i]["link"] + @" </td>
               <td >" + dt.Rows[i]["CapMenu"] + @" </td>
                <td>
                    <a class='trangthai "+(trangthai == "True" ? "active" : "")+@" status"+dt.Rows[i]["MaMenu"]+@"' href=javascript:CapNhatTrangThai(" + dt.Rows[i]["MaMenu"] + @",'" + dt.Rows[i]["TrangThai"] + @"')></a>
                </td>
            <td>
                <a href='Admin.aspx?dm=menu&cn=sua&id=" + dt.Rows[i]["MaMenu"] + @"'>Sửa</a>
                <a href='javascript:XoaMenu(" + dt.Rows[i]["MaMenu"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}
//" + (trangthai == "True" ? "<div class='blue active'></div>" : "<div class='white active'></div>") + @"