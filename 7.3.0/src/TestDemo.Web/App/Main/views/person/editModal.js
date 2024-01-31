(function () {
    angular.module('app').controller('app.views.person.editModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.person', 'id',
        function ($scope, $uibModalInstance, personService, id) {
            var vm = this;

            vm.person = {
                isActive: true
            };

            vm.roles = [];

            var setAssignedRoles = function (person, roles) {
                for (var i = 0; i < roles.length; i++) {
                    var role = roles[i];
                    role.isAssigned = $.inArray(role.name, person.roles) >= 0;
                }
            }

            var init = function () {
                personService.getRoles()
                    .then(function (result) {
                        vm.roles = result.data.items;

                        personService.get({ id: id })
                            .then(function (result) {
                                vm.person = result.data;
                                setAssignedRoles(vm.person, vm.roles);
                            });
                    });
            }

            vm.save = function () {
                var assingnedRoles = [];

                for (var i = 0; i < vm.roles.length; i++) {
                    var role = vm.roles[i];
                    if (!role.isAssigned) {
                        continue;
                    }

                    assingnedRoles.push(role.name);
                }

                vm.user.roleNames = assingnedRoles;
                personService.update(vm.person)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };

            init();
        }
    ]);
})();