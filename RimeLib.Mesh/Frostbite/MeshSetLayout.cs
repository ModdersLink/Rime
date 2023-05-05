using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Mesh.Frostbite
{
    public abstract class MeshSetLayout : IFbSerializable
    {
        public abstract void Deserialize(RimeReader p_Reader);
        public abstract void Deserialize(byte[] p_Data);
        public abstract bool Serialize(RimeWriter p_Writer);
        public abstract bool Serialize([NotNullWhen(true)] out byte[]? p_Data);
    }
}
