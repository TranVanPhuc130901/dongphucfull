using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_KhachHangLienKet_KhachHangLienKet_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.KhachHangLienKet.Thongtin_khachhanglienket();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='makhlienket' id='ma" + dt.Rows[i]["MaKHLienKet"] + @"'>
               <td >" + dt.Rows[i]["TenKHLienKet"] + @" </td>
               <td class='image'><img src='pic/KhachHangLienKet/" + dt.Rows[i]["AnhKHLienKet"] + @"'/></td>
                <td >" + dt.Rows[i]["Link"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=khachhanglienket&cn=sua&id=" + dt.Rows[i]["MaKHLienKet"] + @"'>Sửa</a>
                <a href='javascript:XoaKhachHangLienKet(" + dt.Rows[i]["MaKHLienKet"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}