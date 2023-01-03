using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using System.Diagnostics.CodeAnalysis;

namespace RimeLib.Ant.EA.Types
{
    public class AntGuid 
        : IFbSerializable
    {
        public static readonly AntGuid c_NullGuid = new AntGuid();


        public byte[] Value { get; set; } = new byte[0x10];


        // used for simpleassetresolver
        public uint SimpleRefrenceIndex => EndianBitConverter.Little.ToUInt32(Value, 0);

        // only used for AssetResolver and not simpleassetresolver
        public uint RefrenceIndex => EndianBitConverter.Big.ToUInt32(Value, 0);
        public bool IsStaticRefrence => (RefrenceIndex & 0x80000) != 0;
        public uint StaticRefrence => RefrenceIndex & ~(uint)0x80000;

        public AntGuid()
        {
        }

        public AntGuid(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public AntGuid(byte p_Value)
        {
            var s_Data = BitConverter.GetBytes((uint)0x1010101 * p_Value);

            Array.Copy(s_Data, 0, Value, 0x0, 4);
            Array.Copy(s_Data, 0, Value, 0x4, 4);
            Array.Copy(s_Data, 0, Value, 0x8, 4);
            Array.Copy(s_Data, 0, Value, 0xC, 4);
        }


        public static bool operator ==(AntGuid? p_G1, AntGuid? p_G2)
        {
            if (ReferenceEquals(p_G1, p_G2))
                return true;

            if (p_G1 is null && p_G2 is null)
                return true;

            if (p_G1 is null || p_G2 is null)
                return false;

            return p_G1.Value == p_G2.Value;
        }

        /// <summary>
        /// Guid not equals
        /// </summary>
        /// <param name="p_G1">First guid</param>
        /// <param name="p_G2">Second guid</param>
        /// <returns>True if not equal, false otherwise</returns>
        public static bool operator !=(AntGuid p_G1, AntGuid p_G2)
        {
            return p_G1.Value != p_G2.Value;
        }


        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="p_Obj">Object to compare</param>
        /// <returns>True if equal, false otherwise</returns>
        public override bool Equals(object? p_Obj)
        {
            if (ReferenceEquals(this, p_Obj))
                return true;

            var s_Obj = p_Obj as AntGuid;

            if (s_Obj == null)
                return false;

            return s_Obj.Value == this.Value;
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Value);

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Value = p_Reader.ReadBytes(0x10);
        }



        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
        }
    }
}
