using System;

public class Program
{
    public static void Main()
    {
        string UserChoice = "";
        do
        {
            Console.WriteLine("Please enter your Target?");//20      
            int UserTarget = int.Parse(Console.ReadLine());
            int Start = 0;

            while (Start <= UserTarget)
            {
                Console.Write(Start + " ");  //0 2 4 6 8 10 12 14 16 18 20 
                Start = Start + 2;
            }

            do
            {
                Console.WriteLine("Do you want to continue YES or NO");
                UserChoice = Console.ReadLine().ToUpper();

                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Invalid Choice,Please say YES or NO");
                }
            } while (UserChoice != "YES" && UserChoice != "NO");
        } while (UserChoice == "YES");
    }
}

//Enter name here...
Access: 
using System;
					
public class Program
{
	public static void Main()
	{
		string UserChoice = "";
	do{
      Console.WriteLine("Please enter your Target?");//20      
      int UserTarget = int.Parse(Console.ReadLine());      
      int Start = 0;
      
      while(Start <= UserTarget)
      {        
        Console.Write(Start + " ");  //0 2 4 6 8 10 12 14 16 18 20 
        Start = Start + 2;
      }
		
		do{
		Console.WriteLine("Do you want to continue YES or NO");		
		UserChoice = Console.ReadLine().ToUpper();
		
		if(UserChoice != "YES" && UserChoice != "NO")
		{
			Console.WriteLine("Invalid Choice,Please say YES or NO");
		}
		}while (UserChoice != "YES" && UserChoice != "NO");
		}while(UserChoice == "YES");
	}
}

//Please enter your Target?
//10
//0 2 4 6 8 10 Do you want to continue YES or NO
//yes
//Please enter your Target?
//4
//0 2 4 Do you want to continue YES or NO
//no