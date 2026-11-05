using System;
using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Serialization.Frostbite2_0.Ebx;

/// <summary>Writes every mounted partition's <see cref="StreamingPartitionHeader"/> back and compares it with the shipped bytes.</summary>
public class PartitionHeaderRoundTrip : IWriterRoundTrip
{
    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public void Run(IEngineMounter p_Mounter, int p_Limit, TextWriter p_Writer) => TestPartitionHeaders(p_Mounter, p_Limit, p_Writer);

    // ---------------------------------------------------------------- partition headers

    private static void TestPartitionHeaders(IEngineMounter p_Mounter, int p_Limit, TextWriter p_Writer)
    {
        var s_Partitions = p_Mounter.GetPartitions();
        var s_Total = 0;
        var s_Identical = 0;
        var s_Unreadable = 0;
        var s_FirstFailure = string.Empty;

        foreach (var l_Pair in s_Partitions)
        {
            if (p_Limit > 0 && s_Total >= p_Limit)
                break;

            byte[] s_Payload;

            try
            {
                s_Payload = WriterRoundTrip.ReadAll(l_Pair.Value.FirstVariant);
            }
            catch (Exception)
            {
                ++s_Unreadable;
                continue;
            }

            // 80 bytes: the Frostbite 2.0 header. A partition shorter than that is not one.
            if (s_Payload.Length < 80)
            {
                ++s_Unreadable;
                continue;
            }

            ++s_Total;

            var s_Header = new StreamingPartitionHeader();

            using (var s_Reader = new RimeReader(new MemoryStream(s_Payload)))
                s_Header.Deserialize(s_Reader);

            if (!s_Header.Serialize(out var s_Written) || s_Written.Length != 80)
            {
                if (s_FirstFailure.Length == 0)
                    s_FirstFailure = $"{l_Pair.Key} (writer produced {(s_Written?.Length ?? -1)} bytes)";

                continue;
            }

            var s_Diff = WriterRoundTrip.FirstDiff(s_Payload, 0, s_Written);

            if (s_Diff < 0)
                ++s_Identical;
            else if (s_FirstFailure.Length == 0)
                s_FirstFailure = $"{l_Pair.Key} @ 0x{s_Diff:X}";
        }

        p_Writer.WriteLine($"STREAMINGPARTITIONHEADER {s_Identical} of {s_Total} byte-identical " +
                           $"(unreadable={s_Unreadable}) {(s_Total > 0 && s_Identical == s_Total ? "PASS" : "FAIL")}");

        if (s_FirstFailure.Length > 0)
            p_Writer.WriteLine($"  first mismatch: {s_FirstFailure}");

        if (s_Total == 0)
            p_Writer.WriteLine("  NOTHING TESTED -- the corpus was empty, so the verdict above means nothing.");
    }
}
