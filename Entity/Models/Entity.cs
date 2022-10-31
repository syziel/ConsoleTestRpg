using ConsoleTestRpg.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleTestRpg.Entities.Models.Attributes;

namespace ConsoleTestRpg.Entities.Models
{
    public abstract class Entity
    {
        public int Hitpoints = 0;
        public int MaxHitPoints;
        public int MagicPoints;
        public int MaxMagicPoints;
        public int Level;
        public Attack Attack;
        public int Gold;
        public int ArmorClass;
        public List<IItem>? Inventory;
        public Attributes Attributes;
        public int Inventoryweight;
        public bool IsAlive;

    }
    public class Attributes
    {
        public int Strength;
        public int MaxStrength;
        public int Defense;
        public int MaxDefense;
        public int fortitude;
        public int MaxFortitude;
        public int Constitution;
        public int MaxConstitution;
        public int Dexterity;
        public int MaxDexterity;
        public int Intelligence;
        public int MaxIntelligence;
        public int Wisdom;
        public int MaxWisdom;
        public int Charisma;
        public int MaxCharisma;

        public class Attack
        {
            public int BaseDamage;
            public int crictalHit;
        }
    }
}