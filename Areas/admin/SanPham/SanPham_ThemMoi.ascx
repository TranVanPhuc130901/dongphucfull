<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPham_ThemMoi.ascx.cs" Inherits="Areas_admin_SanPham_SanPham_ThemMoi" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="formthemmoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
   

    <div class="thongTin">
        <div class="tentruong">Tên Sản Phẩm</div>
        <div class="oNhap">
            <asp:TextBox ID="tbtensp" runat="server"></asp:TextBox>

        </div>
    </div>
     <div class="thongTin">
        <div class="tentruong">Mã Danh Mục Sản Phẩm</div>
        <div class="oNhap">
            <asp:DropDownList ID="ddldanhmuc" runat="server"></asp:DropDownList>

        </div>
    </div>
    <CKEditor:CKEditorControl ID="tbmota" runat="server" FilebrowserImageBrowseUrl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></CKEditor:CKEditorControl>
     <div class="thongTin">
        <div class="tentruong">Màu Sắc</div>
        <div class="oNhap">
            <asp:TextBox ID="tbmausac" runat="server"></asp:TextBox>

        </div>
    </div>
     <div class="thongTin">
        <div class="tentruong">Size</div>
        <div class="oNhap">
            <asp:TextBox ID="tbsize" runat="server"></asp:TextBox>

        </div>
    </div>
     <div class="thongTin">
        <div class="tentruong">Khuyến Mãi</div>
        <div class="oNhap">
            <asp:TextBox ID="tbkm" runat="server"></asp:TextBox>

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
        <div class="tentruong">Giá</div>
        <div class="oNhap">
            <asp:TextBox ID="tbgia" runat="server"></asp:TextBox>

        </div>
    </div>
     <div class="thongTin">
        <div class="tentruong">Giá Khuyến Mại</div>
        <div class="oNhap">
            <asp:TextBox ID="tbgiakm" runat="server"></asp:TextBox>

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