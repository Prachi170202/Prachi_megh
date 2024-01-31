(function () {
    angular.module('app').controller('app.views.carr.index',
        ['$scope', 'abp.services.app.carr',
            function ($scope, carService) {


                var vm = this;

                vm.carr = [];
                alert(11);

                function getCar() {
                    carService.getAllCar({}).then(function (result) {
                        console.log(result.data);

                        debugger;
                        vm.carr = result.data;


                    });
                }

                var init = function () {
                    getCar();
                }
                init();
            }
        ]);
})();