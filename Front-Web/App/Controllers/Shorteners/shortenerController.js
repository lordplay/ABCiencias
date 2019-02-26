
(function () {
    'use strict';

    angular
        .module('MainModule')
        .controller('ShortenerController', ['$scope', 'ShortenerService', shortenerController]);

    function shortenerController($scope, ShortenerService) {

        ObterUrls();
        $scope.StatusLink = StatusLink;
        $scope.AlterarStatus = AlterarStatus;

        function ObterUrls() {
            ShortenerService.ObterUrlsAtivas().then(function (response) {
                $scope.shorteners = response;
            })
        }

        function StatusLink(int) {
            if (int)
                return "Ativo"
            return "Inativo"
        }
        function AlterarStatus(Id,) {

        }

    }
})();
