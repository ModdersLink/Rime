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
        public DDSDX10Header( )
        {
        }

        public DDSDX10Header( DXGIFormat p_Format, DDSResoruceDimension p_Dimension, DDSMiscFlag1 p_Misc1 = 0, uint p_ArraySize = 0, DDSMiscFlag2 p_Misc2 = 0 )
        {
            m_DxgiFormat = p_Format;
            m_ResourceDimension = p_Dimension;
            m_MiscFlag = p_Misc1;
            m_ArraySize = p_ArraySize;
            m_MiscFlags2 = p_Misc2;
        }

        public DXGIFormat m_DxgiFormat = 0;
        public DDSResoruceDimension m_ResourceDimension = 0;
        public DDSMiscFlag1 m_MiscFlag = 0;
        public uint m_ArraySize = 0;
        public DDSMiscFlag2 m_MiscFlags2 = 0;


        #region Serializers
        /// <summary>
        /// Deserialize from an open reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position</param>
        public void Deserialize( RimeReader p_Reader )
        {
            m_DxgiFormat = ( DXGIFormat )p_Reader.ReadUInt32( );
            m_ResourceDimension = ( DDSResoruceDimension )p_Reader.ReadUInt32( );
            m_MiscFlag = ( DDSMiscFlag1 )p_Reader.ReadUInt32( );
            m_ArraySize = p_Reader.ReadUInt32( );
            m_MiscFlags2 = ( DDSMiscFlag2 )p_Reader.ReadUInt32( );
        }


        /// <summary>
        /// Serialize to an open writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position</param>
        /// <returns>True on success, false otherwise</returns>
        public bool Serialize( RimeWriter p_Writer )
        {
            p_Writer.Write( ( uint )m_DxgiFormat );
            p_Writer.Write( ( uint )m_ResourceDimension );
            p_Writer.Write( ( uint )m_MiscFlag );
            p_Writer.Write( m_ArraySize );
            p_Writer.Write( ( uint )m_MiscFlags2 );
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

        #endregion
    }
}
