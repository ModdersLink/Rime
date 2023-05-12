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

        Double = 19,
        LayoutTypeCount_FB2 = 19,

        QuatPos = 20,
        Int8Vec16 = 21,
        UInt8Vec16 = 22,
        Int16Vec8 = 23,
        UInt16Vec8 = 24,
        Int32Vec2 = 25,
        Int32Vec3 = 26,
        Int32Vec4 = 27,
        UInt32Vec2 = 28,
        UInt32Vec3 = 29,
        UInt32Vec4 = 30,
        BoolVec2 = 31,
        BoolVec3 = 32,
        BoolVec4 = 33,
        Matrix33 = 34,
        Key = 35



    }
}
