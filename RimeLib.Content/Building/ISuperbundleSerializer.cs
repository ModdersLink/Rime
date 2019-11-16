using System.IO;
using RimeLib.Frostbite;

namespace RimeLib.Content.Building
{
    public interface ISuperbundleSerializer
    {
        void Serialize(SuperbundleDescriptor p_Descriptor, Stream p_OutputSbStream, Stream p_OutputTocStream);
    }
}
