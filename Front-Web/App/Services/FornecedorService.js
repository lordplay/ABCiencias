
(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('fornecedorService', ['$http', 'RequestFactory', fornecedorService]);

    function fornecedorService($http, RequestFactory) {

        var service = {
            ObterFornecedoresAtivos: ObterFornecedoresAtivos
        };

        //retornar apenas os fornecedores ativos
        function ObterFornecedoresAtivos() {
            return $http.get(RequestFactory.backapiurl + '/Fornecedor').then(function (response) {
                return response.data;
            });
        }

        return service;
    }
})();

