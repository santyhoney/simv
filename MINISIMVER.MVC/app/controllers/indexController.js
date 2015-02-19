(function () {

    function indexController() {
        var vm = this;
        vm.mensaje = "Hola, bienvenido al mejor sistema";
    }

    angular.module('miniSimverApp').controller('indexController', indexController);

}());