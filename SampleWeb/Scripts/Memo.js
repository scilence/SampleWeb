var memoApp = angular.module('memoApp', []);

memoApp.controller('memoCtrl', function ($scope) {
    $scope.memo = {};
    $scope.memo.Title = "";
    $scope.memo.Content = "";

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
            console.log(msg);
            var result = msg.d;
            if (result.IsSuccess) {
                alert(result.Message);
            } else {
                alert(result.Message);
            }
        }).fail(function (msg) {
            console.log("Fail!!");
            console.log(msg);
        });
    }

});