<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<%@ Register Src="~/Areas/Client/ClientControl.ascx" TagPrefix="uc1" TagName="ClientControl" %>
<%@ Register Src="~/Areas/Client/Menu.ascx" TagPrefix="uc1" TagName="Menu" %>
<%@ Register Src="~/Areas/Client/LienHe/CuaHang.ascx" TagPrefix="uc1" TagName="CuaHang" %>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">


    <link href="style/client/css/style.css" rel="stylesheet" />
    <link href="style/client/owl_carousel/owl.carousel.css" rel="stylesheet" />
    <link href="style/client/fancybox/fancybox.css" rel="stylesheet" />
    <link href="style/client/css/reponsive.css" rel="stylesheet" />

    <script src="style/client/js/jquery-3.6.0.min.js"></script>

    <title>Đồng phục khánh linh</title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="top">
                <div class="wrp">
                    <div class="top_left">
                        <address class="home">86 Lê Trọng Tấn, T.Xuân, Hà Nội</address>
                        <a href="#" class="phone">(+84) 965.585.368</a>
                    </div>
                    <div class="top_right">
                        <a href="">
                            <img src="style/client/img/icon/facebook.svg" alt="">
                        </a>
                        <a href="">
                            <img src="style/client/img/icon/twitter.svg" alt="">
                        </a>
                        <a href="">
                            <img src="style/client/img/icon/pinterest.svg" alt="">
                        </a>
                        <a href="">
                            <img src="style/client/img/icon/linkedin.svg" alt="">
                        </a>
                    </div>
                </div>
            </div>
            <div class="bot">
                <div class="wrp">
                    <a href="/default.aspx" class="logo">
                        <img src="style/client/img/icon/logo.png" alt="">
                    </a>
                    <div class="menu_btn">
                        <img src="style/client/img/icon/menu.svg" alt="">
                    </div>
                    <uc1:Menu runat="server" ID="Menu" />
                </div>

            </div>
        </header>
        <uc1:ClientControl runat="server" ID="ClientControl" />
        <footer>
            <uc1:CuaHang runat="server" ID="CuaHang" />
            <div class="bot">
                <div class="wrp">
                    <div class="lienhe">
                        <a href="" class="img_footer">
                            <img src="style/client/img/image/footer_banner.png" alt="">
                        </a>
                    </div>
                    <div class="ftcolumn">
                        <div class="col">
                            <img class="logo" src="style/client/img/icon/logo2.png" alt="" />
                            <div class="text">
                                On the other hand, we denounce with righteous indignation and dislike men who are so
                            beguiled and demoralized the charms of pleasure of.
                            </div>
                            <div class="mxh">
                                <a href="" class="face">
                                    <img src="style/client/img/icon/face.png" alt="" />
                                </a>
                                <a href="" class="face">
                                    <img src="style/client/img/icon/twitter_color.png" alt="" />
                                </a>
                                <a href="" class="face">
                                    <img src="style/client/img/icon/pinterest_color.png" alt="" />
                                </a>
                                <a href="" class="face">
                                    <img src="style/client/img/icon/youtube_color.png" alt="" />
                                </a>
                            </div>
                        </div>
                        <div class="col col2">
                            <div class="title">Liên Hệ</div>
                            <div class="home">86 Lê Trọng Tấn, Thanh Xuân, Hà Nội</div>
                            <a href="mailto:dongphuckhanhlinh@gmail.com" class="gmail">dongphuckhanhlinh@gmail.com</a>
                            <a href="tel:0965585368" class="tel2">0965 585 368</a>
                            <a href="#" class="web">dongphuckhanhlinh.com</a>
                        </div>
                        <div class="col col3">
                            <div class="title2">Links Nhanh</div>
                            <div class="nav">
                                <ul class="left">
                                    <li><a href="">Trang Chủ</a></li>
                                    <li><a href="">Giới Thiệu</a></li>
                                    <li><a href="">Báo giá</a></li>
                                    <li><a href="">Đồng phục</a></li>
                                </ul>
                                <ul class="right">
                                    <li><a href="">Phụ Kiện</a></li>
                                    <li><a href="">Tin Tức</a></li>
                                    <li><a href="">Liên Hệ</a></li>
                                    <li><a href="">Chính Sách giao hàng</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="col">
                            <div class="title3">page</div>
                            <iframe src="https://www.facebook.com/plugins/page.php?href=https%3A%2F%2Fwww.facebook.com%2Ffacebook&tabs=timeline&width=272&height=142&small_header=false&adapt_container_width=true&hide_cover=false&show_facepile=false&appId" width="272" height="142" style="border: none; overflow: hidden" scrolling="no" frameborder="0" allowfullscreen="true" allow="autoplay; clipboard-write; encrypted-media; picture-in-picture; web-share"></iframe>
                        </div>
                    </div>
                </div>
            </div>
            <a href="" class="coppy">Copyright @ 2018 Designed by <span>dongphuckhanhlinh.com.</span> All rights reserved.</a>
        </footer>

    </form>
    <div class="layer_modal">
        <div class="modal">
            <img src="style/client/img/icon/close.svg" alt="" class="close">
            <div class="left">
                <div class="WImage">
                    <img src="style/client/img/image/img_poup.jpg" alt="">
                </div>
            </div>
            <div class="right">
                <div class="title">
                    Chào Mừng Bạn Đến với Đồng Phục Khánh Linh
                </div>
                <div class="mota">
                    CHÚNG TÔI SẼ LIÊN HỆ TƯ VẤN VÀ BÁO GIÁ 
                MIỄN PHÍ NGAY CHO BẠN
                </div>
                <div class="decs">Bạn vui lòng nhập thông tin tên và số điện thoại vào bên dưới, chúng tôi sẽ gọi bạn trong vòng 3 phút nữa nhé!</div>
                <div class="model_form">
                    <input type="text" placeholder="Tên Của Bạn" required>
                    <input type="text" placeholder="Số Điện Thoại">
                    <textarea name="" id="" placeholder="Yêu Cầu Của Bạn" required></textarea>
                    <button type="submit">Gọi Cho Tôi Ngay</button>
                </div>
            </div>
        </div>
    </div>
</body>
</html>

<script src="style/client/owl_carousel/owl.carousel.js"></script>
<script src="style/client/fancybox/fancybox.umd.js"></script>
<script src="style/client/js/index.js"></script>
<script src="style/client/js/client.js"></script>

