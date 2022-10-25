<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu_HienThi.ascx.cs" Inherits="Areas_admin_Menu_Menu_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=menu&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Ten Menu</th>
            <th>Link</th>
            <th>Cap Menu</th>
            <th>Trạng Thái</th>
            <th>Chuc Nang</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaMenu(MaMenu) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/Menu/Ajax/XoaMenu.aspx",
            {
                "thaotac": "XoaMenu",
                "MaMenu": MaMenu
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaMenu).slideUp();
                }
            });

        }
    }
    function CapNhatTrangThai(MaMenu, TrangThai) {
        
            $.post("Areas/admin/Menu/Ajax/UpdateActive.aspx",
            {
                "thaotac": "CapNhatTrangThai",
                "MaMenu": MaMenu,
                "TrangThai": TrangThai
            },
            function (data) {
                if (data == 1) {
                    $('.status' + MaMenu).toggleClass("active")
                } else {
                    $('.status' + MaMenu).toggleClass("active")
                }
            });
        }
</script>
