using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MeshExtractor.glTF
{
    /// <summary>
    /// A JSON-formatted file (.gltf) containing a full scene description: node hierarchy, materials, cameras, as well as descriptor information for meshes, animations, and other constructs
    /// </summary>
    public class glTFAsset
    {
        private string m_Version;
        private string m_MinVersion;
        private string m_Generator;
        private string m_Copyright;

        private const string c_CurrentGLTFVersion = "2.0";

        public glTFAsset()
        {
            m_Version = c_CurrentGLTFVersion;
            m_MinVersion = string.Empty;
            m_Generator = "RimeLibLite";
            m_Copyright = "2020 (c) kiwidoggie productions";
        }
    }
}
