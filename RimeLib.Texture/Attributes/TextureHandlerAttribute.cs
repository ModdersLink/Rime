using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class TextureHandlerAttribute : Attribute
    {
        public string FormatType
        {
            get;
        }

        /// <summary>
        /// Loader attribute consturctor
        /// </summary>
        /// <param name="p_FormatType">format type</param>
        public TextureHandlerAttribute(string p_FormatType)
        {
            this.FormatType = p_FormatType;
        }
    }
}
