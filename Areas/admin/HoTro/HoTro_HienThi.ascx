<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HoTro_HienThi.ascx.cs" Inherits="Areas_admin_HoTro_HoTro_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=hotro&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Họ Tên</th>
            <th>Số Điện Thoại</th>
            <th>Email</th>
            <th>Tiêu Đề</th>
            <th>Nội Dung</th>
            <th>Chức Năng</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaHoTro(MaHoTro) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/HoTro/Ajax/XoaHoTro.aspx",
            {
                "thaotac": "XoaHoTro",
                "MaHoTro": MaHoTro
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaHoTro).slideUp();
                }
            });

        }
    }
</script>