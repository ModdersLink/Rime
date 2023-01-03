using fb;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization.Frostbite2_0.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite
{
    public class OccluderMeshData : IFbSerializable
    {
        public AxisAlignedBox BoundingBox = new();

        public ushort VertexCount = 0;
        public ushort IndexCount = 0;

        // theese looks like flags
        public uint DoubleSided = 0;
        public uint HighPriority = 0;

        public int TriangleCount => IndexCount / 3;

        public OccluderPartMask[] Masks = new OccluderPartMask[0];

        public OccluderMeshData()
        {
        }


        public OccluderMeshData(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Deserialize(RimeReader p_Reader)
        {
            var s_StartPosition = p_Reader.Position;

            BoundingBox.Deserialize(p_Reader);
            VertexCount = p_Reader.ReadUInt16();
            IndexCount = p_Reader.ReadUInt16();

            var s_VertexDataOffset = p_Reader.ReadUInt32();
            var s_IndexDataOffset = p_Reader.ReadUInt32();
            var s_PartMaskOffset = p_Reader.ReadUInt32();

            DoubleSided = p_Reader.ReadUInt32();
            HighPriority = p_Reader.ReadUInt32();

            // pad 0x8

            p_Reader.Seek(s_StartPosition + s_VertexDataOffset, SeekOrigin.Begin);

            for (var i=0; i < TriangleCount; i++)
            {
                // __m128*4 - probably lineartransform - read raw bytes. some linear transform deserializer ingame only seems to read 3 floats.


                var s_Transform = new Matrix44(p_Reader);



                //var s_Transform = new LinearTransform();
                //s_Transform.Deserialize(p_Reader);

                // then does matrix multiply with transform
            }    

            p_Reader.Seek(s_StartPosition + s_IndexDataOffset, SeekOrigin.Begin);
            for (var i = 0; i < TriangleCount; i++)
            {
                var s_I1 = p_Reader.ReadUInt16();
                var s_I2 = p_Reader.ReadUInt16();
                var s_I3 = p_Reader.ReadUInt16();
            }

            p_Reader.Seek(s_StartPosition + s_PartMaskOffset, SeekOrigin.Begin);
            for (var i = 0; i < TriangleCount; i++)
            {
                var s_Mask = new OccluderPartMask(p_Reader);

            }

        }

        /// <inheritdoc />
        public void Deserialize(byte[] p_Data)
        {
            Deserialize(new RimeReader(new MemoryStream(p_Data)));
        }
    }
}
