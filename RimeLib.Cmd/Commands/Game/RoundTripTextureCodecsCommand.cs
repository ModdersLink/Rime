using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Texture;
using RimeLib.Texture.Images;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Reads every mounted texture header into a TextureImage and writes it back, reporting per format how many come out byte-identical and whether each chunk is the size the image's layout gives. A chunk the engine lays out differently from the image goes through it and back too.")]
    public class RoundTripTextureCodecsCommand : Command
    {
        [CommandArgument(Description = "How many failures to list per reason.", Optional = true)]
        public int List { get; set; } = 3;

        private sealed class Tally
        {
            public int Textures, Identical, ChunkSized, Realigned;
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Codec = EngineInterfaceRegistry.Create<ITextureCodec>(s_Mounter.GetEngineType());
            var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(s_Mounter.GetEngineType());

            var s_Tallies = new SortedDictionary<TexturePixelFormat, Tally>();
            var s_Failures = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            void Fail(string p_Reason, string p_Name)
            {
                if (!s_Failures.TryGetValue(p_Reason, out var s_Names))
                    s_Failures[p_Reason] = s_Names = new List<string>();
                s_Names.Add(p_Name);
            }

            var s_Textures = 0;
            foreach (var (s_Name, s_Resource) in s_Mounter.GetResources().OrderBy(p_R => p_R.Key, StringComparer.Ordinal))
            {
                var s_Variant = s_Resource.FirstVariant;
                if (s_Variant.GetResourceType() != ResourceType.DxTexture)
                    continue;

                s_Textures++;
                byte[] s_Header;
                using (var s_Reader = s_Variant.GetReader())
                    s_Header = s_Reader.ReadBytes((int)s_Reader.Length);

                TextureImage s_Image;
                try
                {
                    s_Image = s_Codec.Decode(s_Name, s_Header, Array.Empty<byte>());
                }
                catch (Exception s_Ex) when (s_Ex is InvalidDataException or KeyNotFoundException or ArgumentException)
                {
                    Fail($"not read: {s_Ex.Message}", s_Name);
                    continue;
                }

                if (!s_Tallies.TryGetValue(s_Image.Format, out var s_Tally))
                    s_Tallies[s_Image.Format] = s_Tally = new Tally();
                s_Tally.Textures++;

                if (s_Codec.Encode(s_Image, s_Name, s_Header).Header.AsSpan().SequenceEqual(s_Header))
                    s_Tally.Identical++;
                else
                    Fail("written differently", s_Name);

                // The full chunk is the variant read from its start; the others hold a range of it.
                var s_ChunkId = s_Converter.GetTextureChunkId(s_Variant);
                if (!s_Mounter.TryGetChunk(s_ChunkId, out var s_Chunk))
                {
                    Fail("chunk not mounted", s_Name);
                    continue;
                }

                var s_Full = s_Chunk.Variants.FirstOrDefault(p_V => p_V.GetLogicalOffset() == 0) ?? s_Chunk.FirstVariant;
                var s_Expected = s_Codec.ChunkSize(s_Image);
                if (s_Full.GetSize() != s_Expected)
                {
                    Fail($"chunk not {s_Image.Kind} {s_Image.Format} sized", $"{s_Name} ({s_Full.GetSize()} bytes, layout gives {s_Expected})");
                    continue;
                }

                s_Tally.ChunkSized++;

                // Where the engine lays the chunk out differently from the image, the chunk goes
                // through the image and back too.
                if (s_Expected == s_Image.DataSize())
                    continue;

                byte[] s_ChunkData;
                using (var s_Reader = s_Full.GetReader())
                    s_ChunkData = s_Reader.ReadBytes((int)s_Reader.Length);

                if (s_Codec.Encode(s_Codec.Decode(s_Name, s_Header, s_ChunkData), s_Name, s_Header).Chunk.AsSpan().SequenceEqual(s_ChunkData))
                    s_Tally.Realigned++;
                else
                    Fail("chunk written back differently", s_Name);
            }

            foreach (var (s_Format, s_Tally) in s_Tallies)
                p_Writer.WriteLine($"{s_Format,-14} {s_Tally.Textures,6} texture(s): header written back unchanged {s_Tally.Identical}, chunk the layout's size {s_Tally.ChunkSized}{(s_Tally.Realigned > 0 ? $", {s_Tally.Realigned} laid out differently and written back unchanged" : "")}");

            foreach (var (s_Reason, s_Names) in s_Failures.OrderByDescending(p_F => p_F.Value.Count))
            {
                p_Writer.WriteLine($"{s_Names.Count} {s_Reason}");
                foreach (var s_Name in s_Names.Take(List))
                    p_Writer.WriteLine($"  {s_Name}");
            }

            var s_Read = s_Tallies.Values.Sum(p_T => p_T.Textures);
            p_Writer.WriteLine($"round_trip_texture_codecs: {s_Read}/{s_Textures} read, {s_Tallies.Values.Sum(p_T => p_T.Identical)} written back unchanged.");
            return s_Read == s_Textures;
        }
    }
}
