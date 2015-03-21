jwad.controller('JobSeekerController', ['$scope', 'loginService', 'jobSeekerService', '$location', function ($scope, loginService, jobSeekerService, $location) {

    $scope.username = loginService.isLoggedIn();
    $scope.findJobImage = "http://www.talentsquare.com/wp-content/uploads/2013/12/Find_Jobs.jpg";
    $scope.postJob = function () {
        console.log("Your Job as been posted");
        return jobSeekerService.saveProfile($scope.jobSeeker.firstName, $scope.jobSeeker.lastName, $scope.jobSeeker.resume).then(function () {
        });
    }
    $scope.loadSeekers = function () {
        console.log('You have requested for the view the posted jobs');
      //  $location.path('/browse');
        return jobSeekerService.loadSeekers().then(function (data) {
            $scope.seekers = data;
        });
    };
}]);