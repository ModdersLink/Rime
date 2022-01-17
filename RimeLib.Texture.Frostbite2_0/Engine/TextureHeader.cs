using System;
using System.Collections.Generic;
using System.Text;

using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Texture.Frostbite;

namespace RimeLib.Texture.Frostbite2_0.Engine
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
        public uint Version
        {
            get; set;
        } = 10;

        /// <summary>
        /// Type
        /// </summary>
        public TextureType Type
        {
            get; set;
        }

        /// <summary>
        /// Format
        /// </summary>
        public TextureFormat Format
        {
            get; set;
        }

        /// <summary>
        /// Flags
        /// </summary>
        public TextureFlags Flags
        {
            get; set;
        }

        /// <summary>
        /// Width
        /// </summary>
        public short Width
        {
            get; set;
        }

        /// <summary>
        /// Height
        /// </summary>
        public short Height
        {
            get; set;
        }

        /// <summary>
        /// Depth
        /// </summary>
        public short Depth
        {
            get; set;
        }

        /// <summary>
        /// Slice Count
        /// </summary>
        public short SliceCount
        {
            get; set;
        }

        /// <summary>
        /// Unused
        /// </summary>
        public short Unused0
        {
            get; set;
        }

        /// <summary>
        /// Mip Map Count
        /// </summary>
        public byte MipmapCount
        {
            get; set;
        }

        /// <summary>
        /// Mip map base index
        /// </summary>
        public byte MipmapBaseIndex
        {
            get; set;
        }

        /// <summary>
        /// Chunk guid
        /// </summary>
        public GUID StreamingChunkId { get; set; } = Guid.Empty;

        /// <summary>
        /// Mip map sizes (uint32 * 15)
        /// </summary>
        public uint[] MipmapSizes { get; set; } = new uint[15]; // DWORD[15];

        /// <summary>
        /// Mip map chain size
        /// </summary>
        public uint MipmapChainSize
        {
            get; set;
        }

        /// <summary>
        /// Resource name hash
        /// </summary>
        public uint ResourceNamehash
        {
            get; set;
        }

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
            p_Writer.Write(Version);
            p_Writer.Write((uint)Type);
            p_Writer.Write((uint)Format);
            p_Writer.Write((uint)Flags);
            p_Writer.Write(Width);
            p_Writer.Write(Height);
            p_Writer.Write(Depth);
            p_Writer.Write(SliceCount);
            p_Writer.Write(Unused0);
            p_Writer.Write(MipmapCount);
            p_Writer.Write(MipmapBaseIndex);
            StreamingChunkId.Serialize(p_Writer);

            foreach (var s_MipMapSize in MipmapSizes)
                p_Writer.Write(s_MipMapSize);

            p_Writer.Write(MipmapChainSize);
            p_Writer.Write(ResourceNamehash);

            var s_TextureGroupData = Encoding.UTF8.GetBytes(TextureGroup);
            p_Writer.Write(s_TextureGroupData, 0, System.Math.Min(s_TextureGroupData.Length, 16));

            if (s_TextureGroupData.Length < 16)
                p_Writer.WriteNullBytes(16 - (uint)s_TextureGroupData.Length);

            return true;
        }

        public bool Serialize(out byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Version = p_Reader.ReadUInt32();

            if (Version != 10)
                return;

            Type = (TextureType) p_Reader.ReadUInt32();
            Format = (TextureFormat) p_Reader.ReadUInt32();

            if (Format >= TextureFormat.TextureFormat_FB2_Unknown)
                return;

            Flags = (TextureFlags) p_Reader.ReadUInt32();
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
