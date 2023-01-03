using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Mesh.Frostbite2_0.Frostbite
{
    // this has a typo in game, named "OccluderPartMaks"
    public class OccluderPartMask : IFbSerializable
    {
        public ulong[] Masks = new ulong[3];

        public OccluderPartMask()
        {
        }


        public OccluderPartMask(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            if (Masks.Length != 3)
                throw new Exception("Invalid length of occludermeshpart mask");

            for (var i = 0; i < Masks.Length; i++)
                p_Writer.Write(Masks[i]);

            return true;
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            p_Data = null;
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Deserialize(RimeReader p_Reader)
        {
            for (var i = 0; i < Masks.Length; i++)
                p_Reader.ReadUInt64();

        }

        /// <inheritdoc />
        public void Deserialize(byte[] p_Data)
        {
            Deserialize(new RimeReader(new MemoryStream(p_Data)));
        }
    }
}
