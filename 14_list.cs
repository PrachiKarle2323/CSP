using System;
using System.Collections.Generic;

public class Demo{
    public static void Main(string[] args){
        List<int>l1=new List<int>();
        l1.Add(10);
        l1.Add(20);
        l1.Add(20);
        l1.Add(45);
        l1.Add(15);
        
        foreach(int k in l1){
            Console.WriteLine(k);
        }
        Console.WriteLine();
        
        l1.Remove(10);
        foreach(int k in l1){
            Console.WriteLine(k);
        }
        
        Console.WriteLine(l1.Contains(20));
        // Console.WriteLine(l1.count(20));
        
        l1.Sort();
        foreach(int k in l1){
            Console.WriteLine(k);
        }
        
        
        
    }
}
