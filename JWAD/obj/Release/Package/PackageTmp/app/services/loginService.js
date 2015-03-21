jwad.service('loginService', ['$http', '$q', '$window', function($http, $q, $window) {
    var login = function (username, password) {
        var deferred = $q.defer();

        $http({
            url: '/Token', 
            method: 'POST',
            data: 'username=' + username + '&password=' + password + '&grant_type=password',
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' }
        }).success(function (data) {
            console.log(data);
            $window.sessionStorage.setItem('token', data.access_token);
            $window.sessionStorage.setItem('username', data.userName);
            console.log(data.username);
            deferred.resolve(data.username);
        }).error(function (data) {
            deferred.reject(data);
        });

        return deferred.promise;
    };

    var isLoggedIn = function() {
        return $window.sessionStorage.getItem('username');
    }

    return {
        login: login,
        isLoggedIn: isLoggedIn
        
    };

}]);