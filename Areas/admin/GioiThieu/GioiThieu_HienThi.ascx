<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GioiThieu_HienThi.ascx.cs" Inherits="Areas_admin_GioiThieu_GioiThieu_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=gioithieu&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Tên Giới Thiệu</th>
            <th>Ngày Tạo</th>
            <th>Lượt Xem</th>
            <th>Mô Tả</th>
            <th>Mã Danh Mục Giới Thiệu</th>
            <th>Ảnh Giới Thiệu</th>
            <th>Chi Tiết</th>
            <th>Chuc Nang</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaGioiThieu(MaGioiThieu) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/GioiThieu/Ajax/XoaGioiThieu.aspx",
            {
                "thaotac": "XoaGioiThieu",
                "MaGioiThieu": MaGioiThieu
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaGioiThieu).slideUp();
                }
            });

        }
    }
</script>