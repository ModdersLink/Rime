using System;
using System.Collections.Generic;
using System.Text;

namespace MeshExtractor.glTF
{
    class glTFMaterial
    {
        private string m_Name;
        private List<glTFTexture> m_Textures;

        public glTFMaterial(string p_Name)
        {
            m_Name = p_Name;
            m_Textures = new List<glTFTexture>();
        }
    }
}
