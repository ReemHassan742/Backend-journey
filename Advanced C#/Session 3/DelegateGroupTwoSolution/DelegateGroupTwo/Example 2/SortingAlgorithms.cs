using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateGroupTwo.Example_2
{
    public delegate TResult CompareFuncDelegate<in TD,out TResult>(TD a, TD b);
    //Delegate can refer to function that take 2 parameters [same type]  , return TResult
    internal class SortingAlgorithms <T>
    {
        public static void BubbleSort(T[] arr, CompareFuncDelegate<T,bool> compareFuncDelegate )
        {
            if (arr is not null)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i -1; j++)
                    {
                            if (compareFuncDelegate.Invoke(arr[j], arr[j+1]))
                            Swap(ref arr[j] , ref arr[j+1]);
                    }
                }
            }
        }

        //public static void BubbleSortDesc(int[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (arr[j] < arr[j + 1])
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //}
        private static void Swap(ref T v1, ref T v2)
        {
            T Temp = v1;
            v1 = v2;
            v2 = Temp;
        }
    }
}
