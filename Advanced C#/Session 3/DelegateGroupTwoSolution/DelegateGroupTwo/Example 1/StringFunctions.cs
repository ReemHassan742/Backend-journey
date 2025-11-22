using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGroupTwo.Example_1
{
    internal class StringFunctions
    {
        //Count number of upper case chars in string
        public static int CountUpperCase(string s)
        {
            int Count = 0;
            if(s is not null)
            {
                for(int i = 0; i < s.Length; i++)
                {
                    if (char.IsUpper(s[i]))
                        Count++;
                }
            }
            return Count;
        }
        //Count number of lower case chars in string
        public static int CountLowerCase(string s)
        {
            int Count = 0;
            if (s is not null)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsLower(s[i]))
                        Count++;
                }
            }
            return Count;
        }
    }
}
