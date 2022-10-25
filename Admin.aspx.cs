using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session["dangnhap"] != null && Session["dangnhap"].ToString() == "1")
        {

        }
        else
        {
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
            lituser.Text = Session["tentk"].ToString();

    }

    protected void lbdangxuat_click(object sender, EventArgs e)
    {
        Session["dangnhap"] = null;
        Session["tentk"] = null;


        Response.Redirect("/Login.aspx");
    }
}
