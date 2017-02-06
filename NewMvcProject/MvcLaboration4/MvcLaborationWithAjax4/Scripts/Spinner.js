////Upload picture
//$(document).ready(function () {
//    var form = $("form");
//    form.submit(function (e) {
//        e.preventDefault();
//        $.ajax({
//            method: "POST",
//            url: "/Gallery/UploadPicture",
//            data: new FormData(document.getElementsByTagName("form")[0]), beforeSend: function () {
//                $("#Spinner1").show();
//            },
//            success: function (data) {
//                $("#Spinner1").hide();

//            },
//            processData: false,
//            contentType: false
//        });
//    });
//});
////Delete picture
//$(document).ready(function () {
//    var form = $("form");
//    form.submit(function (e) {
//        e.preventDefault();
//        $.ajax({
//            method: "POST",
//            url: "/Gallery/DeletePicture",
//            data: new FormData(document.getElementsByID("form")[0]), beforeSend: function () {
//                $("#Spinner1").show();
//            },
//            success: function (data) {
//                $("#Spinner1").hide();

//            },
//            processData: false,
//            contentType: false
//        });
//    });
//});