angular.module('MyApp', ['ngRoute'])
.config(function ($routeProvider, $locationProvider) {
    $routeProvider
    .when('/', {
        redirectTo: function () {
            return '/home';
        }
    })
    .when('/home', {
        templateUrl: '/Department/Index',
        controller: 'myCtrl'
    })
    .when('/about', {
        templateUrl: '/Template/About.html',
        controller: 'AboutController'
    })
    .when('/order/:id', {
        templateUrl: '/Template/Order.html',
        controller: 'OrderController'
    })
    .otherwise({
        templateUrl: '/Template/Error.html',
        controller: 'ErrorController'
    })
    $locationProvider.html5Mode(false).hashPrefix('!');
})
.controller('myCtrl', function ($scope, $http) {
    $http.get('/Department/GetAllDepartment') // added an '/' along with deleting Controller portion
        .then(function (response) {
            $scope.departments = response.data;
            console.log($scope.departments);
        
        });         

          
    //insert data
    $scope.AddDepartment = function () {
        var employeeData = $scope.aDepartment;               
        $http.post("/Department/InsertDepartment", employeeData).then(function (response, status) {
            alert(response.data);
            $scope.departments.push($scope.aDepartment);
        })
    }

})
.controller('AboutController', function ($scope) {
    $scope.Message = "This is About Page";
})
.controller('OrderController', function ($scope, $routeParams) {
    $scope.Message = "This is Order Page with query string id value "+ $routeParams.id;
})
.controller('ErrorController', function ($scope) {
    $scope.Message = "This is Error Page ";
})