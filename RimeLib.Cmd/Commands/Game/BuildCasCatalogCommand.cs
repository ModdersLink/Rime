using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Frostbite2_0.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Builds a cas.cat and its cas files from the stored frames of the named objects that no mounted catalog already holds, so a mod can cas-ref them instead of shipping the bytes.")]
    public class BuildCasCatalogCommand : Command
    {
        // Objects the base or patch catalog already carries are skipped, since the game ships those as
        // cas already. For a DxTexture the pixel chunk is catalogued alongside the header resource,
        // and it is the chunk that carries nearly all the weight.
        [CommandArgument(Description = "Text file with one resource/partition name per line.")]
        public FileInfo? NameList { get; set; }

        [CommandArgument(Description = "Output directory for cas.cat + cas_NN.cas.")]
        public DirectoryInfo? OutDir { get; set; }

        [CommandArgument(Optional = true, Description = "First cas file number (default 1).")]
        public int StartIndex { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_GameContext = (GameContext)p_Context;
            var s_Mounter = s_GameContext.GetMounter() as EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("build_cas_catalog: no Frostbite2_0 mounter.");
                return false;
            }

            var s_Lines = File.ReadAllLines(NameList!.FullName)
                .Select(p_L => p_L.Trim())
                .Where(p_L => p_L.Length > 0 && !p_L.StartsWith("#"));

            // A line that parses as a guid names a chunk to catalog directly, anything else is a
            // resource or partition name.
            var s_Names = new List<string>();
            var s_ExplicitChunks = new List<GUID>();
            foreach (var s_Line in s_Lines)
            {
                if (Guid.TryParse(s_Line, out _))
                    s_ExplicitChunks.Add(new GUID(s_Line));
                else
                    s_Names.Add(s_Line);
            }

            // Resolve each DxTexture's pixel chunk from its mounted 128-byte header, through the
            // converter so the guid byte order is right, so the catalog carries the pixels and not just
            // the header resource.
            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(s_Mounter.GetEngineType());
            var s_ChunkGuids = new List<GUID>();
            foreach (var s_Name in s_Names)
            {
                if (!s_Mounter.TryGetResource(s_Name.ToLowerInvariant(), out var s_Resource)) continue;
                if (s_Resource!.FirstVariant.GetResourceType() != ResourceType.DxTexture) continue;

                byte[] s_Header;
                using (var s_Reader = s_Resource.FirstVariant.GetReader())
                {
                    if (s_Reader.Length < 128) continue;
                    s_Header = s_Reader.ReadBytes(128);
                }

                var s_Probe = new BundleBuildingContext.ResourceMemoryReader(s_Header, ResourceType.DxTexture, s_Name);
                var s_ChunkId = s_Converter.GetTextureChunkId(s_Probe);
                if (s_ChunkId != GUID.Empty)
                    s_ChunkGuids.Add(s_ChunkId);
            }

            s_ChunkGuids.AddRange(s_ExplicitChunks);

            p_Writer.WriteLine(s_Mounter.BuildCasCatalog(s_Names, OutDir!.FullName, (uint)StartIndex, s_ChunkGuids));
            return true;
        }
    }
}
