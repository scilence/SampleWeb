<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Memo.aspx.cs" Inherits="SampleWeb.Memo.Memo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" src="<%= ResolveClientUrl("~/Scripts/Memo.js") %>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
  
        <div class="row">
          <div class="col-md-offset-2 col-md-1">主題</div>
          <div class="col-md-4">
            <input type="text" id="txt_title" />
          </div>
        </div>
        <div class="row">
          <div class="col-md-offset-2 col-md-1">內文</div>
          <div class="col-md-4">
            <textarea id="txt_content" rows="5" cols="17"></textarea>
          </div>
        </div>
        <div class="row">
          <div class="col-md-offset-5 col-md-1">
            <button id="btn_Confrim">確認</button>
          </div>
        </div>
    
    </div>
</asp:Content>
