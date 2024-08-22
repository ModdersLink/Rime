using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Types
{
    public class AntVector3
        : AntVector4
    {
        public AntVector3()
        {
        }

        public AntVector3(float x, float y, float z)
            : base(x, y, z, 0.0f)
        {
        }

        public AntVector3(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }
    }
}
