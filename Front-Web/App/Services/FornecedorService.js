
(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('fornecedorService', ['$http', 'RequestFactory', fornecedorService]);

    function fornecedorService($http, RequestFactory) {

        var service = {
            ObterFornecedoresAtivos: ObterFornecedoresAtivos,
            ObterInformacoesFornecedor: ObterInformacoesFornecedor
        };

        //retornar apenas os fornecedores ativos
        function ObterFornecedoresAtivos() {
            return $http.get(RequestFactory.backapiurl + '/Fornecedor/ObterFornecedoresAtivos').then(function (response) {
                return response.data;
            });
        }

        function ObterInformacoesFornecedor(id) {
            return $http.post(RequestFactory.backapiurl + '/Fornecedor/ObterInformacoesFornecedor', id).then(function (response) {
                return response.data;
            }).catch(function (e) {
                console.log(e);
            })
        }

        return service;
    }
})();

