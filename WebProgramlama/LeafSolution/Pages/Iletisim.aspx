<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/_Layout.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="LeafSolution.Pages.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CPHHead" runat="server">
    <link href="/MyContent/Styles/ContactStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHContent" runat="server">
    <div class="row" style="margin-top: 10px" ng-controller="IletisimCtrl">
        <div class="col-md-offset-3 col-md-6">
            <%-- <form method="get" action="/Pages/Iletisim.aspx">--%>
            <form name="IletisimForm">
                <div class="form-group row " ng-class="{'has-error':IletisimForm.Ad.$invalid}">
                    <label class="col-md-2">Ad</label>
                    <div class="col-md-10">
                        <input ng-model="txtAd" class="form-control" type="text" name="Ad" placeholder="Adınızı yazınız.." required />
                    </div>
                </div>
                <div class="form-group row" ng-class="{'has-error':IletisimForm.Soyad.$invalid}">
                    <label class="col-md-2">Soyad</label>
                    <div class="col-md-10">
                        <input ng-model="txtSoyad" class="form-control" name="Soyad" type="text" placeholder="Soyadınızı yazınız.." required />
                    </div>
                </div>
                <div class="form-group row" ng-class="{'has-error':IletisimForm.Email.$invalid}">
                    <label class="col-md-2">Email</label>
                    <div class="col-md-10">
                        <input ng-model="txtEmail" class="form-control" name="Email" type="email" placeholder="Email yazınız.." required />
                    </div>
                </div>
                <div class="form-group row" ng-class="{'has-error':IletisimForm.Konu.$invalid}">
                    <label class="col-md-2">Konu</label>
                    <div class="col-md-10">
                        <input ng-model="txtKonu" class="form-control" name="Konu" type="text" placeholder="Konu yazınız.." />
                    </div>
                </div>
                <div class="form-group row" ng-class="{'has-error':IletisimForm.Mesaj.$invalid}">
                    <label class="col-md-2">Mesaj</label>
                    <div class="col-md-10">
                        <textarea class="form-control" name="Mesaj" rows="6" ng-model="txtMesaj"></textarea>
                    </div>
                </div>
                <div class="form-group">
                    <button ng-click="Gonder()" ng-disabled="IletisimForm.$invalid" class="btn btn-sm btn-primary">Gönder</button>
                </div>
                <div class="form-group" ng-show="isShowMessage">
                    <div class="alert alert-success" role="alert">
                        <strong>Bilgi!</strong>
                        <p>Talebiniz tarafımıza ulaşmıştır. En yakın sürede geri dönüş yapılacaktır.</p>
                    </div>
                </div>
            </form>
        </div>
    </div>


    <center>
        <h3>Neredeyiz</h3>
    </center>
    <div class="mapArea">
        <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3011.6766346310287!2d29.020446876504234!3d40.98856112063793!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab98565932cb9%3A0xafaaa9dbc4bf05ab!2sBilgeAdam%20Akademi%20Kad%C4%B1k%C3%B6y!5e0!3m2!1str!2str!4v1687290300998!5m2!1str!2str"
            width="100%" height="450" style="border: 0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHScript" runat="server">
    <script src="/MyContent/AngularScripts/IletisimCtrl.js"></script>
</asp:Content>
