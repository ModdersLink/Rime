using RimeLib.IO;
using CommunityToolkit.Mvvm.ComponentModel;

namespace RimeLib.Serialization;

public abstract partial class EbxSerializable : ObservableObject
{
    public virtual void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
    {
        // No-op.
    }
}