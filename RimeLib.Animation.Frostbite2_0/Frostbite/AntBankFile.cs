using System.IO;
using RimeLib;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Serialization;

namespace Rimelib.Animation.Frostbite2_0.Frostbite
{
    /// <summary>
    /// Finding and loading the blob behind an <c>AntPackageAsset</c> partition. Reading a bank and
    /// writing one back go through here, because they have to agree byte for byte on which blob is
    /// the bank: a writer that picked the chunk where the reader picked the resource would emit a
    /// patch against the wrong bytes and look like it worked.
    /// </summary>
    public static class AntBankFile
    {
        /// <summary>Where a package's bank is, and the bank blob (null with <see cref="Error"/> when it can't be found).</summary>
        public sealed class Location
        {
            public DatabasePartitionBase? Partition { get; init; }
            public RimeLib.Frostbite.Core.GUID StreamingGuid { get; init; } = RimeLib.Frostbite.Core.GUID.Empty;
            public string FileName { get; init; } = "";
            public byte[]? Data { get; init; }
            public string Source { get; init; } = "";
            public string? Error { get; init; }
        }

        /// <summary>The bank blob for an AntPackageAsset partition, or null with a reason.</summary>
        public static byte[]? Read(IEngineMounter p_Mounter, string p_Name, out string p_Source, out string? p_Error)
        {
            var s_Location = Locate(p_Mounter, p_Name);
            p_Source = s_Location.Source;
            p_Error = s_Location.Error;
            return s_Location.Data;
        }

        /// <summary>
        /// The package of an AntPackageAsset partition and its bank blob.
        ///
        /// A package is stored one of two ways and both are in use. PackagingType_Chunk streams a
        /// chunk named by StreamingGuid; everything else ships the bank as an AssetBank RESOURCE
        /// named by the PARTITION. MEASURED over BF3's 323 antanimation partitions: 88 take the
        /// chunk path and 233 leave StreamingGuid all-zero, so a chunk-only reader sees barely a
        /// quarter of the game's animation.
        /// </summary>
        public static Location Locate(IEngineMounter p_Mounter, string p_Name)
        {
            if (!p_Mounter.TryGetPartition(p_Name, out var s_PartitionObject))
                return new Location { Error = $"Could not find partition '{p_Name}'." };

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
                return new Location { Partition = s_Partition, Error = $"Partition '{p_Name}' holds no AntPackageAsset." };

            RimeLib.Frostbite.Core.GUID s_Guid = s_Package.StreamingGuid;
            string s_FileName = s_Package.Win32FileName;

            if (p_Mounter.TryGetChunk(s_Guid, out var s_Chunk) && s_Chunk.FirstVariant != null)
            {
                using var s_ChunkReader = s_Chunk.FirstVariant.GetReader();
                return new Location
                {
                    Partition = s_Partition, StreamingGuid = s_Guid, FileName = s_FileName,
                    Data = s_ChunkReader.ReadBytes((int)s_ChunkReader.Length), Source = "chunk:" + s_Guid.ToString("D"),
                };
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
                return new Location
                {
                    Partition = s_Partition, StreamingGuid = s_Guid, FileName = s_FileName,
                    Data = s_ResReader.ReadBytes((int)s_ResReader.Length), Source = "resource:" + s_Candidate,
                };
            }

            return new Location
            {
                Partition = s_Partition, StreamingGuid = s_Guid, FileName = s_FileName,
                Error = $"'{p_Name}' streams neither chunk {s_Guid:D} nor resource '{s_FileName}'.",
            };
        }

        /// <summary>Parses a bank blob. Throws on a blob that is not a bank.</summary>
        public static AssetBank Load(byte[] p_Data)
        {
            var s_Bank = new AssetBank();
            s_Bank.SetLocalResolver(new RimeLib.Animation.Frostbite.Resolver.LocalAssetResolver());

            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            s_Bank.Load(s_Reader, s_Bank);

            return s_Bank;
        }
    }
}
