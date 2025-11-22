using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSolutionTwo
{
    //Subsribe
    internal class Player
    {
    
        public string Name { get; set; }
        public string Team { get; set; }
        public Player(string name, string team)
        {
            Name = name;
            Team = team;
        }
        public override string ToString()
        {
            return $"Player ==> {Name} :: {Team}";
        }
        public void Run(object? sender , LocationEventArgs locationEventArgs)
        {
            Ball? ball = sender as Ball;
            Console.WriteLine($"{this} Run >>>>>>>>>>>>> {locationEventArgs.Location} , {ball}");
        }

    }
}
