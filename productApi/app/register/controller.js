
app.controller("registercontroller", function ($scope, $http) {
    $scope.Reg = {};

    $scope.register = function () {
        console.log($scope.Reg);
        $http.post("api/Account/Register", $scope.Reg).then(function (response) {
            alert("Success");
        });
    }
});