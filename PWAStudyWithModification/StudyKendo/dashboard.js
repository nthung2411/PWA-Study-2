(function ($) {

    var app = angular.module('app', ['kendo.directives']);

    app.controller('DashboardController', function ($scope) {

        $scope.placeholder = function (element) {
            return element.clone().addClass("placeholder");
        };

        $scope.hint = function (element) {
            return element.clone().addClass("hint")
              .height(element.height())
              .width(element.width());
        };

        $scope.country = new kendo.data.DataSource({
            data: [
              { country: "USA", value: 76430000 },
              { country: "China", value: 53100000 },
              { country: "Brazil", value: 12466000 },
              { country: "France", value: 9600000 },
              { country: "Italy", value: 9400000 },
              { country: "UK", value: 7700000 },
              { country: "Ukraine", value: 7350000 }
            ]
        });

        $scope.pct = new kendo.data.DataSource({
            data: [
              { type: "Dog", value: 36.5 },
              { type: "Cat", value: 30.4 },
              { type: "Other", value: 33.1 }
            ]
        });

        // when an item is dropped in either the side or
        // main containers, resize any Kendo UI widgets
        // inside
        $scope.dropped = function (e) {
            if (e.action === 'receive') {
                kendo.resize(e.item);
            }
        };

        $(window).resize(function () {
            kendo.resize('.widget');
        });

    });

}(jQuery));