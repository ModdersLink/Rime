using RimeLib.Content.Resource;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;


namespace RimeLib.Texture.Frostbite
{
    public interface ITexture : IResource
    {
        TextureType Type
        {
            get;
        }

        TextureFormat Format
        {
            get;
        }

        RimeReader? GetRawTextureData( );

        //Return -1 if invalid or not avalible
        int TextureSize
        {
            get;
        }


        //Return -1 if invalid or not avalible

        int Flags
        {
            get;
        }

        uint Width
        {
            get;
        }

        uint Height
        {
            get;
        }


        uint Depth
        {
            get;
        }

        uint MipmapCount
        {
            get;
        }
    }
}
