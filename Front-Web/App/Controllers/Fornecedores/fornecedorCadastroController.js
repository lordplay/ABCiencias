
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedorCadastroController', ['$scope', 'fornecedorService', 'SweetAlert', '$state',FornecedorCadastroController]);

    function FornecedorCadastroController($scope, fornecedorService, SweetAlert, $state) {

        ObterServicos();
        $scope.checkedService = [];
        $scope.CadastrarFornecedor = CadastrarFornecedor;
        $scope.toggleService = function (servico) {
            if ($scope.checkedService.indexOf(servico) === -1) {
                $scope.checkedService.push(servico);
            } else {
                $scope.checkedService.splice($scope.checkedService.indexOf(servico), 1);
            }
        }

        function ObterServicos() {
            fornecedorService.ObterServicos().then(function (response) {
                $scope.servicos = response;
            });
        }

        function CadastrarFornecedor() {
            var cadastro = {};
            cadastro.razaosocial = $scope.razaosocial;
            cadastro.cnpj = $scope.cnpj;
            cadastro.descricao = $scope.descricao;
            cadastro.servicos = $scope.checkedService;

            fornecedorService.CadastrarFornecedor(cadastro).then(function (response) {
                SweetAlert.swal("Ok", "Cadastro Realizado", "success");
                $state.go('fornecedores.info', { Id: response })
            })
        }

    }
})();
