using System;
using System.Collections.Generic;
using System.Text;
using RimeLib.IO;
using RimeLib.Texture.Frostbite;

namespace RimeLib.Texture.Venice
{
    public class VeniceTexture : ITexture
    {
        public VeniceTexture( RimeReader p_Reader )
        {
            m_Texture = new Engine.TextureHeader( p_Reader );
        }


        Engine.TextureHeader m_Texture;


        public TextureType GetTextureType( )
        {
            return m_Texture.Type;
        }

        public TextureFormat GetTextureFormat( )
        {
            return m_Texture.Format;
        }

        public RimeReader GetRawTextureData( )
        {
            throw new NotImplementedException( "I havent done textures yet..." );
        }
    }
}
