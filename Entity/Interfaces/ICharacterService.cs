using ConsoleTestRpg.Entities.Models;

namespace ConsoleTestRpg.Entites.Interfaces
{
    public interface ICharacterService
    {                    
        public Character LoadCharacter(string name);

        public Character GetCharactersInRange(int minLevel = 0, int maxLevel = 20);
    }
}
