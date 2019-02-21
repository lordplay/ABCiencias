
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('FornecedoresListagemController', ['$scope', FornecedoresListagemController]);

    function FornecedoresListagemController($scope) {
        var vm = this;

        vm.title = '';

        activate();

        function activate() { }
    }
})();
