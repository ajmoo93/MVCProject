$(document).ready(function(e) {
    setInterval(commentsReload, 5000);
});

var commentsReload = function(e) {
    $.ajax({
        type: "GET",
        url: "/Gallery/IndexPartial",
        seccess: function(data) {
            $('loadComments').html(data);
        }
    });
};