<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HoTro_ThemMoi.ascx.cs" Inherits="Areas_admin_HoTro_HoTro_ThemMoi" %>
<div class="formthemmoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>


    <div class="thongTin">
        <div class="tentruong">Họ Tên</div>
        <div class="oNhap">
            <asp:TextBox ID="tbhoten" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Số Điện Thoại</div>
        <div class="oNhap">
            <asp:TextBox ID="tbsodienthoai" runat="server"></asp:TextBox>

        </div>
    </div>

<div class="thongTin">
    <div class="tentruong">Email</div>
    <div class="oNhap">
        <asp:TextBox ID="tbemail" runat="server"></asp:TextBox>

    </div>
</div>

<div class="thongTin">
    <div class="tentruong">Tiêu Đề</div>
    <div class="oNhap">
        <asp:TextBox ID="tbtieude" runat="server"></asp:TextBox>

    </div>
</div>


<div class="thongTin">
    <div class="tentruong">Nội Dung</div>
    <div class="oNhap">
        <asp:TextBox ID="tbnoidung" runat="server"></asp:TextBox>
    </div>

</div>
<div class="thongTin1">
    <div class="tentruong">&nbsp;</div>
    <div class="oNhap">
        <asp:CheckBox ID="cbThemNhieuDanhMuc" runat="server" Text="Tạo thêm danh mục khác sau khi tạo danh mục này" />
    </div>
</div>
<div class="thongTin1">
    <div class="tentruong">&nbsp;</div>
    <div class="oNhap">
        <asp:Button ID="btThemMoi" runat="server" Text="Thêm mới" CssClass="btThemMoi" OnClick="btThemMoi_Click" />
        <asp:Button ID="btHuy" runat="server" Text="Hủy" CssClass="btHuy" CausesValidation="false" Style="height: 26px" OnClick="btHuy_Click" />
    </div>
</div>
</div>
