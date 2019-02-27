
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerController', ['$scope', 'ShortenerService', shortenerController]);

    function shortenerController($scope, ShortenerService) {

        ObterUrls();
        $scope.StatusLink = StatusLink;
        $scope.AlterarStatus = AlterarStatus;
        $scope.Confirmacao = Confirmacao;
        $scope.Delete = Delete;



        function ObterUrls() {
            ShortenerService.ObterUrlsAtivas().then(function (response) {
                $scope.shorteners = response;
            })
        }

        function StatusLink(int) {
            if (int)
                return "Ativo"
            return "Inativo"
        }
        function AlterarStatus(Id, ) {

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
