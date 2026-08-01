using System;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Frostbite2_0.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Texture;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Delivers a streaming texture fully resident: clears its Streaming flag and MipmapBaseIndex and adds the whole cas chunk as a catalog ref, shipping no bytes. Catalog-backed textures only.")]
    internal class DestreamTextureCommand : Command
    {
        // The header keeps its format, group and name hash, and the chunk ships as a full-range
        // catalog reference, so the delivered bytes stay exactly the game's own. Anything a resolve
        // already pulled in under the same name, a partial resource or a ranged chunk, is replaced.
        //
        // Which mode to use depends on where the texture is going. The default puts header and chunk
        // in this bundle, but the generated header then ships as cas idata, which the MVDB texture
        // bind rejects; textures bound by name through the shaderdb tolerate it. To satisfy the MVDB
        // bind, split the two: 'chunkonly' in the cas pack bundle and 'headeronly' in a noncas annex
        // that loads alongside it, since a generated resource only renders through noncas.
        [CommandArgument(Description = "The exact resource/asset name, e.g. vehicles/m1a2/m1a2_d.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "'chunkonly' ships the full-range chunk and drops the resource, 'headeronly' the patched header alone, 'keepmips' keeps MipmapBaseIndex and takes the retail-ranged chunk. Default: both.", Optional = true)]
        public string? Mode { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = p_Context as BundleBuildingContext;
            if (s_BundleContext == null || string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("usage (bundle ctx): destream_texture <name> [chunkonly|headeronly|keepmips]");
                return false;
            }

            var s_Mode = (Mode ?? "").ToLowerInvariant();
            if (s_Mode != "" && s_Mode != "chunkonly" && s_Mode != "headeronly" && s_Mode != "keepmips")
            {
                p_Writer.WriteLine($"destream_texture: unknown mode '{Mode}' (use chunkonly|headeronly|keepmips|<empty>).");
                return false;
            }

            var s_SbBuildingContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_BaseContext = (BaseContext)s_SbBuildingContext.Parent!;
            var s_Mounter = s_BaseContext.GetMounters().Values.FirstOrDefault() as EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("destream_texture: no Frostbite2_0 mounter.");
                return false;
            }

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource))
            {
                p_Writer.WriteLine($"destream_texture: resource not found: {Name}");
                return false;
            }

            byte[] s_Header;
            using (var s_Reader = s_Resource.FirstVariant.GetReader())
            {
                if (s_Reader.Length < 128)
                {
                    p_Writer.WriteLine($"destream_texture: {Name} is not a 128-byte DxTexture header ({s_Reader.Length}).");
                    return false;
                }

                s_Header = s_Reader.ReadBytes(128);
            }

            // keepmips leaves MipmapBaseIndex alone so the header stays coherent with the retail-ranged
            // chunk and the texture never registers with the streaming system. Texture arrays need this:
            // the fully resident shape (mipBase forced to 0 plus the full chunk) is one retail never
            // ships, and it crashes the streaming worker when a canopy samples it.
            var s_Flags = BitConverter.ToUInt32(s_Header, 12);
            var s_NewFlags = s_Flags & ~0x1u;
            BitConverter.GetBytes(s_NewFlags).CopyTo(s_Header, 12);
            var s_MipBase = s_Header[27];
            if (s_Mode != "keepmips")
                s_Header[27] = 0;

            if (s_Mode == "headeronly")
            {
                // Generated resources only render through noncas, so the chunk ships separately.
                try { s_BundleContext.RemoveResource(Name!); } catch { }
                s_BundleContext.AddGeneratedResource(Name!, s_Header, ResourceType.DxTexture, new byte[16]);
                p_Writer.WriteLine($"destream-header {Name}: flags 0x{s_Flags:X} to 0x{s_NewFlags:X}, mipBase {s_MipBase} to 0 (128B noncas resource).");
                return true;
            }

            // Resolve the chunk id through the engine converter so the guid byte order is right.
            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(s_SbBuildingContext.EngineType);
            var s_Probe = new BundleBuildingContext.ResourceMemoryReader(s_Header, ResourceType.DxTexture, Name!);
            var s_ChunkId = s_Converter.GetTextureChunkId(s_Probe);
            if (s_ChunkId == GUID.Empty)
            {
                p_Writer.WriteLine($"destream_texture: {Name} has no streaming chunk id.");
                return false;
            }

            if (s_Mode == "keepmips")
            {
                if (!s_Mounter.TryGetTextureChunkRetailVariant(s_ChunkId, Name!, out var s_Retail))
                {
                    p_Writer.WriteLine($"destream_texture: {Name} chunk {s_ChunkId} has no retail h32 variant, keepmips unavailable.");
                    return false;
                }

                try { s_BundleContext.RemoveResource(Name!); } catch { }
                try { s_BundleContext.RemoveChunk(s_ChunkId); } catch { }
                s_BundleContext.AddGeneratedResource(Name!, s_Header, ResourceType.DxTexture, new byte[16]);
                s_BundleContext.AddChunk(s_ChunkId, s_Retail);
                p_Writer.WriteLine($"destream-keepmips {Name}: flags 0x{s_Flags:X} to 0x{s_NewFlags:X}, mipBase {s_MipBase} kept, retail-ranged chunk {s_ChunkId}.");
                return true;
            }

            // Carry the asset name so the manifest writes a chunkMeta { h32: fnv(name) }. An empty
            // chunkMeta breaks the chunk to texture association at bundle load.
            if (!s_Mounter.TryGetFullRangeCasChunkVariant(s_ChunkId, out var s_Full, Name!))
            {
                p_Writer.WriteLine($"destream_texture: {Name} chunk {s_ChunkId} has no catalog-backed variant, use add_dds_texture for this one.");
                return false;
            }

            try { s_BundleContext.RemoveResource(Name!); } catch { }
            try { s_BundleContext.RemoveChunk(s_ChunkId); } catch { }

            if (s_Mode == "chunkonly")
            {
                s_BundleContext.AddChunk(s_ChunkId, s_Full);
                p_Writer.WriteLine($"destream-chunk {Name}: chunk {s_ChunkId} full-range catalog ref (h32 meta), resource removed.");
                return true;
            }

            s_BundleContext.AddGeneratedResource(Name!, s_Header, ResourceType.DxTexture, new byte[16]);
            s_BundleContext.AddChunk(s_ChunkId, s_Full);

            p_Writer.WriteLine($"destreamed {Name}: flags 0x{s_Flags:X} to 0x{s_NewFlags:X}, mipBase {s_MipBase} to 0, chunk {s_ChunkId} full-range catalog ref.");
            return true;
        }
    }
}
