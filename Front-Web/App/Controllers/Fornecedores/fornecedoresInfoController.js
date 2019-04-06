
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedoresInfoController', ['$scope', 'fornecedorService', '$stateParams', 'SweetAlert', FornecedoresInfoController]);

    function FornecedoresInfoController($scope, fornecedorService, $stateParams, SweetAlert) {
        $scope.detalhesServico = ObterServicoFornecedor;
        $scope.UpdateServicoFornecedor = UpdateServicoFornecedor;

        clear();

        function clear() {
            $scope.servico = {};
        }

        function ObterServicoFornecedor(id) {
            fornecedorService.ObterServicoFornecedor(id).then(function (response) {
                $("#modal-info-servico").modal("show");
                $scope.servico = response;
            })
        }

        if ($stateParams.Id) {
            ObterInformacoesFornecedor($stateParams.Id);
        }

        function ObterInformacoesFornecedor(id) {
            fornecedorService.ObterInformacoesFornecedor(id).then(function (response) {
                $scope.fornecedor = response;
            })
        }

        function UpdateServicoFornecedor(servico) {
            fornecedorService.UpdateServicoFornecedor(servico).then(function (response) {
                SweetAlert.swal("Parabéns", "Informações Atualizadas", "Success");
                $("#modal-info-servico").modal("hide");

            })
        }

    }
})();
