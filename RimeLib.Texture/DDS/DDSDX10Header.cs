using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.DDS
{
    public enum DDSResoruceDimension : uint
    {
        Texture1D = 2,
        Texture2D = 3,
        Texture3D = 4,
    };

    [Flags]
    public enum DDSMiscFlag1 : uint  // see D3D11_RESOURCE_MISC_FLAG
    {
        TextureCube = 0x4,
    };

    [Flags]
    public enum DDSMiscFlag2 : uint
    {
        AlphaModeMask = 0x7,
    };

    public class DDSDX10Header : IFbSerializable
    {
        public DXGIFormat DxgiFormat { get; set; } = 0;
        public DDSResoruceDimension ResourceDimension { get; set; } = 0;
        public DDSMiscFlag1 MiscFlag { get; set; } = 0;
        public uint ArraySize { get; set; } = 0;
        public DDSMiscFlag2 MiscFlags2 { get; set; } = 0;

        public const uint c_HeaderSize = 20;
        public DDSDX10Header()
        {
        }

        public DDSDX10Header(DXGIFormat p_Format, DDSResoruceDimension p_Dimension, DDSMiscFlag1 p_Misc1 = 0, uint p_ArraySize = 0, DDSMiscFlag2 p_Misc2 = 0)
        {
            DxgiFormat = p_Format;
            ResourceDimension = p_Dimension;
            MiscFlag = p_Misc1;
            ArraySize = p_ArraySize;
            MiscFlags2 = p_Misc2;
        }

        public DDSDX10Header(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        #region Serializers
        /// <summary>
        /// Deserialize from an open reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position</param>
        public void Deserialize(RimeReader p_Reader)
        {
            DxgiFormat = (DXGIFormat) p_Reader.ReadUInt32();
            ResourceDimension = (DDSResoruceDimension) p_Reader.ReadUInt32();
            MiscFlag = (DDSMiscFlag1) p_Reader.ReadUInt32();
            ArraySize = p_Reader.ReadUInt32();
            MiscFlags2 = (DDSMiscFlag2) p_Reader.ReadUInt32();
        }


        /// <summary>
        /// Serialize to an open writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((uint) DxgiFormat);
            p_Writer.Write((uint) ResourceDimension);
            p_Writer.Write((uint) MiscFlag);
            p_Writer.Write(ArraySize);
            p_Writer.Write((uint) MiscFlags2);
            return true;
        }


        /// <summary>
        /// Serialize to a byte array
        /// </summary>
        /// <returns>byte[]</returns>
        public bool Serialize(out byte[] p_Data)
        {
            var s_Result = false;
            using (var s_Stream = new MemoryStream())
            {
                using (var s_RimeStream = new RimeWriter(s_Stream))
                {
                    s_Result = this.Serialize(s_RimeStream);
                }
                p_Data = s_Stream.ToArray();
            }
            return s_Result;
        }

        /// <summary>
        /// Deserialize from an byte array
        /// </summary>
        /// <param name="p_Data">Input byte array</param>
        public void Deserialize(byte[] p_Data)
        {
            this.Deserialize(new RimeReader(new MemoryStream(p_Data)));
        }

        #endregion
    }
}
