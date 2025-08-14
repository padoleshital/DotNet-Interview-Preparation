using System;

public class Program
{
	public static void Main()
	{
		Program.EvenNumbers(30);
		Program p = new Program();
		int sum = p.Add(30, 60);
		Console.Write(sum + " "); //90
	}
	public int Add(int FN, int SN) //integer return type
	{
		return FN + SN;
	}

	public static void EvenNumbers(int Target)  //Static method add parameter with int datatype
	{
		int Start = 0;
		while (Start <= Target)
		{
			Console.Write(Start+ " ");  //0 2 4 6 8 10 12 14 16 18 20 22 24 26 28 30
			Start = Start + 2;
		}
	}
}