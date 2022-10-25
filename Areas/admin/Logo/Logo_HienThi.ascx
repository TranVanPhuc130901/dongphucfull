<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Logo_HienThi.ascx.cs" Inherits="Areas_admin_Logo_Logo_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=logo&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Anh logo</th>
            <th>Ten logo</th>
            <th>Chuc Nang</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaLogo(MaLogo) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/Logo/Ajax/XoaLogo.aspx",
            {
                "thaotac": "XoaLogo",
                "MaLogo": MaLogo
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaLogo).slideUp();
                }
            });

        }
    }
</script>
