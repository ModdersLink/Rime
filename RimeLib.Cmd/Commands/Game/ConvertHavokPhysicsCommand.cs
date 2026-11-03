using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite;
using RimeLib.Havok;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Builds each mounted physics resource's packfiles again in another engine's Havok from its shapes, reads the result back and writes it again byte for byte, and queries each MOPP of it with the bounds of what it is over.")]
    public class ConvertHavokPhysicsCommand : Command
    {
        [CommandArgument(Description = "The engine to build the packfiles for.")]
        public EngineType Engine { get; set; }

        [CommandArgument(Description = "Only the resources whose names start with this.", Optional = true)]
        public string Prefix { get; set; } = string.Empty;

        [CommandArgument(Description = "How many failures to list.", Optional = true)]
        public int List { get; set; } = 5;

        [CommandArgument(Description = "A directory to write each converted resource to, as <name>.bin.", Optional = true)]
        public DirectoryInfo? Dump { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Source = EngineInterfaceRegistry.Create<IHavokConverter>(s_Mounter.GetEngineType());
            var s_Target = EngineInterfaceRegistry.Create<IHavokObjectModel>(Engine);

            int s_Total = 0, s_Converted = 0, s_Trees = 0, s_Leaves = 0;
            var s_Failures = new List<string>();
            var s_Unsupported = new SortedDictionary<string, int>(StringComparer.Ordinal);
            foreach (var (s_Name, s_Resource) in s_Mounter.GetResources().OrderBy(p_R => p_R.Key, StringComparer.Ordinal))
            {
                if (s_Resource.FirstVariant.GetResourceType() != ResourceType.HavokPhysicsData || !s_Name.StartsWith(Prefix, StringComparison.OrdinalIgnoreCase))
                    continue;

                ++s_Total;
                byte[] s_Data;
                using (var s_Reader = s_Resource.FirstVariant.GetReader())
                    s_Data = s_Reader.ReadBytes((int)s_Reader.Length);

                try
                {
                    var s_Shapes = s_Source.GetShapes(s_Resource.FirstVariant, s_Mounter).ToList();
                    if (s_Shapes.Count == 0)
                    {
                        s_Unsupported["no shapes read"] = s_Unsupported.GetValueOrDefault("no shapes read") + 1;
                        continue;
                    }

                    var s_Written = s_Target.Rewrite(s_Data, s_Shapes);
                    var s_Misses = s_Target.CheckMopps(s_Written, out var s_Queried).ToList();
                    if (!s_Target.Rewrite(s_Written).AsSpan().SequenceEqual(s_Written))
                        s_Misses.Add("reads back as different objects");
                    s_Trees += s_Queried;
                    s_Leaves += s_Shapes.Count;
                    s_Failures.AddRange(s_Misses.Select(p_M => $"{s_Name}: {p_M}"));
                    if (s_Misses.Count == 0)
                        ++s_Converted;

                    if (Dump != null)
                    {
                        Dump.Create();
                        File.WriteAllBytes(Path.Combine(Dump.FullName, s_Name.Replace('/', '_') + ".bin"), s_Written);
                    }
                }
                catch (NotSupportedException s_Ex)
                {
                    s_Unsupported[s_Ex.Message] = s_Unsupported.GetValueOrDefault(s_Ex.Message) + 1;
                }
                catch (Exception s_Ex) when (s_Ex is InvalidDataException or ArgumentException)
                {
                    s_Failures.Add($"{s_Name}: {s_Ex.Message}");
                }
            }

            foreach (var (s_Reason, s_Count) in s_Unsupported.OrderByDescending(p_U => p_U.Value))
                p_Writer.WriteLine($"{s_Count,6} not converted: {s_Reason}");
            foreach (var s_Line in s_Failures.Take(List))
                p_Writer.WriteLine($"  {s_Line}");

            p_Writer.WriteLine($"convert_havok_physics: {s_Converted}/{s_Total} physics resource(s) built for {Engine} from {s_Leaves} shape(s), {s_Trees} MOPP(s) queried, {s_Failures.Count} failure(s).");
            return s_Failures.Count == 0;
        }
    }
}
