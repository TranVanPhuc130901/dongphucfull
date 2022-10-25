<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KhachHangDanhGia.ascx.cs" Inherits="Areas_Client_KhachHang_KhachHangDanhGia" %>
 <section class="title_trang">
            <div class="wrp">
                <span>Trang Chủ</span>
                <span>Giới Thiệu</span>
                <span>Về Chúng Tôi</span>
                <span>Cuộc Thi Ảnh Hàng Tuần</span>
            </div>
        </section>
        <section class="noivechungtoi">
            <div class="wrp">
                <div class="left">
                    <div class="title">Sản Phẩm</div>
                    <hr />
                    <div class="gr_link">
                        <a href="/default.aspx?dm=gioi-thieu">Giới Thiệu</a>
                        <a href="/default.aspx?dm=khach-hang&danhmucphu=danhgia">Khách hàng của chúng tôi</a>
                        <a href="/default.aspx?dm=gioi-thieu">Tin tuyển dụng</a>
                        <a href="/default.aspx?dm=gioi-thieu">Tin nội bộ </a>
                    </div>
                </div>
                <div class="right">
                    <h2 class="title_bold">Khách hàng của chúng tôi</h2>
                    <hr />
                    <div class="gr_khachhang">
                        <asp:Literal runat="server" ID="litkhachhang"></asp:Literal>
                    </div>
                   <asp:Literal runat="server" ID="ltrPaging"></asp:Literal>
                </div>
            </div>
        </section>