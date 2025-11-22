using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSolutionTwo
{
    //Subscriber
    internal class Refree
    {
        public string Name { get; set; }
        public Refree(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Refree => {Name}";
        }
        public void Look(object? sender, LocationEventArgs locationEventArgs)
        {
            Ball? ball = sender as Ball;

            Console.WriteLine($"{this} Look @ >>>>>>>>>>>>>>> {locationEventArgs.Location} , {ball} ");
        }
    }
}
