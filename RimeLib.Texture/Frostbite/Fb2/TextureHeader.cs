using System;
using System.Text;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Texture.Frostbite.Fb2
{
    /// <summary>
    /// TextureHeader class
    /// The structure and some helper functions for the fb::TextureHeader class
    /// </summary>
    public class TextureHeader : IFbSerializable
    {
        /// <summary>
        /// Version
        /// </summary>
        public uint Version { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public TextureType Type { get; set; }

        /// <summary>
        /// Format
        /// </summary>
        public TextureFormat Format { get; set; }

        /// <summary>
        /// Flags
        /// </summary>
        public uint Flags { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        public short Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        public short Height { get; set; }

        /// <summary>
        /// Depth
        /// </summary>
        public short Depth { get; set; }

        /// <summary>
        /// Slice Count
        /// </summary>
        public short SliceCount { get; set; }

        /// <summary>
        /// Unused
        /// </summary>
        public short Unused0 { get; set; }

        /// <summary>
        /// Mip Map Count
        /// </summary>
        public byte MipmapCount { get; set; }

        /// <summary>
        /// Mip map base index
        /// </summary>
        public byte MipmapBaseIndex { get; set; }

        /// <summary>
        /// Chunk guid
        /// </summary>
        public GUID StreamingChunkId { get; set; } = Guid.Empty;

        /// <summary>
        /// Mip map sizes (uint32 * 15)
        /// </summary>
        public uint[] MipmapSizes { get; set; } = new uint[0]; // DWORD[15];

        /// <summary>
        /// Mip map chain size
        /// </summary>
        public uint MipmapChainSize { get; set; }

        /// <summary>
        /// Resource name hash
        /// </summary>
        public uint ResourceNamehash { get; set; }

        /// <summary>
        /// Texture group (char * 16)
        /// </summary>
        public string TextureGroup { get; set; } = ""; // Len16

        /// <summary>
        /// Default constructor
        /// </summary>
        public TextureHeader()
        {

        }

        /// <summary>
        /// TextureHeader Constructor
        /// This will read out the ITexture structure at an opened stream where the position is at a ITexture structure in the data
        /// </summary>
        /// <param name="p_Reader">Reference to an IceReader class</param>
        public TextureHeader(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public bool Serialize(out byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Version = p_Reader.ReadUInt32();
            Type = (TextureType)p_Reader.ReadUInt32();
            Format = (TextureFormat)p_Reader.ReadUInt32();
            Flags = p_Reader.ReadUInt32();
            Width = p_Reader.ReadInt16();
            Height = p_Reader.ReadInt16();
            Depth = p_Reader.ReadInt16();
            SliceCount = p_Reader.ReadInt16();
            Unused0 = p_Reader.ReadInt16();
            MipmapCount = p_Reader.ReadUByte();
            MipmapBaseIndex = p_Reader.ReadUByte();
            StreamingChunkId = new GUID(p_Reader);

            MipmapSizes = new uint[15];
            for (var i = 0; i < 15; ++i)
                MipmapSizes[i] = p_Reader.ReadUInt32();

            MipmapChainSize = p_Reader.ReadUInt32();
            ResourceNamehash = p_Reader.ReadUInt32();
            TextureGroup = Encoding.UTF8.GetString(p_Reader.ReadBytes(16));
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }
}
