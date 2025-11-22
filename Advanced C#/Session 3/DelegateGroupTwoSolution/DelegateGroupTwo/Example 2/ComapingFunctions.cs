using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGroupTwo.Example_2
{
    internal class ComapringFunctions
    {
        public static bool CompareGreater(int X , int Y)
        {
            return X > Y;
        }
        public static bool CompareLess(int X, int Y)
        {
            return X < Y;
        }
        public static bool CompareStr(string X, string Y) //Sort asc based on length
        {
            return X?.Length > Y?.Length;
        }
        public static bool CompareStrDsc(string X, string Y) //Sort dsc based on length
        {
            return X?.Length < Y?.Length;
        }
    }
}
