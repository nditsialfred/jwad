jwad.controller('RegistrationController', ['$scope', 'registrationService', function($scope, registrationService) {
    $scope.jobSeekerGreeting = "Sign up and we'll help you find the perfect job!";

    $scope.registerUser = function() {
        $scope.loading = !$scope.loading;
        console.log($scope.siteRole);
        return registrationService.registerUser($scope.email, $scope.password, $scope.confirmPassword, $scope.siteRole, $scope.lastName, $scope.firstName)
            .then(function() {
                /* on success */
                
                    $scope.loading = !$scope.loading;
                  
                },
                function() {
                    /* on error */
                    $scope.loading = !$scope.loading;
                    //toaster.pop("error", "Registration Failed", "The username: " + $scope.username + " is taken, please select another one.");
                });
    }
}]);