var jwad = angular.module('JWAD', ['ngRoute']);

jwad.config(['$routeProvider', '$httpProvider', function($routeProvider, $httpProvider) {
    $routeProvider.when('/', {
        templateUrl: 'app/views/home.html',
        controller: 'HomeViewController'
    }).when('/login', {
        templateUrl: 'app/views/login.html',
        controller: 'loginController'
    }).when('/register', {
        templateUrl: 'app/views/register.html',
        controller: 'RegistrationController'
    }).when('/browse', {
        templateUrl: 'app/views/browse.html',
        controller: 'PostJobController'
    }).when('/post', {
        templateUrl: 'app/views/post.html',
        controller: 'PostJobController'
    }).when('/account', {
        templateUrl: 'app/views/account.html',
        controller: 'accountController'
    }).when('/seeker', {
        templateUrl: 'app/views/seekerprofile.html',
        controller: 'JobSeekerController'
    }).when('/findseeker', {
        templateUrl: 'app/views/findseeker.html',
        controller: 'JobSeekerController'
    });


}]);