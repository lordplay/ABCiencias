
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerController', ['$scope', 'ShortenerService', shortenerController]);

    function shortenerController($scope, ShortenerService) {

        $scope.shorteners = [];
        $scope.totalUrls = 0;

        ObterUrls(1);

        $scope.StatusLink = StatusLink;
        $scope.Confirmacao = Confirmacao;
        $scope.Delete = Delete;
        $scope.pageChaged = pageChaged;


        function ObterUrls(page) {
            ShortenerService.ObterUrls(page).then(function (response) {
                $scope.shorteners = response.URLShorteners;
                $scope.totalUrls = response.Count;
            })
        }

        function pageChaged(newpage) {
            ObterUrls(newpage);
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
