using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Types
{
    public class AntQuaternion
         : AntVector4
    {
        public AntQuaternion()
        {
        }

        public AntQuaternion(float x, float y, float z, float w)
            : base(x, y, z, w)
        {
        }

        public AntQuaternion(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }
    }
}
