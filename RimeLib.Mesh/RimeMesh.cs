using System.Collections.Generic;
using fb;
using RimeLib.Mesh.Frostbite;

namespace RimeLib.Mesh
{
    internal class RimeMesh
    {
        protected Dictionary<MeshSubset, List<Dictionary<VertexElementUsage, dynamic>>> m_ParsedSubsets;

        internal RimeMesh()
        {
            m_ParsedSubsets = new Dictionary<MeshSubset, List<Dictionary<VertexElementUsage, dynamic>>>();

        }
    }
}
