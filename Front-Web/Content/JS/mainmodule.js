var app = angular.module("MainModule", ['ngRoute', 'ui.router', 'angularUtils.directives.dirPagination', 'counter', 'oitozero.ngSweetAlert']);



app.run(function ($http) {
    $http.defaults.headers.common['token'] = "19216801";
})