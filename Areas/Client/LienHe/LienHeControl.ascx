<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LienHeControl.ascx.cs" Inherits="Areas_Client_LienHe_LienHeControl" %>
<section class="title_trang">
    <div class="wrp">
        <span>Trang Chủ</span>
        <span>Liên Hệ</span>
    </div>
</section>
<section class="lienhe">
    <div class="wrp">
        <div class="left">
            <div class="gioithieu">Chào mừng bạn đã ghé thăm Đồng phục Khánh Linh</div>
            <div class="title">đồnG phục khánh linh</div>
            <div class="lienhe">
                <address>Địa chỉ: 86 Lê Trọng Tấn, Thanh Xuân, Hà Nội</address>
                <a href="" class="tel">Điện thoại : (+84) 965 585 368 - Fax: (+84) 965 585 368</a>
                <a href="" class="email">
                    <div class="mail">Email: dongphuckhanhlinh.com</div>
                    <div class="web">- Website: <span>www.dongphuckhanhlinh.com</span></div>
                </a>
            </div>
            <div class="boder_iframe">
                <div class="WImage">
                    <iframe
                        src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3723.7776922276003!2d105.86792491424552!3d21.04157929271807!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3135abf01acbe66f%3A0x79da91488abb2a45!2zV2VUcmVrIFN0b3JlIC0gSOG7hyB0aOG7kW5nIFRyYW5nIGLhu4sgVGjhu4MgdGhhbyBOZ2_DoGkgVHLhu51p!5e0!3m2!1svi!2s!4v1661703181273!5m2!1svi!2s"
                        width="735"
                        height="385"
                        style="border: 0"
                        allowfullscreen=""
                        loading="lazy"
                        referrerpolicy="no-referrer-when-downgrade"></iframe>
                </div>
            </div>
        </div>
        <div class="right">
            <div class="tieude">
                Vui lòng điền vào mẫu liên hệ và gửi cho chúng tôi. Các bạn tư vấn viên của Đồng phục Khánh Linh
                        sẽ trả lời bạn sớm nhất. Để được hỗ trợ nhanh nhất, vui lòng liên hệ:
                        <a href="">0965 585 368</a>
            </div>
            <asp:Literal ID="ltrThongBao" runat="server"></asp:Literal>
            <div class="gr_input">
                <div class="input">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tbhoten" Display="Dynamic" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:TextBox runat="server" ID="tbhoten" placeholder="Họ Và Tên"></asp:TextBox>
                </div>
                <div class="input">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="tbemail" Display="Dynamic" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:TextBox runat="server" ID="tbemail" placeholder="Email"></asp:TextBox>
                </div>
                <div class="input">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="tbsodienthoai" Display="Dynamic" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:TextBox runat="server" ID="tbsodienthoai" placeholder="Số Điện Thoại"></asp:TextBox>
                </div>
                <div class="input">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="tbtieude" Display="Dynamic" SetFocusOnError="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:TextBox runat="server" ID="tbtieude" placeholder="Tiêu Đề"></asp:TextBox>
                </div>
                <textarea id="tbnoidung" rows="6" runat="server" class="noidung" placeholder="Nội Dung" />
                <div class="onhap">
                    <asp:Button runat="server" ID="btLienHe" Text="Gui" CssClass="btLienHe" OnClick="btLienHe_Click" />
                </div>
            </div>
        </div>
    </div>
</section>
