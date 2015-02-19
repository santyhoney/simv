(function () {
    var app = angular.module("miniSimverApp", ["ngRoute","ngResource"]);
    app.config(function ($routeProvider) {
        $routeProvider
            .when('/', {                
                controller: 'Entidades',
                controllerAs: 'vm',
                templateUrl: 'views/entidades.html'
            })
            .when('/entidades', {
                controller: 'Entidades',
                controllerAs: 'vm',
                templateUrl: 'views/entidades.html'
            })
            .when('/municipios/:entidadId', {
                controller: 'Municipio',
                controllerAs: 'vm',
                templateUrl: 'views/municipios.html'
            })
         .otherwise({ redirectTo: '/' });
    });
}());