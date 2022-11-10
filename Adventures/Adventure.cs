
using ConsoleTestRpg.Adventures.Models;

namespace ConsoleTestRpg.Adventures

{
    public class Adventure
    {
        public string? GUID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int ExpReward { get; set; }
        public int GoldReward { get; set; }

        public int MaximumLevel { get; set; }
        public int MinimumLevel { get; set; }
        public List<Rooms> Rooms{ get; set; }

        public Adventure()
        {

        }

        /// <summary>
        /// this class dose this and that  and don't do this.
        /// </summary>
        public void myMethod()
        {

        }
    }
}
