using ConsoleTestRpg.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestRpg.Items.Models
{
    public class ItemClass : IItem
    {
        public Itemtype Name;
        public string? Description;
        public int ObjectiveNumber;
        public int Weight;
        public int GoldValue;
    }
    public enum Itemtype
    {
        Rope,
        Torch,
        Exlier,
        Water,
        Food,
        Treasurebox,
        Key,
    }

}
