<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/admin/admin.css" rel="stylesheet" />
</head>

<body>
    <form id="frm" runat="server">
        <div class="name">Đăng Nhập Hệ Thống</div>
        <asp:Literal ID="ltrthongbao" runat="server"></asp:Literal>
        <div class="form-group">
            <div class="text">Tên đăng nhập</div>
            <asp:TextBox ID="tbdangnhap" runat="server" CssClass="form-control form-control-users"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbdangnhap" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">

            <div class="text">Mật khẩu</div>
            <asp:TextBox ID="tbmatkhau" runat="server" TextMode="Password" CssClass="form-control form-control-user"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="tbmatkhau" Display="Dynamic" SetFocusOnError="true" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>

        <asp:Button ID="Button1" runat="server" Text="Đăng Nhập" CssClass="btn btn-primary btn-user btn-block" OnClick="Button1_Click" />
    </form>
</body>
</html>
