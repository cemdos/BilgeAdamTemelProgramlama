var app = angular.module('PortoUIAdmin', []);
var APIService = "http://localhost:5119/api/";

app.controller('RegisterCtrl', function ($scope, $http) {
    $scope.RegisterModel = {};
    $scope.Register = function () {
        $http({
            method: 'POST',
            url: APIService + `Account/Register`,
            data: JSON.stringify($scope.RegisterModel)
        })
            .then(function (success) {
                alert(success.data.ResponseMessage);
                $scope.GetProductList();
            }, function (response) {
                if (response.data.ResponseMessage != null || response.data.ResponseMessage != "")
                    alert(response.data.ResponseMessage)
                else
                    alert(response.message)
            });
    }
});