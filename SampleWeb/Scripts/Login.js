$(function () {
    var data = {
        account: $("[id$=UserName]").val(),
        password: $("[id$=Password]").val()
    };

    $("[id$=LoginButton]").click(function (e) {
        e.preventDefault();
        $.ajax({
            url: "Login.aspx/LoginAccount",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(data)
        }).done(function (msg) {
            console.log(msg);
        }).fail(function (msg) {
            console.log("Fail!!");
        });
    });
})