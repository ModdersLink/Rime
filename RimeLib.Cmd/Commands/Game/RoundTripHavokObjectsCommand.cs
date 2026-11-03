using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Havok;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Writes each mounted physics resource's packfiles again from their Havok objects and compares the bytes, counting the resources with classes the object model lacks apart.")]
    public class RoundTripHavokObjectsCommand : Command
    {
        [CommandArgument(Description = "How many differing resources to list.", Optional = true)]
        public int List { get; set; } = 5;

        [CommandArgument(Description = "A directory to write each differing resource to: <name>.bin as read and .out as written.", Optional = true)]
        public DirectoryInfo? Dump { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Model = EngineInterfaceRegistry.Create<IHavokObjectModel>(s_Mounter.GetEngineType());

            int s_Total = 0, s_Same = 0;
            var s_Differing = new List<string>();
            var s_Unmodelled = new SortedDictionary<string, int>(StringComparer.Ordinal);
            foreach (var (s_Name, s_Resource) in s_Mounter.GetResources().OrderBy(p_R => p_R.Key, StringComparer.Ordinal))
            {
                if (s_Resource.FirstVariant.GetResourceType() != ResourceType.HavokPhysicsData)
                    continue;

                ++s_Total;
                byte[] s_Data;
                using (var s_Reader = s_Resource.FirstVariant.GetReader())
                    s_Data = s_Reader.ReadBytes((int)s_Reader.Length);

                try
                {
                    var s_Written = s_Model.Rewrite(s_Data);
                    if (s_Written.AsSpan().SequenceEqual(s_Data))
                        ++s_Same;
                    else
                    {
                        s_Differing.Add($"{s_Name}: {s_Data.Length} bytes read, {s_Written.Length} written, first difference at 0x{FirstDifference(s_Data, s_Written):X}");
                        if (Dump != null)
                        {
                            Dump.Create();
                            var s_File = Path.Combine(Dump.FullName, s_Name.Replace('/', '_'));
                            File.WriteAllBytes(s_File + ".bin", s_Data);
                            File.WriteAllBytes(s_File + ".out", s_Written);
                        }
                    }
                }
                catch (NotSupportedException s_Ex)
                {
                    s_Unmodelled[s_Ex.Message] = s_Unmodelled.GetValueOrDefault(s_Ex.Message) + 1;
                }
                catch (InvalidDataException s_Ex)
                {
                    s_Differing.Add($"{s_Name}: {s_Ex.Message}");
                }
            }

            foreach (var (s_Reason, s_Count) in s_Unmodelled.OrderByDescending(p_U => p_U.Value))
                p_Writer.WriteLine($"{s_Count,6} not modelled: {s_Reason}");
            foreach (var s_Line in s_Differing.Take(List))
                p_Writer.WriteLine($"  {s_Line}");

            var s_Modelled = s_Total - s_Unmodelled.Values.Sum();
            p_Writer.WriteLine($"round_trip_havok_objects: {s_Same}/{s_Modelled} modelled physics resource(s) written byte for byte, {s_Total - s_Modelled} of {s_Total} with classes not modelled.");
            return s_Differing.Count == 0;
        }

        private static int FirstDifference(byte[] p_A, byte[] p_B)
        {
            var s_Length = System.Math.Min(p_A.Length, p_B.Length);
            for (var i = 0; i < s_Length; ++i)
                if (p_A[i] != p_B[i])
                    return i;
            return s_Length;
        }
    }
}
