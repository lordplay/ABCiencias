
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerEditController', ['$scope', '$stateParams', 'ShortenerService', shortenerEditController]);

    function shortenerEditController($scope, $stateParams, ShortenerService) {
        $scope.UrlData = {};

        $scope.ObterNovaUrl = ObterNovaUrl;
        $scope.SalvarEdicao = SalvarEdicao;
        $scope.AlteraStatus = AlteraStatus;
        $scope.UrlEncurtada = 1;

        if ($stateParams.UrlId) {
            ObterDadosUrl($stateParams.UrlId);
        }

        function UrlEncurtada() {
            return $scope.UrlData.Domain + $scope.UrlData.Guid
        }

        function ObterDadosUrl(id) {
            ShortenerService.ObterDadosUrl(id).then(function (response) {
                $scope.UrlData = response;
                $scope.Texto = $scope.UrlData.Status == 1 ? "Ativo" : "Inativo";
                $scope.checked = $scope.UrlData.Status == 1 ? true : false;
            })
        }

        function ObterNovaUrl() {
            ShortenerService.ObterNovaUrl().then(function (response) {
                $scope.UrlData.Guid = response.Guid;
                $scope.UrlData.Domain = response.Domain;
            })
        }
        function SalvarEdicao(objeto) {
            ShortenerService.SalvarEdicao(objeto).then(function (response) {
            })
        }
        function AlteraStatus() {
            if ($scope.UrlData.Status == 1) {
                $scope.UrlData.Status = 0;
                $scope.Texto = "Inativo";
                $('#status').attr('checked', false);
            } else {
                $scope.UrlData.Status = 1;
                $scope.Texto = "Ativo";
                $('#status').attr('checked', true);
            }
        }

    }
})();
