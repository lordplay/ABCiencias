
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
            ObterUrlsAtivas: ObterUrlsAtivas,
            CadastrarUrl: CadastrarUrl,
            Delete: Delete
        };

        function ObterUrlsAtivas() {
            return $http.get('http://localhost:59006/api/Shortener/ObterUrlsAtivas').then(function (response) {
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
