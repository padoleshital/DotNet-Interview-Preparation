using System;

class Program
{ 
   //Find Even Numbers using loops

    for(int i = 0 ; i<= 20 ; i++)
        {
        if(i % 2 == 1 )
        continue;
        Console.Write(i+ " ");  //0 2 4 6 8 10 12 14 16 18 20 
        }
}