app.controller('SepetCtrl', function ($scope) {
    $scope.SepettekiMiktarDegistiginde = function () {
        localStorage.setItem("Sepet", JSON.stringify($scope.Sepet));
    }

    $scope.ToplamTutarHesapla = function () {
        var toplamTutar = 0;
        for (var i = 0; i < $scope.Sepet.length; i++) {
            toplamTutar += $scope.Sepet[i].Urun.BirimFiyat * $scope.Sepet[i].Miktar;
        }
        return toplamTutar;
    }
});