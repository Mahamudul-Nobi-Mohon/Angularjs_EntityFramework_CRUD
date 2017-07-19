myApp.controller('empController2', function ($route, $scope, $http, $routeParams) {
    $scope.departments = function () {
        $http.get('/Department/GetAllDepartment').then(function (response) {
            $scope.departments = response.data;
        });
    };
    $scope.AddDepartment = function (info) {
        $http.post('/Department/InsertDepartment', info).then(function (response) {
            alert(response.data);
            window.location.href = 'http://localhost:65172/Home/#/';
        });
    };
    $scope.GetSingleDepartment = function () {
        var id = $routeParams.id;
        $http.post('/Department/GetSingleDepartment/', { 'id': id }).then(function (response) {
            var emp = response.data;
            $scope.department = emp;
            console.log($scope.department);
        });
    };
    $scope.UpdateDepartment = function (info) {
        $http.post('/Department/UpdateDepartment', info).then(function (response) {
            alert(response.data);
            window.location.href = 'http://localhost:65172/Home/#/';
        });
    };
    $scope.DeleteDepartment = function (id) {
        var id = id;
        $http.post('/Department/DeleteDepartment', { 'id': id }).then(function (response) {
            alert(response.data);
            window.location.href = 'http://localhost:65172/Home/#/';
           // $route.reload();
        });
    };
    $scope.Cancel = function () {
         window.location.href = 'http://localhost:65172/Home/#/';
            // $route.reload();
       
    };

});
