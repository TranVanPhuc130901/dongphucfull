<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMucTin_HienThi.ascx.cs" Inherits="Areas_admin_DanhMuc_DanhMucTin_DanhMucTin_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=danhmuc&vt=danhmuctin&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Tên danh muc tin</th>
            <th>Danh Muc Tin Cha</th>
            <th>Chuc Nang</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaDanhMucTin(MaDMTin) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/DanhMuc/DanhMucTin/Ajax/XoaDanhMucTin.aspx",
            {
                "thaotac": "XoaDanhMucTin",
                "MaDMTin": MaDMTin
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaDMTin).slideUp();
                }
            });

        }
    }
</script>