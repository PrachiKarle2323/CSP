using System;

interface IVehicle{
    void start();
}

class Car:IVehicle{
    public void start(){
        Console.WriteLine("Car started!");
    }
}

class Demo{
    static void Main(){
      IVehicle v=new Car();
      v.start();
    }
}
