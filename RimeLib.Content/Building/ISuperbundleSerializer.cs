using System.IO;
using RimeLib.Frostbite;

namespace RimeLib.Content.Building
{
    public interface ISuperbundleSerializer
    {
        EngineType GetSupportedEngine();
        void Serialize(SuperbundleDescriptor p_Descriptor, Stream p_OutputSbStream, Stream p_OutputTocStream);
    }
}
