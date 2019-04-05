
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedorCadastroController', ['$scope', 'fornecedorService', 'SweetAlert', FornecedorCadastroController]);

    function FornecedorCadastroController($scope, fornecedorService, SweetAlert) {

        ObterServicos();
        $scope.checkedService = [];
        $scope.CadastrarFornecedor = CadastrarFornecedor;
        $scope.toggleService = function (servico) {
            if ($scope.checkedService.indexOf(servico) === -1) {
                $scope.checkedService.push(servico);
                console.log($scope.checkedService);
            } else {
                $scope.checkedService.splice($scope.checkedService.indexOf(servico), 1);
            }
        }

        function ObterServicos() {
            fornecedorService.ObterServicos().then(function (response) {
                $scope.servicos = response;
                console.log(response);
            });
        }

        function CadastrarFornecedor() {
            var cadastro = {};
            cadastro.razaosocial = $scope.razaosocial;
            cadastro.cnpj = $scope.cnpj;
            cadastro.descricao = $scope.descricao;
            cadastro.servicos = $scope.checkedService;
            console.log(cadastro);
            fornecedorService.CadastrarFornecedor(cadastro).then(function (response) {
                SweetAlert.swal("Ok", response, "success");
            })
        }

    }
})();
