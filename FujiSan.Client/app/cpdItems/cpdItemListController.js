(function () {
	"use strict";

	angular
		.module("fuji")
		.controller("CpdListController", CpdListController);

	CpdListController.$inject = ["CpdItemRepository"];

	function CpdListController(CpdItemRepository) {
		var vm = this;

		function init() {
			CpdItemRepository.query(bindCpdItems);
		}

		function bindCpdItems(cpdItems) {
			vm.cpdItems = cpdItems;
		}

		init();
	}

}());