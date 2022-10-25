<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AnhSP_HienThi.ascx.cs" Inherits="Areas_admin_AnhSP_AnhSP_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=anhsanpham&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Mã Ảnh Sản Phẩm</th>
            <th>Ảnh Sản Phẩm</th>
            <th>Chức Năng</th>
        </tr>
        <asp:Literal ID="litanhsp" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaAnhSP(MaAnhSP) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/AnhSP/Ajax/XoaAnhSP.aspx",
            {
                "thaotac": "XoaAnhSP",
                "MaAnhSP": MaAnhSP
            },
            function (data, status) {
                if (data == 1) {
                    $("#maanhsp" + MaAnhSP).slideUp();
                }
            });

        }
    }
</script>