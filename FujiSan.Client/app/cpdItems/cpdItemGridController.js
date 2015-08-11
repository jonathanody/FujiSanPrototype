(function () {
	"use strict";

	angular
		.module("fuji")
		.controller("CpdItemGridController", CpdItemGridController);

	CpdItemGridController.$inject = ["cpdItemRepository"];

	function CpdItemGridController(cpdItemRepository) {
		var vm = this;

		function init() {
			cpdItemRepository.query(bindCpdItems);
		}

		function bindCpdItems(cpdItems) {
			vm.cpdItems = cpdItems;
		}

		vm.hello = function (name) {
			alert("Hello " + name);
		};

		init();
	}
}());