module cars {
    class vehicle {
        _Manufacturer: string;
        _RegNr: string;
        constructor(manufacturer: string, regNr: string) {
            this._Manufacturer, this._RegNr;
        }
    }
    class car extends vehicle {
        _doors: number;
        constructor(manufacturer: string, regNr: string, doors: number) {
            super(manufacturer, regNr);
            this._Manufacturer = manufacturer, this._RegNr = regNr, this._doors = doors;
        }
        public carc() {
            return `this is a ${this._Manufacturer} and the regNr is ${this._RegNr}.`;
        }
    }
    class MotorCycle extends vehicle {
        _tiers: number;
        constructor(manufacturer: string, regNr: string, tiers: number) {
            super(manufacturer, regNr);
            this._Manufacturer = manufacturer, this._RegNr = regNr, this._tiers = tiers;

        }
        public motorcycle() {
            return `this is a ${this._Manufacturer} and the regNr is ${this._RegNr}.`;

        }

    }
    let carC = new car("volvo", "234-232", 4);

    let motorC = new MotorCycle("honda", "234-232",2);
   
    console.log(carC);
    console.log(motorC);

}