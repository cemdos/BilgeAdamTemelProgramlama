var app = angular.module('leafApp', []);

app.controller('baseCtrl', function ($scope) {
    var localStorageData = localStorage.getItem("Sepet");
    if (localStorageData == null || localStorageData == "")
        $scope.Sepet = [];
    else {
        $scope.Sepet = JSON.parse(localStorageData);
    }

    $scope.SepeteAt = function (seciliUrun) {
        var arananUrun = $scope.Sepet.find(x => x.Urun.UrunAdi == seciliUrun.UrunAdi);
        if (arananUrun == null)
            $scope.Sepet.push({ Urun: seciliUrun, Miktar: 1 });
        else
            arananUrun.Miktar++;
        localStorage.setItem("Sepet", JSON.stringify($scope.Sepet))
    }

    $scope.SepettenUrunCikar = function (CikarilacakUrun) {
        $scope.Sepet = $scope.Sepet.filter(x => x.Urun.UrunAdi != CikarilacakUrun.Urun.UrunAdi)
        localStorage.setItem("Sepet", JSON.stringify($scope.Sepet));
    }
});