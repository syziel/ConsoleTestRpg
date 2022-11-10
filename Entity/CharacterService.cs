﻿using ConsoleTestRpg.Entites.Interfaces;
using ConsoleTestRpg.Entities.Models;
using Newtonsoft.Json;

namespace ConsoleTestRpg.Enties
{
    public class CharacterService : ICharacterService
    {

        public Character LoadCharacter(string name)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Characters";
            var Character = new Character();

            if (File.Exists($"{basePath}\\{name}.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var CharacterJsonFile = directory.GetFiles($"{name}.json");

                using (StreamReader fi = File.OpenText(CharacterJsonFile[0].FullName))
                {
                    Character = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }

            }
            else
            {
                throw new Exception("Character not found.");
            }


            return Character;
        }

        public List<Character> GetCharactersInRange(int minLevel = 0, int maxLevel = 20)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            var charactersInRange = new List<Character>();

            try
            {
                var directory = new DirectoryInfo(basePath);
                foreach (var file in directory.GetFiles($"*.json"))
                {
                    using (StreamReader fi = File.OpenText(file.FullName))
                    {
                        var potentialCharacterInRange = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                        if (potentialCharacterInRange.IsAlive && potentialCharacterInRange.Level >= minLevel && potentialCharacterInRange.Level <= maxLevel);
                        {
                            charactersInRange.Add(potentialCharacterInRange);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($" Something went wrong {ex.Message}");
            }
            return charactersInRange;
        }

        Character ICharacterService.GetCharactersInRange(int minLevel, int maxLevel)
        {
            throw new NotImplementedException();
        }
    }
}

