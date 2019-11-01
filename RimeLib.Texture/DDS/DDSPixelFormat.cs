using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.DDS
{
    [Flags]
    public enum DDSFormatFlags : uint
    {
        None = 0,

        AlphaPixels = 0x000001,
        Alpha = 0x000002,
        FourCC = 0x000004,
        PaletteIndexed8 = 0x000020,
        Rgb = 0x000040,

        Luminance = 0x020000,
        BumpDudV = 0x080000,


        Rgba = Rgb | AlphaPixels,
        LuminanceA = Luminance | AlphaPixels,
        PaletteIndexed8A = PaletteIndexed8 | AlphaPixels,
    };




    public class DDSPixelFormat : IFbSerializable
    {
        public DDSPixelFormat()
        {
        }

        public DDSPixelFormat(DDSFormatFlags p_Flags, uint p_BitCount, uint p_RMask = 0, uint p_GMask = 0, uint p_BMask = 0, uint p_AMask = 0)
        {
            m_Flags = p_Flags;
            m_RGBBitCount = p_BitCount;

            m_RBitMask = p_RMask;
            m_GBitMask = p_GMask;
            m_BBitMask = p_BMask;
            m_ABitMask = p_AMask;
        }

        public DDSPixelFormat(string p_FourCC, uint p_BitCount = 0, uint p_RMask = 0, uint p_GMask = 0, uint p_BMask = 0, uint p_AMask = 0)
            : this(DDSFormatFlags.FourCC, p_BitCount, p_RMask, p_GMask, p_BMask, p_AMask)
        {
            m_FourCC = MakeFourCC(p_FourCC);
        }

        public static readonly DDSPixelFormat s_DXExtFormat = new DDSPixelFormat( "DX10" );

        public uint m_Size = 0x20;
        public DDSFormatFlags m_Flags = DDSFormatFlags.None;
        public uint m_FourCC = 0;
        public uint m_RGBBitCount = 0;
        public uint m_RBitMask = 0;
        public uint m_GBitMask = 0;
        public uint m_BBitMask = 0;
        public uint m_ABitMask = 0;


        public static uint MakeFourCC(string p_Input)
        {
            uint s_Result = 0;

            for (var i = 0; i < System.Math.Min(p_Input.Length, 4); i++)
                s_Result |= (uint) p_Input[i] << (i * 8);

            return s_Result;
        }

        #region Serializers
        /// <summary>
        /// Deserialize from an open reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position</param>
        public void Deserialize(RimeReader p_Reader)
        {
            m_Size = p_Reader.ReadUInt32();
            m_Flags = (DDSFormatFlags) p_Reader.ReadUInt32();
            m_FourCC = p_Reader.ReadUInt32();
            m_RGBBitCount = p_Reader.ReadUInt32();
            m_RBitMask = p_Reader.ReadUInt32();
            m_GBitMask = p_Reader.ReadUInt32();
            m_BBitMask = p_Reader.ReadUInt32();
            m_ABitMask = p_Reader.ReadUInt32();
        }


        /// <summary>
        /// Serialize to an open writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(m_Size);
            p_Writer.Write((uint) m_Flags);
            p_Writer.Write(m_FourCC);
            p_Writer.Write(m_RGBBitCount);
            p_Writer.Write(m_RBitMask);
            p_Writer.Write(m_GBitMask);
            p_Writer.Write(m_BBitMask);
            p_Writer.Write(m_ABitMask);
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
