using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace RimeLib.Frostbite.Codec
{
    public class CodecHeader
        : IFbSerializable
    {
        private const uint c_PackedSizeMask = 0xFFFFF;

        private const uint c_GuardValue = 0x7;
        
        public CodecHeader()
        {
        }

        public CodecHeader(uint p_PackedSize, uint p_UnpackedSize, CodecMethod p_Method)
        {
            UnpackedSize = p_UnpackedSize;

            if (p_PackedSize < p_UnpackedSize)
            {
                PackedSize = p_PackedSize;
                Method = p_Method;
            }
            else
            {
                PackedSize = p_UnpackedSize;
            }

            SetGuardBits();
        }

        public CodecHeader(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }


        public uint UnpackedSize { get; set; } = 0;
        private uint PackedSizeMethod { get; set; } = 0;


        public uint PackedSize
        {
            get => (PackedSizeMethod & c_PackedSizeMask);
            set
            {
                PackedSizeMethod &= ~c_PackedSizeMask; // remove current packed size
                PackedSizeMethod |= (value & c_PackedSizeMask); // set new packed size
                SetGuardBits();
            }
        }
        public CodecMethod Method 
        { 
            get => (CodecMethod)(PackedSizeMethod >> 24); 
            set
            {
                PackedSizeMethod = PackedSize | ((uint)value << 24);
                SetGuardBits();
            }
        }

        public uint GuardBits => (PackedSizeMethod >> 20) & 0xF;

        public bool HasGuardBits => GuardBits != 0; // should be == 0x7, game does != 0

        public bool ValidGuardBits => GuardBits == c_GuardValue;

        public void SetGuardBits() => PackedSizeMethod |= (c_GuardValue << 20);
        public void ClearGuardBits() => PackedSizeMethod &= ~(c_GuardValue << 20);


        public void Deserialize(RimeReader p_Reader)
        {
            UnpackedSize = p_Reader.ReadUInt32();
            PackedSizeMethod = p_Reader.ReadUInt32();
        }


        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(UnpackedSize);
            p_Writer.Write(PackedSizeMethod);

            return true;
        }

        #region defaults
        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
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
        #endregion


    }
}
