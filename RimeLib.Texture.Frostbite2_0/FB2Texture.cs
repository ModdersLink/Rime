using System;
using System.Collections.Generic;
using System.Text;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Texture.Frostbite;

namespace RimeLib.Texture.Venice
{
    public class FB2Texture : ITexture
    {
        public FB2Texture( IEngineMounter p_Engine,
                            RimeReader p_Reader )
        {
            m_Engine = p_Engine;
            m_Texture = new Engine.TextureHeader( p_Reader );

        }


        IEngineMounter m_Engine;

        Engine.TextureHeader m_Texture;


        public RimeReader? GetRawTextureData( )
        {
            if ( !m_Engine.TryGetChunk( m_Texture.StreamingChunkId, out var s_Chunk ) )
                return null;

            return s_Chunk.FirstVariant.GetReader( );
            //throw new NotImplementedException( "I havent done textures yet..." );
        }

        public int GetRawTextureSize( )
        {
            if ( !m_Engine.TryGetChunk( m_Texture.StreamingChunkId, out var s_Chunk ) )
                return -1;

            return ( int )s_Chunk.FirstVariant.GetSize( );
            //throw new NotImplementedException( "I havent done textures yet..." );
        }


        public TextureType GetTextureType( ) => m_Texture.Type;

        public TextureFormat GetTextureFormat( ) => m_Texture.Format;




        //Return -1 if invalid or not avalible

        public int GetFlags( ) => ( int )m_Texture.Flags;

        public int GetWidth( ) => ( int )m_Texture.Width;

        public int GetHeight( ) => ( int )m_Texture.Height;


        public int GetDepth( ) => ( int )m_Texture.Depth;

        public int GetMipmapCount( ) => ( int )m_Texture.MipmapCount;




    }
}
