//var close = document.getElementByClassName("btn btn-default");
//var i;

//for (i = 0; i < close.length; i++) {
//    close[i].onclick = function () {
//        var div = this.parentElement;
//        div.style.opacity = "0";
//        setTimeout(function () { div.style.display = "none"; }, 600);
//    }
//}
//(function () {
//    var sub = document.getElementById("sub");
//    sub.addEventListener("Submit", function (e) {

//    });
    //( function (e){
    //    e.preventDefault();
    //    var AlbumName = document.getElementById("AlbumName");
    //    alert(AlbumName.nodeValue)
    //}
//})

function myfunc() {
    var message = document.getElementById("message");
    message.innerHTML = "";
    x = document.getElementById("sub").valueOf;
    try{
        if(x == "") throw "empty";
        
    }
    catch (err) {
        message.innerHTML = "input is " + err;
    }
}
