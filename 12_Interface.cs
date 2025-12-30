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

//Multiple interfaces
using System;

interface IVehicle{
    void start();
}
interface IVehicle1{
    void end();
}
class Car:IVehicle,IVehicle1{
    public void start(){
        Console.WriteLine("Car started!");
    }
    public void end(){
        Console.WriteLine("Car stop!");
    }
}

class Demo{
    static void Main(){
      IVehicle v=new Car();
      v.start();
      IVehicle1 v1=new Car();
      v1.end();
    }
}
