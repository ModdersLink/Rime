using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Reads each partition of a bundle (or one partition), writes it back with the engine's EBX
    /// writer and compares the bytes with the shipped ones.
    /// </summary>
    [CommandDescription("Reads and rewrites the partitions of a bundle (or one partition) and compares the written bytes with the shipped ones.")]
    public class RoundTripPartitionsCommand : Command
    {
        [CommandArgument(Description = "A bundle name (e.g. win32/levels/mp/mp_siege/conquestlarge0) or a partition name.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "How many partitions to try at most (0 = all).", Optional = true)]
        public int Limit { get; set; } = 0;

        [CommandArgument(Description = "Directory to write differing partitions to (shipped and written), for inspection.", Optional = true)]
        public DirectoryInfo? Output { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());
            var s_Generator = EngineInterfaceRegistry.Create<IPartitionGenerator>(s_Mounter.GetEngineType());

            var s_Names = s_Mounter.TryGetPartition(Name!.ToLowerInvariant(), out _)
                ? new List<string> { Name!.ToLowerInvariant() }
                : s_Mounter.GetPartitionsInBundle(Name!).ToList();
            if (Limit > 0)
                s_Names = s_Names.Take(Limit).ToList();

            int s_Same = 0, s_Different = 0, s_Failed = 0, s_SameContent = 0;
            var s_Reasons = new Dictionary<string, int>();
            foreach (var s_Name in s_Names)
            {
                if (!s_Mounter.TryGetPartition(s_Name.ToLowerInvariant(), out var s_Mounted))
                    continue;

                byte[] s_Shipped;
                using (var s_Reader = s_Mounted.FirstVariant.GetReader())
                    s_Shipped = s_Reader.ReadBytes((int)s_Reader.Length);

                try
                {
                    var s_Partition = s_Converter.FromPartitionObject(s_Name, s_Mounted.FirstVariant);
                    var s_Stream = new MemoryStream();
                    using (var s_Writer = new RimeWriter(s_Stream))
                        s_Generator.Generate(s_Partition, s_Writer);
                    var s_Written = s_Stream.ToArray();

                    if (s_Written.AsSpan().SequenceEqual(s_Shipped))
                    {
                        ++s_Same;
                        continue;
                    }

                    ++s_Different;

                    // Different bytes can still hold the same content: read the written partition
                    // back and compare what both parse to.
                    var s_Reread = s_Converter.FromPartitionObject(s_Name, new BytesVariant(s_Written));
                    if (s_Reread.ToJsonString() == s_Partition.ToJsonString())
                    {
                        ++s_SameContent;
                        continue;
                    }

                    var s_First = 0;
                    while (s_First < System.Math.Min(s_Written.Length, s_Shipped.Length) && s_Written[s_First] == s_Shipped[s_First])
                        ++s_First;
                    var s_Reason = s_Written.Length != s_Shipped.Length ? "size differs" : "content differs";
                    s_Reasons[s_Reason] = s_Reasons.GetValueOrDefault(s_Reason) + 1;
                    if (Output != null)
                    {
                        Directory.CreateDirectory(Output.FullName);
                        var s_File = Path.Combine(Output.FullName, s_Name.Replace('/', '_'));
                        File.WriteAllBytes(s_File + ".shipped", s_Shipped);
                        File.WriteAllBytes(s_File + ".written", s_Written);
                    }
                    if (s_Different - s_SameContent <= 15)
                        p_Writer.WriteLine($"  DIFF {s_Name}: {s_Shipped.Length} shipped, {s_Written.Length} written, first difference at {s_First}");
                }
                catch (Exception s_Exception)
                {
                    ++s_Failed;
                    var s_Reason = s_Exception.GetType().Name + ": " + s_Exception.Message.Split('\n')[0];
                    s_Reasons[s_Reason] = s_Reasons.GetValueOrDefault(s_Reason) + 1;
                    if (s_Failed <= 5)
                        p_Writer.WriteLine($"  FAIL {s_Name}: {s_Reason}");
                }
            }

            p_Writer.WriteLine($"{s_Same} identical, {s_Different} different ({s_SameContent} of them with the same content), {s_Failed} failed of {s_Names.Count}.");
            foreach (var (s_Reason, s_Count) in s_Reasons.OrderByDescending(p_R => p_R.Value).Take(10))
                p_Writer.WriteLine($"  {s_Count,6}  {s_Reason}");
            return true;
        }
    
        /// <summary>Written bytes, readable like a mounted partition.</summary>
        private class BytesVariant : IObjectVariant
        {
            private readonly byte[] m_Data;

            public BytesVariant(byte[] p_Data)
            {
                m_Data = p_Data;
            }

            public bool Cas => false;
            public RimeReader GetReader() => new(new MemoryStream(m_Data, false));
            public long GetSize() => m_Data.Length;
            public RimeLib.Frostbite.Core.Sha1? GetSha1() => null;
            public string GetContainedSuperbundle() => "";
            public string? GetContainedBundle() => null;
        }
    }
}
