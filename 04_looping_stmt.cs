using System;

public class Demo{
    
    public static void Main(string[] args){
        int i=0;
        while(i<=5){
            Console.WriteLine(i);
            i++;
        }
        
        int i=0;
        do{
            Console.WriteLine(i+1);
        }while(i!=0);
        
        
        for(int j=1;j<=10;j++){
            if(j==5){
                continue;
            }
            Console.WriteLine(j*2);  
        }
        
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                Console.Write(i+""+j+",");
            }
            Console.WriteLine();
         }
        
        
    }
}
