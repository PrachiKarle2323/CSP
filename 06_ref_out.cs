using System;

public class Demo{
    static void Update(ref int x){
        x=x+10;
    }
    public static void Main(string[] args){
        int a=5;
        Console.WriteLine(a);
        Update(ref a);
        Console.WriteLine(a);
    }
}


using System;

public class Demo{
    static void Update(out int x){
        x=10;
    }
    public static void Main(string[] args){
        int a;
        Update(out a);
        Console.WriteLine(a);
    }
}

