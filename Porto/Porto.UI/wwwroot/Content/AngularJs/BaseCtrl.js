var app = angular.module('PortoApp', ['toaster']);

app.controller('BaseCtrl', function ($scope, $http, toaster) {
    $scope.AllCategoryList = [];
    $scope.txtCount = 1;

    $scope.PageLoad = function () {
        $scope.GetCategory();
        $scope.FillCart();
    }

    $scope.GetCategory = function () {
        $scope.showSpinner = true;
        $http.get("/Category/GetCategory")
            .then(function (response) {
                var result = response.data;
                if (!result.IsSuccess) {
                    alert(result.ResponseMessage);
                    $scope.showSpinner = false;
                    return;
                }

                $scope.AllCategoryList = result.ModelList;
                $scope.ParentCategoryList = $scope.AllCategoryList?.filter(x => x.ParentID == null) ?? [];
                $scope.showSpinner = false;
            })
            .catch(function (response) {
                $scope.showSpinner = false;
                toaster.pop("error", "Hata", response.message)
            })
    }

    $scope.GetSubCategory = function (ParentID) {
        var subCategories = $scope.AllCategoryList.filter(x => x.ParentID == ParentID);
        return subCategories;
    }

    $scope.AddToCart = function (selectedProduct, countModel) {
        var findedProduct = $scope.Cart.find(x => x.Product.ID == selectedProduct.ID);
        if (findedProduct != null)
            findedProduct.Count += countModel;
        else
            $scope.Cart.push({ Count: countModel, Product: selectedProduct });
        localStorage.setItem("Cart", JSON.stringify($scope.Cart));
    }

    $scope.RemoveToCart = function (removingData) {
        var findedProductIndex = $scope.Cart.findIndex(x => x.Product.ID == removingData.Product.ID);
        if (findedProductIndex != -1)
            $scope.Cart.splice(findedProductIndex, 1);
        localStorage.setItem("Cart", JSON.stringify($scope.Cart));
    }

    $scope.FillCart = function () {
        var stringData = localStorage.getItem("Cart");
        if (stringData == null || stringData == "")
            $scope.Cart = [];
        else
            $scope.Cart = JSON.parse(stringData);
    }

    $scope.GetSubTotal = function () {
        var total = 0;
        for (var i = 0; i < $scope.Cart.length; i++) {
            if ($scope.Cart[i].Product.Discount == null)
                var discountValue = 0;
            else
                discountValue = $scope.Cart[i].Product.Discount;

            total += $scope.Cart[i].Count * ($scope.Cart[i].Product.UnitPrice * (1 - discountValue))
        }

        return total;
    }

    $scope.PageLoad();
});