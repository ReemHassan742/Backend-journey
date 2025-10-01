using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigments.Enums
{
    [Flags]
    internal enum Permissions
    {
        None = 0,
        Read = 1 ,
        Write = 2,  
        Delete = 4,
        Execute = 8
    }
}
