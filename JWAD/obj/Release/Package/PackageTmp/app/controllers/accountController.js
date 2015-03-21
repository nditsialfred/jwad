jwad.controller('accountController', ['$scope', 'loginService', function($scope, loginService) {

    $scope.username = loginService.isLoggedIn();
}]);