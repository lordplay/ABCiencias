
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerCadastrarController', ['$scope', 'ShortenerService', '$state', 'SweetAlert', ShortenerCadastrarController]);

    function ShortenerCadastrarController($scope, ShortenerService, $state, SweetAlert) {
        $scope.Cadastrar = Cadastrar;
        $scope.UrlData = {};
        $scope.ObterNovaUrl = ObterNovaUrl;

        function Cadastrar(cadastro) {
            ShortenerService.CadastrarUrl(cadastro).then(function (response) {
                if (response) {
                    SweetAlert.swal("Parabéns", "Salvo com sucesso", "success");
                    $state.go('shortener.edit', { UrlId: response })
                }
            })
        }

        function ObterNovaUrl() {
            ShortenerService.ObterNovaUrl().then(function (response) {
                $scope.UrlData.Guid = response.Guid;
                $scope.UrlData.Domain = response.Domain;
            })
        }


    }
})();
