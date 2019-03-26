
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerCadastrarController', ['$scope', 'ShortenerService', '$state', ShortenerCadastrarController]);

    function ShortenerCadastrarController($scope, ShortenerService, $state) {
        $scope.Cadastrar = Cadastrar;
        $scope.UrlData = {};
        $scope.ObterNovaUrl = ObterNovaUrl;

        function Cadastrar(cadastro) {
            ShortenerService.CadastrarUrl(cadastro).then(function (response) {
                if(response){
                    alert("Voce será redirecionado")
                }
                $state.go('shortener.edit', { UrlId: response })
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
