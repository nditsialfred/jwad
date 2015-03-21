jwad.service('jobSeekerService', ['$http', '$q', function($http, $q) {
    var saveProfile = function (firstName, lastName, resume) {
        var deferred = $q.defer();
        var model = {"FirstName": firstName,"LastName": lastName,"Resume": resume}
        $http({
            url: "/api/ApiJobSeeker", //This needs to be changed to the JobViewModel
            method: "POST",
            data: model

        }).success(function(data) {
            console.log(model);
            deferred.resolve(model);
        }).error(function(data) {
            console.log(response + " " + status);
            deferred.reject();
        });

        return deferred.promise;
    };
    var loadSeekers = function () {
        var seekersView = [];
        var deferred = $q.defer();
        $http({ url: 'api/ApiJobSeeker', method: 'GET' }).success(function (data) {
            console.log(data);
            seekersView = data;
            deferred.resolve(seekersView);
        }).error(function () { deferred.reject(); });
        return deferred.promise;
    }

    return {
        saveProfile: saveProfile,
        loadSeekers: loadSeekers
    }

}]);