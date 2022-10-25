using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_Banner_Banner_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.Banner.Thongtin_Banner();
        for(int i = 0; i<dt.Rows.Count; i++)
        {
            var trangthai = dt.Rows[i]["TrangThai"].ToString();
            litbanner.Text += @"
        <tr class='mabanner' id='ma" + dt.Rows[i]["MaBanner"] + @"'>
               <td class='image'><img src='pic/Banner/" + dt.Rows[i]["AnhBanner"] + @"'/></td>
               <td >" + dt.Rows[i]["TenBanner"] + @" </td>
                <td>
                    <a class='trangthai " + (trangthai == "True" ? "active" : "") + @" status" + dt.Rows[i]["MaBanner"] + @"' href=javascript:CapNhatTrangThai(" + dt.Rows[i]["MaBanner"] + @",'" + dt.Rows[i]["TrangThai"] + @"')></a>
                </td>
            <td>
                <a href='Admin.aspx?dm=banner&cn=sua&id=" + dt.Rows[i]["MaBanner"] + @"'>Sửa</a>
                <a href=javascript:XoaBanner(" + dt.Rows[i]["MaBanner"] + @",'" + dt.Rows[i]["AnhBanner"] + @"')>Xoá</a></td>
         </tr>

";
        }
    }
}