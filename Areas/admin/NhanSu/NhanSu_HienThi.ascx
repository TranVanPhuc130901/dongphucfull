<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NhanSu_HienThi.ascx.cs" Inherits="Areas_admin_NhanSu_NhanSu_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=nhansu&cn=themmoi" class="btn">Them moi</a>
    <div class="formtimkiem">
        <asp:TextBox runat="server" ID="tbtimkiem"></asp:TextBox>
        <asp:Button ID="btTimKiem" runat="server" Text="Tìm Kiếm" CssClass="btTimKiem" OnClick="btTimKiem_Click"  />
        
    </div>
     <asp:Literal ID="littimkiem" runat="server"></asp:Literal> 
    <table class="nhansu">
        <tr>
            <th>Mã Nhân Sự</th>
            <th>Tên Nhân Sự</th>
            <th>Ảnh Nhân Sự</th>
            <th>Vị Trí</th>
            <th>Chức Năng</th>
        </tr>

        <div>Danh Sách Nhân Sự</div>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>
    </table>
   
</div>
<script type="text/javascript">
    function XoaNhanSu(MaNhanSu) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/NhanSu/Ajax/XoaNhanSu.aspx",
            {
                "thaotac": "XoaNhanSu",
                "MaNhanSu": MaNhanSu
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaNhanSu).slideUp();
                }
            });

        }
    }
</script>
