using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Areas_Client_Menu : System.Web.UI.UserControl
{
    string capmenu = "";
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            litmenu.Text = LayMenu();
           
        }

    }


    private string LayMenu( )
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.Menu.thongtin_menu_capmenu("1");
        for(int i =0; i<dt.Rows.Count; i++)
        {
            var trangthai = dt.Rows[i]["TrangThai"].ToString();
            if(trangthai == "True")
            {
                var list = LayMenuCap1(dt.Rows[i]["MaSubMenu"].ToString());
                s += @"
 <li class='" + (list.Length > 0 ? "menudp" : "") + @"'><a class='menu' href='/default.aspx?dm=" + dt.Rows[i]["link"] + @"'  href=''>" + dt.Rows[i]["TenMenu"] + @"</a>
  ";
                s += @"
 <div class='submenu'>
                    <ul>
";

                s += list;
                s += @"
</ul>
                </div>
";
                s += @"
</li>
";
            }
            
        }
        return s;
    }

    private string LayMenuCap1(string v)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.MenuCap1.thongtin_menu_masubmenu2(v);
        for(int i =0; i < dt.Rows.Count; i++)
        {
            var list = LayMenuCap2(dt.Rows[i]["MaMenu"].ToString());
            s += @"
            
                        <li class='" + (list.Length > 0 ? "nhahang" : "") + @"'><a href=''>" + dt.Rows[i]["TenMenuCon"] + @"</a>

";
            if(list.Length > 0)
            {
                s += @"
<img class='img_huong' src='../../style/client/img/icon/next_2.png' />
";
            }
            s += @"
<div class='submenu2'>
                                <ul class='submenu_ul'>";
            s += list;
            s += @"
    </ul>
                            </div>
";
            s+=@"
</li>
         
";
        }
        return s;
    }

    private string LayMenuCap2(string v)
    {
        string s = "";
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.MenuCap2.thongtin_menu_menucap2(v);
        for(int i =0; i<dt.Rows.Count; i++)
        {
            s += @"
               <li><a href=''>" + dt.Rows[i]["TenMenuCap2"] + @"</a></li>
                            
";
        }
        return s;
    }
}