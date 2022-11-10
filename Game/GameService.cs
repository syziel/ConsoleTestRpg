using ConsoleTestRpg.Adventures;
using ConsoleTestRpg.Adventures.interfaces;
using ConsoleTestRpg.Enties;
using ConsoleTestRpg.Entites.Interfaces;
using ConsoleTestRpg.Entities.Models;
using ConsoleTestRpg.Game.Interfaces;
using Newtonsoft.Json;

namespace ConsoleTestRpg.Game
{
    public class GameService : IGameService
    {
        private IAdventureService adventureService;
        private CharacterService characterService;

        private Character character;

        public GameService(IAdventureService AdventureService, ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = (CharacterService)CharacterService;
        }
        public bool StartGame(Adventure adventure = null)
        {

            try
            {
                if (adventure == null)
                {
                    adventure = adventureService.GetInitialAdventure();
                }


                Console.Clear();
                Console.WriteLine();

                //Create Title Banner
                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if (i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }
                Console.WriteLine($"| {adventure.Title} |");
                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if (i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"\n{adventure.Description.ToUpper()}");

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;

                List<Character> charactersInRange = characterService.GetCharactersInRange(adventure.MinimumLevel, adventure.MaximumLevel);

                if (charactersInRange.Count == 0)
                {
                    Console.WriteLine("No characters in range of adventure");
                    return false;
                }
                else
                {
                    Console.WriteLine("WHO DOTH WISH TO CHANCE DEATH?");
                    var characterCount = 0;
                    foreach (var characters in charactersInRange)
                    {
                        Console.WriteLine($"#{characterCount} {characters.Name} {characters.Level} {characters.Class}");
                        characterCount++;
                    }
                }

                character = characterService.LoadCharacter(charactersInRange[Convert.ToInt32(Console.ReadLine())].Name);

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex.Message}");
                return true;


            }
        }
    }
}
