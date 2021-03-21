using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
           {
               new Command { Id = 0, HowTo = "boil an Egg", Line = "Boil Water", Platform="Kettle and Pan"},
               new Command { Id = 1, HowTo = "cut bread", Line = "Get Knife", Platform="Knife and Chopping board"},
               new Command { Id = 2, HowTo = "make a cup of tea", Line = "Place Teabag in cup", Platform="Kettle and Cup"}

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "boil an Egg", Line = "Boil Water", Platform="Kettle and Pan"};
        }
    }
}
