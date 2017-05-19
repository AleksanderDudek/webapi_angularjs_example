

var app;
(function () {
    app = angular.module("APIModule", []);

    app.service("APIService", function ($http) {

        this.getParcels = function () {


            //nalezt zmienic urlBase na biezacy z wyszukiwarki
            var urlBase = 'http://localhost:1797/api';
            return $http.get(urlBase + '/webapi');
        }

        this.saveParcel = function (par) {
            var urlBase = 'http://localhost:1797/api';
            return $http.post(urlBase + '/webapi', par);
        }
    });
    app.controller("APIController", function ($scope, APIService) {

       
        getAll();

        $scope.getAll = getAll();
            
        function getAll() {
            var servCall = APIService.getParcels();

            servCall.then(function (d) {
                $scope.parcel = d.data;
            });
        };
        
        $scope.addParcel = function () {

            var parcel = {
                Name: $scope.Name,
                PostalCode: $scope.PostalCode,
                City: $scope.City,
                Phone: $scope.Phone,
                Email: $scope.Email,
                Street: $scope.Street,
                RegistrationDate: new Date()
            };

            var saveParcel = APIService.saveParcel(parcel);

            saveParcel.then(function () {
                //tutaj zwracam 
                $scope.getAll();
            });
        };

        
    });

})();



