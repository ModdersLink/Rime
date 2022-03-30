using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

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
            Flags = p_Flags;
            RGBBitCount = p_BitCount;

            RBitMask = p_RMask;
            GBitMask = p_GMask;
            BBitMask = p_BMask;
            ABitMask = p_AMask;
        }

        public DDSPixelFormat(string p_FourCC, uint p_BitCount = 0, uint p_RMask = 0, uint p_GMask = 0, uint p_BMask = 0, uint p_AMask = 0)
            : this(DDSFormatFlags.FourCC, p_BitCount, p_RMask, p_GMask, p_BMask, p_AMask)
        {
            FourCC = DDSUtils.MakeFourCC(p_FourCC);
        }

        public static readonly DDSPixelFormat s_DXExtFormat = new DDSPixelFormat( "DX10" );

        public uint Size { get; set; } = 0x20;
        public DDSFormatFlags Flags { get; set; } = DDSFormatFlags.None;
        public uint FourCC { get; set; } = 0;
        public uint RGBBitCount { get; set; } = 0;
        public uint RBitMask { get; set; } = 0;
        public uint GBitMask { get; set; } = 0;
        public uint BBitMask { get; set; } = 0;
        public uint ABitMask { get; set; } = 0;


        #region Serializers
        /// <summary>
        /// Deserialize from an open reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position</param>
        public void Deserialize(RimeReader p_Reader)
        {
            Size = p_Reader.ReadUInt32();
            Flags = (DDSFormatFlags) p_Reader.ReadUInt32();
            FourCC = p_Reader.ReadUInt32();
            RGBBitCount = p_Reader.ReadUInt32();
            RBitMask = p_Reader.ReadUInt32();
            GBitMask = p_Reader.ReadUInt32();
            BBitMask = p_Reader.ReadUInt32();
            ABitMask = p_Reader.ReadUInt32();
        }


        /// <summary>
        /// Serialize to an open writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Size);
            p_Writer.Write((uint) Flags);
            p_Writer.Write(FourCC);
            p_Writer.Write(RGBBitCount);
            p_Writer.Write(RBitMask);
            p_Writer.Write(GBitMask);
            p_Writer.Write(BBitMask);
            p_Writer.Write(ABitMask);
            return true;
        }


        /// <summary>
        /// Serialize to a byte array
        /// </summary>
        /// <returns>byte[]</returns>
        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
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
