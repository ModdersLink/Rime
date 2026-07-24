using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("DLC-CATALOG RE: builds a cas.cat + cas_NN.cas from the STORED frames of the named mounted objects that are NOT already in the base/patch cas.cat. For DxTexture resources it ALSO catalogs the pixel CHUNK (the real weight). This is the user-side DLC cas-ify tool — a mod's cas-refs (sha1 of the stored frame) resolve against this generated catalog, so DLC bytes need not be shipped. Args: <name_list.txt> <out_dir> [start_index].")]
    public class BuildCasCatalogCommand : Command
    {
        [CommandArgument(Description = "Text file with one resource/partition name per line.")]
        public FileInfo? NameList { get; set; }

        [CommandArgument(Description = "Output directory for cas.cat + cas_NN.cas.")]
        public DirectoryInfo? OutDir { get; set; }

        [CommandArgument(Optional = true, Description = "First cas file number (default 1).")]
        public int StartIndex { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = (GameContext)p_Context;
            var s_Mounter = s_Ctx.GetMounter() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("build_cas_catalog: no Frostbite2_0 mounter.");
                return false;
            }
            var s_AllLines = File.ReadAllLines(NameList!.FullName)
                .Select(p_L => p_L.Trim())
                .Where(p_L => p_L.Length > 0 && !p_L.StartsWith("#"))
                .ToArray();
            // A line that parses as a GUID is a chunk to catalog directly (e.g. mesh/sound chunks);
            // everything else is a resource/partition name.
            var s_Names = new List<string>();
            var s_ExplicitChunks = new List<GUID>();
            foreach (var s_L in s_AllLines)
            {
                if (System.Guid.TryParse(s_L, out _)) s_ExplicitChunks.Add(new GUID(s_L));
                else s_Names.Add(s_L);
            }

            // For DxTexture resources, resolve the pixel chunk GUID from the mounted 128B header
            // (converter = correct guid byte order, the destream/classify pattern) so the catalog
            // carries the actual pixel bytes, not just the header resource.
            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(s_Mounter.GetEngineType());
            var s_ChunkGuids = new List<GUID>();
            foreach (var s_Name in s_Names)
            {
                if (!s_Mounter.TryGetResource(s_Name.ToLowerInvariant(), out var s_Res)) continue;
                if (s_Res!.FirstVariant.GetResourceType() != ResourceType.DxTexture) continue;
                byte[] s_Header;
                using (var s_R = s_Res.FirstVariant.GetReader())
                {
                    if (s_R.Length < 128) continue;
                    s_Header = s_R.ReadBytes(128);
                }
                var s_Probe = new BundleBuildingContext.ResourceMemoryReader(s_Header, ResourceType.DxTexture, s_Name);
                var s_ChunkId = s_Converter.GetTextureChunkId(s_Probe);
                if (s_ChunkId != GUID.Empty) s_ChunkGuids.Add(s_ChunkId);
            }
            s_ChunkGuids.AddRange(s_ExplicitChunks);

            p_Writer.WriteLine(s_Mounter.BuildCasCatalog(s_Names, OutDir!.FullName, (uint)StartIndex, s_ChunkGuids));
            return true;
        }
    }
}
