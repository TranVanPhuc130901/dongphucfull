using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_LienHe_LienHeControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btLienHe_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        DongPhucKhanhLinh.HoTro.hotro_insert(tbhoten.Text, tbemail.Text, tbsodienthoai.Text, tbtieude.Text, tbnoidung.InnerText);
        ltrThongBao.Text += "Chúng Tôi Đã Lưu Lại Phản Hổi Của Quý Khach";
        resetControl();
    }

    private void resetControl()
    {
        tbhoten.Text = "";
        tbemail.Text = "";
        tbsodienthoai.Text = "";
        tbtieude.Text = "";
        tbnoidung.InnerText = "";
      
    }
}