using System;

public class Program{
    //private
   int age=23;
   //protected
   protected int a=3;
   //public
   public string name;
   public Program(string n){
       name=n;
   }
   public void Method1(){
       Console.WriteLine("Simple Method in another class");
   }  
}
public class Demo{
    
    public static void Main(string[] args){
        Program p=new Program("Prachi");
        p.Method1();
        Console.WriteLine(p.name);
        // Console.WriteLine(p.age);//err
    }
}
