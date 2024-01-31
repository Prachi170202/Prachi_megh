(function () {
    angular.module('app').controller('app.views.person.createModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.person',
        function ($scope, $uibModalInstance, personService) {
            var vm = this;

            vm.person = {};
            

            vm.save = function () {
                personService.createPerson(vm.person)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        alert(11);
                        debugger;
                        $uibModalInstance.close();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };
        }
    ]);
})();
