using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;

namespace RimeLib.Mesh.Frostbite
{
    public abstract class MeshSubset : IFbSerializable
    {
        public abstract void Deserialize(RimeReader p_Reader);
        public abstract void Deserialize(byte[] p_Data);
        public abstract bool Serialize(RimeWriter p_Writer);
        public abstract bool Serialize([NotNullWhen(true)] out byte[]? p_Data);
    }
}
