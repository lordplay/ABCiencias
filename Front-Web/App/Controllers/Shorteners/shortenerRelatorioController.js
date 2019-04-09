
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerRelatorioController', ['$scope', 'ShortenerService', ShortenerRelatorioController]);

    function ShortenerRelatorioController($scope, ShortenerService) {

        $scope.gerarRelatorio = RelatorioMock;
        $scope.labels = [];
        $scope.data = [];

        function RelatorioMock() {
            var date = new Date(Date.now());
            date.setDate(date.getDate() - 10);

            var filter = {
                Date_inicio: date,
                Data_fim: new Date(Date.now()),
            };

            ShortenerService.GerarRelatorio(filter).then(function (response) {
                if (response.StatusOperacao === 0) {
                    if (response.Retorno) {
                        var d = response.Retorno;
                        console.log(d);
                        alert("cabou");
                        for (let i = 0; i < d.length; i++) {
                            $scope.labels.push(d[i].Url.Nome);
                            $scope.data.push(d[i].Count);
                        }
                        console.log($scope.labels);
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
    }
})();
