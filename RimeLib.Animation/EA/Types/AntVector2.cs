using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Types
{
    public class AntVector2
        : AntVector4
    {
        public AntVector2()
        {
        }

        public AntVector2(float x, float y)
            : base(x, y, 0.0f, 0.0f)
        {
        }

        public AntVector2(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }
    }
}
