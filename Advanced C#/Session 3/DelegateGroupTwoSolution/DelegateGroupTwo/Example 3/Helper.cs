using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGroupTwo.Example_3
{
    //public delegate bool FilterationFuncDelgate<TD>(TD X);

    internal class Helper
    {
        public static List<T> GetElements<T>(List<T> Numbers , Predicate<T> filterationFuncDelgate )
        {
            List<T> result = new List<T>();
            if (Numbers is not null)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    //if (Numbers[i] % 2 == 1)
                    //if (filterationFuncDelgate.Invoke(Numbers[i]) )
                    if (filterationFuncDelgate(Numbers[i]) )
                        result.Add(Numbers[i]);
                }
            }
            return result;
        }
       
        
        
        
        //    public static List<int> GetOddNumbers(List<int> Numbers)
        //    {
        //        List<int> result = new List<int>();
        //        if(Numbers is not null)
        //        {
        //            for(int i = 0; i < Numbers.Count; i++)
        //            {
        //                if (Numbers[i] % 2 == 1)
        //                    result.Add(Numbers[i]);
        //            }
        //        }
        //        return result;
        //    }
        //    public static List<int> GetEvenNumbers(List<int> Numbers)
        //    {
        //        List<int> result = new List<int>();
        //        if (Numbers is not null)
        //        {
        //            for (int i = 0; i < Numbers.Count; i++)
        //            {
        //                if (Numbers[i] % 2 == 0)
        //                    result.Add(Numbers[i]);
        //            }
        //        }
        //        return result;
        //    }
        //public static List<int> GetNumbersDivisbleBy7(List<int> Numbers)
        //{
        //    List<int> result = new List<int>();
        //    if (Numbers is not null)
        //    {
        //        for (int i = 0; i < Numbers.Count; i++)
        //        {
        //            if (Numbers[i] % 7 == 0)
        //                result.Add(Numbers[i]);
        //        }
        //    }
        //    return result;
        //}
    }
}
