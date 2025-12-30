using System;
public class Program{
    int age=22;
    
    public int Age{
        get{
            return age;
        }
        set{
            age=value;
        }
    }
    
}
public class Demo{
    
    public static void Main(string[] args){
       Program p=new Program();
       Console.WriteLine(p.Age);
       p.Age=23;
       Console.WriteLine(p.Age);
    }
}
