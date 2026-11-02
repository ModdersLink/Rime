using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Reads every mounted resource of the types the engine has structs for and writes it back, reporting per type how many come out byte-identical, and which types have no struct.")]
    public class RoundTripResourcesCommand : Command
    {
        [CommandArgument(Description = "Only this resource type.", Optional = true)]
        public string? Type { get; set; }

        [CommandArgument(Description = "How many differing resources to list per type.", Optional = true)]
        public int List { get; set; } = 3;

        [CommandArgument(Description = "A directory to write every differing resource to: <name>.bin as read, .meta and .out as written.", Optional = true)]
        public DirectoryInfo? Dump { get; set; }

        /// <summary>Every IResourceStructs of the loaded assemblies that supports the engine.</summary>
        private static List<IResourceStructs> Providers(RimeLib.Frostbite.EngineType p_Engine)
        {
            var s_Providers = new List<IResourceStructs>();
            foreach (var s_Assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type[] s_Types;
                try
                {
                    s_Types = s_Assembly.GetTypes();
                }
                catch (System.Reflection.ReflectionTypeLoadException s_Ex)
                {
                    s_Types = s_Ex.Types.Where(p_T => p_T != null).ToArray()!;
                }

                foreach (var s_Type in s_Types.Where(p_T => !p_T.IsAbstract && !p_T.IsInterface && typeof(IResourceStructs).IsAssignableFrom(p_T)))
                {
                    if (Activator.CreateInstance(s_Type) is IResourceStructs s_Provider && s_Provider.GetSupportedEngines().Contains(p_Engine))
                        s_Providers.Add(s_Provider);
                }
            }

            return s_Providers;
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_ByType = new Dictionary<ResourceType, IResourceStructs>();
            foreach (var s_Provider in Providers(s_Mounter.GetEngineType()))
            foreach (var s_Type in s_Provider.Types)
                s_ByType.TryAdd(s_Type, s_Provider);

            var s_Stats = new SortedDictionary<string, (int Total, int Same, List<string> Differing)>(StringComparer.Ordinal);
            foreach (var (s_Name, s_Resource) in s_Mounter.GetResources().OrderBy(p_R => p_R.Key, StringComparer.Ordinal))
            {
                var s_Variant = s_Resource.FirstVariant;
                var s_Type = s_Variant.GetResourceType();
                if (Type != null && !string.Equals(s_Type.ToString(), Type, StringComparison.OrdinalIgnoreCase))
                    continue;

                var s_Key = s_Type.ToString();
                var s_Entry = s_Stats.TryGetValue(s_Key, out var s_Found) ? s_Found : (Total: 0, Same: 0, Differing: new List<string>());
                s_Entry.Total++;

                if (s_ByType.TryGetValue(s_Type, out var s_Provider))
                {
                    string? s_Problem = null;
                    try
                    {
                        byte[] s_Data;
                        using (var s_Reader = s_Variant.GetReader())
                            s_Data = s_Reader.ReadBytes((int)s_Reader.Length);
                        s_Variant.TryGetMeta(out var s_Meta);

                        byte[]? s_Written = null;
                        try
                        {
                            s_Written = s_Provider.RoundTrip(s_Type, s_Data, s_Meta);
                            s_Problem = s_Written.AsSpan().SequenceEqual(s_Data)
                                ? null
                                : $"{s_Data.Length} bytes read, {s_Written.Length} written, first difference at {FirstDifference(s_Data, s_Written)}";
                        }
                        finally
                        {
                            if (Dump != null && (s_Written == null || s_Problem != null))
                                DumpDiffering(s_Name, s_Data, s_Meta, s_Written);
                        }
                    }
                    catch (Exception s_Ex)
                    {
                        s_Problem = s_Ex.Message;
                    }

                    if (s_Problem == null)
                        s_Entry.Same++;
                    else if (s_Entry.Differing.Count < List)
                        s_Entry.Differing.Add($"{s_Name}: {s_Problem}");
                }

                s_Stats[s_Key] = s_Entry;
            }

            var s_AllSame = true;
            foreach (var (s_Type, (s_Total, s_Same, s_Differing)) in s_Stats.OrderByDescending(p_S => p_S.Value.Total))
            {
                var s_Has = Enum.TryParse<ResourceType>(s_Type, out var s_Parsed) && s_ByType.ContainsKey(s_Parsed);
                p_Writer.WriteLine(s_Has ? $"{s_Type,-32} {s_Same,6} of {s_Total,6} byte-identical" : $"{s_Type,-32} {s_Total,6} resource(s), no struct");
                foreach (var s_Line in s_Differing)
                    p_Writer.WriteLine($"    DIFF {s_Line}");
                s_AllSame &= !s_Has || s_Same == s_Total;
            }

            return s_AllSame;
        }

        private void DumpDiffering(string p_Name, byte[] p_Data, byte[]? p_Meta, byte[]? p_Written)
        {
            var s_Path = Path.Combine(Dump!.FullName, p_Name.Replace('/', '_'));
            Directory.CreateDirectory(Dump.FullName);
            File.WriteAllBytes(s_Path + ".bin", p_Data);
            if (p_Meta != null)
                File.WriteAllBytes(s_Path + ".meta", p_Meta);
            if (p_Written != null)
                File.WriteAllBytes(s_Path + ".out", p_Written);
        }

        private static int FirstDifference(byte[] p_A, byte[] p_B)
        {
            for (var i = 0; i < System.Math.Min(p_A.Length, p_B.Length); ++i)
            {
                if (p_A[i] != p_B[i])
                    return i;
            }

            return p_A.Length == p_B.Length ? -1 : System.Math.Min(p_A.Length, p_B.Length);
        }
    }
}
