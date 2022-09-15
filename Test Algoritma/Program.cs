using System;

public class Program
{
	public static void Main()
	{
		string child = "";
		var checkChild = 1;
		for (int i = 1; i < 500; i++)
		{
			switch (checkChild)
			{
				case 1:
					child = "si A berteriak";
					checkChild = 2;
					break;
				case 2:
					child = "si B berteriak";
					checkChild = 3;
					break;
				case 3:
					child = "si C berteriak";
					checkChild = 1;
					break;
			}
			

			if ((i % 3) == 0)
            {
				Console.WriteLine($"{child} tik");
				Console.WriteLine("");
			}

			if ((i % 5) == 0)
			{
				Console.WriteLine($"{child} tek");
				Console.WriteLine("");
			}

			if ((i % 7) == 0)
			{
				Console.WriteLine($"{child} tok");
				Console.WriteLine("");
			}

		}
	}


}
