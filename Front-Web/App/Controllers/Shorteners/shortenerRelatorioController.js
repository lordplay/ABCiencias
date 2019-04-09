
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerRelatorioController', ['$scope', 'ShortenerService', ShortenerRelatorioController]);

    function ShortenerRelatorioController($scope, ShortenerService) {
        $scope.gerarRelatorio = RelatorioMock;
        function RelatorioMock() {
            var date = new Date(Date.now());
            date.setDate(date.getDate() - 10);

            var filter = {
                Date_inicio: date,
                Data_fim: new Date(Date.now()),
                IdObjeto: 4014
            };

            ShortenerService.GerarRelatorio(filter).then(function (response) {
                if (response.StatusOperacao === 0) {
                    if (response.Retorno) {
                        console.log(response);
                    }
                    else {
                        Console.log("Vazio");
                    }
                } else {
                    console.log("Erro");
                    console.log(response);
                }
            })

        };

        //function GerarRelatorio(inicio,fim,) {
        //    var SolicitacaoRelatorio = {
        //        Data_inicio: Data.
        //    }

        //}




    }
})();
