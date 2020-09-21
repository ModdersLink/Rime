
using System;
using System.Collections.Generic;
using System.Text;

using RimeLib.Frostbite;
using RimeLib.Content.Frostbite;
using RimeLib.IO;
using RimeLib.Content.Mounting;
using System.Diagnostics;
using RimeLib.IO.Conversion;
using RimeLib.Texture.Frostbite;
using RimeLib.Texture.Attributes;

namespace RimeLib.Texture.Frostbite2_0
{
    [TextureLoader(EngineType.Frostbite2_0)]
    public class FB2TextureManager : ITextureHandler
    {
        public FB2TextureManager()
        {
        }

        public bool Load(IEngineMounter p_Mounter, IResourceVariant p_ResourceRefrence, out TextureBase? p_Texture)
        {
            p_Texture = null;

            try
            {
                switch (p_ResourceRefrence.GetResourceType())
                {
                case ResourceType.DxTexture:
                {
                    using var s_LEReader = new RimeReader(p_ResourceRefrence.GetReader(), Endianness.LittleEndian);

                    p_Texture = new FB2Texture(s_LEReader);
                    break;
                }
                case ResourceType.XenonTexture:
                {
                    using var s_BEReader = new RimeReader(p_ResourceRefrence.GetReader(), Endianness.BigEndian);

                    p_Texture = new FB2XenonTexture(s_BEReader);
                    break;
                }
                case ResourceType.Ps3Texture:
                {
                    using var s_BEReader = new RimeReader(p_ResourceRefrence.GetReader(), Endianness.BigEndian);

                    p_Texture = new FB2Ps3Texture(s_BEReader);
                    break;
                }
                }

                p_Texture.Provider = new FB2DataProvider(p_Mounter, p_Texture as FB2Texture);
            }
            catch
            {
                p_Texture = null;
                return false;
            }

            return p_Texture != null;
        }


        public TextureBase? CreateTexture(ResourceType p_ResourceType, uint p_Width, uint p_Height, TextureFormat p_Format, TextureType p_Type, uint p_MipmapCount)
        {
            TextureBase? s_Texture = null;

            switch (p_ResourceType)
            {
            case ResourceType.DxTexture:
                s_Texture = new FB2Texture(p_Type, p_Format, p_Width, p_Height, p_MipmapCount);
                break;
            case ResourceType.XenonTexture:
                //s_Texture = new FB2XenonTexture(p_Type, p_Format, p_Width, p_Height);

            case ResourceType.Ps3Texture:
                //s_Texture = new FB2Ps3Texture(p_Type, p_Format, p_Width, p_Height);
                throw new NotImplementedException("importing xbox and ps3 textures not done!");
            }


            if (s_Texture == null)
                throw new Exception("This shouldnt happen!");

            s_Texture.Provider = new MemoryTextureDataProvider((int) s_Texture.TextureSize);

            return null;
        }
    }
}
