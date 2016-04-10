(function() {
	'use strict';

	window.app.controller('EditProfileController', EditProfileController);

	EditProfileController.$inject = ['$http', 'editProfileConfig', 'model'];
	function EditProfileController($http, editProfileConfig, model) {
		var vm = this;

		vm.profile = model;
		vm.save = save;
		//vm.init = init;

		//function init(profile) {
		//    vm.profile = profile;
		//}


		//$http.post('/Profile/LoadProfile')
		//	.success(function (profile) {
		//		vm.profile = profile;
		//	});

		function save() {
			vm.saving = true;
			vm.errorMessage = null;
			vm.success = false;

			$http.post(editProfileConfig.saveUrl, vm.profile)
				.success(function() {
					vm.success = true;
				})
				.error(function(msg) {
					vm.errorMessage = msg;
				})
				.finally(function() {
					vm.saving = false;
				});
		}
	}
})();