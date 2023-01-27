using RimeLib.IO;

namespace RimeLib.Serialization;

public abstract class EbxSerializable
{
    public virtual void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
    {
        // No-op.
    }
}