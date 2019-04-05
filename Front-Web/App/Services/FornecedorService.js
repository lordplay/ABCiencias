
(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('fornecedorService', ['$http', 'RequestFactory', fornecedorService]);

    function fornecedorService($http, RequestFactory) {

        var service = {
            ObterFornecedoresAtivos: ObterFornecedoresAtivos,
            ObterInformacoesFornecedor: ObterInformacoesFornecedor,
            ObterServicos: ObterServicos,
            CadastrarFornecedor: CadastrarFornecedor
        };

        //retornar apenas os fornecedores 
        function ObterFornecedoresAtivos() {
            return $http.get(RequestFactory.backapiurl + 'Fornecedor/ObterFornecedoresAtivos').then(function (response) {
                return response.data;
            });
        }

        function ObterInformacoesFornecedor(id) {
            return $http.post(RequestFactory.backapiurl + 'Fornecedor/ObterInformacoesFornecedor', id).then(function (response) {
                return response.data;
            }).catch(function (e) {
                console.log(e);
            })
        }

        function ObterServicos() {
            return $http.get(RequestFactory.backapiurl + 'Fornecedor/ObterServicosDisponiveis').then(function (response) {
                return response.data;
            }).catch(function (e) {
                console.log(e);
            })
        }

        function CadastrarFornecedor(cadastro) {
            return $http({ method: 'POST', url: RequestFactory.backapiurl + 'Fornecedor/CadastrarFornecedor', data: cadastro }).then(function (response) {
                return response.data;
            }).catch(function (e) {
                console.log(e);
            })
        }

        return service;
    }
})();

