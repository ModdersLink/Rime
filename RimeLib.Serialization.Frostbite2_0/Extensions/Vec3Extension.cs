using fb;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Frostbite2_0.Extensions
{
    public static class Vec3Extension
    {

        public static void Deserialize(this Vec3 p_Value, RimeReader p_Reader)
        {
            p_Value.x = p_Reader.ReadSingle();
            p_Value.y = p_Reader.ReadSingle();
            p_Value.z = p_Reader.ReadSingle();
            p_Reader.ReadBytes(4); // padding
        }

        public static void Serialize(this Vec3 p_Value, RimeWriter p_Writer)
        {
            p_Writer.Write(p_Value.x);
            p_Writer.Write(p_Value.y);
            p_Writer.Write(p_Value.z);
            p_Writer.WriteNullBytes(4);
        }
    }
}
