using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2;

public partial class Areas_Client_SanPham_Ajax_GioHang : System.Web.UI.Page
{
    private string thaotac = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["thaotac"] != null)
            thaotac = Request.Params["thaotac"];

        switch (thaotac)
        {
            case "ThemVaoGioHang":
                ThemVaoGioHang();
                break;
            case "LayThongTinGioHang":
                LayThongTinGioHang();
                break;
            case "LayTongSoSP":
                LayTongSoSP();
                break;
            case "TongThanhTien":
                TongThanhTien();
                break;
            case "XoaSPTrongGioHang":
                XoaSPTrongGioHang();
                break;
            case "CapNhatSoLuongVaoGioHang":
                CapNhatSoLuongVaoGioHang();
                break;
            case "GuiDonHang":
                GuiDonHang();
                break;
        }

    }

    private void GuiDonHang()
    {
        string ketqua = "";
        string hoTen = Request.Params["hoTen"];
        string diaChi = Request.Params["diaChi"];
        string soDienThoai = Request.Params["soDienThoai"];
        string email = Request.Params["email"];
        string phuongthucthanhtoan = Request.Params["phuongthucthanhtoan"];


        if (Session["GioHang"] != null)
        {
            //Khai báo datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];

            double tongtien = 0;
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                //tongtien += int.Parse(dtGioHang.Rows[i]["SoLuong"].ToString()) * double.Parse(dtGioHang.Rows[i]["GiaSP"].ToString());
            }

            string MaKH = XuLyThongTinKhachHang(hoTen, diaChi, soDienThoai, email);

            string ngaytao = DateTime.Now.ToString();
            DongPhucKhanhLinh.DonDatHang.dondathang_insert(ngaytao, phuongthucthanhtoan, MaKH, hoTen, soDienThoai, email);

            DataTable dtDondathang = DongPhucKhanhLinh.DonDatHang.Thongtin_dathang();
            string madondathang = dtDondathang.Rows[0]["MaDonDatHang"].ToString();


            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                DongPhucKhanhLinh.ChiTietDatHang.ctdathang_insert(dtGioHang.Rows[i]["MaSP"].ToString(), madondathang);
            }


            Session["GioHang"] = null;

            string mathanhtoantructuyen = madondathang;
            switch (phuongthucthanhtoan)
            {
                case "ChuyenKhoan":
                    break;

                case "Onepay":
                    #region Chuyển sang trang Onepay
                    string SECURE_SECRET = OnepayCode.SECURE_SECRET;//Hòa: cần thanh bằng mã thật cấu hình trong app_code
                                                                    // Khoi tao lop thu vien va gan gia tri cac tham so gui sang cong thanh toan
                    VPCRequest conn = new VPCRequest(OnepayCode.VPCRequest);//Hòa: Cần thay bằng cổng thật cấu hình trong app_code
                    conn.SetSecureSecret(SECURE_SECRET);
                    // Add the Digital Order Fields for the functionality you wish to use
                    // Core Transaction Fields
                    conn.AddDigitalOrderField("Title", "onepay paygate");
                    conn.AddDigitalOrderField("vpc_Locale", "vn");//Chon ngon ngu hien thi tren cong thanh toan (vn/en)
                    conn.AddDigitalOrderField("vpc_Version", "2");
                    conn.AddDigitalOrderField("vpc_Command", "pay");
                    conn.AddDigitalOrderField("vpc_Merchant", OnepayCode.Merchant);//Hòa: cần thanh bằng mã thật cấu hình trong app_code
                    conn.AddDigitalOrderField("vpc_AccessCode", OnepayCode.AccessCode);//Hòa: cần thanh bằng mã thật cấu hình trong app_code
                    conn.AddDigitalOrderField("vpc_MerchTxnRef", mathanhtoantructuyen);//Hòa: mã thanh toán
                    conn.AddDigitalOrderField("vpc_OrderInfo", mathanhtoantructuyen);//Hòa: thông tin đơn hàng
                    conn.AddDigitalOrderField("vpc_Amount", (tongtien * 100).ToString());//Hòa: chi phí cần nhân 100 theo yêu cầu của onepay
                    conn.AddDigitalOrderField("vpc_Currency", "VND");
                    conn.AddDigitalOrderField("vpc_ReturnURL", OnepayCode.ReturnURL);//Hòa: địa chỉ nhận kết quả trả về
                                                                                     // Thong tin them ve khach hang. De trong neu khong co thong tin
                    conn.AddDigitalOrderField("vpc_SHIP_Street01", "");
                    conn.AddDigitalOrderField("vpc_SHIP_Provice", "");
                    conn.AddDigitalOrderField("vpc_SHIP_City", "");
                    conn.AddDigitalOrderField("vpc_SHIP_Country", "");
                    conn.AddDigitalOrderField("vpc_Customer_Phone", "");
                    conn.AddDigitalOrderField("vpc_Customer_Email", "");
                    conn.AddDigitalOrderField("vpc_Customer_Id", "");
                    // Dia chi IP cua khach hang
                    conn.AddDigitalOrderField("vpc_TicketNo", Request.UserHostAddress);
                    // Chuyen huong trinh duyet sang cong thanh toan
                    String url = conn.Create3PartyQueryString();
                    #endregion

                    ketqua = url;

                    break;
                case "OnepayQuocTe":
                    string SECURE_SECRET1 = OnepayQuocTeCode.SECURE_SECRET;//Hòa: cần thanh bằng mã thật cấu hình trong app_code; 
                                                                           // Khoi tao lop thu vien va gan gia tri cac tham so gui sang cong thanh toan
                    VPCRequest conn1 = new VPCRequest(OnepayQuocTeCode.VPCRequest);//Hòa: Cần thay bằng cổng thật
                    conn1.SetSecureSecret(SECURE_SECRET1);
                    // Add the Digital Order Fields for the functionality you wish to use
                    // Core Transaction Fields
                    conn1.AddDigitalOrderField("AgainLink", "http://onepay.vn");
                    conn1.AddDigitalOrderField("Title", "onepay paygate");
                    conn1.AddDigitalOrderField("vpc_Locale", "en");//Chon ngon ngu hien thi tren cong thanh toan (vn/en)
                    conn1.AddDigitalOrderField("vpc_Version", "2");
                    conn1.AddDigitalOrderField("vpc_Command", "pay");
                    conn1.AddDigitalOrderField("vpc_Merchant", OnepayQuocTeCode.Merchant);//Hòa: cần thanh bằng mã thật cấu hình trong app_code
                    conn1.AddDigitalOrderField("vpc_AccessCode", OnepayQuocTeCode.AccessCode);//Hòa: cần thanh bằng mã thật cấu hình trong app_code
                    conn1.AddDigitalOrderField("vpc_MerchTxnRef", mathanhtoantructuyen);//Hòa: mã thanh toán
                    conn1.AddDigitalOrderField("vpc_OrderInfo", mathanhtoantructuyen);//Hòa: mã thanh toán
                    conn1.AddDigitalOrderField("vpc_Amount", (tongtien * 100).ToString());//Hòa: chi phí cần nhân 100 theo yêu cầu của onepay

                    conn1.AddDigitalOrderField("vpc_ReturnURL", OnepayQuocTeCode.ReturnURL);//Hòa: địa chỉ nhận kết quả trả về
                                                                                            // Thong tin them ve khach hang. De trong neu khong co thong tin
                    conn1.AddDigitalOrderField("vpc_SHIP_Street01", "");
                    conn1.AddDigitalOrderField("vpc_SHIP_Provice", "");
                    conn1.AddDigitalOrderField("vpc_SHIP_City", "");
                    conn1.AddDigitalOrderField("vpc_SHIP_Country", "");
                    conn1.AddDigitalOrderField("vpc_Customer_Phone", "");
                    conn1.AddDigitalOrderField("vpc_Customer_Email", "");
                    conn1.AddDigitalOrderField("vpc_Customer_Id", "");
                    // Dia chi IP cua khach hang
                    conn1.AddDigitalOrderField("vpc_TicketNo", Request.UserHostAddress);
                    // Chuyen huong trinh duyet sang cong thanh toan
                    String url1 = conn1.Create3PartyQueryString();
                    ketqua = url1;

                    break;
            }
        }
        else
            ketqua = "Giỏ hàng đã hết hạn, vui lòng chọn lại sản phẩm và đặt lại";
        Response.Write(ketqua);
    }

    private string XuLyThongTinKhachHang(string hoTen, string diaChi, string soDienThoai, string email)
    {

        DataTable dt = DongPhucKhanhLinh.ThongTinKH.thongtin_khachhang_email(email);
        if (dt.Rows.Count == 0)
        {
            string matKhau = DongPhucKhanhLinh.MaHoa.MaHoaMD5(email);
            DongPhucKhanhLinh.ThongTinKH.thongtinKH_insert(hoTen, diaChi, soDienThoai, email, matKhau);


            dt = DongPhucKhanhLinh.ThongTinKH.thongtin_khachhang_email(email);
            return dt.Rows[0]["MaKH"].ToString();
        }
        else
            return dt.Rows[0]["MaKH"].ToString();
    }

    private void CapNhatSoLuongVaoGioHang()
    {
        string idSP = Request.Params["idSp"];
        string soluongmoi = Request.Params["soluongmoi"];


        if (Session["GioHang"] != null)
        {
            //Khai báo datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                if (dtGioHang.Rows[i]["MaSP"].ToString() == idSP)
                    dtGioHang.Rows[i]["SoLuong"] = soluongmoi;

            }
            Session["GioHang"] = dtGioHang;
        }
        Response.Write("");
    }

    private void XoaSPTrongGioHang()
    {
        string idSP = Request.Params["idSp"];


        if (Session["GioHang"] != null)
        {
            //Khai báo datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                if (dtGioHang.Rows[i]["MaSP"].ToString() == idSP)
                {
                    dtGioHang.Rows[i].Delete();
                }
            }
            Session["GioHang"] = dtGioHang;
        }
        Response.Write("");
    }

    private void TongThanhTien()
    {
        double tongtien = 0;

        if (Session["GioHang"] != null)
        {
            //Khai báo datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                //tongtien += int.Parse(dtGioHang.Rows[i]["SoLuong"].ToString()) * double.Parse(dtGioHang.Rows[i]["GiaSP"].ToString());
            }
        }
        Response.Write(tongtien);
    }

    private void LayTongSoSP()
    {
        int tongso = 0;

        if (Session["GioHang"] != null)
        {
            //Khai báo datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                tongso += 1;
            }
        }
        Response.Write(tongso);
    }

    private void LayThongTinGioHang()
    {
        string ketQua = "";

        //Nếu tồn tại giỏ hàng thì mới lấy ra kết quả
        if (Session["GioHang"] != null)
        {
            //Khai báo datatable để chứa giỏ hàng
            DataTable dtGioHang = new DataTable();
            dtGioHang = (DataTable)Session["GioHang"];


            ketQua += @"
<table style='width:100%;'>
    <tbody>
        <tr>
            <th>Ảnh Sản Phẩm</th>
            <th>Tên sản phẩm</th>
            <th>Đơn giá</th>
            <th></th>
        </tr>
    ";

            //Chạy vòng lặp và xuất dữ liệu trong giỏ hàng ra dạng bảng
            for (int i = 0; i < dtGioHang.Rows.Count; i++)
            {
                ketQua += @"
        <tr class='line-item' id='tr_" + dtGioHang.Rows[i]["MaSP"] + @"'>
            <td class='item-image'><img class='anhSPGioHang' src='pic/SanPham/" + dtGioHang.Rows[i]["AnhSP"] + @"' /></td>
            <td class='item-title'>
                <a href='/Default.aspx?modul=SanPham&modulphu=ChiTietSanPham&id=" + dtGioHang.Rows[i]["MaSP"] + @"'>" + dtGioHang.Rows[i]["TenSP"] + @"</a>
            </td>
            <td class='item-delete'><a href='javascript://' onclick='XoaSPTrongGioHang(" + dtGioHang.Rows[i]["MaSP"] + @")'>Xóa</a></td>
        </tr>
";
            }

            ketQua += @"
    </tbody>
</table>
";
        }

        Response.Write(ketQua);
    }

    private void ThemVaoGioHang()
    {
        string ketQua = "";

        string id = Request.Params["id"];
        //string soLuong = Request.Params["soLuong"];

        //Lấy thông tin chi tiết sản phẩm được add vào giỏ hàng
        DataTable dt = new DataTable();
        dt = DongPhucKhanhLinh.SanPham.thongtin_sanpham_id(id);
        if (dt.Rows.Count > 0)//Nếu tồn tại sản phẩm mới thực hiện thao tác
        {
            //Nếu chưa có giỏ hàng --> tạo giỏ hàng
            if (Session["GioHang"] == null)
            {
                //Khai báo datatable để lưu thông tin sản phẩm vào giỏ hàng lần đầu tiên
                DataTable dtGioHang = new DataTable();
                dtGioHang.Columns.Add("MaSP");
                dtGioHang.Columns.Add("TenSP");
                dtGioHang.Columns.Add("AnhSP");
                
                //Lưu các thông tin của sản phẩm hiện tại vào datatable
                dtGioHang.Rows.Add(dt.Rows[0]["MaSP"].ToString(), dt.Rows[0]["TenSP"].ToString(),
                    dt.Rows[0]["AnhSP"].ToString());

                //Gán giá trị của bảng tạm - datatable vào giỏ hàng
                Session["GioHang"] = dtGioHang;

            }
            //Nếu đã có giỏ hàng --> thêm mới sản phẩm vào giỏ hàng
            else
            {
                //Khai báo datatable để chứa giỏ hàng
                DataTable dtGioHang = new DataTable();
                dtGioHang = (DataTable)Session["GioHang"];

                //Kiểm tra xem trong giỏ hàng có sản phẩm này chưa
                //Nếu có --> tăng số lượng ở dòng chứa sản phẩm này
                //Nếu chưa có --> thêm sản phẩm vào dòng cuối giỏ hàng

                int viTriSPTrongGioHang = -1;//Nếu sau vòng lặp vị trí thay đổi --> tức là có sản phẩm trong giỏ hàng
                for (int i = 0; i < dtGioHang.Rows.Count; i++)
                {
                    if (dtGioHang.Rows[i]["MaSP"].ToString() == id)
                    {
                        //Có tồn tại sản phẩm này trong giỏ hàng
                        viTriSPTrongGioHang = i;
                        //Thoát vòng lặp
                        break;
                    }
                }

                //Nếu có
                if (viTriSPTrongGioHang != -1)
                {
                    //Lấy ra số lượng hiện tại của sản phẩm đó trong giỏ hàng
                     

                    //Tăng số lượng lên
                    //soLuongHienTai += int.Parse(soLuong);

                    //Cập nhật vào dòng chứa thông tin sản phẩm hiện tại
                    //dtGioHang.Rows[viTriSPTrongGioHang]["SoLuong"] = soLuongHienTai;

                    //Gán lại giá trị của bảng tạm vào giỏ hàng
                    //Gán giá trị của bảng tạm - datatable vào giỏ hàng
                    Session["GioHang"] = dtGioHang;
                }
                //Nếu không có trong giỏ hàng
                else
                {
                    //Lưu các thông tin của sản phẩm hiện tại vào datatable
                    dtGioHang.Rows.Add(dt.Rows[0]["MaSP"].ToString(), dt.Rows[0]["TenSP"].ToString(),
                        dt.Rows[0]["AnhSP"].ToString());

                    //Gán giá trị của bảng tạm - datatable vào giỏ hàng
                    Session["GioHang"] = dtGioHang;
                }
            }
        }
        else
        {
            ketQua = "Không tồn tại sản phẩm này";
        }

        Response.Write(ketQua);
    }
}