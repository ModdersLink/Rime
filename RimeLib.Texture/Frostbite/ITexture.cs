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

        RimeReader GetRawTextureData( );



        //Maybe a list of mipmap stuff
    }
}
