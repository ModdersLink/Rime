using RimeLib.Serialization.Ebx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization
{
    class TypeFieldTable
    {
        protected Dictionary<string, List<FieldDescriptor>> m_TypeFields;

        public TypeFieldTable()
        {
            m_TypeFields = new Dictionary<string, List<FieldDescriptor>>();
        }

        public bool AddType(string p_TypeName, int p_FieldCount)
        {
            // First we check to see if this contains our typename already
            if (m_TypeFields.ContainsKey(p_TypeName))
            {
                // Then we get the list of field descriptors
                if (!m_TypeFields.TryGetValue(p_TypeName, out List<FieldDescriptor>? s_Descriptors))
                    return false;

                // Validate that our stored count == what we are trying to add
                if (s_Descriptors?.Count != p_FieldCount)
                    throw new InvalidOperationException("BUG: Added descriptor count != previous descriptor count.");

                // This is a duplicate just return happily
                return true;
            }

            m_TypeFields.Add(p_TypeName, new List<FieldDescriptor>(p_FieldCount));

            return true;
        }

        public int GetTypeIndex(string p_TypeName)
        {
            var s_Index = Array.IndexOf(m_TypeFields.Keys.ToArray(), p_TypeName);
            if (s_Index == -1)
                return -1;

            return s_Index;
        }
    }
}
