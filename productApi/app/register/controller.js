app.controller("registercontroller", function ($scope, $http) {
    $scope.register = function () {
        debugger;
        if ($scope.password1 == $scope.password2) {
            data = { useremail: $scope.emailId, password: $scope.password1 };
            $http.post("api/Account/Register",data
                ).then(function (response) {
                    alert("Success");
                })
        }
    }
})