using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Serialization.Ebx
{
    public class TypeInstance
    {
        public TypeDescriptor Descriptor { get; set; }
        public List<FieldInstance> Fields { get; set; }
        public UInt32 ArrayEntryIndex { get; set; }

        public TypeInstance()
        {
            Descriptor = new TypeDescriptor();
            Fields = new List<FieldInstance>();
        }
    }
}
