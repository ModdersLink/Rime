using RimeLib.Frostbite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class TextureLoaderAttribute : Attribute
    {
        public EngineType EngineVersion
        {
            get;
        }

        /// <summary>
        /// Loader attribute consturctor
        /// </summary>
        /// <param name="p_EngineVersion">what is the engine this texture is for</param>
        public TextureLoaderAttribute(EngineType p_EngineVersion)
        {
            this.EngineVersion = p_EngineVersion;
        }
    }
}
