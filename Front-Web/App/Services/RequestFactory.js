
(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('RequestFactory', [RequestFactory]);

    function RequestFactory() {
        var backapiurl = 'http://backapi-dev.us-west-2.elasticbeanstalk.com/api/';

        var service = {
            backapiurl: backapiurl
        };

        function backapiurl() {
            return url;
        }

        return service;
    }
})();
