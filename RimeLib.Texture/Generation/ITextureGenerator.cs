using System.Collections.Generic;
using System.IO;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Texture.Generation;

public interface ITextureGenerator : IEngineInterface
{
    void GenerateFromDDS(
        RimeReader p_DDSReader,
        TextureAttributes p_Attributes,
        RimeWriter p_ResourceWriter,
        out Dictionary<GUID, Stream> p_GeneratedChunks
    );
}