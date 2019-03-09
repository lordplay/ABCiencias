
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedoresListagemCategoriasController', ['$scope', 'fornecedorService', FornecedoresListagemCategoriasController]);

    function FornecedoresListagemCategoriasController($scope, FornecedorService) {
        ListarCategorias();
        function ListarCategorias() {
            FornecedorService.ObterCategorias().then(function (response) {
                $scope.Categorias = response;
            })
        }

    }
})();
