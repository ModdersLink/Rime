using System;
using System.IO;
using System.Linq;
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
using RimeLib.Texture.DDS;
using RimeLib.Texture.Images;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Gives a converted level the minimap of the game it comes from: the image of the source's
    /// minimap asset, turned to run as the bundle's engine draws it and made grey in the layout and
    /// brightness of a template level's minimap texture, over the source's frame, with the template's
    /// other minimap settings and what they reference.
    /// </summary>
    [CommandDescription("Gives a converted level the minimap of a source game's minimap asset, laid out like a template level's of the bundle's engine.")]
    public class AddMinimapCommand : Command
    {
        [CommandArgument(Description = "The bundle's level partition, e.g. levels/mp_prison/mp_prison.")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "The source game's minimap asset, e.g. levels/mp/mp_prison/minimaps/win32/minimap_minimap2dtexture.")]
        public string? Minimap { get; set; }

        [CommandArgument(Description = "The id of the game the minimap asset is in.")]
        public int Source { get; set; }

        [CommandArgument(Description = "A level of the bundle's engine whose minimap settings and texture layout to take, e.g. levels/mp_subway/mp_subway.")]
        public string? Template { get; set; }

        [CommandArgument(Description = "The id of the game the template is in.")]
        public int Target { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Partition) || string.IsNullOrWhiteSpace(Minimap) || string.IsNullOrWhiteSpace(Template))
            {
                p_Writer.WriteLine("usage: add_minimap <partition> <minimap> <source> <template> <target>");
                return false;
            }

            var s_Bundle = (BundleBuildingContext)p_Context;
            var s_Sb = (SbBuildingContext)s_Bundle.Parent!;
            var s_Mounters = ((BaseContext)s_Sb.Parent!).GetMounters();
            if (!s_Mounters.TryGetValue(Source, out var s_SourceGame) || !s_Mounters.TryGetValue(Target, out var s_TargetGame)
                || s_TargetGame.GetEngineType() != s_Sb.EngineType)
            {
                p_Writer.WriteLine($"Mount the source as {Source} and a game of the bundle's engine as {Target}.");
                return false;
            }

            var s_Engine = s_Sb.EngineType;
            var s_TargetReader = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Engine);
            var s_SourceReader = EngineInterfaceRegistry.Create<IPartitionConverter>(s_SourceGame.GetEngineType());
            var s_Rules = EngineInterfaceRegistry.Create<IMinimapTarget>(s_Engine);
            var s_Name = Partition!.ToLowerInvariant();
            if (!BundlePartitionVariant.All(s_Bundle).TryGetValue(s_Name, out var s_Variant))
            {
                p_Writer.WriteLine($"The bundle has no partition '{Partition}'.");
                return false;
            }

            var s_Level = s_TargetReader.FromPartitionObject(s_Name, s_Variant);
            if (Read(s_SourceGame, s_SourceReader, Minimap!.ToLowerInvariant()) is not { } s_SourceMinimap
                || EngineInterfaceRegistry.Create<IMinimapSource>(s_SourceGame.GetEngineType()).Read(s_SourceMinimap) is not var (s_SourceTexture, s_Frame))
            {
                p_Writer.WriteLine($"Game {Source} has no minimap asset '{Minimap}'.");
                return false;
            }

            if (Read(s_TargetGame, s_TargetReader, Template!.ToLowerInvariant()) is not { } s_Template || s_Rules.Texture(s_Template) is not { } s_TemplateTexture)
            {
                p_Writer.WriteLine($"Game {Target} has no level '{Template}' with a minimap texture.");
                return false;
            }

            var s_SourceCodec = EngineInterfaceRegistry.Create<ITextureCodec>(s_SourceGame.GetEngineType());
            var s_TargetCodec = EngineInterfaceRegistry.Create<ITextureCodec>(s_Engine);
            var s_Image = Texture(s_SourceGame, s_SourceCodec, s_SourceTexture.Partition, out _);
            var s_Layout = Texture(s_TargetGame, s_TargetCodec, s_TemplateTexture.Partition, out var s_LayoutChunk);
            if (s_Layout.Format != TexturePixelFormat.L8)
            {
                p_Writer.WriteLine($"The template's minimap texture is {s_Layout.Format}; only L8 is written.");
                return false;
            }

            // The texture asset is named as the template's is, under the level's folder.
            var s_Folder = s_Name[..s_Name.LastIndexOf('/')];
            var s_TextureName = $"{s_Folder}/ui/minimap/{s_Name[(s_Name.LastIndexOf('/') + 1)..]}_satellite";
            var s_TextureGuid = PartitionConversion.Derived(s_Level.PartitionGuid, "Minimap");
            var s_Grey = s_Layout.Copy();
            s_Grey.ChunkId = PartitionConversion.Derived(s_TextureGuid, "Chunk");
            s_Grey.Data = Grey(Bgra(s_Image), s_Image.Width, s_Image.Height, s_Frame, s_Rules.Signs, s_Layout);
            var s_Written = s_TargetCodec.Encode(s_Grey, s_TextureName);
            s_Bundle.AddGeneratedResource(s_TextureName, s_Written.Header, ResourceType.DxTexture, s_Written.Meta);
            int? s_FirstMip = s_LayoutChunk.TryGetMeta(out var s_Meta) && s_Meta.TryGetByKey<DbObject>("meta", out var s_Inner)
                && s_Inner!.Value.TryGetByKey<int>("firstMip", out var s_Mip) ? s_Mip!.Value : null;
            var s_Hash = (int)Frostbite.Utils.HashQuick(s_TextureName);
            s_Bundle.AddChunk(s_Grey.ChunkId, new MemoryChunk(s_Written.Chunk, EngineInterfaceRegistry.Create<IChunkMetaWriter>(s_Engine).Create(s_Hash, s_FirstMip), s_Hash));

            var s_Asset = s_Rules.TextureAsset(s_TextureName);
            s_Asset.InstanceId = new DataContainerId.Guid(s_TextureGuid);
            var s_Types = EngineInterfaceRegistry.Create<IEbxTypeLibrary>(s_Engine);
            Add(s_Bundle, s_Engine, s_TextureName, s_Types.CreatePartition(s_TextureName, s_TextureGuid, s_TextureGuid, [s_Asset]));

            var s_Referenced = s_Rules.Set(s_Level, s_Template, new InstanceRef(s_TextureGuid, s_TextureGuid), s_Frame);
            if (s_Referenced == null)
            {
                p_Writer.WriteLine($"'{Partition}' has no minimap settings.");
                return false;
            }

            Add(s_Bundle, s_Engine, s_Name, s_Level);
            var s_Names = s_Referenced.Select(p_R => s_TargetGame.TryGetPartitionByGuid(p_R.Partition, out var s_N, out _) ? s_N : null).OfType<string>().ToList();
            if (s_Names.Count > 0 && PartitionClosure.Create(s_Bundle, Target, [], TextWriter.Null) is { } s_Closure)
                s_Closure.AddAll(s_Names, p_Writer);
            p_Writer.WriteLine($"'{s_Name}' shows '{s_TextureName}' ({s_Grey.Width}x{s_Grey.Height} {s_Grey.Format}, {s_Grey.MipCount} mips) over {s_Frame.Size} m around ({s_Frame.CenterX}, {s_Frame.CenterZ}), with {s_Names.Count} partition(s) of '{Template}'.");
            return true;
        }

        private static DatabasePartitionBase? Read(IEngineMounter p_Game, IPartitionConverter p_Reader, string p_Name) =>
            p_Game.TryGetPartition(p_Name, out var s_Partition) ? p_Reader.FromPartitionObject(p_Name, s_Partition.FirstVariant) : null;

        /// <summary>The texture of a texture asset, which is named after its partition, with its chunk.</summary>
        private static TextureImage Texture(IEngineMounter p_Game, ITextureCodec p_Codec, GUID p_Asset, out IChunkVariant p_Chunk)
        {
            if (!p_Game.TryGetPartitionByGuid(p_Asset, out var s_Name, out _) || !p_Game.TryGetResource(s_Name, out var s_Resource))
                throw new InvalidDataException($"Texture asset {p_Asset} has no texture resource.");

            var s_Header = MountedTextures.Read(s_Resource.FirstVariant);
            var s_Image = p_Codec.Decode(s_Name, s_Header, []);
            p_Chunk = MountedTextures.WholeChunk(p_Game, s_Image.ChunkId);
            return p_Codec.Decode(s_Name, s_Header, MountedTextures.Read(p_Chunk));
        }

        /// <summary>The first mip level as BGRA texels.</summary>
        private static byte[] Bgra(TextureImage p_Image)
        {
            var s_Mip = p_Image.Data.AsSpan(0, (int)p_Image.MipSize(0)).ToArray();
            return p_Image.Format switch
            {
                TexturePixelFormat.Dxt1 => DXTDecoder.DecodeDXT1Texture(p_Image.Width, p_Image.Height, s_Mip, false),
                TexturePixelFormat.Dxt5 => DXTDecoder.DecodeDXT45Texture(p_Image.Width, p_Image.Height, s_Mip, false),
                TexturePixelFormat.Argb8888 => s_Mip,
                _ => throw new InvalidDataException($"A minimap texture in {p_Image.Format} is not read."),
            };
        }

        /// <summary>
        /// The image as the layout's L8 mip chain: sampled at the layout's size, turned where the
        /// engines' minimaps run the other way, and its grey levels given the mean and spread of the
        /// layout's own texels.
        /// </summary>
        private static byte[] Grey(byte[] p_Bgra, int p_Width, int p_Height, MinimapFrame p_Frame, (int X, int Z) p_Signs, TextureImage p_Layout)
        {
            int s_Width = p_Layout.Width, s_Height = p_Layout.Height;
            var s_FlipX = p_Frame.SignX != p_Signs.X;
            var s_FlipZ = p_Frame.SignZ != p_Signs.Z;
            var s_Levels = new double[s_Width * s_Height];
            for (var y = 0; y < s_Height; ++y)
            for (var x = 0; x < s_Width; ++x)
            {
                var s_X = (s_FlipX ? s_Width - 1 - x : x) * p_Width / s_Width;
                var s_Y = (s_FlipZ ? s_Height - 1 - y : y) * p_Height / s_Height;
                var s_Texel = (s_Y * p_Width + s_X) * 4;
                s_Levels[y * s_Width + x] = 0.114 * p_Bgra[s_Texel] + 0.587 * p_Bgra[s_Texel + 1] + 0.299 * p_Bgra[s_Texel + 2];
            }

            var (s_Mean, s_Spread) = Spread(s_Levels);
            var (s_LayoutMean, s_LayoutSpread) = Spread(p_Layout.Data.AsSpan(0, s_Width * s_Height).ToArray().Select(p_B => (double)p_B).ToArray());
            var s_Scale = s_Spread > 0 ? s_LayoutSpread / s_Spread : 0;
            var s_Data = new byte[p_Layout.ChainSize()];
            for (var i = 0; i < s_Levels.Length; ++i)
                s_Data[i] = (byte)System.Math.Clamp(System.Math.Round(s_LayoutMean + (s_Levels[i] - s_Mean) * s_Scale), 0, 255);

            // Each further mip level averages 2x2 texels of the one before.
            long s_From = 0, s_To = s_Width * s_Height;
            for (var s_Mip = 1; s_Mip < p_Layout.MipCount; ++s_Mip)
            {
                int s_PrevWidth = TextureImage.Level(s_Width, s_Mip - 1), s_PrevHeight = TextureImage.Level(s_Height, s_Mip - 1);
                int s_MipWidth = TextureImage.Level(s_Width, s_Mip), s_MipHeight = TextureImage.Level(s_Height, s_Mip);
                for (var y = 0; y < s_MipHeight; ++y)
                for (var x = 0; x < s_MipWidth; ++x)
                {
                    int s_X0 = System.Math.Min(2 * x, s_PrevWidth - 1), s_X1 = System.Math.Min(2 * x + 1, s_PrevWidth - 1);
                    int s_Y0 = System.Math.Min(2 * y, s_PrevHeight - 1), s_Y1 = System.Math.Min(2 * y + 1, s_PrevHeight - 1);
                    var s_Sum = s_Data[s_From + s_Y0 * s_PrevWidth + s_X0] + s_Data[s_From + s_Y0 * s_PrevWidth + s_X1]
                        + s_Data[s_From + s_Y1 * s_PrevWidth + s_X0] + s_Data[s_From + s_Y1 * s_PrevWidth + s_X1];
                    s_Data[s_To + y * s_MipWidth + x] = (byte)((s_Sum + 2) / 4);
                }

                s_From = s_To;
                s_To += (long)s_MipWidth * s_MipHeight;
            }

            return s_Data;
        }

        private static (double Mean, double Spread) Spread(double[] p_Values)
        {
            var s_Mean = p_Values.Average();
            return (s_Mean, System.Math.Sqrt(p_Values.Average(p_V => (p_V - s_Mean) * (p_V - s_Mean))));
        }

        private static void Add(BundleBuildingContext p_Bundle, EngineType p_Engine, string p_Name, DatabasePartitionBase p_Partition)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                EngineInterfaceRegistry.Create<IPartitionGenerator>(p_Engine).Generate(p_Partition, s_Writer);
            p_Bundle.RemovePartition(p_Name);
            p_Bundle.AddRawPartitionBytes(p_Name, s_Stream.ToArray());
        }
    }
}
