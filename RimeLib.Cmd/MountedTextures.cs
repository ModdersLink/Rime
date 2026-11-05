using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Texture.Images;

namespace RimeLib.Cmd
{
    /// <summary>A mounted game's textures, as texture conversion reads them.</summary>
    internal static class MountedTextures
    {
        public static IEnumerable<KeyValuePair<string, IMountedObject<IResourceVariant>>> All(IEngineMounter p_Mounter) =>
            p_Mounter.GetResources()
                .Where(p_R => p_R.Value.FirstVariant.GetResourceType() == ResourceType.DxTexture)
                .OrderBy(p_R => p_R.Key, StringComparer.Ordinal);

        /// <summary>The streaming groups the game's textures are in.</summary>
        public static HashSet<string> Groups(IEngineMounter p_Mounter, ITextureCodec p_Codec)
        {
            var s_Groups = new HashSet<string>(StringComparer.Ordinal);
            foreach (var (s_Name, s_Resource) in All(p_Mounter))
            {
                try
                {
                    s_Groups.Add(p_Codec.Decode(s_Name, Read(s_Resource.FirstVariant), Array.Empty<byte>()).Group);
                }
                catch (InvalidDataException)
                {
                    // A header the codec refuses names no group to convert to.
                }
            }

            return s_Groups;
        }

        public static byte[] Read(IObjectVariant p_Variant)
        {
            using var s_Reader = p_Variant.GetReader();
            return s_Reader.ReadBytes((int)s_Reader.Length);
        }

        /// <summary>The whole chunk: the variant read from its start, where others hold a range of it.</summary>
        public static IChunkVariant WholeChunk(IEngineMounter p_Mounter, GUID p_Id)
        {
            if (!p_Mounter.TryGetChunk(p_Id, out var s_Chunk))
                throw new InvalidDataException($"Chunk {p_Id} is not mounted.");
            return s_Chunk.Variants.FirstOrDefault(p_V => p_V.GetLogicalOffset() == 0) ?? s_Chunk.FirstVariant;
        }
    }
}
