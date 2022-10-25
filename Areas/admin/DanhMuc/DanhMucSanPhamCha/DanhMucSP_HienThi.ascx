<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhMucSP_HienThi.ascx.cs" Inherits="Areas_admin_DanhMuc_DanhMucSP_DanhMucSP_GioiThieu" %>
<div class="right">
    <a href="/Admin.aspx?dm=danhmuc&vt=dmsanphamcha&cn=themmoi" class="btn">Them moi</a>
    <table>
        <tr>
            <th>Tên danh muc san pham</th>
            <th>Mo Ta</th>
            <th>Chuc Nang</th>
        </tr>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>
        
    </table>
</div>
<script type="text/javascript">
    function XoaDanhMucSanPham(MaDMCha) {
        if (confirm("Bạn có muốn xoá không")) {
            $.post("Areas/admin/DanhMuc/DanhMucSanPhamCha/Ajax/XoaDanhMucSanPham.aspx",
            {
                "thaotac": "XoaDanhMucSanPham",
                "MaDMCha": MaDMCha
            },
            function (data, status) {
                if (data == 1) {
                    $("#ma" + MaDMCha).slideUp();
                }
            });

        }
    }
</script>