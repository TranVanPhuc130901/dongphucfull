<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu_ThemMoi.ascx.cs" Inherits="Areas_admin_Menu_Menu_ThemMoi" %>
<div class="formthemmoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tentruong">Ten Menu</div>
        <div class="oNhap">
            <asp:TextBox ID="tbtenmenu" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Link</div>
        <div class="oNhap">
            <asp:TextBox ID="tblink" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Cap Menu</div>
        <div class="oNhap">
            <asp:TextBox ID="tbcapmenu" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Thu Tu</div>
        <div class="oNhap">
            <asp:TextBox ID="tbthutu" runat="server"></asp:TextBox>

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
