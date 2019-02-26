
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerEditController', ['$scope', '$stateParams', 'ShortenerService', shortenerEditController]);

    function shortenerEditController($scope, $stateParams, ShortenerService) {

        $scope.ObterNovaUrl = ObterNovaUrl;
        $scope.SalvarEdicao = SalvarEdicao;

        if ($stateParams.UrlId) {
            ObterDadosUrl($stateParams.UrlId);
        }

        function ObterDadosUrl(id) {
            ShortenerService.ObterDadosUrl(id).then(function (response) {
                $scope.UrlData = response;
            })
        }

        function ObterNovaUrl() {
            ShortenerService.ObterNovaUrl().then(function (response) {
                $scope.UrlData.Guid = response;
            })
        }
        function SalvarEdicao(objeto) {
            ShortenerService.SalvarEdicao(objeto).then(function (response) {
            })
        }
    }
})();
