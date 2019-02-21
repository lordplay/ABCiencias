(function () {
    'use strict';

    angular
        .module('MainModule')
        .config(RouteConfig)

    /** @ngInject */
    function RouteConfig($routeProvider, $locationProvider, $stateProvider) {
        $stateProvider
            .state('fornecedores', {
                url: "/forncedores",
                abstract: true,
                template: '<ui-view/>'
            })
            .state('fornecedores.listagem', {
                url: "/listagem",
                templateUrl: 'Templates/Fornecedores/fornecedores-listagem.html',
                controller: "FornecedoresListagemController"
            });
    }

}());