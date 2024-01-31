(function () {
    angular.module('app').controller('app.views.depart.index',
        ['$scope', 'abp.services.app.department',
            function ($scope, departmentService) {
          

                var vm = this;

                vm.depart = [];
                alert(11);

                function getTest() {
                    departmentService.getAllPeople({}).then(function (result) {
                        console.log(result.data);

                        debugger;
                        vm.depart = result.data;

                        
                    });
                }

                var init = function () {
                    getTest();
                }
                init();
            }
        ]);
})();