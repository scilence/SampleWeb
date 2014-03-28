﻿$(function () {

    $("[id$=LoginButton]").click(function (e) {
        e.preventDefault();
        var data = {
            account: $("[id$=UserName]").val(),
            password: $("[id$=Password]").val()
        };

        $.ajax({
            url: "Login.aspx/LoginAccount",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            //data: "{ account: '123', password: '456' }"
            data: JSON.stringify(data)
        }).done(function (msg) {
            console.log(msg);
        }).fail(function (msg) {
            console.log("Fail!!");
        });
    });
})