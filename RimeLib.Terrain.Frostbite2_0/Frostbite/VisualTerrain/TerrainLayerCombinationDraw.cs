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

        /// <summary>
        /// A BYTE, not a flag, despite the name.
        ///
        /// This was read as a bool, which looked right because a bool is one byte and the parse
        /// stayed aligned. It is wrong: across MP_007's 98 combinations this byte takes the values
        /// 0, 3, 4, 5, 6, 9, 10, 11 and 13 -- 90 of the 98 are something other than 0 or 1. Read as
        /// a bool they all collapse to true, and written back they all come out as 1, which is 90
        /// changed bytes in a resource nobody edited. It is a level index like the Level byte on
        /// the draw methods beside it, not a flag; it correlates with none of the neighbouring
        /// counts or levels, so it is carried through verbatim rather than derived.
        /// </summary>
        public byte MeshScatteringMaskScaleLevelEnd;
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

        /// <summary>
        /// The exact mirror of <see cref="Deserialize(RimeReader)"/>.
        ///
        /// Note the odd order the format uses for the mask-scale methods: the COUNT, then the
        /// MeshScatteringMaskScaleLevelEnd byte, and only then the methods themselves. That is
        /// measured from the shipped resources, not assumed -- writing it before the count
        /// desynchronises every following byte.
        /// </summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((uint) TerrainLayerIndices.Length);
            foreach (var s_Index in TerrainLayerIndices)
                p_Writer.Write(s_Index);

            p_Writer.Write((uint) MeshScatteringMaskScaleDrawMethods.Length);
            p_Writer.Write(MeshScatteringMaskScaleLevelEnd);

            foreach (var s_Method in MeshScatteringMaskScaleDrawMethods)
                if (!s_Method.Serialize(p_Writer))
                    return false;

            p_Writer.Write((uint) Surface2dDrawMethods.Length);
            foreach (var s_Method in Surface2dDrawMethods)
                if (!s_Method.Serialize(p_Writer))
                    return false;

            p_Writer.Write((uint) Surface3dDrawMethods.Length);
            foreach (var s_Method in Surface3dDrawMethods)
                if (!s_Method.Serialize(p_Writer))
                    return false;

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            TerrainLayerIndexCount = p_Reader.ReadUInt32();
            TerrainLayerIndices = new byte[TerrainLayerIndexCount];
            for (var i = 0; i < TerrainLayerIndexCount; i++)
                TerrainLayerIndices[i] = p_Reader.ReadUByte();

            MeshScatteringMaskScaleDrawMethodCount = p_Reader.ReadUInt32();
            MeshScatteringMaskScaleLevelEnd = p_Reader.ReadUByte();

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
