using System.IO;
using RimeLib.Frostbite;

namespace RimeLib.Animation.Frostbite
{
    /// <summary>Converts this engine's AnimationSet banks to another engine's.</summary>
    public interface IAnimationBankConverter : IEngineInterface
    {
        /// <summary>
        /// A bank as the target's. The bank's objects keep their places, objects the target needs
        /// besides them following, so the indices an AntAnimationSetAsset keeps into the bank hold.
        /// </summary>
        byte[] Convert(byte[] p_Bank, EngineType p_Target, TextWriter p_Log);
    }
}
