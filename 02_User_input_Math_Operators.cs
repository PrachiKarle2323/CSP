using System;

public class Demo{
    
    public static void Main(string[] args){
        Console.Write("Enter your age: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a);
        
        Console.WriteLine(Math.Max(10,20));
        Console.WriteLine(Math.Min(10,20));
        Console.WriteLine(Math.Sqrt(4));
        Console.WriteLine(Math.Abs(-23));
        Console.WriteLine(Math.Round(23.56));
        
        Console.WriteLine("Arithemetic");
        Console.WriteLine(20+10);
        Console.WriteLine(20-10);
        Console.WriteLine(20/10);
        Console.WriteLine(20*10);
        
         Console.WriteLine("Assignment");
         int x=0;
         x+=45;
         x-=15;
         x/=15;
         x*=30;
         Console.WriteLine(x);
         
         
         Console.WriteLine("Logical");
         Console.WriteLine(10 == 10 && 10 != 10);
         Console.WriteLine(10 == 10 || 10 != 10);
         Console.WriteLine(!(10 == 10));
         
        Console.WriteLine("Comparison");
        x=34;
        int y=45;
        Console.WriteLine(x == y);
        Console.WriteLine(x != y);
        Console.WriteLine(x > y);
        Console.WriteLine(x < y);
        Console.WriteLine(x >= y);
        Console.WriteLine(x <= y);
    }
}
