var myNamespace = myNamespace || {};

var productName = new Array();
var productid = new Array();
var Price = new Array();
var ppl = new Array();
ppl[0] = "volvo" + "12";
ppl[1] = "Saab" + "32";
ppl[2] = "Bmw" + "43";
ppl[3] = "Audi" + "54";
ppl[4] = "Toyota" + "14";
function add() {
    var productNameValue = document.getElementById('pname').value;
    var productidValue = document.getElementById('pid').value;
    var priceValue = document.getElementById('price').value;

    productName[productName.length] = productNameValue;
    productid[productid.length] = productidValue;
    priceValue[Price.length] = priceValue;
}
function show() {
    var content = "<b>All Elements of the Arrays :</b><br>";
    for (var i = 0; i < productName.length; i++) {
        content += productName[i] + "<br/>";
    }
    for (var i = 0; i < productid.length; i++) {
        content += productid[i] + "<br/>";
    }
    for (var i = 0; i < Price.length; i++) {
        content += Price[i] + "<br/>";
    }
        document.getElementById('show').innerHTML = content;

}
function people() {
    for (var i = 0; i < ppl.length; i++) {
        document.write(ppl[i] + "<br/>")
    }
}

function showform(){
    document.getElementById('hide').style.visibility = "visible";
}