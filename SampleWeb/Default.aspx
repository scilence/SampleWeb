<%@ Page Title="首頁" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SampleWeb._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <script type="text/javascript" src="<%= ResolveClientUrl("~/Scripts/Default.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveClientUrl("~/Scripts/angular.min.js") %>"></script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        歡迎使用 Sample Web
    </h2>
    <p>
        <h3>1. 增加sqlite</h3>
        <h3>2. 增加logger</h3>
    </p>
</asp:Content>
