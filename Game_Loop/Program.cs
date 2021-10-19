using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Loop
{
	class Program
	{
		static int X;
		static int Y;
		static bool gameOver;
		static int userInput;

		static void PlayerUpdate()
		{
			ConsoleKeyInfo Input = Console.ReadKey(true);

			if (Input.Key == ConsoleKey.W)
			{
				Console.Clear();
				Console.SetCursorPosition(X, Y--);
				Console.WriteLine(".");
				
			}
			if (Input.Key == ConsoleKey.S)
			{
				Console.Clear();
				Console.SetCursorPosition(X, Y++);
				Console.WriteLine(".");
			}
			if (Input.Key == ConsoleKey.A)
			{
				Console.Clear();
				Console.SetCursorPosition(X--, Y);
				Console.WriteLine(".");
			}
			if (Input.Key == ConsoleKey.D)
			{
				Console.Clear();
				Console.SetCursorPosition(X++, Y); 
				Console.WriteLine(".");
			}
		}


		static void PlayerDraw()
		{
			Console.SetCursorPosition(X, Y);
			Console.WriteLine(".");
		}

		static void Main(string[] args)
		{
			PlayerDraw();
			while (gameOver == false)
			{
				PlayerUpdate();

			}

			if (gameOver == true)
			{
				Console.WriteLine("GAME OVER!!");

			}



		}




	}
}
