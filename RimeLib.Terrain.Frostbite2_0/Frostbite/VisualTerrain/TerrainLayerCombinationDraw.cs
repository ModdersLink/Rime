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
    public class TerrainLayerCombinationDraw : IFbSerializable
    {
        public uint TerrainLayerIndexCount;
        public byte[] TerrainLayerIndices { get; set; } = new byte[0];

        public uint MeshScatteringMaskScaleDrawMethodCount;
        public bool MeshScatteringMaskScaleLevelEnd;
        public MeshScatteringMaskScaleMethod[] MeshScatteringMaskScaleDrawMethods { get; set; } = new MeshScatteringMaskScaleMethod[0];

        public uint Surface2dMethodCount;
        // aka TerrainLayerCombinationDraw2dPass
        public Surface2dDrawMethod[] Surface2dDrawMethods { get; set; } = new Surface2dDrawMethod[0];

        public uint Surface3dMethodCount;
        public Surface3dDrawMethod[] Surface3dDrawMethods { get; set; } = new Surface3dDrawMethod[0];

        public TerrainLayerCombinationDraw(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            TerrainLayerIndexCount = p_Reader.ReadUInt32();
            TerrainLayerIndices = new byte[TerrainLayerIndexCount];
            for (var i = 0; i < TerrainLayerIndexCount; i++)
                TerrainLayerIndices[i] = p_Reader.ReadUByte();

            MeshScatteringMaskScaleDrawMethodCount = p_Reader.ReadUInt32();
            MeshScatteringMaskScaleLevelEnd = p_Reader.ReadBool();

            MeshScatteringMaskScaleDrawMethods = new MeshScatteringMaskScaleMethod[MeshScatteringMaskScaleDrawMethodCount];
            for (var i = 0; i < MeshScatteringMaskScaleDrawMethodCount; i++)
                MeshScatteringMaskScaleDrawMethods[i] = new MeshScatteringMaskScaleMethod(p_Reader);

            Surface2dMethodCount = p_Reader.ReadUInt32();
            Surface2dDrawMethods = new Surface2dDrawMethod[Surface2dMethodCount];
            for (var i = 0; i < Surface2dMethodCount; i++)
                Surface2dDrawMethods[i] = new Surface2dDrawMethod(p_Reader);

            Surface3dMethodCount = p_Reader.ReadUInt32();
            Surface3dDrawMethods = new Surface3dDrawMethod[Surface3dMethodCount];
            for (var i = 0; i < Surface3dMethodCount; i++)
                Surface3dDrawMethods[i] = new Surface3dDrawMethod(p_Reader);
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
