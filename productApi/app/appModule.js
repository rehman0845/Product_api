var app = angular.module("myapp", ["ngRoute"]);
app.config(function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl:"/app/shared/_index.html"
        })
        .when("/login", {
            templateUrl: "/app/login/Login.html",
            controller:"logincontroller"
        })
    .when("/register", {
        templateUrl: "/app/register/register.html",
        controller: "registercontroller"
    })
})