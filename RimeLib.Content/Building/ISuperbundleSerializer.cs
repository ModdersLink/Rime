using System.Collections.Generic;
using System.IO;
using RimeLib.Frostbite;

namespace RimeLib.Content.Building
{
    public interface ISuperbundleSerializer : IEngineInterface
    {
        /// <summary>
        /// Problems met while serializing that did not stop the build, for the caller to report.
        /// Reset by each <see cref="Serialize"/> call.
        /// </summary>
        IReadOnlyList<string> Warnings { get; }

        void Serialize(SuperbundleDescriptor p_Descriptor, Stream p_OutputSbStream, Stream p_OutputTocStream);
    }
}
