(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('RequestFactory', [RequestFactory]);

    function RequestFactory() {
        var backapiurl = 'http://localhost:59006/api/';

        var service = {
            backapiurl: backapiurl
        };

        function backapiurl() {
            return url;
        }

        return service;
    }
})();


(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('fornecedorService', ['$http', 'RequestFactory', fornecedorService]);

    function fornecedorService($http, RequestFactory) {

        var service = {
            ObterFornecedoresAtivos: ObterFornecedoresAtivos
        };

        //retornar apenas os fornecedores ativos
        function ObterFornecedoresAtivos() {
            return $http.get(RequestFactory.backapiurl + '/Fornecedor').then(function (response) {
                return response.data;
            });
        }

        return service;
    }
})();