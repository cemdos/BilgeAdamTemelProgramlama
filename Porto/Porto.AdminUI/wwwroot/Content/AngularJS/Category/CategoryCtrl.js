
app.controller('CategoryCtrl', function ($scope, $http, $uibModal) {
    $scope.GetCategoryList = function () {
        $http.get(APIService + `Category/GetCategoryList`)
            .then(function (response) {
                var result = response.data;
                if (result.IsSuccess)
                    $scope.CategoryList = result.ModelList;
                else
                    alert(result.ResponseMessage);
            })
            .catch(function (response) {
                if (response.data.ResponseMessage != null || response.data.ResponseMessage != "")
                    alert(response.data.ResponseMessage)
                else
                    alert(response.message)
            })
    }
    $scope.GetCategoryList();

    $scope.OpenNewCategoryModal = function () {
        var modalInstance = $uibModal.open({
            templateUrl: "/HtmlModalTemplate/NewCategoryModal.html",
            controller: "NewCategoryModalCtrl",
            size: 'sm',
        });

        modalInstance.result.then(function (response) {
            $scope.AddCategory(response);
        });

    };


    $scope.AddCategory = function (model) {

        $http({
            method: 'POST',
            url: APIService + `Category/AddCategory`,
            data: JSON.stringify(model)
        })
            .then(function (success) {
                alert(success)
            }, function (error) {
                alert(error.data);
            });
    }
});

app.controller('NewCategoryModalCtrl', function ($scope, $uibModalInstance) {
    $scope.CategoryModel = {};

    $scope.Save = function () {

        $uibModalInstance.close($scope.CategoryModel);
    }

    $scope.cancel = function () {
        $uibModalInstance.dismiss();
    }

});