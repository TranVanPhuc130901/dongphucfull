<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CongNghe_HienThi.ascx.cs" Inherits="Areas_admin_CongNghe_CongNghe_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=congnghe&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Tên Công Nghệ</th>
            <th>Mô tả</th>
            <th>Link</th>
            <th>Chức Năng</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaCongNghe(MaCN) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/CongNghe/Ajax/XoaCongNghe.aspx",
            {
                "thaotac": "XoaCongNghe",
                "MaCN": MaCN
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaCN).slideUp();
                }
            });

        }
    }
</script>
