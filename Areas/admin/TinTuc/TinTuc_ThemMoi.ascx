<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TinTuc_ThemMoi.ascx.cs" Inherits="Areas_admin_TinTuc_TinTuc_ThemMoi" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<div class="formthemmoi">
    <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>


    <div class="thongTin">
        <div class="tentruong">Tên Tin Tức</div>
        <div class="oNhap">
            <asp:TextBox ID="tbtentintuc" runat="server"></asp:TextBox>

        </div>
    </div>
      <div class="thongTin">
        <div class="tentruong">Mo Ta Tin</div>
        <div class="oNhap">
            <asp:TextBox ID="tbmota" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Mã Danh Mục Tin Tứcc</div>
        <div class="oNhap">
           <asp:DropDownList runat="server" ID="ddltintuc"></asp:DropDownList>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Ngày Tạo</div>
        <div class="oNhap">
            <asp:TextBox ID="tbngaytao" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Lượt Xem</div>
        <div class="oNhap">
            <asp:TextBox ID="tbluotxem" runat="server"></asp:TextBox>

        </div>
    </div>
    <div class="thongTin">
        <div class="tentruong">Link</div>
        <div class="oNhap">
            <asp:TextBox ID="tblink" runat="server"></asp:TextBox>

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
    <ckeditor:ckeditorcontrol id="tbchitiettin" runat="server" filebrowserimagebrowseurl="ckeditor/ckfinder/ckfinder.aspx?type=Images&path=pic"></ckeditor:ckeditorcontrol>
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
