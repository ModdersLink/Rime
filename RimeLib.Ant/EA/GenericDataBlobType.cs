using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA
{
    public enum GenericDataBlobType
    {
        Invalid = -1,
        Data = 0,
        Stream = 1,
        Reflection = 2,
        RefPack = 3,

        Ref2 = 4,
        Data2 = 5, // in game this is added inbetween Data(0) and stream(2) | = 1
        Info = 6,
    }
}
