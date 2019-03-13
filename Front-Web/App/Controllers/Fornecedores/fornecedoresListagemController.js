
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedoresListagemController', ['$scope', 'fornecedorService', FornecedoresListagemController]);

    function FornecedoresListagemController($scope, FornecedorService) {
        $scope.ObterFornecedoresAtivos = ObterFornecedoresAtivos;
        ObterFornecedoresAtivos();

        function ObterFornecedoresAtivos() {
            FornecedorService.ObterFornecedoresAtivos().then(function (response) {
                $scope.fornecedores = response;
            });

        }
    }
})();


