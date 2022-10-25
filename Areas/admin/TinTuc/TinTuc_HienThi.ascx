<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TinTuc_HienThi.ascx.cs" Inherits="Areas_admin_TinTuc_TinTuc_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=tintuc&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Tên Tin Tức</th>
            <th>Mô tả</th>
            <th>Mã Danh Mục Tin</th>
            <th>Ngày Tạo</th>
            <th>Lượt Xem</th>
            <th>
                Ảnh tin tức
            </th>
            <th>Chi Tiet Tin</th>
            <th>Chức Năng</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
</div>
<script type="text/javascript">
    function XoaTinTuc(MaTinTuc) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/TinTuc/Ajax/XoaTinTuc.aspx",
            {
                "thaotac": "XoaTinTuc",
                "MaTinTuc": MaTinTuc
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaTinTuc).slideUp();
                }
            });

        }
    }
</script>