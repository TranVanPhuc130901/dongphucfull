<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMucSP_ThemMoi.ascx.cs" Inherits="Areas_admin_DanhMuc_DanhMucSP_DanhMucSP_ThemMoi" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="formthemmoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>

    <div class="thongTin">
        <div class="tentruong">Ten Danh muc san pham</div>
        <div class="oNhap">
            <asp:TextBox ID="tbdanhmucsp" runat="server"></asp:TextBox>

        </div>
    </div>
    <ckeditor:ckeditorcontrol id="tbmotatin" runat="server" filebrowserimagebrowseurl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></ckeditor:ckeditorcontrol>
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
