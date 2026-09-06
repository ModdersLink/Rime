using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Finding and loading the blob behind an <c>AntPackageAsset</c> partition.
    ///
    /// Extracted from <see cref="DumpAnimationBankCommand"/> because reading a bank and WRITING one
    /// back have to agree byte for byte on which blob is the bank -- a writer that picked the chunk
    /// where the reader picked the resource would emit a patch against the wrong bytes and look
    /// like it worked.
    /// </summary>
    public static class AntBankFile
    {
        /// <summary>
        /// The bank blob for an AntPackageAsset partition, or null with a reason.
        ///
        /// A package is stored one of two ways and both are in use. PackagingType_Chunk streams a
        /// chunk named by StreamingGuid; everything else ships the bank as an AssetBank RESOURCE
        /// named by the PARTITION. MEASURED over BF3's 323 antanimation partitions: 88 take the
        /// chunk path and 233 leave StreamingGuid all-zero, so a chunk-only reader sees barely a
        /// quarter of the game's animation.
        /// </summary>
        public static byte[]? Read(IEngineMounter p_Mounter, string p_Name, out string p_Source,
                                   out string? p_Error)
        {
            p_Source = "";
            p_Error = null;

            if (!p_Mounter.TryGetPartition(p_Name, out var s_PartitionObject))
            {
                p_Error = $"Could not find partition '{p_Name}'.";
                return null;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(p_Mounter.GetEngineType());
            var s_Partition = s_Converter.FromPartitionObject(p_Name, s_PartitionObject.FirstVariant);

            dynamic? s_Package = null;

            foreach (var s_Instance in s_Partition.Instances)
            {
                if (s_Instance.GetType().Name == "AntPackageAsset")
                {
                    s_Package = s_Instance;
                    break;
                }
            }

            if (s_Package == null)
            {
                p_Error = $"Partition '{p_Name}' holds no AntPackageAsset.";
                return null;
            }

            RimeLib.Frostbite.Core.GUID s_Guid = s_Package.StreamingGuid;
            string s_FileName = s_Package.Win32FileName;

            if (p_Mounter.TryGetChunk(s_Guid, out var s_Chunk) && s_Chunk.FirstVariant != null)
            {
                using var s_ChunkReader = s_Chunk.FirstVariant.GetReader();
                p_Source = "chunk:" + s_Guid.ToString("D");
                return s_ChunkReader.ReadBytes((int)s_ChunkReader.Length);
            }

            // The AssetBank resource is named after the PARTITION, not after Win32FileName -- that
            // field holds the source-tree path the package was built from and no resource answers
            // to it.
            foreach (var s_Candidate in new[] { p_Name.ToLowerInvariant(), s_FileName.ToLowerInvariant() })
            {
                if (string.IsNullOrWhiteSpace(s_Candidate) ||
                    !p_Mounter.TryGetResource(s_Candidate, out var s_Res) ||
                    s_Res.FirstVariant == null)
                {
                    continue;
                }

                using var s_ResReader = s_Res.FirstVariant.GetReader();
                p_Source = "resource:" + s_Candidate;
                return s_ResReader.ReadBytes((int)s_ResReader.Length);
            }

            p_Error = $"'{p_Name}' streams neither chunk {s_Guid:D} nor resource '{s_FileName}'.";
            return null;
        }

        /// <summary>Parses a bank blob. Throws on a blob that is not a bank.</summary>
        public static Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank Load(byte[] p_Data)
        {
            var s_Bank = new Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank();
            s_Bank.SetLocalResolver(new RimeLib.Animation.Frostbite.Resolver.LocalAssetResolver());

            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            s_Bank.Load(s_Reader, s_Bank);

            return s_Bank;
        }
    }
}
