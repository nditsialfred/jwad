jwad.service('registrationService', ['$http', '$q', function($http, $q) {
    var registerUser = function (email, password, confirmPassword, userRole, lastName, firstName) {
        var deffered = $q.defer();
        var model = {
            "Email": email,
            "Password": password,
            "ConfirmPassword": confirmPassword,
            "Role": userRole,
            "LastName": lastName,
            "FirstName": firstName
        };
        $http({
            url: "/api/Account/Register",
            method: "POST",
            data: model
        }).success(function (data) {
            console.log(data);
            deffered.resolve(data);
        }).error(function(data) {
            deffered.reject(data);
        });
        deffered.resolve(model);
        return deffered.promise;
    }
    return {
        registerUser : registerUser
    }
}]);