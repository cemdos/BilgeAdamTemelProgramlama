var app = angular.module('PortoApp', ['toaster']);

app.controller('BaseCtrl', function ($scope, $http, toaster) {
    $scope.AllCategoryList = [];

    $scope.PageLoad = function () {
        $scope.GetCategory();
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

    $scope.PageLoad();
});