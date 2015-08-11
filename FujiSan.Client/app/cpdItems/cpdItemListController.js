(function () {
	"use strict";

	angular
		.module("fuji")
		.controller("CpdListController", CpdListController);

	CpdListController.$inject = ["cpdItemRepository"];

	function CpdListController(cpdItemRepository) {
		var vm = this;

		function init() {
			cpdItemRepository.query(bindCpdItems);
		}

		function bindCpdItems(cpdItems) {
			vm.cpdItems = cpdItems;
		}

		init();
	}

}());