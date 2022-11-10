using ConsoleTestRpg.Adventures;
using ConsoleTestRpg.Enties;
using ConsoleTestRpg.Game;
using ConsoleTestRpg.Gamw;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

namespace RPGConsoleTutorialSeries
{
	class Program
	{
		private static AdventureService adventureService = new AdventureService();
		private static CharacterService characterService = new CharacterService();
		private static GameService gameService = new GameService(adventureService, characterService);

		static void Main(string[] args)
		{
			MakeTitle();
			MakeMainMenu();
		}
		private static void MakeTitle()
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("***************************************************");
			Console.WriteLine("*                                                 *");
			Console.WriteLine("*      ┌─┐┌─┐┌┐┌┌─┐┌─┐┬  ┌─┐  ┌─┐┬─┐┌─┐┬ ┬┬       *");
			Console.WriteLine("*      │  │ ││││└─┐│ ││  ├┤   │  ├┬┘├─┤││││       *");
			Console.WriteLine("*      └─┘└─┘┘└┘└─┘└─┘┴─┘└─┘  └─┘┴└─┴ ┴└┴┘┴─┘     *");
			Console.WriteLine("*                                                 *");
			Console.WriteLine("***************************************************\n\n");
		}

		private static void MakeMainMenu()
		{
			MakeMenuOptions();
			var inputVaild = false;

			while (!inputVaild)
			{
				switch (Console.ReadLine()?.ToUpper())
				{
					case "S":
						gameService.StartGame();
						inputVaild = true;
						break;
					case "C":
						CreateCharacter();
						inputVaild = true;
						break;
					case "L":
						LoadGame();
						inputVaild = true;
						break;
					default:
						Console.WriteLine("\nChoose right letter");
						MakeMenuOptions();
						inputVaild = false;
						break;
				}
			}
		}

		private static void MakeMenuOptions()
		{
			Console.WriteLine("(S)tart a new game");
			Console.WriteLine("(L)oad a game");
			Console.WriteLine("(C)reate new character");
		}

		private static void LoadGame()
		{
			//throw new NotImplementedException();
		}

		private static void CreateCharacter()
		{
			Console.WriteLine("You are creating a character");
		}
	}
}