namespace ConsoleTestRpg.Entities.Models
{
    public class Character : Entity
    {
        public string? Name;
        public string? Background;
        public int Exp;
        public int MaxExp;
        public List<string>? AdventuresPlayed;
        public CharacterClass Class;

        public int Count()
        {
            throw new NotImplementedException();
        }
    }
     public enum CharacterClass
    {
        Fighter,
        Thief,
        Mage,
        Cleric,
        Barbarian,
        Bard,
        Druid,
        Monk,
        Archer,
        Sorcerer,
        Warlock,
        Artificer,
        SpellSword,
        Ranger,
        Paladin,
        Rogue,
        BloodHunter,
        Nercomancer

    }
}

