
(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('RequestFactory', [RequestFactory]);

    function RequestFactory() {
        var ambiente = 'local';
        var backapiurl = '';

        run();

        function run() {
            switch (ambiente) {
                case "dev":
                    backapiurl = 'http://backapi-dev.us-west-2.elasticbeanstalk.com/api/';
                    break;
                case "local":
                    backapiurl = 'http://localhost:59006/api/';
                    break;
            }
        }

        var service = {
            backapiurl: backapiurl
        };

        return service;
    }
})();
