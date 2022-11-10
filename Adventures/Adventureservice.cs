<<<<<<< HEAD
﻿using ConsoleTestRpg.Adventures.interfaces;
using Newtonsoft.Json;

namespace ConsoleTestRpg.Adventures
{
    public class AdventureService : IAdventureService
    {
        public Adventure GetInitialAdventure() 
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Adventures";
            var initialAdventure = new Adventure();

            if (File.Exists($"{basePath}\\initial.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("initial.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());
                }
            }

            return initialAdventure;
        }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestRpg.Adventures
{
    internal class Adventureservice
    {
>>>>>>> b2420501713986ef7accf08f4a0e29df8d1fa342
    }
}
