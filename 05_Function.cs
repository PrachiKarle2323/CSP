using System;

public class Demo{
    static void myMethod(){
        Console.WriteLine("Simple Static methods");
    }
    void method1(){
        Console.WriteLine("Method without parameters");
    }
    void sum(int a,int b){
        Console.WriteLine(a+b);
    }
    int Sum(int a,int b,int c){
        return (a+b+c);
    }
    
    int Sub(int a,int b=0){
        return a-b;
    }
    
    
    public static void Main(string[] args){
        
        Demo.myMethod();
        Demo d=new Demo();
        d.method1();
        d.sum(10,20);
        Console.WriteLine(d.Sum(1,2,4));
        //named 
        Console.WriteLine(d.Sum(c:2,b:5,a:9));
        Console.WriteLine(d.Sub(10,2));
        Console.WriteLine(d.Sub(10));
    }
    
}
