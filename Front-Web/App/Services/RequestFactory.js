
(function () {
    'use strict';

    angular
        .module('MainModule')
        .factory('RequestFactory', [RequestFactory]);

    function RequestFactory() {

        var backapiurl = 'http://backapi-dev.us-west-2.elasticbeanstalk.com/api/'

        //switch (ambiente) {
        //    case 'dev':
        //        backapiurl = 'http://backapi-dev.us-west-2.elasticbeanstalk.com/api/'
        //    case 'local':
        //        backapiurl = 'http://localhost:59006/api/'
        //}

        var service = {
            backapiurl: backapiurl
        };


        return service;
    }
})();
