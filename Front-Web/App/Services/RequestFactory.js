
(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('RequestFactory', [RequestFactory]);

    function RequestFactory() {
        var backapiurl;
        var ambiente = 'dev';

        switch (ambiente) {
            case 'hml':
                backapiurl = 'http://backapi-dev.us-west-2.elasticbeanstalk.com/api/'
            case 'dev':
                backapiurl = 'http://localhost:59006/api/'
            default:
        }

        var service = {
            backapiurl: backapiurl
        };

        function backapiurl() {
            return url;
        }

        return service;
    }
})();
