jwad.controller('loginController', ['$scope', 'loginService', '$location', function ($scope, loginService, $location) {
    $scope.isLoading = function () {
        $scope.buttonText = $scope.loading ? 'Please Wait...' : 'Login';
        return $scope.loading;
    };

    $scope.processLogin = function () {
       // $scope.loading = !$scope.loading;
        return loginService.login($scope.username, $scope.password)
            .then(function (username) {
               
            console.log('You tried to login');
                //$scope.loading = !$scope.loading;
                $location.path('/');
            }, function (data) {
                $scope.errorMessage = data.error_description;
                $scope.loading = !$scope.loading;
            });
    };
    $scope.isLoggedIn = function () {
        $scope.username = loginService.isLoggedIn();
        return $scope.username;
    };
}]);