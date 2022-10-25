<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KhachHangLienKet.ascx.cs" Inherits="Areas_Client_KhachHang_KhachHangLienKet" %>
<section class="title_trang">
    <div class="wrp">
        <span>Trang Chủ</span>
        <span>Giới Thiệu</span>
        <span>Về Chúng Tôi</span>
        <span>Cuộc Thi Ảnh Hàng Tuần</span>
    </div>
</section>
<section class="khachhangcuachungtoi">
    <div class="wrp">
        <div class="left">
            <h2 class="title">Sản Phẩm</h2>
            <hr />
            <div class="gr_link">
                        <a href="">Giới Thiệu</a>
                        <a href="/default.aspx?dm=gioi-thieu&danhmucphu=vechungtoi">Khách hàng của chúng tôi</a>
                        <a href="">Tin tuyển dụng</a>
                        <a href="">Tin nội bộ </a>
                    </div>
        </div>
        <div class="right">
            <div class="sec5_tc">
                <h2 class="title_s">Khách Hàng Của Chúng Tôi</h2>
                <div class="gr_item">
                    <asp:Literal runat="server" ID="khachhanglienket"></asp:Literal>
                </div>
                </div>
                <div class="phantrang">
                    <a href="">
                        <img src="./img/icon/prev.png" alt="" /></a>
                    <a href="">1</a>
                    <a href="">2</a>
                    <a href="">3</a>
                    <a href="">4</a>
                    <a href="">
                        <img src="./img/icon/next.png" alt="" /></a>
                </div>
    </div>
    </div>
</section>
