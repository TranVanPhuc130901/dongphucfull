using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_Logo_Logo_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.Logo.Thongtin_Logo();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='malogo' id='ma" + dt.Rows[i]["MaLogo"] + @"'>
               <td class='image'><img src='pic/Logo/" + dt.Rows[i]["AnhLogo"] + @"'/></td>
               <td >" + dt.Rows[i]["TenLogo"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=logo&cn=sua&id=" + dt.Rows[i]["MaLogo"] + @"'>Sửa</a>
                <a href='javascript:XoaLogo(" + dt.Rows[i]["MaLogo"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}