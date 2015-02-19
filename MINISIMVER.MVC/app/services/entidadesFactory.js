(function () {

    EntidadesFactory.$inject = ["$resource"];
        
    function EntidadesFactory($resource)
    {
        return $resource('/api/Entidades/:Id',
            {Id:"@Id"},
            {'update':{method:'PUT'}}
        );        
    }

    angular.module('miniSimverApp').factory('entidadesFactory', EntidadesFactory);
    
}());