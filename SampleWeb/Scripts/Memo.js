var memoApp = angular.module('memoApp', []);

memoApp.controller('memoCtrl', function ($scope) {
    $scope.memo = {};
    $scope.memo.Title = "";
    $scope.memo.Content = "";
    $scope.memo.isShow = true;

    $scope.list = {};
    $scope.list.Title = "";
    $scope.list.Content = "";
    $scope.list.isShow = false;

    $scope.Confirm = function ($event) {
        $event.preventDefault();
        var data = { memo: $scope.memo };
        $.ajax({
            url: "Memo.aspx/Confirm",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(data)
        }).done(function (msg) {
            //console.log(msg);
            var result = msg.d;
            if (result.IsSuccess) {
                $scope.list.Title = result.Data.Title;
                $scope.list.Content = result.Data.Content;
                $scope.list.isShow = true;
                $scope.memo.isShow = false;
                console.log(result.Message);
                console.log($scope.list);
                console.log($scope.memo);
            } else {
                alert(result.Message);
            }
        }).fail(function (msg) {
            console.log("Fail!!");
            console.log(msg);
        });
    }


    $scope.GoBack = function ($event) {
        $event.preventDefault();

        $scope.memo.Title = "";
        $scope.memo.Content = "";
        $scope.memo.isShow = true;
        $scope.list.isShow = false;

    }

});