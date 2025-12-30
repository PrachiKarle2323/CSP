using System;

abstract class Animal{
    public abstract void Sound();
    public void sleep(){
        Console.WriteLine("Normal method in abstract class");
    }
}

class Dog:Animal{
    public override void Sound(){
         Console.WriteLine("Dog barks");
    }
}

class Demo{
    static void Main(){
        Animal a=new Dog();
        a.Sound();
        a.sleep();
    }
}
