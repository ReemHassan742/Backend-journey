using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSolutionTwo
{
    internal struct Location
    {
      

        public int X { set; get; }
        public int Y{ set; get; }
        public int Z { set; get; }

        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X} ,{ Y} ,{ Z})";
        }
    }
}
