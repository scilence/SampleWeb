$(function () {
    $("[id$=CreateUserButton]").click(function (e) {
        e.preventDefault();
        var data = {
            account: $("[id$=UserName]").val(),
            password: $("[id$=Password]").val(),
            email: $("[id$=Email]").val()
        };

        $.ajax({
            url: "Register.aspx/AddUser",
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(data)
        }).done(function (msg) {
            var result = msg.d;
            if (result.IsSuccess) {
                alert(result.Message);
            } else {
                alert(result.Message);
            }


        }).fail(function (msg) {
            console.log("Fail!!");
        });
    });
});