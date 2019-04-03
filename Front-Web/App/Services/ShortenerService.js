
(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('ShortenerService', ['$http', 'RequestFactory', ShortenerService]);

    function ShortenerService($http, RequestFactory) {
        var service = {
            ObterDadosUrl: ObterDadosUrl,
            ObterNovaUrl: ObterNovaUrl,
            SalvarEdicao: SalvarEdicao,
            ObterUrls: ObterUrls,
            CadastrarUrl: CadastrarUrl,
            Delete: Delete,
            Pesquisar: Pesquisar
        };

        function Pesquisar(input) {
            return $http({ method: 'POST', url: RequestFactory.backapiurl + 'Shortener/ObterUrls', data: { page: 1, search: input } }).then(function (response) {
                return response.data;
            });
        }

        function ObterUrls(page, input) {
            return $http({ method: 'POST', url: RequestFactory.backapiurl + 'Shortener/ObterUrls', data: { page: page, search: input } }).then(function (response) {
                return response.data;
            });
        }

        function ObterDadosUrl(id) {
            return $http({ method: 'POST', url: RequestFactory.backapiurl + 'Shortener/ObterUrlPorId', data: id }).then(function (response) {
                return response.data;
            });
        }
        function ObterNovaUrl() {
            return $http({ method: 'POST', url: RequestFactory.backapiurl + 'Shortener/ObterNovaUrl' }).then(function (response) {
                return response.data;
            });
        }
        function SalvarEdicao(objeto) {
            return $http({ method: 'POST', url: RequestFactory.backapiurl + 'Shortener/AtualizarUrl', data: objeto }).then(function (response) {
                return response.data;
            })
        }
        function CadastrarUrl(cadastro) {
            return $http({ method: 'POST', url: RequestFactory.backapiurl + 'Shortener/CadastrarUrl', data: cadastro }).then(function (response) {
                return response.data;
            });
        }
        function Delete(id) {
            return $http({ method: 'POST', url: RequestFactory.backapiurl + 'Shortener/DeletarUrl', data: id }).then(function (response) {
                return response.data;
            });
        }
        return service;
    }
})();
