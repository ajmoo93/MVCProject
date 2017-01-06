var mainApp = angular.module("mainApp", ['ngRoute']);

mainApp.config(function ($routeProvider) {
    $routeProvider
    .when('/', {
        controller: "PeopleController",
        templateUrl: "../PartialViews/home.html"
    })
    .when('/PeopleListing', {
        controller: "PeopleController",
        templateUrl: "../PartialViews/PeopleListing.html"
    })
    .when('/tomato', {
        template: "<h2>Mr-toddle did you eat my tomatos?</h2>"
    })
    .otherwise({
        redirectTo: '/'
    })
    
});
mainApp.controller("PeopleController", function ($scope) {
    $scope.people = [{ Name: 'Emil', city: 'Citycity' },
        {Name: 'Anna', city: 'TwingCity' },
        {Name: 'Panna', city: 'WingCity' }];

    $scope.message = "Mr-Toddle you need to work now, no games for you.";
});