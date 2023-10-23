using fb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Frostbite2_0.Extensions
{
    public static class AntRefExtension
    {
        public static bool Valid(this AntRef p_Val) => p_Val.AssetId != -1; // p_Val.AssetId != 0xFFFFFFFF;

        public static uint PackageId(this AntRef p_Val) => ((uint)p_Val.AssetId >> 20) & 0x3FF;

        // this uses a refrence used like a guid in ant
        public static uint RefrenceId(this AntRef p_Val) => (uint)p_Val.AssetId & 0xFFFFF;

    }
}
