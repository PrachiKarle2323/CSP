using System;

public class Demo{
    int myNum=23;
    public static void Main(string[] args){
        Console.Write("Hello world");
        Console.WriteLine("Prachi");
        Demo d=new Demo();
        int a=10987;
        bool b=Convert.ToBoolean(a);
        double c=Convert.ToDouble(a);
        string s=Convert.ToString(a);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(s);
        
        int f=Convert.ToInt32(b);
        long g=Convert.ToInt64(f);
        Console.WriteLine(f);
        Console.WriteLine(g);
        // Console.WriteLine(d.myNum);
    }
}
