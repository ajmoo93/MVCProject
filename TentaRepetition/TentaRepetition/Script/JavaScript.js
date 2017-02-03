var MyApp = angular.module('MyApp', []);

MyApp.factory('PeopleFactory', function () {
    var persons = [{ FirstName: 'Emil', LastName: 'Lindgren', Age: '23', City: 'Höganäs' },
        { FirstName: 'Anna', LastName: 'Nyman', Age: '22', City: 'Helsingborg' },
        { FirstName: 'Bertil', LastName: 'Svensson', Age: '56', City: 'Helsingborg' },
        { FirstName: 'Sofia', LastName: 'Karlsson', Age: '34', City: 'Lund' },
        { FirstName: 'Andreas', LastName: 'Petersson', Age: '43', City: 'Ystad' },


    ];
    var factory = {};
    factory.GetAllPeople = function () {
        return persons;
    }
    factory.AddPeople = function (person) {
        return persons.push(person)
    }
    return factory;
});

var controllers = {};

controllers.PeopleController = function ($scope, PeopleFactory) {
    $scope.persons = PeopleFactory.GetAllPeople();
    
    $scope.AddPeople = function () {
       
        PeopleFactory.AddPeople({ FirstName: $scope.NewFirstName, LastName: $scope.NewLastName, Age: $scope.NewAge, City: $scope.NewCity })
    }
}
MyApp.controller(controllers);
