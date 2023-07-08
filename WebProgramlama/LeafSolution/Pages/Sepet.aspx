<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/_Layout.Master" AutoEventWireup="true" CodeBehind="Sepet.aspx.cs" Inherits="LeafSolution.Pages.Sepet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CPHHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHContent" runat="server">
    <div ng-controller="SepetCtrl">
        <table class="table table-hover table-bordered">
            <thead>
                <tr>
                    <th style="width: 100px;"></th>
                    <th>Ürün Adı</th>
                    <th>Birim Fiyat</th>
                    <th style="width: 100px;">Miktar</th>
                    <th style="width: 100px;">Tutar</th>
                    <th style="width: 60px;"></th>
                </tr>
            </thead>
            <tbody>
                <tr ng-repeat="item in Sepet">
                    <td>
                        <img src="{{item.Urun.Url}}" style="width:70px;"/>
                    </td>
                    <td>{{item.Urun.UrunAdi}}</td>
                    <td>{{item.Urun.BirimFiyat | currency:"₺":2}}</td>
                    <td>
                        <input ng-change="SepettekiMiktarDegistiginde()" class="form-control" type="number" ng-model="item.Miktar" min="1"  />
                    </td>
                    <td>{{item.Urun.BirimFiyat * item.Miktar | currency:"₺":2}}</td>
                    <td>
                        <button ng-click="SepettenUrunCikar(item)" class="btn btn-sm btn-danger">Sil</button>
                    </td>
                </tr>
                <tr>
                    <td colspan="4" class="text-right"><b>Toplam Tutar:</b></td>
                    <td colspan="2"><b>{{ToplamTutarHesapla() | currency:"₺":2}}</b></td>
                </tr>

            </tbody>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHScript" runat="server">
    <script src="/MyContent/AngularScripts/SepetCtrl.js"></script>
</asp:Content>
