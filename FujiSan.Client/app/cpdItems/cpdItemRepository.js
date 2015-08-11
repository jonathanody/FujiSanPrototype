(function () {
	"use strict";

	angular
		.module("fuji")
		.factory("cpdItemRepository", cpdItemRepository);

	cpdItemRepository.$inject = ["$resource"];

	function cpdItemRepository($resource) {
		return $resource("http://localhost:52500/api/cpditems/:id", { id: "@id" },
			{
				query: {
					method: "GET",
					isArray: true,
					transformResponse: function (data) {
						var cpdItems = angular.fromJson(data);

						cpdItems.forEach(function (cpdItem) {
							cpdItem.session = new Date(cpdItem.session);
						});

						return cpdItems;
					}
				}
			});
	}
}());