using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_admin_CongNghe_CongNghe_HienThi : System.Web.UI.UserControl
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
        dt = DongPhucKhanhLinh.CongNghe.Thongtin_congnghe();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            litbanner.Text += @"
        <tr class='macn' id='ma" + dt.Rows[i]["MaCN"] + @"'>
               
               <td >" + dt.Rows[i]["TenCN"] + @" </td>
                <td class='motagt'>" + dt.Rows[i]["MoTaCN"] + @" </td>
                <td >" + dt.Rows[i]["Link"] + @" </td>
            <td>
                <a href='Admin.aspx?dm=congnghe&cn=sua&id=" + dt.Rows[i]["MaCN"] + @"'>Sửa</a>
                <a href='javascript:XoaCongNghe(" + dt.Rows[i]["MaCN"] + @")'>Xoá</a></td>
         </tr>

";
        }
    }
}