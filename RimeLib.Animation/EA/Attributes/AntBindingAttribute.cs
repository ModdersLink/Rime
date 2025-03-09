using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Attributes
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class AntBindingAttribute
        : Attribute
    {

        public AntBindingAttribute(uint p_Hash)
        {
            Hash = p_Hash;
        }


        public uint Hash { get; set; } = 0;
    }
}
