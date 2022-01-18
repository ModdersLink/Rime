using RimeLib.Texture.Frostbite;
using System.IO;

namespace RimeLib.Texture
{
    public abstract class TextureBase
    {
        public abstract TextureType Type { get; }
        
        public abstract TextureFormat Format { get; }

 
        public virtual uint GetMipmapSize(uint p_MipmapIndex) => 0;

        public virtual bool SerializeHeaderData(Stream p_Header)
        {
            return false;
        }

        //Return -1 if invalid or not avalible
        public virtual uint TextureSize => 0;

        public virtual bool IsTiled => false;

        //Return -1 if invalid or not avalible

        public virtual TextureFlags Flags => 0;

        public virtual uint Width => 0;

        public virtual uint Height => 0;

        public virtual uint Depth => 0;

        public virtual uint MipmapCount => 0;


        public ITextureDataProvider? Provider { get; set; }
    }
}
