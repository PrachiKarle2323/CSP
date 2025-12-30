using System;

public class Parent{
    public int sum(int a,int b){
        return a+b;
    }
    public int sum(int a,int b,int c){
        return a+b+c;
    }
    public void demo(){
        Console.WriteLine("Parent Class");
    }
}
public class Derived:Parent{
    public void demo(){
        Console.WriteLine("Derived Class");
    }
}
public class Demo{
    
    public static void Main(string[] args){
       Derived d=new Derived();
       d.demo();
       Console.WriteLine(d.sum(10,20));
       Console.WriteLine(d.sum(10,20,30));
    }
}
