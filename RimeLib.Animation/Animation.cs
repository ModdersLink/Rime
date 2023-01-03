
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;

namespace RimeLib.Animation
{
    /// <summary>
    /// Credits: IceBloc (https://github.com/marv7000/IceBloc)
    /// 
    /// </summary>
    public class Animation : IFbSerializable
    {
        public int CodecType { get; set; }
        public int AnimId { get; set; }
        public float TrimOffset { get; set; }
        public ushort EndFrame { get; set; }
        public bool Additive { get; set; }
        public GUID ChannelToDofAsset { get; set; } = GUID.Empty;
        
        public Animation() 
        { 

        }

        public Animation(RimeReader p_Reader)
        {

        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            throw new System.NotImplementedException();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }
}
