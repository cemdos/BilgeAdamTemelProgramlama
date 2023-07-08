<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/_Layout.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="LeafSolution.Pages.Urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CPHHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHContent" runat="server">
    <div ng-controller="UrunlerCtrl">
        <h1>Ürünler Sayfası</h1>
        <div class="row">
            <div class="col-md-3 col-sm-6" ng-repeat="product in products">
                <div class="thumbnail">
                    <img src="{{product.Url}}" alt="https://place-hold.it/240x200">
                    <div class="caption">
                        <h3>{{product.UrunAdi}}</h3>
                        <p>{{product.Aciklama}}</p>
                        <p><strong>{{product.BirimFiyat}}</strong></p>
                        <p>
                            <a ng-click="SepeteAt(product)" href="#" class="btn btn-primary" role="button">Sepete At</a>
                            <a href="#" class="btn btn-default" role="button">Hemen Öde</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHScript" runat="server">
    <script src="/MyContent/AngularScripts/UrunlerCtrl.js"></script>
</asp:Content>
