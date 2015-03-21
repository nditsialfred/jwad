jwad.service('postJobService', ['$http', '$q', function($http, $q) {
   var jwadRegister = function(title, salary, city, state, jobDescription, zip) {
       var deferred = $q.defer();
       var model = {
         //  "JobRequirementId": JobRequirementId,
           "JobTitle": title,
           "Salary": salary,
           "JobCity": city,
           "JobState": state,
           "JobDescription": jobDescription,
           "JobZipCode": zip
       };
       console.log(model); //The data is coming all the way back here for now
       $http({
           url: "/api/ApiJob", //This needs to be changed to the JobViewModel
           method: "POST",
           data: model
       }).success(function (model) {
           console.log(model);
           deferred.resolve(model);

       }).error(function (response, status) {
           console.log(response + " " + status);
           deferred.reject();
       });
       return deferred.promise;
   }

    var loadJobs = function() {
        var jobView = [];
        var deferred = $q.defer();
        $http({ url: 'api/ApiJob', method: 'GET' }).success(function(data) {
            jobView = data;
            deferred.resolve(jobView);
        }).error(function () { deferred.reject(); });
        return deferred.promise;
    }

    var deleteJobs = function(job) {
        var deferred = $q.defer();
        var model = {
            "JobRequirementId": job.JobRequirementId
        };
        $http({
            url: 'api/ApiJob',
            method: 'DELETE',
            headers: { "Content-Type": "application/json" },
            data: model
        }).success(function (item) {
            console.log("We Deleted An Item");
            deferred.resolve(item);
        }).error(function () {
            console.log("You failed to delete the item, check the code.");
            deferred.reject();
        })
        return deferred.promsise;
    }
    return {
        jwadRegister: jwadRegister,
        loadJobs: loadJobs,
        deleteJobs: deleteJobs

    };

}]);