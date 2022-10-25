<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KhachHangLienKet_ThemMoi.ascx.cs" Inherits="Areas_admin_KhachHangLienKet_KhachHangLienKet_ThemMoi" %>
<div class="formthemmoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
   

    <div class="thongTin">
        <div class="tentruong">Tên Khách Hàng Liên Kết</div>
        <div class="oNhap">
            <asp:TextBox ID="tbkhlienket" runat="server"></asp:TextBox>

        </div>
    </div>
     <div class="thongTin">
        <div class="tentruong">Ảnh Đại Diện</div>
        <div class="oNhap">
            <div>
                <asp:HiddenField ID="hdTenAnhDaiDienCu" runat="server" />
                <asp:Literal ID="ltrAnhDaiDien" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAnhDaiDien" runat="server" />
        </div>
    </div>
    
    <div class="thongTin">
        <div class="tentruong">Link Khách Hàng</div>
        <div class="oNhap">
            <asp:TextBox ID="tblink" runat="server"></asp:TextBox>

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