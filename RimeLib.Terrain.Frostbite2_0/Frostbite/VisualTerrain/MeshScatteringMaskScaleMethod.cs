using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain
{
    public class MeshScatteringMaskScaleMethod : IFbSerializable
    {
        public uint MaskedTerrainLayerIndexCount;
        public byte[] MaskedTerrainLayerIndices { get; set; } = new byte[0];

        public uint OutputLayerOrderCount;
        public byte[] OutputLayerOrder { get; set; } = new byte[0];

        public string ShaderName { get; set; } = string.Empty;

        public bool DestructionMaskEnable;
        public byte Level;

        public MeshScatteringMaskScaleMethod(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            MaskedTerrainLayerIndexCount = p_Reader.ReadUInt32();
            MaskedTerrainLayerIndices = new byte[MaskedTerrainLayerIndexCount];
            for (var i = 0; i < MaskedTerrainLayerIndexCount; i++)
                MaskedTerrainLayerIndices[i] = p_Reader.ReadUByte();

            OutputLayerOrderCount = p_Reader.ReadUInt32();
            OutputLayerOrder = new byte[OutputLayerOrderCount];
            for (var i = 0; i < OutputLayerOrderCount; i++)
                OutputLayerOrder[i] = p_Reader.ReadUByte();

            ShaderName = p_Reader.ReadNullTerminatedString();
            DestructionMaskEnable = p_Reader.ReadBool();
            Level = p_Reader.ReadUByte();
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
