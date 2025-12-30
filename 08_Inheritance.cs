using System;

public class Parent{
    public void parent(){
        Console.WriteLine("Parent Class");
    }
}
public class Derived:Parent{
    public void derived(){
        Console.WriteLine("Derived Class");
    }
}
public class Demo{
    
    public static void Main(string[] args){
       Derived d=new Derived();
       d.parent();
       d.derived();
    }
}
