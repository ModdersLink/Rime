using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rimelib.Ant.Frostbite2_0.EA.Decompressor
{
    public class DCTDecompressor
    {


        void Parse(ant.DctAnimationAsset p_Anim)
        {
            var s_DCTData = p_Anim.Data.ToArray();


            using var s_Reader = new RimeReader(new MemoryStream(s_DCTData));
        }
    }
}
