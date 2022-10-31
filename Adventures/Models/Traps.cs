using ConsoleTestRpg.Game;

namespace ConsoleTestRpg.Adventures.Models
{
    public class Traps
    {
        public TrapType TrapType;
        public Die DamageDie = Die.D4;
        public Traps Trap;
        public List<Traps> TrapList;
    }
    public enum TrapType
    {
       pit,
       poison,
       fire,
       lighting,
       water,
       earth,
       wind
    }
}

