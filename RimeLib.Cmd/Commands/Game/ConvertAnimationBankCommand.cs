using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using RimeLib.Animation.EA.GenericData;
using RimeLib.Animation.Frostbite;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Converts a mounted AnimationSet bank to another mounted game's engine, writes it, reads it back and writes that again with the target's writer, and optionally compares its objects with a bank of the target's.")]
    public class ConvertAnimationBankCommand : Command
    {
        [CommandArgument(Description = "The bank's AssetBank resource, named after its AntAnimationSetAsset partition.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id of the mounted game to convert to.")]
        public int Target { get; set; }

        [CommandArgument(Description = "The file to write the converted bank to.")]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "A bank of the target's to compare the converted one with, object by object.", Optional = true)]
        public string? Compare { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Game = (GameContext)p_Context;
            var s_Source = s_Game.GetMounter();
            if (!((BaseContext)s_Game.Parent!).GetMounters().TryGetValue(Target, out var s_Target))
            {
                p_Writer.WriteLine($"No game is mounted with id {Target}.");
                return false;
            }

            if (Read(s_Source, Name!, p_Writer) is not { } s_Data)
            {
                p_Writer.WriteLine($"{Name} is not a mounted resource.");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IAnimationBankConverter>(s_Source.GetEngineType());
            var s_Converted = s_Converter.Convert(s_Data, s_Target.GetEngineType(), p_Writer);
            File.WriteAllBytes(Destination!.FullName, s_Converted);

            var s_Bank = new AnimationSetBank();
            s_Bank.Deserialize(s_Converted);
            p_Writer.WriteLine($"{Name}: {s_Data.Length} bytes, {s_Converted.Length} converted, {s_Bank.Archive.Objects.Count} objects in {s_Bank.Archive.Reflection!.Layouts.Length} layouts, packaging {s_Bank.PackagingType}");

            var s_Structs = ResourceTypeProviders.ByType<IResourceStructs>(s_Target.GetEngineType(), p_P => p_P.Types);
            var s_Same = true;
            if (s_Structs.TryGetValue(ResourceType.AssetBank, out var s_Writer))
            {
                s_Same = s_Writer.RoundTrip(ResourceType.AssetBank, s_Converted, null).AsSpan().SequenceEqual(s_Converted);
                p_Writer.WriteLine(s_Same ? "the target's writer writes it back byte-identical" : "the target's writer writes it back DIFFERENT");
            }

            if (Compare != null)
            {
                if (Read(s_Target, Compare, p_Writer) is not { } s_Theirs)
                {
                    p_Writer.WriteLine($"{Compare} is not a resource of the target.");
                    return false;
                }

                var s_Other = new AnimationSetBank();
                s_Other.Deserialize(s_Theirs);
                CompareBanks(s_Bank.Archive.Objects, s_Other.Archive.Objects, p_Writer);
            }

            return s_Same;
        }

        private static byte[]? Read(IEngineMounter p_Mounter, string p_Name, TextWriter p_Writer)
        {
            if (!p_Mounter.TryGetResource(p_Name.ToLowerInvariant(), out var s_Resource) || s_Resource.FirstVariant == null)
                return null;

            p_Writer.WriteLine(s_Resource.FirstVariant.TryGetMeta(out var s_Meta) && s_Meta != null
                ? $"{p_Name}: meta {Convert.ToHexString(s_Meta)}"
                : $"{p_Name}: no meta");

            using var s_Reader = s_Resource.FirstVariant.GetReader();
            return s_Reader.ReadBytes((int)s_Reader.Length);
        }

        /// <summary>
        /// Pairs the objects of two banks by layout and name, in order where several share both, and
        /// writes the fields that differ. An id is written as the object it names, as two banks
        /// number their objects each their own way.
        /// </summary>
        private static void CompareBanks(List<Instance> p_Ours, List<Instance> p_Theirs, TextWriter p_Writer)
        {
            var s_OurIds = Ids(p_Ours);
            var s_TheirIds = Ids(p_Theirs);
            var s_Unmatched = p_Theirs.ToList();
            var s_Same = 0;

            foreach (var s_Ours in p_Ours)
            {
                var s_Theirs = s_Unmatched.FirstOrDefault(p_T => Key(p_T) == Key(s_Ours));
                if (s_Theirs == null)
                {
                    p_Writer.WriteLine($"  only converted: {Key(s_Ours)}");
                    continue;
                }

                s_Unmatched.Remove(s_Theirs);
                var s_Differences = new List<string>();
                Differences(s_Ours, s_Theirs, "", s_OurIds, s_TheirIds, s_Differences);

                if (s_Differences.Count == 0)
                {
                    s_Same++;
                    continue;
                }

                p_Writer.WriteLine($"  {Key(s_Ours)}:");
                foreach (var s_Difference in s_Differences.Take(12))
                    p_Writer.WriteLine($"    {s_Difference}");
            }

            foreach (var s_Theirs in s_Unmatched)
                p_Writer.WriteLine($"  only the target's: {Key(s_Theirs)}");

            p_Writer.WriteLine($"{s_Same} of {p_Ours.Count} converted objects as the target's ({p_Theirs.Count} there)");
        }

        private static string Key(Instance p_Object) => $"{p_Object.Layout.Name} '{(p_Object.Has("__name") ? p_Object["__name"] : null)}'";

        private static Dictionary<Guid, Instance> Ids(List<Instance> p_Objects) =>
            p_Objects.Where(p_O => p_O.Has("__guid")).GroupBy(p_O => (Guid)p_O["__guid"]!).ToDictionary(p_G => p_G.Key, p_G => p_G.First());

        private static void Differences(object? p_Ours, object? p_Theirs, string p_Path, Dictionary<Guid, Instance> p_OurIds,
            Dictionary<Guid, Instance> p_TheirIds, List<string> p_Differences)
        {
            switch (p_Ours, p_Theirs)
            {
                case (Instance s_A, Instance s_B):
                    if (s_A.Layout.Name != s_B.Layout.Name)
                    {
                        p_Differences.Add($"{p_Path}: {s_A.Layout.Name} | {s_B.Layout.Name}");
                        return;
                    }

                    for (var i = 0; i < s_A.Layout.Fields.Length; i++)
                    {
                        if (s_A.Layout.Fields[i].Name == "__guid")
                            continue;

                        Differences(s_A.Values[i], s_B.Values[i], p_Path.Length == 0 ? s_A.Layout.Fields[i].Name : $"{p_Path}.{s_A.Layout.Fields[i].Name}",
                            p_OurIds, p_TheirIds, p_Differences);
                    }
                    return;

                case (List<object?> s_A, List<object?> s_B):
                    if (s_A.Count != s_B.Count)
                    {
                        p_Differences.Add($"{p_Path}: {s_A.Count} elements | {s_B.Count}");
                        return;
                    }

                    var s_Before = p_Differences.Count;
                    for (var i = 0; i < s_A.Count && p_Differences.Count - s_Before < 3; i++)
                        Differences(s_A[i], s_B[i], $"{p_Path}[{i}]", p_OurIds, p_TheirIds, p_Differences);
                    return;
            }

            var s_Ours = Describe(p_Ours, p_OurIds);
            var s_Theirs = Describe(p_Theirs, p_TheirIds);
            if (s_Ours != s_Theirs)
                p_Differences.Add($"{p_Path}: {s_Ours} | {s_Theirs}");
        }

        private static string Describe(object? p_Value, Dictionary<Guid, Instance> p_Ids) => p_Value switch
        {
            null => "null",
            Guid s_Guid when s_Guid == Guid.Empty => "none",
            Guid s_Guid => p_Ids.TryGetValue(s_Guid, out var s_Object) ? $"-> {Key(s_Object)}" : $"-> missing {s_Guid}",
            float s_Float => s_Float.ToString("R", CultureInfo.InvariantCulture),
            _ => Convert.ToString(p_Value, CultureInfo.InvariantCulture) ?? "",
        };
    }
}
