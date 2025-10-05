using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOneGroupTwoAdv
{
    internal class Helper <T> where T : Point,  IComparable<T>  /*, IComparer<T> , IEquatable<T> ,*//* ,new()*/
        //Point or any obj from class  inhiret from point

    {
        #region Swap
        //Swap Generics
        //T STAND TEMPLATE
        public static void Swap<T1>(ref T1 X, ref T1 Y)
        {
            T1 Temp = X;
            X = Y;
            Y = Temp;
        }
        //Swap
        //public static void Swap(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void Swap(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //public static void Swap(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        #endregion

        #region Search Array
        public static int SearchArray<T>(T[] Arr , T Value)
        {
            if (Arr is not null)
            {
                for(int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(Value))
                        return i;
                }
            }
            return -1; //Array null , Value not found
        }
        #endregion

        #region BubbleSort
        public static void BubbleSort<T1>(T1[] Arr) where T1 : IComparable<T1> , IComparer<T1> , new()
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int k = 0; k < Arr.Length - i - 1; k++)
                    {
                        if (Arr[k].CompareTo(Arr[k + 1]) == 1)
                            Helper<T>.Swap<T1>(ref Arr[k], ref Arr[k + 1]);
                    }
                }
            }
        }
        #endregion
    }
}
