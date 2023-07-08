//var app = angular.module('leafApp', []);

app.controller('IletisimCtrl', function ($scope) {
    $scope.isShowMessage = false;

    $scope.Gonder = function () {
        //if ($scope.txtAd == "" || $scope.txtAd == null) {
        //    alert("Ad alanı boş geçilemez...");
        //    return;
        //}

        $scope.isShowMessage = true;
    }
});