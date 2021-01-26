using RimeLib.IO;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Serialization.Containers
{
    // TODO: Implement MemberInfoFlags
    [ContainerType(Alignment: 8)]
    public class FileRef : FrostbiteContainer
    {
        private string m_Chars = string.Empty;

        public string Chars 
        { 
            get { return m_Chars; } 
            set 
            {
                if (OnPropertyChanging(nameof(Chars), this, m_Chars, value))
                    m_Chars = value; 
            } 
        }

        public FileRef()
        {
        }

        public FileRef(FileRef p_Other)
        {
            Chars = p_Other.Chars;
        }

        public FileRef(string p_Chars)
        {
            Chars = p_Chars;
        }

        public FileRef(RimeReader p_Reader, bool _ = true)
        {
            Deserialize(p_Reader);
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Chars = p_Reader.ReadNullTerminatedString();
        }
    }
}
