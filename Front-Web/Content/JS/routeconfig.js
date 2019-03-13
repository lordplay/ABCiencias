(function () {
    'use strict';

    angular
        .module('MainModule')
        .config(RouteConfig)

    /** @ngInject */
    function RouteConfig($routeProvider, $locationProvider, $stateProvider) {

        fornecedoresRoute();
        UrlShortenerRoute();

        function fornecedoresRoute() {
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
                })
                .state('fornecedores.info', {
                    url: "/listagem/{Id}",
                    templateUrl: 'Templates/Fornecedores/fornecedores-info.html',
                    controller: "FornecedoresInfoController"
                });
        }

        function UrlShortenerRoute() {
            $stateProvider
                .state('shortener', {
                    url: "/shortener",
                    abstract: true,
                    template: '<ui-view/>'
                })
                .state('shortener.listagem', {
                    url: "/listagem",
                    templateUrl: 'Templates/Shortener/shorteners-listagem.html',
                    controller: "ShortenerController"
                })
                .state('shortener.cadastrar', {
                    url: "/cadastrar",
                    templateUrl: 'Templates/Shortener/shorteners-cadastrar.html',
                    controller: "ShortenerCadastrarController"
                })
                .state('shortener.edit', {
                    url: "/listagem/{UrlId}",
                    templateUrl: 'Templates/Shortener/shorteners-edit.html',
                    controller: 'ShortenerEditController'
                });
        }
    }
}());