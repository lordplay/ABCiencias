
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
