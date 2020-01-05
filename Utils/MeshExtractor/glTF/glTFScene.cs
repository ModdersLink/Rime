using System;
using System.Collections.Generic;
using System.Text;

namespace MeshExtractor.glTF
{
    class glTFScene
    {
        private string m_Name;
        private List<glTFNode> m_Nodes;

        public glTFScene()
        {
            m_Nodes = new List<glTFNode>();
        }
    }
}
