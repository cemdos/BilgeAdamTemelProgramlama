app.controller('ViewCartCtrl', function ($scope, $http, toaster) {

    //$scope.PageLoad = function () {
    //    var url = window.location.href;
    //    var categoryId = url.split('/')[url.split('/').length - 1];
    //    $scope.GetProductList(categoryId);
    //}

    //$scope.GetProductList = function (categoryId) {
    //    $http.get(`/Product/GetProductOfCategory/${categoryId}`)
    //        .then(function (response) {
    //            var result = response.data;
    //            if (!result.IsSuccess) {
    //                toaster.pop("error", "Hata", result.ResponseMessage)
    //                return;
    //            }

    //            $scope.productList = result.ModelList;
    //        });
    //}

    //$scope.PageLoad();
});