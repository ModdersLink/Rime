using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Texture.Xbox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Texture.Frostbite2_0
{
    public class FB2XenonDataProvider : FB2DataProvider
    {
        public FB2XenonDataProvider(IEngineMounter p_Engine, FB2Texture p_Texture)
            : base(p_Engine, p_Texture)
        {
        }

        public RimeReader? GetReader(object? p_Data)
        {

            var s_Reader = base.GetReader(p_Data);

            if (s_Reader == null)
                return null;

            return new XboxTextureReader(s_Reader, m_Texture.Width, m_Texture.Height, 1, m_Texture.Format);
        }

    }
}
