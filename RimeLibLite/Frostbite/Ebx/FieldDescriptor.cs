using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Serialization.Ebx
{
    public class FieldDescriptor
    {
        public static int SizeOf => 14 + MemberInfoFlags.SizeOf;

        /// <summary>
        /// Gets the name of this field
        /// On Set will update NameHash
        /// </summary>
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;

                if (m_Name != null)
                    NameHash = FbUtils.HashQuick(m_Name);
            }
        }

        /// <summary>
        /// fb::HashQuick of Name field
        /// </summary>
        public uint NameHash { get; set; }

        /// <summary>
        /// Frostbite MemberInfoFlags
        /// </summary>
        public MemberInfoFlags Flags { get; set; }

        /// <summary>
        /// This is the TypeDescriptor index, not actual field type
        /// </summary>
        public ushort FieldType { get; set; }

        /// <summary>
        /// Offset
        /// TODO: Better description
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// I have no idea what this is used for
        /// Is it ever non-zero in BF3?
        /// </summary>
        public int SecondaryOffset { get; set; }

        /// <summary>
        /// IGNORE THIS
        /// This is just to make my life easier, it's not actually serialized
        /// </summary>
        public Type? CSharpType { get; set; }

        private string m_Name;

        public FieldDescriptor(RimeReader p_Reader, IReadOnlyDictionary<uint, string> p_HashedTypeNames)
        {
            NameHash = p_Reader.ReadUInt32();
            Flags = new MemberInfoFlags(p_Reader);
            FieldType = p_Reader.ReadUInt16();
            Offset = p_Reader.ReadInt32();
            SecondaryOffset = p_Reader.ReadInt32();

            m_Name = string.Empty;

            if (p_HashedTypeNames != null)
                Name = p_HashedTypeNames[NameHash];
        }

        public FieldDescriptor()
        {
            Flags = new MemberInfoFlags();

            m_Name = string.Empty;
        }

        public void Serialize(EndianBinaryWriter p_Writer)
        {
            if (Name != null)
                NameHash = FbUtils.HashQuick(Name);

            p_Writer.Write(NameHash);
            p_Writer.Write(Flags.FlagBits);
            p_Writer.Write(FieldType);
            p_Writer.Write(Offset);
            p_Writer.Write(SecondaryOffset);
        }

        public override string ToString()
        {
            return $"{Name} ({Offset} - {SecondaryOffset})";
        }

        protected bool Equals(FieldDescriptor other)
        {
            return NameHash == other.NameHash && Equals(Flags, other.Flags) && FieldType == other.FieldType && Offset == other.Offset && SecondaryOffset == other.SecondaryOffset;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((FieldDescriptor)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)NameHash;
                hashCode = (hashCode * 397) ^ Flags.GetHashCode();
                hashCode = (hashCode * 397) ^ FieldType.GetHashCode();
                hashCode = (hashCode * 397) ^ Offset;
                hashCode = (hashCode * 397) ^ SecondaryOffset;
                return hashCode;
            }
        }

        public static bool operator ==(FieldDescriptor left, FieldDescriptor right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FieldDescriptor left, FieldDescriptor right)
        {
            return !Equals(left, right);
        }
    }
}
