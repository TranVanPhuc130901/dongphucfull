<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPham_DanhSach.ascx.cs" Inherits="Areas_Client_SanPham_SanPham_DanhSach" %>
<section class="title_trang">
    <div class="wrp">
        <span>Trang Chủ</span>
        <span>Sản Phẩm</span>
        <span>Đồng phục khách sạn</span>
        <span>Đồng phục quản lý</span>
    </div>
</section>
<section class="sec1_danhsach">
    <div class="wrp">
        <div class="left">
            <div class="title">Sản Phẩm</div>
            <hr />
            <div class="gr_drop">
                <asp:Literal runat="server" ID="litdanhmucsp"></asp:Literal>
               
            </div>
            <div class="color title">Màu Sắc</div>
            <hr />
            <div class="gr_color">
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
                <img src="../../../style/client/img/image/xanh.png" alt="" class="item_color" />
            </div>
        </div>
        <div class="right">
            <asp:Literal runat="server" ID="litmota"></asp:Literal>
            <div class="gr_item">
                <asp:Literal runat="server" ID ="litsanpham"></asp:Literal>
               
            </div>

            <asp:Literal runat="server" ID="ltrphantrang"></asp:Literal>
            <%--<div class="phantrang">
                <a href="">
                     <img src="../../../style/client/img/icon/prev.png" alt="" /></a>
                <a href="">1</a>
                <a href="">2</a>
                <a href="">3</a>
                <a href="">4</a>
                <a href="">
                    <img src="../../../style/client/img/icon/next.png" alt="" /></a>
            </div>--%>
        </div>
    </div>
</section>
<section class="sec5_tc">
    <div class="wrp">
        <h2 class="title_s">Khách Hàng Của Chúng Tôi
        </h2>
        <div class="gr_item owl-carousel">
            <asp:Literal runat="server" ID="litkhachhangcuachungtoi"> </asp:Literal>
           
        </div>
    </div>
</section>
