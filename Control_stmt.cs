using System;

public class Demo{
    
    public static void Main(string[] args){
        int x=45,y=35;
        //1
       if(x <= y){
           Console.WriteLine("Yes");
       }
       
       //2
       if(x <= y){
           Console.WriteLine("Yes");
       }
       else{
           Console.WriteLine("No");
       }
       
       //ternary
       int a=x<=y?x:y;
       Console.WriteLine(a);
       
       
       //3
       if(x==y){
           Console.WriteLine("equal");
       }
       else if(x<y){
           Console.WriteLine("Less");
       }
       else{
           Console.WriteLine("Greater");
       }
       
       //4 
       bool flag=false;
       switch(flag){
           case true:
               Console.WriteLine("True");
               break;
            case false:
                Console.WriteLine("False");
                break;
            default:
                Console.WriteLine("Default");
                break;
       }
       
    }
}
