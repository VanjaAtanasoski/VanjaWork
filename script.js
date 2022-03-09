console.log("connected");


class Bus {
    constructor(lintNumber,color,passengers,price){
        this.lintNumber=lintNumber;
        this.color=color;
        this.passengers=passengers;
        this.price=price;
        this.status='';

    }
    set status(mode){
        this._status=mode;
    }
    get statsus(){
        return this._status
    }

}
class Passanger {
    constructor(name,age){
        this.name=name;
        this.age=age;
    }
}

const people=[
    new Passanger('Vanja',23),
    new Passanger('Batko', 23),
    new Passanger('Ti',23)
];
const bus1=new Bus(13,'red',people,50);
console.log(bus1);
bus1.status="Stop";