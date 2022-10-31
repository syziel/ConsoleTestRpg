using ConsoleTestRpg.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ConsoleTestRpg.Adventures.Models;
using ConsoleTestRpg.Items.Interfaces;
using ConsoleTestRpg.Items.Models;


namespace ConsoleTestRpg.Adventures.Models
{
    public class Rooms
    {
        public string RoomName;
        public int RoomNumber;
        public string Description;
        public List<Monster> Monsters;
        public Treasure Chest;
        public Objective FinalObjective;
        public List<Exit> Exits;

    }
}
