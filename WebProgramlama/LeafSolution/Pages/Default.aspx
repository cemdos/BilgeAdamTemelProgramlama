<%@ Page Title="" Language="C#" MasterPageFile="~/Shared/_Layout.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LeafSolution.Pages.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CPHHead" runat="server">
    <link href="/MyContent/Styles/Plugins/CubeSlider.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPHContent" runat="server">
    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
            <li data-target="#carousel-example-generic" data-slide-to="1"></li>
            <li data-target="#carousel-example-generic" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <div class="jumbotron jumbotronSlider">
                    <h1>Ziyaretçilerinizi arttırın!</h1>
                    <p>Nulla fringilla congue dictum. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                    <p><a class="btn btn-primary" href="#" role="button">Ayrıntı</a></p>
                </div>
            </div>
            <div class="item">
                <div class="jumbotron jumbotronSlider">
                    <h1>Kurumsal Web Çözümleri!</h1>
                    <p>
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur euismod lacus.
                    </p>
                    <p><a class="btn btn-primary" href="#" role="button">Ayrıntı</a></p>
                </div>
            </div>
            <div class="item">
                <div class="jumbotron jumbotronSlider">
                    <h1>Satış Sonrası Destek</h1>
                    <p>Mauris tellus lacus, ornare ligula eu, pellentesque iaculis purus. </p>
                    <p><a class="btn btn-primary" href="#" role="button">Ayrıntı</a></p>
                </div>
            </div>
        </div>

        <!-- Controls -->
        <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

    <center>
        <h3>2013'ün En Hızlı Büyüyen Hosting Firmasıyız</h3>
    </center>
    <img class="img-left" src="https://zinzinzibidi.com/Areas/leaf_solutions/Content/img/cake.png" />
    <div class="slider-right" style="width: 240px; height: 240px">
        <div class="slider">
            <div class="cubeContainer">
                <div class="slide x"></div>
                <div class="slide y"></div>
                <div class="slide z"></div>
            </div>
        </div>
    </div>
    <p style="text-align: justify">Vivamus ac nulla hendrerit, adipiscing lacus sodales, gravida nibh. Duis lorem orci, tincidunt ac vulputate nec, faucibus eget nunc. Mauris quis iaculis neque. Donec sit amet mollis urna. Ut id orci quis neque egestas suscipit. Nam imperdiet ultricies adipiscing. Maecenas nec dui dapibus, sodales erat et, tincidunt nunc. Vivamus pharetra auctor mauris id malesuada. Nam ultricies nisi odio, non dignissim massa viverra volutpat. Fusce gravida pharetra sapien, porta tempor neque pellentesque eget. Maecenas ut tortor ac nunc viverra tempor tristique nec felis. Sed justo risus, volutpat a tincidunt vel, bibendum ac metus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Pellentesque viverra tortor nec lectus viverra convallis. Fusce quis lorem mi.</p>
    <p style="text-align: justify">Nulla facilisi. Fusce ac sodales nibh. Maecenas ullamcorper neque sit amet lorem faucibus tempor. Sed tincidunt magna nisl, eu accumsan est fringilla vel. Proin eu tincidunt elit, quis imperdiet diam. Vivamus ullamcorper aliquam mi, vel vehicula eros interdum at. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nullam sem nibh, pellentesque vitae ornare eget, sodales molestie nibh. Proin id pellentesque velit, et condimentum lectus. Nunc id nibh est. Fusce id tincidunt orci, a vestibulum ante. Nulla non magna consequat, vehicula libero a, auctor est. Phasellus lobortis nec nulla ut interdum. Suspendisse potenti. Aenean iaculis lacinia eros, vitae ultricies lectus eleifend aliquet. Sed fermentum, ligula eget faucibus fermentum, arcu sapien fringilla massa, a semper lacus ante eu ligula.</p>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CPHScript" runat="server">
</asp:Content>
