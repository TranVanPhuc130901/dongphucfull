<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TinTuc_ChiTiet.ascx.cs" Inherits="Areas_Client_TinTuc_TinTuc_ChiTiet" %>
<section class="title_trang">
            <div class="wrp">
                <span>Trang Chủ</span>
                <span>Tin Tức</span>
                <span>Tư Vấn</span>
            </div>
        </section>
        <section class="sec1_chitiettin">
            <div class="wrp">
                
                <div class="left">
                    <div class="title">Sản Phẩm</div>
                    <hr />
                    <div class="gr_drop">
                          <asp:Literal runat="server" ID="litdanhmuctin"></asp:Literal>
                    </div>
                    <div class="box2_left">
                        <div class="box_title">
                            <div class="title">Bài Viết tham khảo</div>
                        </div>
                        <div class="gr_baiviet">
                            <asp:Literal runat="server" ID="litbaivietthamkhao"></asp:Literal>
                        </div>
                    </div>
                </div>
                <div class="right">
                    <asp:Literal runat="server" ID="litchitiettintuc"></asp:Literal>
                   
                    <div class="lienquan">
                        <h2 class="title">Bài Viết Liên Quan</h2>
                        <hr />
                        <div class="gr_item owl-carousel">
                            <asp:Literal runat="server" ID="litlienquan"></asp:Literal>
                            
                            
                        </div>
                    </div>
                </div>
            </div>
        </section>