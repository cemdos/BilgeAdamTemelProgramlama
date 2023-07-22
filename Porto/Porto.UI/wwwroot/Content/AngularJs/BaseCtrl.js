var app = angular.module('PortoApp', []);

app.controller('BaseCtrl', function ($scope, $http) {
    $scope.AllCategoryList = [];

    $scope.PageLoad = function () {
        $scope.GetCategory();
    }

    $scope.GetCategory = function () {
        //spinner'ı baslat
        $http.get("/Category/GetCategory")
            .then(function (response) {
                $scope.AllCategoryList = response.data;
                $scope.ParentCategoryList = $scope.AllCategoryList.filter(x => x.ParentID == null);
                //spinner'ı kapat
            })
            .catch(function (response) {
                alert(response.message);
            })
    }

    $scope.GetSubCategory = function (ParentID) {
        var subCategories = $scope.AllCategoryList.filter(x => x.ParentID == ParentID);
        return subCategories;
    }

    $scope.PageLoad();
});