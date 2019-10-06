using RimeLib.IO;
using RimeLib.Math;

namespace RimeLib.Mesh.Frostbite.Helpers
{
    public class VertexData
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float W { get; set; }
        public byte[] BoneIndicies { get; set; } = new byte[4]; // Len4
        public byte[] BlendWeights { get; set; } = new byte[4]; // Len4
        public float[] VertexNormals { get; set; } = new float[4]; // Len4
        public float[] VertexTangents { get; set; } = new float[4]; // Len4
        public float[] UV { get; set; } = new float[2]; // Len2
        // TODO: Remove below once we figure out that everything is alright.
        //private byte[] m_unknown; // Len12

        public VertexData()
        {
            // TODO: Implement
        }

        public VertexData(RimeReader p_Reader)
        {
            X = RimeMath.HalfToFloat(p_Reader.ReadUInt16());
            Y = RimeMath.HalfToFloat(p_Reader.ReadUInt16());
            Z = RimeMath.HalfToFloat(p_Reader.ReadUInt16());
            W = RimeMath.HalfToFloat(p_Reader.ReadUInt16());
            BoneIndicies = p_Reader.ReadBytes(4);
            BlendWeights = p_Reader.ReadBytes(4);

            for (int i = 0; i < VertexNormals.Length; ++i)
                VertexNormals[i] = p_Reader.ReadUByte();

            for (int i = 0; i < VertexTangents.Length; ++i)
                VertexTangents[i] = p_Reader.ReadUByte();

            for (int i = 0; i < UV.Length; ++i)
                UV[i] = RimeMath.HalfToFloat(p_Reader.ReadUInt16());
        }

        public void Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(RimeMath.FloatToHalf(X));
            p_Writer.Write(RimeMath.FloatToHalf(Y));
            p_Writer.Write(RimeMath.FloatToHalf(Z));
            p_Writer.Write(RimeMath.FloatToHalf(W));
            p_Writer.Write(BoneIndicies);
            p_Writer.Write(BlendWeights);

            for (int i = 0; i < VertexNormals.Length; ++i)
                p_Writer.Write((byte)VertexNormals[i]);

            for (int i = 0; i < VertexTangents.Length; ++i)
                p_Writer.Write((byte)VertexTangents[i]);

            for (int i = 0; i < UV.Length; ++i)
                p_Writer.Write(RimeMath.FloatToHalf(UV[i]));
        }
    }
}
