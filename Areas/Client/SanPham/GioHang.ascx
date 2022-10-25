<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GioHang.ascx.cs" Inherits="Areas_Client_SanPham_GioHang" %>
<div class="wrp">
    <div class="tongsp">
        Bạn đang có 
        <span class="laytongsosanpham"></span>
        trong giỏ hàng
    </div>

    <div id="thongtingiohang">
    </div>

    <div class="giohang">
        <div class="dathang">
            <div class="modal-footer">
                <div class="dienThongTinDatHang">
                    <div class="goiY">
                        Quý khách vui lòng điền đầy đủ thông tin theo form phía dưới và nhấn nút Đặt hàng.<br />
                        Lưu ý: Nếu quý khách điền vào ô Email thì hệ thống sẽ kiểm tra và tạo cho quý khách một tài khoản thành viên với tên đăng nhập và mật khẩu chính là email của quý khách để quý khách có thể đặt hàng dễ dàng hơn ở lần sau.
                    </div>
                    <div class="row">
                        <div class="col-lg-3">
                            <div class="modal-title-note">
                                Họ tên (*):
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="modal-note">
                                <input id="tbHoTen" type="text" />
                            </div>
                        </div>
                        <div class="cb"></div>
                    </div>

                    <div class="row">
                        <div class="col-lg-3">
                            <div class="modal-title-note">
                                Địa chỉ:
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="modal-note">
                                <input id="tbDiaChi" type="text" />
                            </div>
                        </div>
                        <div class="cb"></div>
                    </div>

                    <div class="row">
                        <div class="col-lg-3">
                            <div class="modal-title-note">
                                Số điện thoại (*):
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="modal-note">
                                <input id="tbSoDienThoai" type="text" />
                            </div>
                        </div>
                        <div class="cb"></div>
                    </div>

                    <div class="row">
                        <div class="col-lg-3">
                            <div class="modal-title-note">
                                Email:
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="modal-note">
                                <input id="tbEmail" type="text" />
                            </div>
                        </div>
                        <div class="cb"></div>
                    </div>
                </div>

            </div>
            <div class="CacHinhThucThanhToan">
                <div class="goiY">
                    Quý khách vui lòng chọn một trong các hình thức thanh toán dưới đây để thanh toán cho đơn hàng của mình
                </div>
                <div>
                    <input id="rbChuyenKhoan" type="radio" name="rbHinhThucThanhToan" /><label for="rbChuyenKhoan">Thanh toán chuyển khoản</label>
                    <div class="paymentInfo">
                        Tên tài khoản: Công ty cổ phần dịch vụ Tất Thành<br />
                        Số tài khoản: 1305201005711<br />
                        Ngân hàng nông nghiệp và phát triển nông thôn Việt Nam - Chi nhánh Tràng An
                    </div>
                </div>
                <br />
                <div>
                    <input id="rbOnepay" type="radio" name="rbHinhThucThanhToan" checked="checked" /><label for="rbOnepay">Thanh toán trực tuyến qua thẻ ATM</label>
                    <div class="paymentInfo">
                        <script type="text/javascript" src="http://202.9.84.88/documents/payment/logoscript.jsp?logos=at&lang=vi"></script>
                        <div class="cb">
                            <!---->
                        </div>
                    </div>
                </div>
                <br />
                <div>
                    <input id="rbOnepayQuocTe" type="radio" name="rbHinhThucThanhToan" /><label for="rbOnepayQuocTe">Thanh toán trực tuyến qua thẻ Visa, Master, American Express,...</label>
                    <div class="paymentInfo">
                        <script type="text/javascript" src="http://202.9.84.88/documents/payment/logoscript.jsp?logos=v,m,a,j,u&lang=en"></script>
                        <div class="cb">
                            <!---->
                        </div>
                    </div>
                </div>
                <br />
            </div>
            <div class="btn">
                <a href="/default.aspx?dm=san-pham&danhmucphu=danhmuc">Tiếp tục mua hàng</a>
                <div class="btn_muahang">
                    <a href="javascript://" onclick="GuiDonHang()">Đặt Hàng</a>
                </div>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    function LayThongTinGioHang() {
        $.post("Areas/Client/SanPham/Ajax/GioHang.aspx",
                {
                    "thaotac": "LayThongTinGioHang"
                },
                function (data, status) {

                    $("#thongtingiohang").html(data);


                });
    }
    function LayTongSoSP() {
        $.post("Areas/Client/SanPham/Ajax/GioHang.aspx",
                {
                    "thaotac": "LayTongSoSP"
                },
                function (data, status) {

                    $(".laytongsosanpham").html(data);


                });
    }
    function TongThanhTien() {
        $.post("Areas/Client/SanPham/Ajax/GioHang.aspx",
                {
                    "thaotac": "TongThanhTien"
                },
                function (data, status) {

                    $(".tongthanhtien").html(data);


                });
    }
    LayThongTinGioHang();
    LayTongSoSP();
    TongThanhTien();


    function XoaSPTrongGioHang(idSP) {

        if (confirm("Bạn có muốn xoá sản phẩm này không")) {


            $.post("Areas/Client/SanPham/Ajax/GioHang.aspx",
                    {
                        "thaotac": "XoaSPTrongGioHang",
                        "idSP": idSP
                    },
                    function (data, status) {

                        if (data === "") {
                            $("#tr_" + idSP).remove();

                            LayTongSoSP();
                            TongThanhTien();
                        }


                    });
        }
    }

    function CapNhatSoLuongVaoGioHang(idSP) {
        var soluongmoi = $("#quantity_" + idSP).val();
        $.post("Areas/Client/SanPham/Ajax/GioHang.aspx",
                {
                    "thaotac": "CapNhatSoLuongVaoGioHang",
                    "idSP": idSP,
                    "soluongmoi": soluongmoi
                },
                function (data, status) {

                    if (data === "") {

                        LayTongSoSP();
                        TongThanhTien();
                    }


                });
    }

    function GuiDonHang() {
        if ($("#tbHoTen").val() !== "" && $("#tbSoDienThoai").val() !== "") {

            var phuongthucthanhtoan = "";
            if ($("#rbChuyenKhoan").is(":checked")) phuongthucthanhtoan = "ChuyenKhoan";
            if ($("#rbOnepay").is(":checked")) phuongthucthanhtoan = "Onepay";
            if ($("#rbOnepayQuocTe").is(":checked")) phuongthucthanhtoan = "OnepayQuocTe";

            $.post("Areas/Client/SanPham/Ajax/GioHang.aspx",
                {
                    "thaotac": "GuiDonHang",
                    "hoTen": $("#tbHoTen").val(),
                    "diaChi": $("#tbDiaChi").val(),
                    "soDienThoai": $("#tbSoDienThoai").val(),
                    "email": $("#tbEmail").val(),
                    "phuongthucthanhtoan": phuongthucthanhtoan
                },
                function (data, status) {
                    if (phuongthucthanhtoan === "ChuyenKhoan") {
                        if (data === "") {
                            alert("Bạn đã gửi đơn hàng thành công");
                            location.href = "/";

                        }
                    } else {
                        location.href = data;
                    }

                });
        } else {
            alert("Bạn vui lòng đền họ tên và số điện thoại để đặt hàng")
        }

    }
</script>
