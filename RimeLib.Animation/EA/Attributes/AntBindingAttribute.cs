using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.Attributes
{

    // AllowMultiple: a class can bind several layout hashes — the hash is schema-derived, so
    // builds with a drifted schema for the same type (e.g. the BF3 alpha) carry a second hash.
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
