using fb;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Frostbite2_0.Extensions
{
    public static class AxisAlignedBoxExtension
    {
        public static void Deserialize(this AxisAlignedBox p_Value, RimeReader p_Reader)
        {
            p_Value.min.Deserialize(p_Reader);
            p_Value.max.Deserialize(p_Reader);
        }

        public static void Serialize(this AxisAlignedBox p_Value, RimeWriter p_Writer)
        {
            p_Value.min.Serialize(p_Writer);
            p_Value.max.Serialize(p_Writer);
        }
    }
}
