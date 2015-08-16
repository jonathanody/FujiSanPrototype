(function () {
	"use strict";

	var app = angular.module("fuji", ["ngResource", "ngAnimate", "ui.router", "iso.directives"]);

	app.config(["$stateProvider", "$urlRouterProvider",
		function ($stateProvider, $urlRouterProvider) {
			$urlRouterProvider.otherwise("/");

			$stateProvider
			// Home
			.state("home", {
				url: "/",
				templateUrl: "app/homeView.html"
			})
			.state("cpdItemsList", {
				url: "/cpdItemList",
				templateUrl: "app/cpdItems/cpdItemList.html",
				controller: "CpdListController as vm"
			})
			.state("cpdItemsGrid", {
				url: "/cpdItemGrid",
				templateUrl: "app/cpdItems/cpdItemGrid.html",
				controller: "CpdItemGridController as vm"
			});
		}
	]);
}());