using RimeLib.IO;

namespace RimeLib.Serialization.Frostbite2_0.Ebx
{
    public abstract class EbxSerializable
    {
        public virtual void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
        {
            // No-op.
        }
    }
}
