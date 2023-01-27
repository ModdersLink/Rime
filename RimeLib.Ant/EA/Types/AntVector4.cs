using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Types
{
    public class AntVector4
        : IFbSerializable
    {
        public float X { get; set; } = 0.0f;
        public float Y { get; set; } = 0.0f;
        public float Z { get; set; } = 0.0f;
        public float W { get; set; } = 0.0f;

        public AntVector4()
        {
        }

        public AntVector4(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public AntVector4(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }


        public override string ToString() => $"({X} {Y} {Z} {W})";

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(X);
            p_Writer.Write(Y);
            p_Writer.Write(Z);
            p_Writer.Write(W);

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            X = p_Reader.ReadSingle();
            Y = p_Reader.ReadSingle();
            Z = p_Reader.ReadSingle();
            W = p_Reader.ReadSingle();
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
