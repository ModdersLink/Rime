using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Mesh.Sets;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Reads every mounted MeshSet into the engine-independent model and checks that writing it back gives the same bytes, then fits it to another mounted game's engine, writes it with that engine's codec and reads it back, reporting what the target has no room for.")]
    public class CheckMeshConversionCommand : Command
    {
        [CommandArgument(Description = "Id of the mounted game to convert to.")]
        public int Target { get; set; }

        [CommandArgument(Description = "How many MeshSets to list per failure.", Optional = true)]
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

            var s_From = EngineInterfaceRegistry.Create<IMeshSetCodec>(s_Source.GetEngineType());
            var s_To = EngineInterfaceRegistry.Create<IMeshSetCodec>(s_Target.GetEngineType());

            var s_Dropped = new Dictionary<string, int>(StringComparer.Ordinal);
            var s_Failures = new Dictionary<string, List<string>>(StringComparer.Ordinal);
            int s_Sets = 0, s_Converted = 0;

            foreach (var (s_Name, s_Resource) in s_Source.GetResources()
                         .Where(p_R => p_R.Value.FirstVariant.GetResourceType() == ResourceType.MeshSet)
                         .OrderBy(p_R => p_R.Key, StringComparer.Ordinal))
            {
                s_Sets++;
                try
                {
                    var s_Payload = Read(s_Resource.FirstVariant);
                    var s_Model = s_From.Decode(s_Payload);
                    Same(s_From.Encode(s_Model, s_Payload), s_Payload, "written back");

                    var s_Fitted = MeshSetConversion.ToEngine(s_Model, s_To, out var s_Drops);
                    var s_Written = s_To.Encode(s_Fitted);
                    Same(s_To.Encode(s_To.Decode(s_Written), s_Written), s_Written, "converted and read back");

                    foreach (var s_Drop in s_Drops)
                        s_Dropped[s_Drop] = s_Dropped.GetValueOrDefault(s_Drop) + 1;
                    s_Converted++;
                }
                catch (Exception s_Ex) when (s_Ex is InvalidDataException or NotSupportedException or ArgumentException)
                {
                    if (!s_Failures.TryGetValue(s_Ex.Message, out var s_Names))
                        s_Failures[s_Ex.Message] = s_Names = new List<string>();
                    s_Names.Add(s_Name);
                }
            }

            if (s_Dropped.Count > 0)
                p_Writer.WriteLine("Dropped, as the target has no room for them:");
            foreach (var (s_Drop, s_Count) in s_Dropped.OrderByDescending(p_D => p_D.Value))
                p_Writer.WriteLine($"  {s_Drop,-36} in {s_Count,6} MeshSet(s)");

            foreach (var (s_Reason, s_Names) in s_Failures.OrderByDescending(p_F => p_F.Value.Count))
            {
                p_Writer.WriteLine($"{s_Names.Count} not converted: {s_Reason}");
                foreach (var s_Name in s_Names.Take(List))
                    p_Writer.WriteLine($"  {s_Name}");
            }

            p_Writer.WriteLine($"check_mesh_conversion: {s_Converted}/{s_Sets} converted to {s_Target.GetEngineType()}.");
            return s_Converted == s_Sets;
        }

        private static MeshSetPayload Read(IResourceObject p_Variant)
        {
            if (!p_Variant.TryGetMeta(out var s_Meta))
                throw new InvalidDataException("a MeshSet without meta");

            using var s_Reader = p_Variant.GetReader();
            return new MeshSetPayload(s_Reader.ReadBytes((int)s_Reader.Length), s_Meta);
        }

        private static void Same(MeshSetPayload p_Written, MeshSetPayload p_Expected, string p_How)
        {
            if (!p_Written.Data.AsSpan().SequenceEqual(p_Expected.Data) || !p_Written.Meta.AsSpan().SequenceEqual(p_Expected.Meta))
                throw new InvalidDataException($"different bytes when {p_How}");
        }
    }
}
