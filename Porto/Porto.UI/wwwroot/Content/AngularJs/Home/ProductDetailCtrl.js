app.controller('ProductDetailCtrl', function ($scope, $http, toaster) {
    $scope.PageLoad = function () {
        var url = window.location.href;
        var productId = url.split('/')[url.split('/').length - 1];
        $scope.GetProductDetail(productId);
    }

    $scope.GetProductDetail = function (ProductId) {
        $http.get(`/Product/GetProduct/${ProductId}`)
            .then(function (response) {
                var result = response.data;
                if (!result.IsSuccess) {
                    toaster.pop("error", "Hata", result.ResponseMessage)
                    return;
                }

                $scope.productDetail = result.Model;
            });
    }

    $scope.PageLoad();
});