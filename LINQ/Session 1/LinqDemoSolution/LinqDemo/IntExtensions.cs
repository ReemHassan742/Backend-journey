using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal static class IntExtensions
    {
        public static int ReverseNumber(this int Number) //Extension method 
        {
            int ReversedNumber = 0, Reminder;
            while(Number != 0) 
            {
                Reminder = Number % 10; 
                ReversedNumber = ReversedNumber * 10 + Reminder; 
                Number = Number / 10; 
            }
            return ReversedNumber;
        }
        public static long ReverseNumber(this long Number) //Extension method 
        {
            long ReversedNumber = 0, Reminder;
            while (Number != 0)
            {
                Reminder = Number % 10;
                ReversedNumber = ReversedNumber * 10 + Reminder;
                Number = Number / 10;
            }
            return ReversedNumber;
        }
    }
}
