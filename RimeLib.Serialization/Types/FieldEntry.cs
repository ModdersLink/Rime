using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Types
{
    public class FieldEntry
    {
        private Type m_Type;
        private string m_Name;
        private int m_OffsetInPayload;
        private dynamic m_Value;

        private TypeEntry m_Parent;

        public FieldEntry(TypeEntry p_ParentEntry, dynamic p_Value)
        {
            m_Parent = p_ParentEntry;
            m_Name = string.Empty;
            m_Value = p_Value;
        }
    }
}
