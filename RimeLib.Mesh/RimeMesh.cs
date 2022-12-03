using RimeLib.Mesh.Frostbite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fb;

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
