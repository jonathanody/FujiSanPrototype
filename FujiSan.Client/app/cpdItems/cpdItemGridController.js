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
			vm.filterTypes = getDistinctTypes(cpdItems);
		}

		vm.hello = function (name) {
			alert("Hello " + name);
		};

		function getDistinctTypes(cpdItems) {
			var unique = {};
			var distinct = [];
			cpdItems.forEach(function (x) {
				if (!unique[x.type]) {
					distinct.push(x.type);
					unique[x.type] = true;
				}
			});

			return distinct;
		}

		init();
	}
}());