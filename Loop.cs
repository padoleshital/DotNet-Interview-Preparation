using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        static void Main()
        {
            int[] Numbers = new int[4];

            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            Numbers[3] = 104;

            //for loop 
            for (int j = 0; j < Numbers.Length; j++)
            {
                Console.WriteLine(Numbers[j]);
            }

            //While loop
            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }

            //foreach
            foreach (int k in Numbers)
            {
                Console.WriteLine(k);
            }

            //Find Even Numbers using loops



            // for(int i = 0 ;i<= 20; i++)
            //     {
            //     if(i % 2 == 1 )
            //     countinue;
            //     Console.WriteLine(i)
            //     }

        }
    }
}