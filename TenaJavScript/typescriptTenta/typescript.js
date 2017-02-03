var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var cars;
(function (cars) {
    var vehicle = (function () {
        function vehicle(manufacturer, regNr) {
            this._Manufacturer, this._RegNr;
        }
        return vehicle;
    })();
    var car = (function (_super) {
        __extends(car, _super);
        function car(manufacturer, regNr, doors) {
            _super.call(this, manufacturer, regNr);
            this._Manufacturer = manufacturer, this._RegNr = regNr, this._doors = doors;
        }
        car.prototype.carc = function () {
            return "this is a " + this._Manufacturer + " and the regNr is " + this._RegNr + ".";
        };
        return car;
    })(vehicle);
    var MotorCycle = (function (_super) {
        __extends(MotorCycle, _super);
        function MotorCycle(manufacturer, regNr, tiers) {
            _super.call(this, manufacturer, regNr);
            this._Manufacturer = manufacturer, this._RegNr = regNr, this._tiers = tiers;
        }
        MotorCycle.prototype.motorcycle = function () {
            return "this is a " + this._Manufacturer + " and the regNr is " + this._RegNr + ".";
        };
        return MotorCycle;
    })(vehicle);
    var carC = new car("volvo", "234-232", 4);
    var motorC = new MotorCycle("honda", "234-232", 2);
    console.log(carC);
    console.log(motorC);
})(cars || (cars = {}));
