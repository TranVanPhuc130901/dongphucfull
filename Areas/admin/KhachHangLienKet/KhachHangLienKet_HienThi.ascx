<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KhachHangLienKet_HienThi.ascx.cs" Inherits="Areas_admin_KhachHangLienKet_KhachHangLienKet_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=khachhanglienket&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Tên Khách Hàng Liên Kết</th>
            <th>Ảnh Khách Hàng Liên Kết</th>
            <th>Link</th>
            <th>Chức Năng</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaKhachHangLienKet(MaKHLienKet) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/KhachHangLienKet/Ajax/XoaKhachHangLienKet.aspx",
            {
                "thaotac": "XoaKhachHangLienKet",
                "MaKHLienKet": MaKHLienKet
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaKHLienKet).slideUp();
                }
            });

        }
    }
</script>