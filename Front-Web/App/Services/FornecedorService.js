﻿
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
            CadastrarFornecedor: CadastrarFornecedor,
            ObterServicoFornecedor: ObterServicoFornecedor,
            UpdateServicoFornecedor: UpdateServicoFornecedor
        };

        //retornar apenas os fornecedores 
        function ObterFornecedoresAtivos() {
            return $http.get(RequestFactory.backapiurl + 'Fornecedor/ObterFornecedoresAtivos').then(function (response) {
                return response.data;
            });
        }

        //Obter informacao do servico do fornecedor
        function ObterServicoFornecedor(id) {
            return $http.post(RequestFactory.backapiurl + 'Fornecedor/ObterServicoFornecedor', id).then(function (response) {
                return response.data;
            })
        }

        function UpdateServicoFornecedor(servico) {
            return $http.post(RequestFactory.backapiurl + 'Fornecedor/UpdateServicoFornecedor', servico).then(function (response) {
                return response.data;
            })
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

