(function () {
    angular.module('app').controller('app.views.person.index',
        ['$scope', '$timeout', '$uibModal', 'abp.services.app.person',
            function ($scope,$timeout, $uibModal, personService) {
                var vm = this;

                vm.person = [];

                
                function getTest() {
                    personService.getAllPeople({}).then(function (result) {
                        vm.person = result.data;

                    });
                }

                vm.openPersonCreationModal = function () {
                    var modalInstance = $uibModal.open({
                        templateUrl: '/App/Main/views/person/createModal.cshtml',
                        controller: 'app.views.person.createModal as vm',
                        backdrop: 'static'
                    });

                    modalInstance.rendered.then(function () {
                        $.AdminBSB.input.activate();
                    });

                    modalInstance.result.then(function () {
                        getTest();
                    });
                };

                var init = function () {
                    getTest();
                }
                init();
            }
        ]);
})();