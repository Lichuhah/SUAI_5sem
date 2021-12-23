app = angular.module('birja', []);

app.controller("birjaController", function ($scope, $http) {

    $scope.successGetBirjasCallback = function (response) {
         $scope.birjaList = response.data;
        $scope.errormessage="";
    };

    $scope.errorGetBirjasCallback = function (error) {
        console.log(error);
        $scope.errormessage="Unable to get list of company";
    };

   $scope.getBirjas = function () {
        $http.get('/public/rest/birja').then($scope.successGetBirjasCallback, $scope.errorGetBirjasCallback);
    };

    $scope.successDeleteBirjaCallback = function (response) {
        for (var i = 0; i < $scope.birjaList.length; i++) {
            var j = $scope.birjaList[i];
            if (j.id === $scope.deletedId) {
                $scope.birjaList.splice(i, 1);
                break;
            }
        }
        $scope.errormessage="";
        $http.get('/public/rest/birja').then($scope.successGetBirjasCallback, $scope.errorGetBirjasCallback);
    };

    $scope.errorDeleteBirjaCallback = function (error) {
        console.log(error);
        $scope.errormessage="Unable to delete company; check if there are any related records exist. Such records should be removed first";
    };

    $scope.deleteBirja = function (id) {
        $scope.deletedId = id;
        $http.delete('/public/rest/birja/' + id).then($scope.successDeleteBirjaCallback, $scope.errorDeleteBirjaCallback);
    };

    $scope.successGetBirjaCallback = function (response) {
        $scope.birjaList.splice(0, 0, response.data);
        $scope.errormessage="";
    };

    $scope.errorGetBirjaCallback = function (error) {
        console.log(error);
        $scope.errormessage="Unable to get information on company";
    };

    $scope.successAddBirjaCallback = function (response) {
        $http.get('/public/rest/birja').then($scope.successGetBirjasCallback, $scope.errorGetBirjasCallback);
        $scope.errormessage="";
    };

    $scope.errorAddBirjaCallback = function (error) {
        console.log(error);
        $scope.errormessage="Impossible to add new company;";
    };

    $scope.addBirja = function () {
        $http.post('/public/rest/birja/'+$scope.inputCompanyName + "/" + $scope.inputKolActives + "/" + $scope.inputPriceActive).then($scope.successAddBirjaCallback, $scope.errorAddBirjaCallback);
    };

});
