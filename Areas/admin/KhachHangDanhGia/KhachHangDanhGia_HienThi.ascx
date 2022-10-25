<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KhachHangDanhGia_HienThi.ascx.cs" Inherits="Areas_admin_KhachHangDanhGia_KhachHangDanhGia_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=khachhangdanhgia&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Tên Khách Hàng</th>
            <th>Ảnh Khách Hàng</th>
            <th>Link</th>
            <th>Chức Năng</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaKhachHangDanhGia(MaDanhGia) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/KhachHangDanhGia/Ajax/XoaKhachHangDanhGia.aspx",
            {
                "thaotac": "XoaKhachHangDanhGia",
                "MaDanhGia": MaDanhGia
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaDanhGia).slideUp();
                }
            });

        }
    }
</script>