using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.DDS
{

    enum DDSFlags : uint
    {
        Caps    = 0x01,
        Height  = 0x02,
        Width   = 0x04,
        Pitch   = 0x08,

        PixelFormat = 0x001000,
        MipmapCount = 0x020000,
        LinearSize  = 0x080000,
        Depth       = 0x800000
    };


    enum DDSCaps : uint
    {
        Complex = 0x0008,
        Texture = 0x1000,
        Mipmap  = 0x400000
    };

    enum DDSCaps2 : uint
    {
        Cubemap             = 0x0200,

        Cubemap_Face_PositiveX = 0x0400,
        Cubemap_Face_NegativeX = 0x0800,

        Cubemap_Face_PositiveY = 0x1000,
        Cubemap_Face_NegativeY = 0x2000,

        Cubemap_Face_PositiveZ = 0x4000,
        Cubemap_Face_NegativeZ = 0x8000,


        Cubemap_Volume      = 0x4000, //3d texture


        Cubemap_PositiveX = Cubemap | Cubemap_Face_PositiveX,
        Cubemap_NegativeX = Cubemap | Cubemap_Face_NegativeX,

        Cubemap_PositiveY = Cubemap | Cubemap_Face_PositiveY,
        Cubemap_NegativeY = Cubemap | Cubemap_Face_NegativeY,

        Cubemap_PositiveZ = Cubemap | Cubemap_Face_PositiveZ,
        Cubemap_NegativeZ = Cubemap | Cubemap_Face_NegativeZ,



        AllFaces =  Cubemap_PositiveX | Cubemap_NegativeX |
                    Cubemap_PositiveY | Cubemap_NegativeY |
                    Cubemap_PositiveZ | Cubemap_NegativeZ,

    };


    public class DDSHeader : IFbSerializable
    {
        public const uint c_DDSMagic = 0x20534444; // "DDS "


        public uint m_Size;
        public uint m_Flags;
        public uint m_Height;
        public uint m_Width;
        public uint m_PitchOrLinearSize;
        public uint m_Depth; // only if DDS_HEADER_FLAGS_VOLUME is set in flags
        public uint m_MipMapCount;
        public uint[] m_Reserved1 = new uint[11];
        public DDSPixelFormat m_PixelFormat = new DDSPixelFormat( );
        public uint m_Caps;
        public uint m_Caps2;
        public uint m_Caps3;
        public uint m_Caps4;
        public uint m_Reserved2;


        /// <summary>
        /// Deserialize from an open reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position</param>
        public void Deserialize( RimeReader p_Reader )
        {
            var s_Magic = p_Reader.ReadUInt32( );

            if ( s_Magic != c_DDSMagic )
            {
                throw new Exception( "Not valid dds magic" );
                //return;
            }

            m_Size = p_Reader.ReadUInt32( );
            m_Flags = p_Reader.ReadUInt32( );
            m_Height = p_Reader.ReadUInt32( );
            m_Width = p_Reader.ReadUInt32( );
            m_PitchOrLinearSize = p_Reader.ReadUInt32( );
            m_Depth = p_Reader.ReadUInt32( );
            m_MipMapCount = p_Reader.ReadUInt32( );

            for ( var i = 0; i < m_Reserved1.Length; i++ )
                m_Reserved1[i] = p_Reader.ReadUInt32( );

            m_PixelFormat.Deserialize( p_Reader );

            m_Caps = p_Reader.ReadUInt32( );
            m_Caps2 = p_Reader.ReadUInt32( );
            m_Caps3 = p_Reader.ReadUInt32( );
            m_Caps4 = p_Reader.ReadUInt32( );
            m_Reserved2 = p_Reader.ReadUInt32( );
        }


        /// <summary>
        /// Serialize to an open writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize( RimeWriter p_Writer )
        {
            p_Writer.Write( c_DDSMagic );



            p_Writer.Write( m_Size );
            p_Writer.Write( m_Flags );
            p_Writer.Write( m_Height );
            p_Writer.Write( m_Width );
            p_Writer.Write( m_PitchOrLinearSize );
            p_Writer.Write( m_Depth );
            p_Writer.Write( m_MipMapCount );

            for ( var i = 0; i < m_Reserved1.Length; i++ )
                p_Writer.Write( m_Reserved1[i] );

            m_PixelFormat.Serialize( p_Writer );

            p_Writer.Write( m_Caps );
            p_Writer.Write( m_Caps2 );
            p_Writer.Write( m_Caps3 );
            p_Writer.Write( m_Caps4 );
            p_Writer.Write( m_Reserved2 );
            return true;
        }


        /// <summary>
        /// Serialize to a byte array
        /// </summary>
        /// <returns>byte[]</returns>
        public bool Serialize( out byte[] p_Data )
        {
            var s_Result = false;
            using ( var s_Stream = new MemoryStream( ) )
            {
                using ( var s_RimeStream = new RimeWriter( s_Stream ) )
                {
                    s_Result = this.Serialize( s_RimeStream );
                }
                p_Data = s_Stream.ToArray( );
            }
            return s_Result;
        }

        /// <summary>
        /// Deserialize from an byte array
        /// </summary>
        /// <param name="p_Data">Input byte array</param>
        public void Deserialize( byte[] p_Data )
        {
            this.Deserialize( new RimeReader( new MemoryStream( p_Data ) ) );
        }
    }
}
