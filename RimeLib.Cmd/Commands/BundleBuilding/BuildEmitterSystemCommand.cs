using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using fb;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;
using RimeLib.Texture.Images;

namespace RimeLib.Cmd.Frostbite2_0.Commands.BundleBuilding
{
    /// <summary>
    /// Builds a level's emitter system from a template level's and the atlas textures the converted
    /// closures met. Frostbite 2 finds a particle's texture by name among the system's atlas entries,
    /// so each atlas texture becomes an entry named as the converted emitters name it. Both of the
    /// template's atlases grow to twice their height with their texels in the top half, so every
    /// template entry keeps its texels at half its height; the atlas textures go into the bottom half
    /// of the base atlas.
    /// </summary>
    [EngineCommand(typeof(BundleBuildingContext), EngineType.Frostbite2_0)]
    [CommandDescription("Builds an emitter system and its atlases from a template level's and the atlas textures the converted closures met.")]
    public class BuildEmitterSystemCommand : Command
    {
        [CommandArgument(Description = "The emitter system to build, e.g. Levels/MP_Prison/MP_Prison/EmitterSystem_Win32; its atlases go beside it.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The template emitter system, e.g. levels/mp_subway/mp_subway/emittersystem_win32.")]
        public string? Template { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game the template is in.")]
        public int TemplateId { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game the converted closures came from.")]
        public int SourceId { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Template))
            {
                p_Writer.WriteLine("usage: build_emitter_system <name> <template> <template id> <source id>");
                return false;
            }

            var s_Bundle = (BundleBuildingContext)p_Context;
            var s_Sb = (SbBuildingContext)s_Bundle.Parent!;
            var s_Mounters = ((BaseContext)s_Sb.Parent!).GetMounters();
            if (!s_Mounters.TryGetValue(TemplateId, out var s_Game) || s_Game.GetEngineType() != s_Sb.EngineType
                || !s_Game.TryGetPartition(Template!.ToLowerInvariant(), out var s_TemplateObject))
            {
                p_Writer.WriteLine($"Game {TemplateId} of this engine has no partition '{Template}'.");
                return false;
            }

            if (!s_Mounters.TryGetValue(SourceId, out var s_Source) || !EngineInterfaceRegistry.IsSupported<IAtlasTextureCodec>(s_Source.GetEngineType()))
            {
                p_Writer.WriteLine($"Game {SourceId} is not mounted or has no atlas textures.");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Sb.EngineType);
            var s_TemplatePartition = s_Converter.FromPartitionObject(Template!.ToLowerInvariant(), s_TemplateObject.FirstVariant);
            if (s_TemplatePartition.PrimaryInstance is not EmitterSystemAsset s_Template)
            {
                p_Writer.WriteLine($"'{Template}' is not an emitter system.");
                return false;
            }

            var s_Codec = EngineInterfaceRegistry.Create<ITextureCodec>(s_Sb.EngineType);
            var s_Folder = Name![..(Name!.LastIndexOf('/') + 1)];
            var s_Textures = ReadAtlasTextures(s_Sb, s_Source, p_Writer);
            var s_Base = Atlas(s_Bundle, s_Game, s_Codec, s_Converter, s_Template.BaseAtlasTexture, s_Folder, s_Textures, p_Writer);
            var s_Normal = Atlas(s_Bundle, s_Game, s_Codec, s_Converter, s_Template.NormalAtlasTexture, s_Folder, [], p_Writer);
            if (s_Base == null || s_Normal == null)
                return false;

            var s_System = new EmitterSystemAsset
            {
                Name = Name!,
                BaseAtlasTexture = s_Base.Value.Reference,
                NormalAtlasTexture = s_Normal.Value.Reference,
            };

            // The template's entries, of either atlas, keep their texels in the top half.
            foreach (var s_Entry in s_Template.TextureInfos)
            {
                s_Entry.MinUv.y /= 2f;
                s_Entry.MaxUv.y /= 2f;
                s_System.TextureInfos.Add(s_Entry);
            }

            var s_Names = s_Template.TextureInfos.Select(p_E => p_E.TextureName).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var s_Atlas = s_Base.Value.Atlas;
            foreach (var s_Cell in s_Atlas.Cells)
            {
                var s_Texture = s_Textures.First(p_T => p_T.Name == s_Cell.Name);
                float s_Bw = s_Texture.BorderWidth / (1 << s_Atlas.DroppedMips), s_Bh = s_Texture.BorderHeight / (1 << s_Atlas.DroppedMips);
                s_System.TextureInfos.Add(new EmitterTextureAtlasInfo
                {
                    TextureName = s_Cell.Name,
                    MinUv = new Vec2 { x = (s_Cell.X + s_Bw) / s_Atlas.Width, y = (s_Cell.Y + s_Bh) / s_Atlas.Height },
                    MaxUv = new Vec2 { x = (s_Cell.X + s_Cell.Width - s_Bw) / s_Atlas.Width, y = (s_Cell.Y + s_Cell.Height - s_Bh) / s_Atlas.Height },
                });
                s_Names.Add(s_Cell.Name);
            }

            var s_Name = Name!.ToLowerInvariant();
            var s_Guid = PartitionConversion.Derived(s_TemplatePartition.PartitionGuid, s_Name);
            s_System.InstanceId = new DataContainerId.Guid(s_Guid);
            AddPartition(s_Bundle, s_Name, s_Guid, s_System);

            // Converted emitters look their textures up by name; one not here samples the whole base atlas.
            var s_Missing = s_Sb.ConvertedPartitions.Values.SelectMany(p_P => p_P.Instances).OfType<UpdateTextureCoordsData>()
                .Select(p_D => p_D.TextureInfo1.TextureName).Where(p_N => p_N.Length > 0 && !s_Names.Contains(p_N))
                .Distinct(StringComparer.OrdinalIgnoreCase).ToList();
            p_Writer.WriteLine($"'{s_Name}': {s_Template.TextureInfos.Count} entries of '{Template}' and {s_Atlas.Cells.Count} atlas texture(s) " +
                $"in a {s_Atlas.Width}x{s_Atlas.Height} atlas, their top {s_Atlas.DroppedMips} mip(s) dropped.");
            if (s_Missing.Count > 0)
                p_Writer.WriteLine($"Converted emitters name {s_Missing.Count} texture(s) the system has none of: {string.Join(", ", s_Missing)}");
            return true;
        }

        private sealed record AtlasTexture(string Name, TextureImage Image, float BorderWidth, float BorderHeight);

        /// <summary>The base atlas textures the converted closures met, with their texels; normal maps are left out.</summary>
        private static List<AtlasTexture> ReadAtlasTextures(SbBuildingContext p_Sb, IEngineMounter p_Source, TextWriter p_Writer)
        {
            var s_Codec = EngineInterfaceRegistry.Create<IAtlasTextureCodec>(p_Source.GetEngineType());
            var s_Textures = new List<AtlasTexture>();
            var s_Normals = new List<string>();
            foreach (var (s_Name, _) in p_Sb.UnconvertedResources.Where(p_R => p_R.Value == ResourceType.AtlasTexture).OrderBy(p_R => p_R.Key, StringComparer.OrdinalIgnoreCase))
            {
                if (!p_Source.TryGetResource(s_Name.ToLowerInvariant(), out var s_Resource))
                    continue;

                var s_Header = MountedTextures.Read(s_Resource.FirstVariant);
                var s_Read = s_Codec.Decode(s_Header, []);
                if (s_Read.IsNormalMap)
                {
                    s_Normals.Add(s_Name);
                    continue;
                }

                s_Read = s_Codec.Decode(s_Header, MountedTextures.Read(MountedTextures.WholeChunk(p_Source, s_Read.Image.ChunkId)));
                s_Textures.Add(new AtlasTexture(s_Resource.OriginalName, s_Read.Image, s_Read.BorderWidth, s_Read.BorderHeight));
            }

            if (s_Normals.Count > 0)
                p_Writer.WriteLine($"Left out {s_Normals.Count} normal map(s), drawn with the template's default normal map: {string.Join(", ", s_Normals)}");
            return s_Textures;
        }

        /// <summary>
        /// The template's atlas grown with the textures, added beside the system as a texture asset
        /// of the template atlas's name, its resource and its chunk; none where the template has no such atlas.
        /// </summary>
        private static (CtrRef<TextureAsset> Reference, TextureAtlas Atlas)? Atlas(BundleBuildingContext p_Bundle, IEngineMounter p_Game, ITextureCodec p_Codec,
            IPartitionConverter p_Converter, CtrRef<TextureAsset> p_Template, string p_Folder, List<AtlasTexture> p_Textures, TextWriter p_Writer)
        {
            if (!p_Game.TryGetPartitionByGuid(p_Template.PartitionGuid, out var s_PartitionName, out var s_Partition)
                || p_Converter.FromPartitionObject(s_PartitionName, s_Partition.FirstVariant) is not { PrimaryInstance: TextureAsset s_Asset } s_AssetPartition
                || !p_Game.TryGetResource(s_Asset.Name.ToLowerInvariant(), out var s_Resource))
            {
                p_Writer.WriteLine($"The template's atlas {p_Template.PartitionGuid} is not a mounted texture.");
                return null;
            }

            var s_TemplateHeader = MountedTextures.Read(s_Resource.FirstVariant);
            var s_TemplateImage = p_Codec.Decode(s_Asset.Name.ToLowerInvariant(), s_TemplateHeader, []);
            var s_TemplateChunk = MountedTextures.WholeChunk(p_Game, s_TemplateImage.ChunkId);
            s_TemplateImage = p_Codec.Decode(s_Asset.Name.ToLowerInvariant(), s_TemplateHeader, MountedTextures.Read(s_TemplateChunk));

            var s_Atlas = new TextureAtlas(s_TemplateImage, p_Textures.Select(p_T => (p_T.Name, p_T.Image)).ToList());
            var s_Image = s_Atlas.Build();
            var s_Name = p_Folder + s_Asset.Name[(s_Asset.Name.LastIndexOf('/') + 1)..];
            var s_Lower = s_Name.ToLowerInvariant();
            var s_Guid = PartitionConversion.Derived(s_AssetPartition.PartitionGuid, s_Lower);
            s_Image.ChunkId = PartitionConversion.Derived(s_Guid, "chunk");

            var s_Written = p_Codec.Encode(s_Image, s_Lower, s_TemplateHeader);
            p_Bundle.AddGeneratedResource(s_Lower, s_Written.Header, ResourceType.DxTexture, s_Written.Meta);
            int? s_FirstMip = s_TemplateChunk.TryGetMeta(out var s_Meta) && s_Meta.TryGetByKey<DbObject>("meta", out var s_Inner)
                && s_Inner!.Value.TryGetByKey<int>("firstMip", out var s_Mip) ? s_Mip!.Value : null;
            var s_Hash = (int)RimeLib.Frostbite.Utils.HashQuick(s_Lower);
            p_Bundle.AddChunk(s_Image.ChunkId, new MemoryChunk(s_Written.Chunk,
                EngineInterfaceRegistry.Create<IChunkMetaWriter>(((SbBuildingContext)p_Bundle.Parent!).EngineType).Create(s_Hash, s_FirstMip), s_Hash));

            var s_Texture = new TextureAsset { Name = s_Name, InstanceId = new DataContainerId.Guid(s_Guid) };
            AddPartition(p_Bundle, s_Lower, s_Guid, s_Texture);
            p_Writer.WriteLine($"'{s_Lower}': {s_TemplateImage.Width}x{s_TemplateImage.Height} of '{s_PartitionName}' grown to {s_Image.Width}x{s_Image.Height}, {s_Image.MipCount} mips.");
            return (new CtrRef<TextureAsset>(s_Guid, s_Texture.InstanceId), s_Atlas);
        }

        private static void AddPartition(BundleBuildingContext p_Bundle, string p_Name, GUID p_Guid, DataContainerBase p_Instance)
        {
            var s_Sb = (SbBuildingContext)p_Bundle.Parent!;
            var s_Partition = EngineInterfaceRegistry.Create<IEbxTypeLibrary>(s_Sb.EngineType).CreatePartition(p_Name, p_Guid, p_Guid, [p_Instance]);
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                EngineInterfaceRegistry.Create<IPartitionGenerator>(s_Sb.EngineType).Generate(s_Partition, s_Writer);
            p_Bundle.RemovePartition(p_Name);
            p_Bundle.AddRawPartitionBytes(p_Name, s_Stream.ToArray());
        }
    }
}
