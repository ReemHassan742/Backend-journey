using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Generics
{
    public class RangeGenerics<T> where T : IComparable<T>
    {
        public T Minimum { get; }
        public T Maximum { get; }

        public RangeGenerics(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");

            Minimum = minimum;
            Maximum = maximum;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }
        public double Length()
        {
            dynamic min = Minimum;
            dynamic max = Maximum;

            try
            {
                return (double)(max - min);
            }
            catch
            {
                throw new InvalidOperationException("Length can only be calculated for numeric types.");
            }
        }

        public override string ToString()
        {
            return $"Range: [{Minimum}, {Maximum}]";
        }
    }
    
}
