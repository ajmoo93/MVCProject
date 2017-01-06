var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
//veriables
var age;
var firstName;
var LastName;
var person;
age = 34;
firstName = "Emil";
LastName = "Lidgren";
person = { name: "Emil" };
var numberList = [1, 2, 3];
var personInfo;
//personInfo = ["Emil", 23]; // number first
personInfo = [23, "Emil"];
//loopar
var list = [4, 2, 7];
for (var i in list) {
    console.log("Values from for (let i in list):" + i); // Ger index 0,1,2
}
for (var _i = 0; _i < list.length; _i++) {
    var i = list[_i];
    console.log("Values from for (let i in list):" + i); // get values 4,2,7
}
//Metoder
function func() {
    var x = 5;
    //Void = no return.
}
function func2() {
    var x = "4";
    return x;
}
var result = func2();
function func3(age, name) {
    var x = 10 + age;
    return x;
}
var resultFromFunc3 = func3(23, "Emil");
// klaser 
var pet = (function () {
    // konstruktor 
    function pet(petName) {
        this.name = petName;
    }
    pet.prototype.setNewAge = function (newAge) {
        age = newAge;
        this.verifyNewAge(newAge);
    };
    pet.prototype.verifyNewAge = function (ageToVerify) {
        return ageToVerify;
    };
    pet.prototype.getAge = function () {
        return age;
    };
    return pet;
})();
var fistPet1 = new pet("Mr-Toddle");
fistPet1.name = "Mr-Miggle";
fistPet1.setNewAge(1);
var petAge = fistPet1.getAge();
console.log("Pet age is: " + age);
//class animals
var animal = (function () {
    function animal(theName) {
        this.name = theName;
    }
    animal.prototype.move = function (distanceInMeters) {
        console.log(this.name + "moved" + distanceInMeters + "meters");
    };
    return animal;
})();
var snake = (function (_super) {
    __extends(snake, _super);
    function snake(name) {
        _super.call(this, name);
    }
    snake.prototype.move = function (distanceInMeters) {
        if (distanceInMeters === void 0) { distanceInMeters = 3; }
        console.log("Wombeling");
        _super.prototype.move.call(this, distanceInMeters);
    };
    return snake;
})(animal);
var mySnake = new snake("Mr-Snucki");
mySnake.name = "Ms-Snucki"; // tillgång till veriablen name eftersom den finns i base.klassen.
mySnake.move();
//modules
var Animals;
(function (Animals) {
    var Animal = (function () {
        function Animal(theName) {
            this.name = theName;
        }
        return Animal;
    })();
    Animals.Animal = Animal;
})(Animals || (Animals = {}));
var newPet = new MainApp.Animal("swppy");
var myAnimalsFromModule = new Animals.Animal("Baby-Snucki");
