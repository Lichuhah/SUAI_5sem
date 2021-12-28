var app = angular.module('Birja', []);

app.controller("BirjaController", function ($scope, $http) {

    $scope.successGetBirjasCallback = function (response) {
         $scope.birjaList = response.data;
        $scope.errormessage="";
    };

    $scope.errorGetBirgasCallback = function (error) {
        console.log(error);
        $scope.errormessage="Unable to get list of Birja";
    };

    $scope.getBirjas = function () {
        $http.get('/public/rest/company').then($scope.successGetBirjasCallback, $scope.errorGetBirgasCallback);
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
    };

    $scope.errorDeleteBirjaCallback = function (error) {
        console.log(error);
        $scope.errormessage="Unable to delete company; check if there are any related records exist. Such records should be removed first";
    };

    $scope.deleteBirja = function (id) {
        $scope.deletedId = id;
        $http.delete('/public/rest/company/' + id).then($scope.successDeleteBirjaCallback, $scope.errorDeleteBirjaCallback);
    };


    $scope.successGetBirjaCallback = function (response) {
        $scope.birjaList.splice(0, 0, response.data);
        $scope.errormessage="";
    };

    $scope.errorGetBirjaCallback = function (error) {
        console.log(error);
        $scope.errormessage="Unable to get information on company number "+$scope.inputnumber;
    };

    $scope.successAddBirjaCallback = function (response) {
        $http.get('/public/rest/company/').then($scope.successGetBirjasCallback, $scope.errorGetBirjaCallback);
        $scope.errormessage="";
    };

    $scope.errorAddBirjaCallback = function (error) {
        console.log(error);
        $scope.errormessage="Impossible to add new Birja; check if it's number is unique";
    };

    $scope.addBirja = function () {
        const body = {nameCompany: $scope.inputnameCompany, kolActives: $scope.inputkolActives, priceActive: $scope.inputpriceActive};
        $http.post('/public/rest/company/', body ).then($scope.successAddBirjaCallback, $scope.errorAddBirjaCallback);
    };

});
