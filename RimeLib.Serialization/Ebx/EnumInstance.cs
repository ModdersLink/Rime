using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Serialization.Ebx
{
    class EnumInstance
    {
        public ushort Type { get; set; }
        public Dictionary<int, string> Values { get; set; }

        public EnumInstance()
        {
            Values = new Dictionary<int, string>();
        }
    }
}
