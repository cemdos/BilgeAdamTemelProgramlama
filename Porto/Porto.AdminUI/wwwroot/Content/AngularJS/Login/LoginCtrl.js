﻿var app = angular.module('PortoUIAdmin', []);
var APIService = "http://localhost:5119/api/";

app.controller('LoginCtrl', function ($scope, $http) {
    $scope.Login = function () {
        var Username = $scope.Username;
        var Password = $scope.Password;

        $http.get(APIService + `Account/Login/${Username}/${Password}`)
            .then(function (response) {
                var result = response.data;
                alert(JSON.stringify(result))
            })
            .catch(function (response) {
                if (response.data.ResponseMessage != null || response.data.ResponseMessage != "")
                    alert(response.data.ResponseMessage)
                else
                    alert(response.message)
            })
    }
});