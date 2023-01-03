using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AntFieldAttribute
        : Attribute
    {

        public AntFieldAttribute(int p_Index)
        {
            Index = p_Index;
        }


        public int Index { get; set; } = int.MinValue;
    }
}
