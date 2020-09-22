using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture
{
    public interface ITextureFileHandler
    {


        bool Load(ITextureHandler p_Handler, RimeReader p_Reader, out TextureBase? p_Texture);


        bool Save(TextureBase p_Texture, RimeWriter p_Writer);
    }
}
