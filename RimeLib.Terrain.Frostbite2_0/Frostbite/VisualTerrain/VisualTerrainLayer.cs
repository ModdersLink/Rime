using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain
{
    public class VisualTerrainLayer : IFbSerializable
    {
        public bool VirtualTextureEnable { get; set; } = false;

        public MeshScatteringType[] ScatteringTypes { get; set; } = new MeshScatteringType[0];

        //TerrainLayerCombinationDrawDatabase

        public VisualTerrainLayer(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            VirtualTextureEnable = p_Reader.ReadBool();

            var s_MeshScatteringTypeCount = p_Reader.ReadUInt32();
            ScatteringTypes = new MeshScatteringType[s_MeshScatteringTypeCount];
            for (var i=0; i < s_MeshScatteringTypeCount; i++)
                ScatteringTypes[i] = new MeshScatteringType(p_Reader);
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
        }
    }
}
