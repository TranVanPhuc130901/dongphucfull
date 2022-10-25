<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TinTuc_DanhSach.ascx.cs" Inherits="Areas_Client_TinTuc_TinTuc_DanhSach" %>
 <section class="title_trang">
            <div class="wrp">
                <span>Trang Chủ</span>
                <span>Tin Tức</span>
                <span>Tư Vấn</span>
            </div>
        </section>
        <section class="sec1_tintuc sec1_tintucdm">
            <div class="wrp">
                <div class="left">
                    <div class="title">Tin Tức</div>
                    <hr />
                    <div class="gr_drop">
                        <asp:Literal runat="server" ID="litdanhmuctintuc"></asp:Literal>
                    </div>
                    
                </div>
                <div class="right">
                    <asp:Literal runat="server" ID="litdanhsachtintuc"></asp:Literal>
                    
                   <asp:Literal runat="server" ID="ltrphantrang"></asp:Literal>
                </div>
            </div>
        </section>