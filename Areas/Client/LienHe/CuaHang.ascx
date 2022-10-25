<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CuaHang.ascx.cs" Inherits="Areas_Client_LienHe_CuaHang" %>
<div class="top">
    <div class="title_t">Văn Phòng Giao Dịch</div>
    <div class="wrp">
        <div class="gr_item">
            <asp:Literal runat="server" ID="litcuahang"></asp:Literal>
        </div>
        <hr />
        <asp:Literal runat="server" ID="litvanphong"></asp:Literal>
    </div>
    <asp:Literal runat="server" ID="litdown"></asp:Literal>

    <div class="wrp wrp_drop">
        <asp:Literal runat="server" ID="litlaylistcuahang"></asp:Literal>
    </div>
</div>
