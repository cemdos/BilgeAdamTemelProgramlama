
app.controller('ProductCtrl', function ($scope, $http, $uibModal) {
    $scope.GetProductList = function () {
        $http.get(APIService + `Product/GetProductList`)
            .then(function (response) {
                var result = response.data;
                $scope.ProductList = result.ModelList;
            })
            .catch(function (response) {
                $scope.ErrorMessage(response);
            })
    }
    $scope.GetProductList();

    $scope.OpenNewProductModal = function () {
        var milisecond = (new Date()).getMilliseconds();
        var modalInstance = $uibModal.open({
            templateUrl: `/HtmlModalTemplate/NewProductModal.html?V=${milisecond}`,
            controller: "NewProductModalCtrl",
            size: 'md',
        });

        modalInstance.result.then(function (response) {
            $scope.AddProduct(response);
        });
    }

    $scope.AddProduct = function (model) {
        $http({
            method: 'POST',
            url: APIService + `Product/AddProduct`,
            data: JSON.stringify(model)
        })
            .then(function (success) {
                alert(success.data.ResponseMessage);
                $scope.GetProductList();
            }, function (error) {
                $scope.ErrorMessage(error);
            });
    }
});

app.controller('NewProductModalCtrl', function ($scope, $uibModalInstance, $http) {
    $scope.ProductModel = {};

    $scope.PageLoad = function () {
        $scope.GetCategoryList();
    }

    $scope.GetCategoryList = function () {
        $http.get(APIService + `Category/GetCategoryList`)
            .then(function (response) {
                var result = response.data;
                $scope.CategoryList = result.ModelList;
            })
            .catch(function (response) {
                $scope.ErrorMessage(response);
            })
    }

    $scope.Save = function () {
        $uibModalInstance.close($scope.ProductModel);
    }

    $scope.cancel = function () {
        $uibModalInstance.dismiss();
    }

    $scope.PageLoad();
});