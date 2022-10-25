<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPham_HienThi.ascx.cs" Inherits="Areas_admin_SanPham_SanPham_HienThi" %>
<div class="right">
    <a href="/Admin.aspx?dm=sanpham&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Tên Sản Phẩm</th>
            <th>Mã Danh Mục Sản Phẩm</th>
            <th>Mô Tả</th>
            <th>Màu Sắc</th>
            <th>Size</th>
            <th>Khuyến Mãi</th>
            <th>Ảnh Sản Phẩm</th>
            <th>Giá</th>
            <th>Giá Khuyến Mãi</th>
            <th>Chức Năng</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>

    </table>
    <asp:Literal ID="ltrPaging" runat="server"></asp:Literal>
</div>
<script type="text/javascript">
    function XoaSanPham(MaSP, AnhSP) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/SanPham/Ajax/XoaSanPham.aspx",
            {
                "thaotac": "XoaSanPham",
                "MaSP": MaSP,
                "AnhSP": AnhSP
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaSP).slideUp();
                }
            });

        }
    }
</script>