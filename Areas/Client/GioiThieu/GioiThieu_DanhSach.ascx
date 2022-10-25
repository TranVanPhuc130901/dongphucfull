<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GioiThieu_DanhSach.ascx.cs" Inherits="Areas_Client_GioiThieu_GioiThieu_DanhSach" %>
 <section class="title_trang">
            <div class="wrp">
                <span>Trang Chủ</span>
                <span>Về Chúng Tôi</span>
            </div>
        </section>
        <section class="sec1_gioithieu">
            <div class="wrp">
                <div class="left">
                    <h2 class="title">Về chúng tôi</h2>
                    <hr />
                    <div class="gr_link">
                        <a href="">Giới Thiệu</a>
                        <a href="/default.aspx?dm=khach-hang&danhmucphu=danhgia">Khách hàng của chúng tôi</a>
                        <a href="">Tin tuyển dụng</a>
                        <a href="">Tin nội bộ </a>
                    </div>
                </div>
                <div class="right">
                    <h2 class="title_r">Giới Thiệu</h2>

                    <div class="gr_item">
                        <asp:Literal runat="server" ID="litdanhsachgioithieu"></asp:Literal>
                    </div>
                </div>
            </div>
        </section>