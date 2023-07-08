//var app = angular.module('leafApp', []);

app.controller('UrunlerCtrl', function ($scope) {
    $scope.products = [
        { UrunAdi: "Urun1", Aciklama: "Aciklama 1",BirimFiyat:50, Url:"https://fastly.picsum.photos/id/670/240/200.jpg?hmac=4pgULroAOibdzFxAjUtqCuXAFgA5pJb0JxKrTY7DPCk"},
        { UrunAdi: "Urun2", Aciklama: "Aciklama 2", BirimFiyat: 60, Url:"https://fastly.picsum.photos/id/606/240/200.jpg?hmac=NLpOVk8bg5zTnsa7p5m1ZpJ92ctmZTWnvZRbOtlpt1s" },
        { UrunAdi: "Urun3", Aciklama: "Aciklama 3", BirimFiyat: 70, Url:"https://fastly.picsum.photos/id/1063/240/200.jpg?hmac=rW698qaiVZ6LmJxQuHn53O0qUhfgu1hCaVvsubrfUY0" },
        { UrunAdi: "Urun4", Aciklama: "Aciklama 4", BirimFiyat: 80, Url: "https://fastly.picsum.photos/id/1063/240/200.jpg?hmac=rW698qaiVZ6LmJxQuHn53O0qUhfgu1hCaVvsubrfUY0" },
        { UrunAdi: "Urun5", Aciklama: "Aciklama 5", BirimFiyat: 90, Url: "https://fastly.picsum.photos/id/1063/240/200.jpg?hmac=rW698qaiVZ6LmJxQuHn53O0qUhfgu1hCaVvsubrfUY0" },
        { UrunAdi: "Urun6", Aciklama: "Aciklama 6", BirimFiyat: 55, Url: "https://fastly.picsum.photos/id/1063/240/200.jpg?hmac=rW698qaiVZ6LmJxQuHn53O0qUhfgu1hCaVvsubrfUY0" },
        { UrunAdi: "Urun7", Aciklama: "Aciklama 7", BirimFiyat: 65, Url: "https://fastly.picsum.photos/id/1063/240/200.jpg?hmac=rW698qaiVZ6LmJxQuHn53O0qUhfgu1hCaVvsubrfUY0" },
        { UrunAdi: "Urun8", Aciklama: "Aciklama 8", BirimFiyat: 75, Url: "https://fastly.picsum.photos/id/1063/240/200.jpg?hmac=rW698qaiVZ6LmJxQuHn53O0qUhfgu1hCaVvsubrfUY0" }
    ];
});