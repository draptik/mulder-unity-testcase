<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductList.ascx.cs" Inherits="MyApp.Web.ProductList" %>
<%@ Import Namespace="MyApp.ViewModel" %>
<asp:Repeater runat="server" ID="Rpt_ProductList">
    <ItemTemplate>
        <div>
            <asp:Literal runat="server" ID="ltrProductId" Text="<%# ((ProductVM)Container.DataItem).Id %>" />
            <asp:Literal runat="server" ID="ltrProductName" Text="<%# ((ProductVM)Container.DataItem).Name %>" />
        </div>
    </ItemTemplate>
</asp:Repeater>