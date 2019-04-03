
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerController', ['$scope', 'ShortenerService', shortenerController]);

    function shortenerController($scope, ShortenerService) {

        $scope.shorteners = [];
        $scope.totalUrls = 0;

        ObterUrls(1);

        $scope.pesquisar = pesquisar;
        $scope.StatusLink = StatusLink;
        $scope.Confirmacao = Confirmacao;
        $scope.Delete = Delete;
        $scope.pageChaged = pageChaged;

        function pesquisar(search) {
            ShortenerService.Pesquisar(search).then(function (response) {
                $scope.shorteners = response.URLShorteners;
                $scope.totalUrls = response.Count;
            })
        }

        function ObterUrls(page, input) {
            ShortenerService.ObterUrls(page, input).then(function (response) {
                $scope.shorteners = response.URLShorteners;
                $scope.totalUrls = response.Count;
            })
        }

        function pageChaged(newpage, search) {
            ObterUrls(newpage, search);
        }

        function StatusLink(int) {
            if (int)
                return "Ativo"
            return "Inativo"
        }
        function Confirmacao(id, nome) {
            $scope.delete = {};
            $scope.delete.id = id;
            $scope.delete.nome = nome;
            $('#modal').modal("show");
        }
        function Delete(id) {
            $('#modal').modal("hide");
            ShortenerService.Delete(id).then(function (response) {
            })
        }

    }
})();
