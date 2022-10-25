using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_AnhSP_AnhSP_HienThi : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LayAnhSp();
        }
    }

    private void LayAnhSp()
    {
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.AnhSP.Thongtin_anhsp();
        for (int i = 0; i < dt.Rows.Count; i++)
        {

            litanhsp.Text += @"
        <tr class='maanhsp' id='ma" + dt.Rows[i]["MaAnhSP"] + @"'>
<td >" + dt.Rows[i]["MaSP"] + @"</td>
                <td class='image'><img src='pic/SanPham/" + dt.Rows[i]["AnhSP"] + @"'/></td>
               
            <td>
                <a href='Admin.aspx?dm=anhsanpham&cn=sua&id=" + dt.Rows[i]["MaAnhSP"] + @"'>Sửa</a>
                <a href='javascript:XoaAnhSP(" + dt.Rows[i]["MaAnhSP"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}