<%@ Register Src="~/Areas/admin/adminControl.ascx" TagPrefix="uc1" TagName="adminControl" %>\

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>
<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Admin</title>
    <link href="style/admin/admin.css" rel="stylesheet" />
</head>
<body>
    <form id="frm1" runat="server">
        <header class="header">
            <div class="wrp">
                <div class="left">
                    <img src="style/client/img/icon/logo.png" />
                </div>
                <div class="right">
                    <div class="gr_user">Xin chào, <asp:Literal runat="server" ID="lituser"></asp:Literal>|</div>
                   
                    <asp:LinkButton ID="lbdangxuat" CssClass="nav-link logout1" runat="server" onClick="lbdangxuat_click">đăng xuất</asp:LinkButton>
                </div>
            </div>
        </header>
        <section class="sec1_admin">
            <div class="wrp">
                <div class="left">
                    <div class="danhmucbtn">Danh Muc </div>
                    <div class="danhmuc">
                        <a href="/Admin.aspx?dm=danhmuc&vt=dmgioithieu">Danh muc gioi thieu</a>
                        <a href="/Admin.aspx?dm=danhmuc&vt=dmsanpham">Danh muc san pham</a>
                        <a href="/Admin.aspx?dm=danhmuc&vt=danhmuctin">Danh muc tin</a>
                        <a href="/Admin.aspx?dm=danhmuc&vt=dmsanphamcha">Danh muc san pham cha</a>
                    </div>
                    <a href="/Admin.aspx?dm=menu">Menu</a>
                    <a href="/Admin.aspx?dm=logo">Logo</a>
                    <a href="/Admin.aspx?dm=banner">Banner</a>
                    <a href="/Admin.aspx?dm=sanpham">San Pham</a>
                    <a href="/Admin.aspx?dm=tintuc">Tin Tuc</a>
                    <a href="/Admin.aspx?dm=nhansu">Nhân Sự</a>
                    <a href="/Admin.aspx?dm=congnghe">Công Nghệ</a>
                    <a href="/Admin.aspx?dm=thongtincuahang">Thông Tin Cửa Hàng</a>
                    <a href="/Admin.aspx?dm=gioithieu">Giới Thiệu</a>
                    <a href="/Admin.aspx?dm=hotro">Hỗ Trợ</a>
                    <a href="/Admin.aspx?dm=khachhangdanhgia">Khách Hàng Đánh Giá</a>
                    <a href="/Admin.aspx?dm=khachhanglienket">Khách Hàng Liên Kết</a>
                    <a href="/Admin.aspx?dm=anhsanpham">Anh San Pham</a>
                </div>
                <uc1:adminControl runat="server" ID="adminControl" />
            </div>
        </section>
    </form>
</body>
<script src="style/js/jquery.min.js"></script>
<script src="style/js/admin.js"></script>
</html>
