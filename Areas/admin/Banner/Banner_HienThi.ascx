<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Banner_HienThi.ascx.cs" Inherits="Areas_admin_Banner_Banner_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=banner&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Ảnh Banner</th>
            <th>Tên Banner</th>
            <th>Trạng Thái</th>
            <th>Chức Năng</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaBanner(MaBanner, AnhBanner) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/Banner/Ajax/XoaBanner.aspx",
            {
                "thaotac": "XoaBanner",
                "MaBanner": MaBanner,
                "AnhBanner": AnhBanner
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaBanner).slideUp();
                }
            });

        }
    }
    function CapNhatTrangThai(MaBanner, TrangThai) {

        $.post("Areas/admin/Banner/Ajax/UpdateActive.aspx",
        {
            "thaotac": "CapNhatTrangThai",
            "MaBanner": MaBanner,
            "TrangThai": TrangThai
        },
        function (data) {
            if (data == 1) {
                $('.status' + MaBanner).toggleClass("active")
            } else {
                $('.status' + MaBanner).toggleClass("active")
            }
        });
    }
</script>
