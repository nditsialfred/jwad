jwad.controller('PostJobController', ['$scope', '$location', '$http', 'postJobService', '$route', function ($scope, $location, $http, postJobService, $route) {

    $scope.header = "Post what you're looking forward and the talent will come knocking at your door!";
    $scope.puzzleImage = "http://musique-dir.info/wp-content/uploads/2014/12/cropped-information-technology-banner.jpg";
    $scope.puzzleGreeting = "Looking for the missing piece for your organization?";

    $scope.postJob = function () {
        console.log("Your Job as been posted");
        return postJobService.jwadRegister($scope.jobForm.title, $scope.jobForm.salary, $scope.jobForm.city, $scope.jobForm.state, $scope.jobForm.jobDescription, $scope.jobForm.zip).then(function () {
        });
    }

    $scope.loadJobs = function () {
        console.log('You have requested for the view the posted jobs');
        $location.path('/browse');
        return postJobService.loadJobs().then(function (data) {$scope.jobs = data;
        });
    };

    $scope.delete = function (item) {
        console.log('You have requested to delete a job.');
        $route.reload();
        return postJobService.deleteJobs(item);
    }


}]);