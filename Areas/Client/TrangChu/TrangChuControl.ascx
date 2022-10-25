<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TrangChuControl.ascx.cs" Inherits="Areas_Client_TrangChu_TrangChuControl" %>
<section class="sec1_trangchu">
    <div class='banner owl-carousel'>
        <asp:Literal ID="litbanner" runat="server"></asp:Literal>
    </div>
    <div class="wrp">
        <div class="sec1_tc_left">
            <div class="title">
                Giới thiệu về đồng phục Khánh Linh
            </div>
            <div class="decs">
                <p>Ngoài việc sở hữu đội ngũ Designer trẻ trung sáng tạo, luôn nắm bắt kịp thời xu thế thời trang trong và ngoài nước.</p>

                <p>Đồng phục Khánh Linh còn sở hữu Đội ngũ kỹ thuật viên nhà xưởng chuyên nghiệp, giàu năm kinh nghiệm trong việc may đo, in ấn Đồng phục.</p>

                <p>Chúng tôi đã mạnh dạn tập trung đầu tư mở rộng quy mô nhà xưởng cũng như hệ thống trang thiết bị, dây chuyền sản xuất hiện đại, được nhập khẩu từ các nước tiên tiến như CHLB Đức, Mỹ,Ý, Nhật...</p>

                <p>Từ những lợi thế trên, Khánh Linh luôn tự tin đem lại giải pháp hiệu quả nhất từ công đoạn tư vấn thiết kế cho đến may đồng phục đẹp.</p>
                <a href="">Xem Thêm</a>
            </div>
        </div>
        <div class="sec1_tc_right">
            <iframe width="100%" height="100%" src="https://www.youtube.com/embed/VGOjvxROELw" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
            </a>
        </div>
    </div>
</section>
<section class="sec2_tc">
    <div class="wrp">
        <h2 class="title_s">Các dòng sản phẩm nổi bật tại Khánh Linh</h2>
        <div class="gr_item owl-carousel">
            <asp:Literal ID="litdongsanpham" runat="server"></asp:Literal>
        </div>
    </div>
</section>
<section class="sec3_tc">
    <div class="wrp">
        <h2 class="title_s">Công nghệ hiện đại tại Đồng phục Khánh Linh
        </h2>
        <div class="box">
            <div class="sec3_tc_left">
                <div class="WImage">
                    <img src="style/client/img/image/img_bn1.jpg" alt="">
                    <asp:Literal ID="litcongngheleft" runat="server"></asp:Literal>

                </div>
            </div>
            <div class="sec3_tc_right">
                <asp:Literal ID="litcongngheright" runat="server"></asp:Literal>

            </div>
        </div>
    </div>
</section>
<section class="sec4_tc">
    <div class="wrp">
        <h2 class="title_s">Khách Hàng Nói Về Chúng Tôi
        </h2>
        <div class="gr_item owl-carousel">
            <asp:Literal ID="litkhachhangdanhgia" runat="server"></asp:Literal>

        </div>
        <a href="/default.aspx?dm=khach-hang&danhmucphu=danhgia" class="all">Xem Tất Cả</a>
    </div>
</section>
<section class="sec5_tc">
    <div class="wrp">
        <h2 class="title_s">Khách Hàng Của Chúng Tôi
        </h2>
        <div class="gr_item owl-carousel">
            <asp:Literal ID="litkhachhangcuachungtoi" runat="server"></asp:Literal>

        </div>
    </div>
</section>
<section class="sec6_tc">
    <div class="wrp">
        <div class="thongtin"><span>450</span> Dự án đã hoàn thành</div>
        <div class="thongtin"><span>200</span> Đối tác trong và ngoài nước</div>
        <div class="thongtin"><span>99%</span> tỷ lệ khách hàng hài lòng </div>
    </div>
</section>
<section class="sec7_tc">
    <div class="wrp">
        <div class="title_s">
            Đội ngũ nhân sự
        </div>
        <div class="gr_item">
            <asp:Literal runat="server" ID="litnhansu"></asp:Literal>
        </div>
    </div>
</section>
<section class="sec8_tc">
    <div class="wrp">
        <h2 class="title_s">Tin Tức Nổi Bật
        </h2>
        <div class="gr_item">
            <asp:Literal runat="server" ID="littintuc"></asp:Literal>
        </div>
    </div>
</section>
