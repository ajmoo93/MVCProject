$(document).ready(function () {
    var form = $("#Create");

    form.submit(function (e) {
        e.preventDefault();
        $.ajax({
            method: "POST",
            url: "/Gallery/Create",
            data: new FormData(document.getElementsByTagName("form")[0]), beforeSend: function () {
                $("#SpiningImg").show();
            },
            success: function (data) {
                $("#content").html(data);
                $("#SpiningImg").hide();

            },
            processData: false,
            contentType: false
        });
    });
});