using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Attributes
{

    // A class can bind several layout hashes. The hash comes from the schema, so a build whose
    // schema for the type has drifted, such as a pre-release one, carries a second hash.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
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
