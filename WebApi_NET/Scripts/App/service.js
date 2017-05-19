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