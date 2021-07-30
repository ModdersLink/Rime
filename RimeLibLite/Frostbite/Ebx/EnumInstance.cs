using System.Collections.Generic;

namespace RimeLib.Serialization.Ebx
{
    public class EnumInstance
    {
        public ushort Type { get; set; }
        public Dictionary<int, string> Values { get; set; }

        public EnumInstance()
        {
            Values = new Dictionary<int, string>();
        }
    }
}
