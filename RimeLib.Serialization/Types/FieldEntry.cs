using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Types
{
    public class FieldEntry
    {
        // The type of the underlying data
        private Type m_Type;

        // Field name
        private string m_Name;

        // Offset in the payload
        private int m_OffsetInPayload;


        // Rime specific things
        private TypeEntry m_Parent;

        // MemberInfoFlags from frostbite
        private ushort m_FrostbiteFlags;

        public bool IsBlittable => m_FrostbiteFlags != 0; // TODO: Fix this

        public FieldEntry(TypeEntry p_ParentEntry, dynamic p_Value)
        {
            m_Parent = p_ParentEntry;
            m_Name = string.Empty;
            m_Type = p_Value.GetType();
        }
    }
}
