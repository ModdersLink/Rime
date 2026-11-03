using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.IO;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Converts the partitions of a bundle (or one partition) to another mounted game's engine by type and field name, writes each with that engine's EBX writer and reads it back, reporting what the target's types cannot hold.")]
    public class CheckPartitionConversionCommand : Command
    {
        [CommandArgument(Description = "Id of the mounted game to convert to.")]
        public int Target { get; set; }

        [CommandArgument(Description = "A bundle name (e.g. win32/levels/mp/mp_prison/mp_prison) or a partition name.")]
        public string Name { get; set; } = "";

        [CommandArgument(Description = "How many entries to list per kind of loss.", Optional = true)]
        public int Top { get; set; } = 15;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Game = (GameContext)p_Context;
            var s_Source = s_Game.GetMounter();
            if (!((BaseContext)s_Game.Parent!).GetMounters().TryGetValue(Target, out var s_Target))
            {
                p_Writer.WriteLine($"No game is mounted with id {Target}.");
                return false;
            }

            var s_Reader = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Source.GetEngineType());
            var s_TargetReader = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Target.GetEngineType());
            var s_TargetWriter = EngineInterfaceRegistry.Create<IPartitionGenerator>(s_Target.GetEngineType());
            var s_Rules = EngineInterfaceRegistry.IsSupported<IConversionRules>(s_Source.GetEngineType())
                ? EngineInterfaceRegistry.Create<IConversionRules>(s_Source.GetEngineType()).For(s_Target.GetEngineType())
                : null;
            var s_Conversion = new PartitionConversion(EngineInterfaceRegistry.Create<IEbxTypeLibrary>(s_Target.GetEngineType()), s_Rules);

            var s_Name = Name.ToLowerInvariant();
            var s_Names = s_Source.TryGetPartition(s_Name, out _) ? [s_Name] : s_Source.GetPartitionsInBundle(Name).ToList();

            var s_Failures = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            var s_Converted = 0;
            foreach (var s_Partition in s_Names)
            {
                if (!s_Source.TryGetPartition(s_Partition.ToLowerInvariant(), out var s_Mounted))
                    continue;

                try
                {
                    var s_Written = Write(s_TargetWriter, s_Conversion.Convert(s_Reader.FromPartitionObject(s_Partition, s_Mounted.FirstVariant)));
                    var s_Read = s_TargetReader.FromPartitionObject(s_Partition,
                        new BundlePartitionVariant(new SbBuildingContext.MemoryReader(s_Written), Name));
                    if (!Write(s_TargetWriter, s_Read).AsSpan().SequenceEqual(s_Written))
                        throw new InvalidDataException("written differently after reading it back");
                    s_Converted++;
                }
                catch (Exception s_Ex) when (s_Ex is InvalidDataException or NotSupportedException or ArgumentException or InvalidCastException)
                {
                    var s_Reason = s_Ex.Message.Split('\n')[0];
                    if (!s_Failures.TryGetValue(s_Reason, out var s_List))
                        s_Failures[s_Reason] = s_List = new List<string>();
                    s_List.Add(s_Partition);
                }
            }

            s_Conversion.Report.WriteTo(p_Writer, Top);
            foreach (var (s_Reason, s_List) in s_Failures.OrderByDescending(p_F => p_F.Value.Count))
            {
                p_Writer.WriteLine($"{s_List.Count} not converted: {s_Reason}");
                foreach (var s_Partition in s_List.Take(3))
                    p_Writer.WriteLine($"  {s_Partition}");
            }

            p_Writer.WriteLine($"check_partition_conversion: {s_Converted}/{s_Names.Count} partition(s) converted to {s_Target.GetEngineType()}.");
            return s_Converted == s_Names.Count;
        }

        private static byte[] Write(IPartitionGenerator p_Writer, DatabasePartitionBase p_Partition)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                p_Writer.Generate(p_Partition, s_Writer);
            return s_Stream.ToArray();
        }
    }
}
