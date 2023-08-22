var app = angular.module('PortoUIAdmin', ['ui.bootstrap']);
var APIService = "http://localhost:5119/api/";

app.controller('BaseCtrl', function ($scope, $http) {

    $scope.UserRole = "";

    $scope.PageLoad = function () {
        $scope.TokenConfiguration();
        $scope.GetRole();
        $scope.TokenControl();
    }

    $scope.TokenConfiguration = function () {
        var token = localStorage.getItem("Token");
        $http.defaults.headers.common['Authorization'] = 'Bearer ' + token;
    }

    $scope.TokenControl = function () {
        $http.get(APIService + `base/apihealthcheck`)
            .catch(function (response) {
                alert("Token Süresi doldu yada izinsiz giriş..");
                window.location.href = "/Home/Login";
            });
    }

    $scope.GetRole = function () {
        $http.get(APIService + `base/GetRole`)
            .then(function (response) {
                if (response.data != null && response.data != "") {
                    $scope.UserRole = response.data;
                }
            })
            .catch(function (response) {
                alert("Token Süresi doldu yada izinsiz giriş..");
                window.location.href = "/Home/Login";
            });
    }


    $scope.Logout = function () {
        localStorage.removeItem("Token");
        window.location.href = "/Home/Login";
    }


    $scope.PageLoad();
});