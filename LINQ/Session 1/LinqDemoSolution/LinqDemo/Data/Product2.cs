using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo.Data
{
    internal class Product2 : Product
    {
        public int SerialNum { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" SerialNum :{SerialNum}";
        }
    }
}
