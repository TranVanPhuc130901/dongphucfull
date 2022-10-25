using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_HoTro_HoTro_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.HoTro.Thongtin_hotro();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='mahotro' id='ma" + dt.Rows[i]["MaHoTro"] + @"'>
               
               <td >" + dt.Rows[i]["HoTen"] + @" </td>
                <td >" + dt.Rows[i]["SoDienThoai"] + @" </td>
                <td >" + dt.Rows[i]["Email"] + @" </td>
                <td >" + dt.Rows[i]["TieuDe"] + @" </td>
                <td >" + dt.Rows[i]["NoiDung"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=hotro&cn=sua&id=" + dt.Rows[i]["MaHoTro"] + @"'>Sửa</a>
                <a href='javascript:XoaHoTro(" + dt.Rows[i]["MaHoTro"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}