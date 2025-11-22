using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGroupTwo.Example_3
{
    internal class FilterationFunctions
    {
        public static bool CheckOdd(int X)
        {
            return X % 2 == 1;
        }
        public static bool CheckEven(int X)
        {
            return X % 2 == 0;
        }
        public static bool CheckDivisbleBy7(int X)
        {
            return X % 7 == 0;
        }
        public static bool CheckDivisbleBy10(int X)
        {
            return X % 10 == 0;
        }
        public static bool CheckStrLen(string X)
        {
            return X?.Length > 4;
        }
    }
}
