
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedoresListagemController', ['$scope', 'fornecedorService', FornecedoresListagemController]);

    function FornecedoresListagemController($scope, FornecedorService) {
        var vm = this;
        $scope.ObterFornecedoresAtivos = ObterFornecedoresAtivos;
        ObterFornecedoresAtivos();

        function ObterFornecedoresAtivos() {
            FornecedorService.ObterFornecedoresAtivos().then(function (response) {
                console.log(response);
                $scope.fornecedores = response;
            });

        }
    }
})();


