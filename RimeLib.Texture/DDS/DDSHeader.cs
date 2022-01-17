using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.DDS
{
    [Flags]
    public enum DDSFlags : uint
    {
        Caps = 0x01,
        Height = 0x02,
        Width = 0x04,
        Pitch = 0x08,

        PixelFormat = 0x001000,
        MipmapCount = 0x020000,
        LinearSize = 0x080000,
        Depth = 0x800000,

        Srgb = 0x40000000,

        Texture = Caps | Height | Width | PixelFormat,
    };


    [Flags]
    public enum DDSCaps : uint
    {
        Complex = 0x0008,
        Texture = 0x1000,
        Mipmap = 0x400000,


        MipmapFlags = Complex | Mipmap
    };

    [Flags]
    public enum DDSCaps2 : uint
    {
        

        Cubemap = 0x0200,

        Cubemap_Face_PositiveX = 0x0400,
        Cubemap_Face_NegativeX = 0x0800,

        Cubemap_Face_PositiveY = 0x1000,
        Cubemap_Face_NegativeY = 0x2000,

        Cubemap_Face_PositiveZ = 0x4000,
        Cubemap_Face_NegativeZ = 0x8000,


        Volume = 0x200000, //3d texture


        Cubemap_PositiveX = Cubemap | Cubemap_Face_PositiveX,
        Cubemap_NegativeX = Cubemap | Cubemap_Face_NegativeX,

        Cubemap_PositiveY = Cubemap | Cubemap_Face_PositiveY,
        Cubemap_NegativeY = Cubemap | Cubemap_Face_NegativeY,

        Cubemap_PositiveZ = Cubemap | Cubemap_Face_PositiveZ,
        Cubemap_NegativeZ = Cubemap | Cubemap_Face_NegativeZ,



        AllFaces = Cubemap_PositiveX | Cubemap_NegativeX |
                    Cubemap_PositiveY | Cubemap_NegativeY |
                    Cubemap_PositiveZ | Cubemap_NegativeZ,

    };


    public class DDSHeader : IFbSerializable
    {
        public DDSHeader()
        {
        }
        public DDSHeader(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }


        public const uint c_DDSMagic = 0x20534444; // "DDS "
        public const uint c_DDSHeaderSize = 0x7C; //TODO

        public uint Magic { get; set; } = c_DDSMagic;
        public uint Size { get; protected set; } = c_DDSHeaderSize;
        public DDSFlags Flags { get; set; } = 0;
        public uint Height { get; set; } = 0;
        public uint Width { get; set; } = 0;
        public uint PitchOrLinearSize { get; set; } = 0;
        public uint Depth { get; set; } = 0; // only if DDS_HEADER_FLAGS_VOLUME is set in flags
        public uint MipMapCount { get; set; } = 0;
        public uint[] Reserved { get; set; } = new uint[11];
        public DDSPixelFormat PixelFormat { get; set; } = new DDSPixelFormat( );
        public DDSCaps Caps { get; set; } = 0;
        public DDSCaps2 Caps2 { get; set; } = 0;
        public uint Caps3 { get; set; } = 0;
        public uint Caps4 { get; set; } = 0;
        public uint Reserved2 { get; set; } = 0;

        // DX10 Support
        public DDSDX10Header? Dx10Header { get; set; } = null;


        /// <summary>
        /// Deserialize from an open reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position</param>
        public void Deserialize(RimeReader p_Reader)
        {
            Magic = p_Reader.ReadUInt32( );

            if (Magic != c_DDSMagic)
                throw new Exception($"Invalid DDS header magic {Magic}.");

            Size = p_Reader.ReadUInt32();

            if (Size < c_DDSHeaderSize)
                throw new Exception("Something is wrong with this dds");

            Flags = (DDSFlags) p_Reader.ReadUInt32();
            Height = p_Reader.ReadUInt32();
            Width = p_Reader.ReadUInt32();
            PitchOrLinearSize = p_Reader.ReadUInt32();
            Depth = p_Reader.ReadUInt32();
            MipMapCount = p_Reader.ReadUInt32();

            for (var i = 0; i < Reserved.Length; i++)
                Reserved[i] = p_Reader.ReadUInt32();

            PixelFormat.Deserialize(p_Reader);

            Caps = (DDSCaps) p_Reader.ReadUInt32();
            Caps2 = (DDSCaps2) p_Reader.ReadUInt32();
            Caps3 = p_Reader.ReadUInt32();
            Caps4 = p_Reader.ReadUInt32();
            Reserved2 = p_Reader.ReadUInt32();

            // Determine if we have a DX10 header to read after the end of this
            if (PixelFormat.FourCC == DDSUtils.MakeFourCC("DX10"))
                Dx10Header = new DDSDX10Header(p_Reader);

        }


        /// <summary>
        /// Serialize to an open writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(Magic);
            p_Writer.Write(Size);
            p_Writer.Write((uint) Flags);
            p_Writer.Write(Height);
            p_Writer.Write(Width);
            p_Writer.Write(PitchOrLinearSize);
            p_Writer.Write(Depth);
            p_Writer.Write(MipMapCount);

            for (var i = 0; i < Reserved.Length; i++)
                p_Writer.Write(Reserved[i]);

            PixelFormat.Serialize(p_Writer);

            p_Writer.Write((uint) Caps);
            p_Writer.Write((uint) Caps2);
            p_Writer.Write(Caps3);
            p_Writer.Write(Caps4);
            p_Writer.Write(Reserved2);

            if (PixelFormat.FourCC == DDSUtils.MakeFourCC("DX10"))
                Dx10Header?.Serialize(p_Writer);
            
            // After this is pixel data
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

        public static uint FourCCFromDXGIFormat(DXGIFormat p_Format)
        {
            switch (p_Format)
            {
                case DXGIFormat.BC1_UNORM:
                    return DDSUtils.MakeFourCC("DXT1");
                case DXGIFormat.BC3_UNORM:
                    return DDSUtils.MakeFourCC("DXT3");
                case DXGIFormat.BC5_UNORM:
                    return DDSUtils.MakeFourCC("DXT5");
                default:
                    return 0;
            }
        }

    }
}
