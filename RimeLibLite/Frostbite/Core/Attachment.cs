using System.Diagnostics.CodeAnalysis;
using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation for fb::Attachment
    /// </summary>
    public class Attachment : IFbSerializable
    {
        private Sha1 m_Sha; // SHA1 Reference to attachment payload

        /// <summary>
        /// Default constructor
        /// </summary>
        public Attachment()
        {
            m_Sha = new Sha1();
        }

        /// <summary>
        /// Constructor that takes a SHA1 hash
        /// </summary>
        /// <param name="p_Sha">Hash of attachment</param>
        public Attachment(Sha1 p_Sha)
        {
            m_Sha = p_Sha;
        }

        /// <summary>
        /// Constructor to read a hash from a opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of an Attachment</param>
        public Attachment(RimeReader p_Reader)
        {
            m_Sha = new Sha1();
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Constructor taking byte array the length of a SHA1
        /// </summary>
        /// <param name="p_Sha">Bytes of a SHA1</param>
        public Attachment(byte[] p_Sha)
        {
            m_Sha = new Sha1(p_Sha);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            m_Sha = new Sha1(p_Reader);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }
}
