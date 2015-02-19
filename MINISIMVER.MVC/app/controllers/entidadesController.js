(function () {

    EntidadesController.$inject = ['entidadesFactory'];

    function EntidadesController(entidadesFactory) {
        var vm = this;                
        vm.entidades = entidadesFactory.query();
        vm.mostrarEdicion = false;
        vm.entidadEditable = {};
        vm.habilitarEdicionEntidad = function () {        
            vm.mostrarEdicion = true;
            vm.entidadEditable = new entidadesFactory();
        }

        vm.guardarEntidad = function (entidad) {
            if (entidad.Id) {
                vm.actualizarEntidad(entidad);
            }
            else {
                vm.crearEntidad(entidad);
            }
        }

        vm.actualizarEntidad = function (entidad) {
            entidad.$update();
        }

        vm.crearEntidad = function (entidad) {
            entidad.$save();
            vm.entidades.push(entidad);
            vm.mostrarEdicion = false;
        }

        vm.editarEntidad = function (entidad) {
            vm.entidadEditable = entidad;
            vm.mostrarEdicion = true;
        }

        vm.eliminarEntidad = function (entidad) {            
            entidad.$delete();
            vm.entidades=_.without(vm.entidades, entidad);
        }

        //entidadesFactory.query(function (response) {
        //    vm.entidades = response;
        //});
    }
   
    angular.module('miniSimverApp').controller('Entidades', EntidadesController);

}());