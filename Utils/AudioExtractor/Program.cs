using CommandLine;
using fb;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using RimeLib;
using RimeLib.Audio.EA.Audio;
using RimeLib.Audio.EA.Audio.Format1;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Serialization;
using RimeLib.Utils;

namespace AudioExtractor
{
    class Program
    {
        internal class Options
        {
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;

            [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to extract.")]
            public string GamePath { get; set; } = "";

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
            public EngineType EngineType { get; set; }

            [Value(2, MetaName = "outPath", Required = true, HelpText = "The output directory where the extracted files will be put into.")]
            public string OutputPath { get; set; } = "";
        }

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                LoadContentAssembly(p_Options);
                DumpFiles(p_Options);

                Console.WriteLine("Audio content successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Error =>
            {
                System.Environment.Exit(1);
            });
            Console.WriteLine("Hello World!");
        }

        private static void LoadContentAssembly(Options p_Options)
        {
            var s_AssemblyName = "RimeLib.Content." + p_Options.EngineType;

            try
            {
                if (!p_Options.Quiet)
                    Console.WriteLine("Loading engine content support assembly.");

                Assembly.Load(s_AssemblyName);
            }
            catch
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Failed to load supporting engine assembly ({s_AssemblyName}.dll). This means that the engine is not supported or that you are missing required files.");

                System.Environment.Exit(1);
            }
        }


        private static async void DumpFiles(Options p_Options)
        {
            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, false, p_Options.EngineType);
            await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            await s_Mounter.MountSuperbundle("Win32/Xp2Chunks", true);
            await s_Mounter.MountSuperbundle("Win32/Levels/XP2_Factory/XP2_Factory", true);

            if (!p_Options.Quiet)
                Console.WriteLine($"Everything is now mounted! Starting audio conversion.");
            
            PartitionRegistry.ParseAndRegisterAllPartitions(s_Mounter);
            
            var s_Results = PartitionRegistry.Partitions.Where(p_Partition => p_Partition.PrimaryInstance.GetType().Name == "SoundWaveAsset");
            foreach (var s_Partition in s_Results)
            {

                var s_Asset = s_Partition.PrimaryInstance as SoundWaveAsset;

                if (s_Asset == null)
                    continue;
                
                
                // Iterate over each of the variants
                foreach (var s_VariationRef in s_Asset.Variations)
                {
                    var s_Variation = s_VariationRef.Get();

                    if (s_Variation == null)
                        continue;
                    
                    if (s_Variation.ChunkIndex > s_Asset.Chunks.Count)
                        throw new Exception("variation chunk index out of bounds");

                    var s_Chunk = s_Asset.Chunks[s_Variation.ChunkIndex];
                    
                    if (!s_Mounter.TryGetChunk(s_Chunk.ChunkId, out var s_ChunkVariant))
                        continue;

                    //byte[] s_ChunkData = null;
                    //using (var s_ChunkReader = s_ChunkVariant.FirstVariant.GetReader())
                    //    s_ChunkData = s_ChunkReader.ReadBytes((int)s_Chunk.ChunkSize);

                    using var s_ByteReader = s_ChunkVariant.FirstVariant.GetReader();
                    //using var s_ByteReader = new RimeReader(new MemoryStream(s_ChunkData));
                    //File.WriteAllBytes("/home/txt/Documents/RE/bf3/sound/sound.bin", s_ChunkData);
                    // Iterate over each of the provided segments
                    foreach (var s_Segment in s_Variation.Segments)
                    {
                        s_ByteReader.Seek(s_Segment.SamplesOffset, SeekOrigin.Begin);
                        // rw::audio::core::SndPlayerFormat1ChunkParser / rw::audio::core::SndPlayerReadFormat1ChunkHeader

                        var s_ChunkList = new List<KeyValuePair<ChunkHeader, byte[]>>();

                        while (true)
                        {
                            var s_DataChunk = new ChunkHeader(s_ByteReader);

                            if (s_DataChunk.Type == ChunkType.End)
                                break;
                            
                            var s_Data = s_ByteReader.ReadBytes((int) s_DataChunk.SizeWithoutHeader);
                            s_ChunkList.Add(new KeyValuePair<ChunkHeader, byte[]>(s_DataChunk, s_Data));
                        }
                        
                        // chunk 0 should always be header. Some quick linq to fix maybe
                        var s_SoundInfo = new SndPlayerAssetHeader(new RimeReader(new MemoryStream(s_ChunkList.Where(x => x.Key.Type == ChunkType.Header).First().Value)));

                        List<float> s_TotalOutSamples = new();

                        long s_DataChunkSampleOffset = 0;
                        var s_DataChunks = s_ChunkList.Where(x => x.Key.Type == ChunkType.Data);
                        foreach (var s_ChunkInfo in s_DataChunks)
                        {
                            if (s_ChunkInfo.Key.Type != ChunkType.Data)
                                continue;
                            
                            using var s_ChunkReader = new RimeReader(new MemoryStream(s_ChunkInfo.Value), Endianness.BigEndian);
                            
                            // rw::audio::core::SndPlayerReadFormat1DataChunk
                            var s_SampleCount = s_ChunkReader.ReadUInt32();
                        
                            // sound data comes here
                            if (s_SoundInfo.Decoder == SndPlayerCodec.XaSeekable1)
                            {
                                float[] s_OutSamples = new float[s_SoundInfo.NumChannels*s_SampleCount + 128*s_SoundInfo.NumChannels];
                                
                                for (var s_SampleChunk = 0; s_ChunkReader.Position < s_ChunkInfo.Value.Length; s_SampleChunk++)
                                {
                                    for (var s_Channel = 0; s_Channel < s_SoundInfo.NumChannels; s_Channel++)
                                    {
                                        float[] s_Samples = Xas1.DecodeChannel(s_ChunkReader);
                                        
                                        // intertwine samples so each channel comes after each other
                                        // [sample0-left], [sample0-right], [sample1-left], [sample1-right],
                                        for (var s_Sample = 0; s_Sample < s_Samples.Length; s_Sample++)
                                            s_OutSamples[s_SampleChunk*s_Samples.Length*s_SoundInfo.NumChannels + 
                                                         s_SoundInfo.NumChannels * s_Sample + 
                                                         s_Channel] = s_Samples[s_Sample];
                                    }
                                }

                                s_TotalOutSamples.AddRange(s_OutSamples);
                            }
                            else
                            {
                                
                                Console.WriteLine("Unsupported format!");
                            }
                        }


                        {
                            var s_Riff = new RiffFile();
                            s_Riff.TypeStr = "WAVE";
                            {
                                var s_FormatChunk = new RimeLib.Audio.WaveFile.AudioFormatExtended()
                                {
                                    Format = RimeLib.Audio.WaveFile.AudioFormat.AudioFormatType.Extensible,
                                    NumChannels = (ushort)s_SoundInfo.NumChannels,
                                    SampleRate = s_SoundInfo.SampleRate,
                                    AvgBytesPerSec =
                                        s_SoundInfo.SampleRate * s_SoundInfo.NumChannels * 4, //4 = sizeof(float)
                                    BlockAlign = (ushort)(s_SoundInfo.NumChannels * 4), //4 = sizeof(float)
                                    BitsPerSample = 8 * 4, //4=sizeof(float)

                                    BitsPerSample2 = 8 * 4, //4=sizeof(float)
                                    ChannelMask = (uint)(1 << (int)s_SoundInfo.NumChannels) - 1,

                                    // STATIC_KSDATAFORMAT_SUBTYPE_IEEE_FLOAT
                                    Guid = new byte[]
                                    {
                                        0x03, 0x00, 0x00, 0x00,
                                        0x00, 0x00,
                                        0x10, 0x00,
                                        0x80,
                                        0x00,
                                        0x00,
                                        0xAA,
                                        0x00,
                                        0x38,
                                        0x9b,
                                        0x71
                                    }
                                };


                                using var s_Stream = new MemoryStream();
                                s_FormatChunk.Serialize(new RimeWriter(s_Stream));
                                
                                s_Riff.Add("fmt ", s_Stream.ToArray());
                            }
                            {
                                var s_FactChunk = new RimeLib.Audio.WaveFile.FACT()
                                {
                                    SampleLength = 0x4,
                                };
                                
                                using var s_Stream = new MemoryStream();
                                s_FactChunk.Serialize(new RimeWriter(s_Stream));
                                
                                s_Riff.Add("fact", s_Stream.ToArray());
                            }
                            {
                                using var s_Stream = new MemoryStream();
                                using var s_DataWriter = new RimeWriter(s_Stream);

                                foreach (var s_Sample in s_TotalOutSamples)
                                    s_DataWriter.Write(s_Sample);
                                
                                
                                s_Riff.Add("data", s_Stream.ToArray());
                            }


                            using var s_FileStream = new FileStream($"/home/txt/Documents/RE/bf3/sound/{s_Asset.Name.Replace("/", "_")}-{s_Segment.SamplesOffset}.wav", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);

                            using var s_FileWriter = new RimeWriter(s_FileStream);

                            s_Riff.Serialize(s_FileWriter);
                        }
                        // needs to read seek table somewhere
                        // check rw::audio::core::SeekTableParser::Parse
                        
                        
                        

                    }
                }
      

            }

        }
    }
}
