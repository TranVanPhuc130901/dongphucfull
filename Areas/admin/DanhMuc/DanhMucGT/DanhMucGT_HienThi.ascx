<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMucGT_HienThi.ascx.cs" Inherits="Areas_admin_DanhMuc_DanhMucGT_DanhMuc_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=danhmuc&vt=dmgioithieu&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Tên danh muc gioi thieu</th>
            <th>Chuc Nang</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaDanhMucGioiThieu(MaDMGT) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/DanhMuc/DanhMucGT/Ajax/XoaDanhMucGioiThieu.aspx",
            {
                "thaotac": "XoaDanhMucGioiThieu",
                "MaDMGT": MaDMGT
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaDMGT).slideUp();
                }
            });

        }
    }
</script>