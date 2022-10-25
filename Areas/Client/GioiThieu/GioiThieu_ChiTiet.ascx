<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GioiThieu_ChiTiet.ascx.cs" Inherits="Areas_Client_GioiThieu_GioiThieu_ChiTiet" %>
<section class="title_trang">
    <div class="wrp">
        <span>Trang Chủ</span>
        <span>Giới Thiệu</span>
        <span>Về Chúng Tôi</span>
        <span>Cuộc Thi Ảnh Hàng Tuần</span>
    </div>
</section>
<section class="gtvechungtoi">
    <div class="wrp">
        <div class="left">
            <div class="title">Gioi Thieu</div>
            <hr />
            <div class="gr_drop">
                <asp:Literal runat="server" ID="litdanhmucsp"></asp:Literal>
            </div>
        </div>
        <div class="right">
            <asp:Literal runat="server" ID="litgioithieuchitiet"></asp:Literal>

            <div class="gioithieu">Chào mừng bạn đã ghé thăm Đồng phục Khánh Linh</div>
            <div class="name">đồnG phục khánh linh</div>
            <div class="lienhe">
                <address>Địa chỉ: 86 Lê Trọng Tấn, Thanh Xuân, Hà Nội</address>
                <a href="tel:0965585368" class="tel">Điện thoại : (+84) 965 585 368 - Fax: (+84) 965 585 368</a>
                <div class="email">
                    <a href="mailto:dongphuckhanhlinh@gmail.com" class="mail">Email: dongphuckhanhlinh.com</a>
                    <a href="" class="web">- Website: <span>www.dongphuckhanhlinh.com</span></a>
                </div>
            </div>
            <hr />
            <div class="link_mxh">
                <img src="../../../style/client/img/icon/facebook.svg" alt="" />
                <img src="../../../style/client/img/icon/twitter.svg" alt="" />
                <img src="../../../style/client/img/icon/share.png" alt="" />
            </div>
            <hr />
            <div class="baibietkhac">
                <div class="title">Bài viết khác:</div>
                <div class="gr_khac">
                    <asp:Literal runat="server" ID="litdanhmucgioithieukhac"></asp:Literal>
                </div>
            </div>
        </div>
    </div>
</section>
