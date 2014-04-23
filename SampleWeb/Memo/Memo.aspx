<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Memo.aspx.cs" Inherits="SampleWeb.Memo.Memo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" src="<%= ResolveClientUrl("~/Scripts/Memo.js") %>"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container" ng-app="memoApp" ng-controller="memoCtrl">
    
        <div id="adddiv" ng-show="memo.isShow">
            <div class="row">
              <div class="col-md-offset-7 col-md-1">
                <button id="btn_Confrim" class="btn btn-primary btn-lg btn-block"  ng-click="Confirm($event)">確認</button>
              </div>
            </div>
            <div class="row">
              <div class="col-md-offset-2 col-md-1">
                主題
              </div>
              <div class="col-md-4">
                <input type="text" id="txt_title" class="form-control" placeholder="主題" ng-model="memo.Title" />
              </div>
            </div>
            <div class="row">
              <div class="col-md-offset-2 col-md-1">
                內文
              </div>
              <div class="col-md-4">
                <textarea id="txt_content" class="form-control" rows="5" placeholder="內文" ng-model="memo.Content"  ></textarea>
              </div>
            </div>
        </div>
    
        <div id="listdiv" ng-show="list.isShow">
            <div class="row">
              <div class="col-md-offset-7 col-md-1">
                <button id="btn_GoBack" class="btn btn-primary btn-lg btn-block"  ng-click="GoBack($event)">回到新增</button>
              </div>
            </div>
            <div class="row">
              <div class="col-md-offset-2 col-md-1">
                主題
              </div>
              <div class="col-md-4">
                {{ list.Title }} 
              </div>
            </div>
            <div class="row">
              <div class="col-md-offset-2 col-md-1">
                內文
              </div>
              <div class="col-md-4">
                {{ list.Content }} 
              </div>
            </div>
        </div>

    </div>
</asp:Content>
