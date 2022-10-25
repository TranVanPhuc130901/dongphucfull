<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TinTuc.ascx.cs" Inherits="Areas_Client_TinTuc_TinTuc" %>
<section class="title_trang">
    <div class="wrp">
        <span>Trang Chủ</span>
        <span>Tin Tức</span>
    </div>
</section>
<section class="sec1_tintuc">
    <div class="wrp">
        <div class="left">
            <div class="title">Tin Tức</div>
            <hr />
            <div class="gr_drop">
                <asp:Literal runat="server" ID="litdanhmuctin"></asp:Literal>
            </div>
        </div>
        <div class="right">
            <asp:Literal runat="server" ID="litheadtintuc"></asp:Literal>
        </div>
    </div>
</section>
