using RimeLib.IO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization
{
    public class StringTable
    {
        protected ConcurrentDictionary<int, string> m_Strings;
        protected int m_StringTableSize;

        public StringTable()
        {
            m_Strings = new ConcurrentDictionary<int, string>();
            m_StringTableSize = 0;
        }

        public bool AddString(string p_String)
        {
            // If the string table already contains this string
            if (m_Strings.Values.Contains(p_String))
                return true;

            return m_Strings.TryAdd(GetStringTableSize(), p_String);
        }

        public string GetString(int p_Offset)
        {
            if (m_Strings.TryGetValue(p_Offset, out string? s_Value))
                return s_Value;

            return string.Empty;
        }

        public int GetOffset(string p_String)
        {
            foreach (var s_Pair in m_Strings)
            {
                if (s_Pair.Value == p_String)
                    return s_Pair.Key;
            }

            return -1;
        }

        protected int GetStringTableSize()
        {
            var s_StringTableSize = 0;
            foreach (var s_Pair in m_Strings)
                s_StringTableSize += s_Pair.Value.Length + 1;

            return s_StringTableSize;
        }

        public void Recalculate()
        {
            // TODO: Do we want to sort?

            var s_Strings = new ConcurrentDictionary<int, string>();

            var s_CurrentOffset = 0;
            foreach (var s_Pair in m_Strings)
            {
                s_Strings.TryAdd(s_CurrentOffset, s_Pair.Value);
                s_CurrentOffset += s_Pair.Value.Length + 1; // Add the null terminator
            }

            m_Strings = s_Strings;
        }

        public byte[] Serialize()
        {
            // Recalculate all offsets one final time
            Recalculate();

            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                foreach (var s_Pair in m_Strings)
                {
                    s_Writer.Seek(s_Pair.Key, SeekOrigin.Begin);
                    s_Writer.WriteNullTerminatedString(s_Pair.Value);
                }

                return ((MemoryStream)s_Writer.BaseStream).ToArray();
            }
        }
    }
}
