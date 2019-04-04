
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedorCadastroController', ['$scope', 'fornecedorService', FornecedorCadastroController]);

    function FornecedorCadastroController($scope, fornecedorService) {

        $scope.checkedService = [];
        $scope.toggleService = function (servico) {
            if ($scope.checkedService.indexOf(servico) === -1) {
                $scope.checkedService.push(servico);
                console.log($scope.checkedService);
            } else {
                $scope.checkedService.splice($scope.checkedService.indexOf(servico), 1);
                console.log($scope.checkedService);
            }
        }

        ObterServicos();
        function ObterServicos() {
            fornecedorService.ObterServicos().then(function (response) {
                $scope.servicos = response;
                console.log(response);
            });
        }


    }
})();
