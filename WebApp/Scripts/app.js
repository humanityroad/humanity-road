
/**
 * @ngdoc overview
 * @name frontEndApp
 * @description
 * # frontEndApp
 *
 * Main module of the application.
 */
var app = angular
    .module('frontEndApp', [
    'ngMaterial',
        'ngAnimate'
        ,'ngAria'
        ,'ngCookies'
        ,'ngMessages'
        ,'ngResource'
        ,'ngRoute'
        ,'ngSanitize'
        ,'ngTouch'           
        , 'chart.js'
        , 'ngMaterialDatePicker'
    ]);


// create httpRequestInterceptor factory and configure app

app.factory('httpRequestInterceptor', function() {
        return {
            request: function(config) {
                config.headers['X-Requested-By'] = 'AngularClient';
                return config;

            }
        };
    });

var httpConfig = function ($httpProvider) {
    $httpProvider.interceptors.push('httpRequestInterceptor');
};
httpConfig.$inject = ['$httpProvider'];

app.config(httpConfig);


// configure app client routes

var routeConfig = function ($routeProvider) {

    $routeProvider
        .when('/Profile/Edit', {
            templateUrl: 'app/profile-edit',            
        })
        .when('/Home', {
            templateUrl: 'app/Home',            
        })
        .otherwise('/Profile/Edit');
};
routeConfig.$inject = ['$routeProvider'];

app.config(routeConfig);
