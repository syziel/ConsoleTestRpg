using ConsoleTestRpg.Items.Interfaces;

namespace ConsoleTestRpg.Adventures.Models
{
    public class Treasure
    {
        public bool Locked = false;
        public Traps Trap;
        public List<IItem> Chest;
        public int Gold;
    }
}