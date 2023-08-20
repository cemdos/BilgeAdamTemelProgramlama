
app.controller('CategoryCtrl', function ($scope, $http) {
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
});