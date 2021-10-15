using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Types
{
    public class TypeEntry
    {
        private TypeEntry m_InheritedType;
        private int m_Alignment;
        private int m_TypeSize;
        private List<FieldEntry> m_Fields;

        public TypeEntry()
        {
            m_Fields = new List<FieldEntry>();
        }
    }
}
