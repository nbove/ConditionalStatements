/*
 Author: Nick Bove
 Date: 1/21/19
 Comments: This C# Console application code demonstrates the use of 
           conditional statements after getting input from users
*/

using System;

namespace ConditionalStatements
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What grade do you expect to get in ISM 4300?");
			Console.WriteLine("Please enter an integer value");

			try
			{

				String userinput = Console.ReadLine();
				int UserGrade = int.Parse(userinput);

				if (UserGrade < 60)
				{

					Console.WriteLine("You will receive an F");
					UserGrade = int.Parse(Console.ReadLine());
				}

				else if ((UserGrade >= 60) && (UserGrade <= 61))
				{
					Console.WriteLine("You will receivea D-");
					UserGrade = int.Parse(Console.ReadLine());
				}

				else if ((UserGrade >= 62) && (UserGrade <= 67))
				{
					Console.WriteLine("You will receive a D");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else if ((UserGrade >= 68) && (UserGrade <= 69))
				{
					Console.WriteLine("You will receive a D+");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else if ((UserGrade >= 70) && (UserGrade <= 71))
				{
					Console.WriteLine("You will receive a C-");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else if ((UserGrade >= 72) && (UserGrade <= 77))
				{
					Console.WriteLine("You will receive a C");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else if ((UserGrade >= 78) && (UserGrade <= 79))
				{
					Console.WriteLine("You will receive a C+");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else if ((UserGrade >= 80) && (UserGrade <= 81))
				{
					Console.WriteLine("You will receive a B-");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else if ((UserGrade >= 82) && (UserGrade <= 87))
				{
					Console.WriteLine("You will receive a B");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else if ((UserGrade >= 88) && (UserGrade <= 89))
				{
					Console.WriteLine("You will receive a B+");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else if ((UserGrade >= 90) && (UserGrade <= 91))
				{
					Console.WriteLine("You will receive a A-");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else if ((UserGrade >= 92) && (UserGrade <= 97))
				{
					Console.WriteLine("You will receive a A");
					UserGrade = int.Parse(Console.ReadLine());
				}
				else
				{
				
					Console.WriteLine("You will receive a A+");
					UserGrade = int.Parse(Console.ReadLine());
				}

			}
                catch
			{
				Console.WriteLine("Please use an integer data type for your grade you expect next time...");
				Console.WriteLine("Press any key to exit the program and try again...");
				Console.ReadKey(true);
			}
		}
	}
}








