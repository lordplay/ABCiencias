
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedoresInfoController', ['$scope', 'fornecedorService', '$stateParams', FornecedoresInfoController]);

    function FornecedoresInfoController($scope, fornecedorService, $stateParams) {

        if ($stateParams.Id) {
            ObterInformacoesFornecedor($stateParams.Id);
        }

        function ObterInformacoesFornecedor(id) {
            fornecedorService.ObterInformacoesFornecedor(id).then(function (response) {
                $scope.fornecedor = response;
            })
        }
    }
})();
