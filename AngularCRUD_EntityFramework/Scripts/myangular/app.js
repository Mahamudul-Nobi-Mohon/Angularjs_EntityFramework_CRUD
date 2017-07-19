var myApp = angular.module('myApp', ['ngRoute']);

myApp.config(function ($routeProvider) {
   $routeProvider
	.when('/', {
	    templateUrl: '/Department/Index',
	    controller: 'empController2'
	})
	.when('/department', {
	    templateUrl: '/Department/Index',
	    controller: 'empController2'
	})
	.when('/department/create', {
	    templateUrl: '/Department/Create',
	    controller: 'empController2'
	})
	.when('/department/edit/:id', {
	    templateUrl: '/Department/Edit',
	    controller: 'empController2'
	})
	.when('/department/Details/:id', {
	    templateUrl: '/Department/Details',
	    controller: 'empController2'
	})
    .when('/department/delete/:id', {
        templateUrl: '/Department/Delete',
        controller: 'empController2'
    });
});

