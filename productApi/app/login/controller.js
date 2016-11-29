app.controller("logincontroller", function ($scope, $http) {
    $scope.login = function ()
    {
        $http.post("api/Account/")
    }
})