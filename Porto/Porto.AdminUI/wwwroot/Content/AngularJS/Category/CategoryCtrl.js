
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
        var milisecond = (new Date()).getMilliseconds();
        var modalInstance = $uibModal.open({
            templateUrl: `/HtmlModalTemplate/NewCategoryModal.html?V=${milisecond}`,
            controller: "NewCategoryModalCtrl",
            size: 'sm',
        });

        modalInstance.result.then(function (response) {
            response.ParentID = parseInt(response.ParentID);
            $scope.AddCategory(response);
        },
            function (response) {
                console.log(response);
            });

    };


    $scope.AddCategory = function (model) {

        $http({
            method: 'POST',
            url: APIService + `Category/AddCategory`,
            data: JSON.stringify(model)
        })
            .then(function (success) {
                alert(success.data.ResponseMessage);
                $scope.GetCategoryList();
            }, function (error) {
                if (error.data.ResponseMessage != null)
                    alert(error.data.ResponseMessage);
                else
                    alert(error.message);
            });
    }


    $scope.RemoveCategory = function (id) {
        var state = confirm("Silmek istediğinize eminmisiniz");
        if (!state)
            return;

        $http.get(APIService + `Category/RemoveCategory/${id}`)
            .then(function (response) {
                alert(response.data.ResponseMessage);
                $scope.GetCategoryList();
            })
            .catch(function (response) {
                if (response.data.ResponseMessage != null || response.data.ResponseMessage != "")
                    alert(response.data.ResponseMessage)
                else
                    alert(response.message)
            })
    }

    $scope.OpenEditCategoryModal = function (categoryModel) {
        var modalInstance = $uibModal.open({
            templateUrl: "/HtmlModalTemplate/EditCategoryModal.html",
            controller: "EditCategoryModalCtrl",
            size: 'sm',
            resolve: { 
                SelectedCategory: function () {
                    return categoryModel;
                }
            }
        });

        modalInstance.result.then(function (response) {
            $scope.EditCategory(response);
        });
    }

    $scope.EditCategory = function (model) {

        $http({
            method: 'POST',
            url: APIService + `Category/EditCategory`,
            data: JSON.stringify(model)
        })
            .then(function (success) {
                alert(success.data.ResponseMessage);
                $scope.GetCategoryList();
            }, function (error) {
                if (error.data.ResponseMessage != null)
                    alert(error.data.ResponseMessage);
                else
                    alert(error.message);
            });
    }

});

app.controller('NewCategoryModalCtrl', function ($scope, $uibModalInstance, $http) {
    $scope.CategoryModel = {};
    $scope.ParentCategoryList = [];

    $scope.PageLoad = function () {
        $scope.GetParentCategoryList();
    }

    $scope.GetParentCategoryList = function () {
        $http.get(APIService + `Category/GetCategoryList`)
            .then(function (response) {
                var result = response.data;
                if (result.IsSuccess)
                    $scope.ParentCategoryList = result.ModelList;
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

    $scope.Save = function () {

        $uibModalInstance.close($scope.CategoryModel);
    }

    $scope.cancel = function () {
        $uibModalInstance.dismiss();
    }

    $scope.PageLoad();
});

app.controller('EditCategoryModalCtrl', function ($scope, $uibModalInstance, SelectedCategory) {
    $scope.CategoryModel = SelectedCategory;

    $scope.Save = function () {
        $uibModalInstance.close($scope.CategoryModel);
    }

    $scope.cancel = function () {
        $uibModalInstance.dismiss();
    }

});