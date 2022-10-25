<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMucTin_ThemMoi.ascx.cs" Inherits="Areas_admin_DanhMuc_DanhMucTin_DanhMucTin_ThemMoi" %>
<div class="formthemmoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>

    <div class="thongTin">
        <div class="tentruong">Ten Danh muc tin</div>
        <div class="oNhap">
            <asp:TextBox ID="tbdanhmuctin" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Mã Danh Mục Tin</div>
        <div class="oNhap">
            <asp:DropDownList ID="ddldanhmuc" runat="server"></asp:DropDownList>

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
