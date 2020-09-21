using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Texture.Frostbite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture
{
    public interface ITextureHandler
    {
        bool Load(IEngineMounter p_Mounter, IResourceVariant p_ResourceRefrence, out TextureBase? p_Resource);

        TextureBase? CreateTexture(ResourceType p_ResourceType, uint p_Width, uint p_Height, TextureFormat p_Format, TextureType p_Type = TextureType.TextureType_2D, uint p_MipmapCount = 1);


    }
}
