using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Loop
{
	class Program
	{
		static int X = 0;
		static int Y = 0;
		static bool gameOver = false;


		static void PlayerUpdate()
		{
			ConsoleKeyInfo Input = Console.ReadKey(true);

			if (Input.Key == ConsoleKey.W)
			{
				if (Y >= 1)
				{
					Y--;
				}
			}
			if (Input.Key == ConsoleKey.S)
			{
				Y++;
			}
			if (Input.Key == ConsoleKey.A)
			{
				if (X >= 1)
				{
					X--;
				}
			}
			if (Input.Key == ConsoleKey.D)
			{
				X++;

			}
			if (Input.Key == ConsoleKey.Escape)
			{

				Console.WriteLine("GAME OVER!!");
				Console.WriteLine("Press Enter You Are Done");
				gameOver = true;


			}
		}


		static void PlayerDraw()
		{
			Console.Clear();
			Console.SetCursorPosition(X, Y);
			Console.WriteLine(".");
		}

		static void Main(string[] args)
		{
			ConsoleKeyInfo Input = Console.ReadKey(true);

			while (gameOver == false)
			{
				PlayerDraw();
				PlayerUpdate();
			}






		}




	}
}
