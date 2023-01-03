using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Reflection
{
    public enum LayoutType 
        : uint
    {
        Invalid = 0,
        Bool = 1,
        Int8 = 2,
        UInt8 = 3,
        Int16 = 4,
        UInt16 = 5,
        Int32 = 6,
        UInt32 = 7,
        Int64 = 8,
        UInt64 = 9,
        Float = 10,
        Vector2 = 11,
        Vector3 = 12,
        Vector4 = 13,
        Quaternion = 14,
        Matrix44 = 15,
        Guid = 16,
        String = 17,
        DataRef = 18,

        LayoutTypeCount = 19,
    }
}
