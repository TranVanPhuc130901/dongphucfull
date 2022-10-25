<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachCuaHang_HienThi.ascx.cs" Inherits="Areas_admin_DanhSachCuaHang_DanhSachCuaHang_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=thongtincuahang&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Dia chi</th>
            <th>So Dien Thoai</th>
            <th>Email</th>
            <th>Link</th>
            <th>Anh Cua Hang</th>
            <th>Cua Hang</th>
            <th>Chức Năng</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaDanhSachCuaHang(MaCuaHang) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/DanhSachCuaHang/Ajax/XoaDanhSachCuaHang.aspx",
            {
                "thaotac": "XoaDanhSachCuaHang",
                "MaCuaHang": MaCuaHang
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaCuaHang).slideUp();
                }
            });

        }
    }
</script>