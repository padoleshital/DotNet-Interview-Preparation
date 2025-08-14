// Create method with ref parameter

using System;

public class Program
{
    public static void Main()
    {
        int i = 0;
        string val = "Dog";
        //pass as reference parameter
        CompareValue(ref val);
        Console.WriteLine(val); //Cat
        SimpleMethod(ref i); // 101
        Console.Write(i);
    }

    public static void SimpleMethod(ref int a)
    {
        a = 101;
    }

    static void CompareValue(ref string val1)
    {
        //Compare the value
        if (val1 == "Dog")
        {
            Console.WriteLine("String are Same");
        }
        //Assigning new value
        val1 = "Cat1";

    }
}


//Method with value parameter
using System;
					
public class Program
{
    public static void Main()
    {
        int i = 0;
        string str1 = "shital";
        string str2 = "Padole";
        string res = AddStr(str1, str2);
        // The Value of the parameter
        //variable alredy assign		
        SimpleMethod(i);
        Console.WriteLine(res); //shitalPadole
        Console.WriteLine(i); // 0
    }

    public static void SimpleMethod(int j)
    {
        j = 101;
    }

    public static string AddStr(string s1, string s2)
    {
        return s1 + s2;
    }
}


//Method With out Parameter

using System;
					
public class Program
{
    public static void Main()
    {
        int Total = 0;
        int Product = 0;
        Calculate(10, 20, out Total, out Product);
        // Display the value of num
        Console.WriteLine("Sum = {0} && Product = {1}", Total, Product); //Sum = 30 && Product = 200

    }
    // Method in which out parameter is passed
    // and this method returns the value of
    // the passed parameter
    public static void Calculate(int FN, int SN, out int Sum, out int Product)
    {
        Sum = FN + SN;
        Product = FN * SN;
    }
}