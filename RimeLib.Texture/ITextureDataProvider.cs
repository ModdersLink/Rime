using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Texture
{
    public interface ITextureDataProvider
    {
        RimeReader? GetReader(object? p_Data = null);

        RimeWriter? GetWriter(object? p_Data = null);
    }
}
