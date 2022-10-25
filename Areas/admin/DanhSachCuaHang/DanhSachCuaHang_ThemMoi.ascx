<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachCuaHang_ThemMoi.ascx.cs" Inherits="Areas_admin_DanhSachCuaHang_DanhSachCuaHang_ThemMoi" %>
<div class="formthemmoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
    <div class="thongTin">
        <div class="tentruong">Địa Chỉ</div>
        <div class="oNhap">
            <asp:TextBox ID="tbdiachi" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Số Điện Thoại</div>
        <div class="oNhap">
            <asp:TextBox ID="tbsdt" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Email</div>
        <div class="oNhap">
            <asp:TextBox ID="tbemail" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Link(vui lòng nhâp link địa chỉ cửa hàng)</div>
        <div class="oNhap">
            <asp:TextBox ID="tblink" runat="server" TextMode="MultiLine"></asp:TextBox>

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
        <div class="tentruong">Chuc Nang</div>
        <div class="oNhap">
            <asp:TextBox ID="tbchucnang" runat="server"></asp:TextBox>

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
