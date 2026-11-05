using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Texture.Images;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Fits every mounted texture to another mounted game's engine (its formats and streaming groups), writes it with that engine's codec and reads it back, reporting the format conversions and group mappings it made and the textures it could not convert.")]
    public class CheckTextureConversionCommand : Command
    {
        [CommandArgument(Description = "Id of the mounted game to convert to.")]
        public int Target { get; set; }

        [CommandArgument(Description = "How many textures to list per failure.", Optional = true)]
        public int List { get; set; } = 3;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Game = (GameContext)p_Context;
            var s_Source = s_Game.GetMounter();
            if (!((BaseContext)s_Game.Parent!).GetMounters().TryGetValue(Target, out var s_Target))
            {
                p_Writer.WriteLine($"No game is mounted with id {Target}.");
                return false;
            }

            var s_From = EngineInterfaceRegistry.Create<ITextureCodec>(s_Source.GetEngineType());
            var s_To = EngineInterfaceRegistry.Create<ITextureCodec>(s_Target.GetEngineType());
            var s_Groups = TargetGroups(s_Target, s_To);

            var s_Conversions = new SortedDictionary<string, int>(StringComparer.Ordinal);
            var s_GroupMappings = new Dictionary<string, int>(StringComparer.Ordinal);
            var s_Failures = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            int s_Textures = 0, s_Converted = 0;

            foreach (var (s_Name, s_Resource) in Textures(s_Source))
            {
                s_Textures++;
                var s_Header = Read(s_Resource.FirstVariant);
                try
                {
                    var s_Image = s_From.Decode(s_Name, s_Header, Array.Empty<byte>());
                    if (TextureConversion.NeedsData(s_Image.Format, s_To.Formats))
                        s_Image = s_From.Decode(s_Name, s_Header, ReadChunk(s_Source, s_Image));

                    var s_Fitted = TextureConversion.ToFormats(s_Image, s_To.Formats).Copy();
                    s_Fitted.Group = TextureConversion.ToGroups(s_Image.Group, s_Groups);

                    var s_Written = s_To.Encode(s_Fitted, s_Name);
                    var s_Read = s_To.Decode(s_Name, s_Written.Header, s_Written.Chunk);
                    if (s_Written.Chunk.Length > 0 && s_Written.Chunk.Length != s_To.ChunkSize(s_Read))
                        throw new InvalidDataException($"A {s_Written.Chunk.Length} byte chunk where the target's layout gives {s_To.ChunkSize(s_Read)}.");

                    Count(s_Conversions, s_Image.Format == s_Fitted.Format ? $"{s_Image.Format}" : $"{s_Image.Format} -> {s_Fitted.Format}");
                    if (s_Fitted.Group != s_Image.Group)
                        Count(s_GroupMappings, $"{s_Image.Group} -> {s_Fitted.Group}");
                    s_Converted++;
                }
                catch (Exception s_Ex) when (s_Ex is InvalidDataException or NotSupportedException or ArgumentException or KeyNotFoundException)
                {
                    if (!s_Failures.TryGetValue(s_Ex.Message, out var s_Names))
                        s_Failures[s_Ex.Message] = s_Names = new List<string>();
                    s_Names.Add(s_Name);
                }
            }

            foreach (var (s_Conversion, s_Count) in s_Conversions)
                p_Writer.WriteLine($"{s_Conversion,-28} {s_Count,6}");

            p_Writer.WriteLine($"{s_GroupMappings.Values.Sum()} texture(s) in a streaming group the target does not have:");
            foreach (var (s_Mapping, s_Count) in s_GroupMappings.OrderByDescending(p_M => p_M.Value))
                p_Writer.WriteLine($"  {s_Mapping,-36} {s_Count,6}");

            foreach (var (s_Reason, s_Names) in s_Failures.OrderByDescending(p_F => p_F.Value.Count))
            {
                p_Writer.WriteLine($"{s_Names.Count} not converted: {s_Reason}");
                foreach (var s_Name in s_Names.Take(List))
                    p_Writer.WriteLine($"  {s_Name}");
            }

            p_Writer.WriteLine($"check_texture_conversion: {s_Converted}/{s_Textures} converted to {s_Target.GetEngineType()}.");
            return s_Converted == s_Textures;
        }

        private static IEnumerable<KeyValuePair<string, IMountedObject<IResourceVariant>>> Textures(IEngineMounter p_Mounter) =>
            p_Mounter.GetResources()
                .Where(p_R => p_R.Value.FirstVariant.GetResourceType() == ResourceType.DxTexture)
                .OrderBy(p_R => p_R.Key, StringComparer.Ordinal);

        /// <summary>The streaming groups the target game's textures are in.</summary>
        private static HashSet<string> TargetGroups(IEngineMounter p_Target, ITextureCodec p_Codec)
        {
            var s_Groups = new HashSet<string>(StringComparer.Ordinal);
            foreach (var (s_Name, s_Resource) in Textures(p_Target))
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

        private static byte[] Read(IObjectVariant p_Variant)
        {
            using var s_Reader = p_Variant.GetReader();
            return s_Reader.ReadBytes((int)s_Reader.Length);
        }

        /// <summary>The full chunk: the variant read from its start, the others hold a range of it.</summary>
        private static byte[] ReadChunk(IEngineMounter p_Mounter, TextureImage p_Image)
        {
            if (!p_Mounter.TryGetChunk(p_Image.ChunkId, out var s_Chunk))
                throw new InvalidDataException($"Chunk {p_Image.ChunkId} is not mounted.");

            return Read(s_Chunk.Variants.FirstOrDefault(p_V => p_V.GetLogicalOffset() == 0) ?? s_Chunk.FirstVariant);
        }

        private static void Count(IDictionary<string, int> p_Counts, string p_Key) =>
            p_Counts[p_Key] = p_Counts.TryGetValue(p_Key, out var s_Count) ? s_Count + 1 : 1;
    }
}
