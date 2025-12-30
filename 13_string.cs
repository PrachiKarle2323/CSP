using System;

public class Demo{
    public static void Main(string[] args){
        string name="Prachi";
        string surname="Karle";
        Console.WriteLine(name.Length);
        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());
        Console.WriteLine(name.IndexOf("i"));
        
        Console.WriteLine(string.Concat(name,surname));
        string n=$"{name} {surname}";
        Console.WriteLine(n);
        
        Console.WriteLine(n.Substring(3,6));
    }
}
