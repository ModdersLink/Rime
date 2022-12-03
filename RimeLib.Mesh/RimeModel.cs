using RimeLib.Mesh.Frostbite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fb;

namespace RimeLib.Mesh
{
    internal class RimeModel
    {
        public int Stride { get; protected set; }

        public List<byte[]> VertexData { get; set; } = new List<byte[]>();

        public int VertexCount => VertexData.Count;

        public Dictionary<VertexElementUsage, dynamic> VertexUsage { get; protected set; } = new Dictionary<VertexElementUsage, dynamic>();
    }
}
