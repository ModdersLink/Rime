using RimeLib.Content.Resource;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;


namespace RimeLib.Texture.Frostbite
{
    public interface ITexture : IResource
    {
        TextureType GetTextureType( );

        TextureFormat GetTextureFormat( );

        RimeReader? GetRawTextureData( );

        //Return -1 if invalid or not avalible
        int GetRawTextureSize( );


        //Return -1 if invalid or not avalible

        int GetFlags( );

        int GetWidth( );

        int GetHeight( );

        
        int GetDepth( );

        int GetMipmapCount( );
    }
}
