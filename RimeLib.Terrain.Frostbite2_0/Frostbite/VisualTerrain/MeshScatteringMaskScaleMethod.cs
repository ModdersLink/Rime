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

        /// <summary>
        /// The exact mirror of <see cref="Deserialize(RimeReader)"/>. Two independent byte arrays,
        /// each with its own leading uint32 count, then the shader and two trailing bytes.
        /// </summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((uint) MaskedTerrainLayerIndices.Length);
            foreach (var s_Index in MaskedTerrainLayerIndices)
                p_Writer.Write(s_Index);

            p_Writer.Write((uint) OutputLayerOrder.Length);
            foreach (var s_Order in OutputLayerOrder)
                p_Writer.Write(s_Order);

            p_Writer.WriteNullTerminatedString(ShaderName);
            p_Writer.Write(DestructionMaskEnable);
            p_Writer.Write(Level);

            return true;
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
