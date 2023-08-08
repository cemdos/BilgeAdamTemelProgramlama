app.controller('ViewCartCtrl', function ($scope, $http, toaster) {

    $scope.InvoiceModel = {
        Customer: {},
        Cart: $scope.Cart,
    };

    $scope.GetTotal = function () {
        var total = 0;
        for (var i = 0; i < $scope.Cart.length; i++) {
            var cartItem = $scope.Cart[i];
            var discountRate = cartItem.Product.Discount == null ? 0 : cartItem.Product.Discount;
            var DiscountedPrice = cartItem.Count * (cartItem.Product.UnitPrice * (1 - discountRate));
            total += DiscountedPrice;
        }
        return total;
    }

    $scope.SaveInvoice = function () {
        //alert(JSON.stringify($scope.InvoiceModel));
        $http.post('/Invoice/SaveInvoice', JSON.stringify($scope.InvoiceModel))
        .then(function (response) {
            alert("Başarılı");
        }, function (response) {
            alert(JSON.stringify(response));
        });
    }



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