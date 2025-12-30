using System;
using System.Collections.Generic;

public class Demo
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> stu = new Dictionary<int, string>();

        stu.Add(1, "Prachi");
        Console.WriteLine(stu[1]);

        foreach (KeyValuePair<int, string> k in stu)
        {
            Console.WriteLine(k.Key + " " + k.Value);
        }
    }
}
