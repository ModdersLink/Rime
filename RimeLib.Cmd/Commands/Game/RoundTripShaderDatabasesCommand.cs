using System;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Reads every mounted shader database and writes it back, reporting any that do not come out byte-identical.")]
    public class RoundTripShaderDatabasesCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Context = (GameContext)p_Context;
            var s_Builder = EngineInterfaceRegistry.Create<IShaderDatabaseBuilder>(s_Context.GetMounter().GetEngineType());

            int s_Same = 0, s_Total = 0;
            foreach (var (s_Name, s_Resource) in s_Context.GetMountedResourceVariations().OrderBy(p_R => p_R.Key, StringComparer.Ordinal))
            {
                if (s_Resource.FirstVariant.GetResourceType() is not (ResourceType.IShaderDatabase or ResourceType.DxShaderDatabase))
                    continue;

                s_Total++;
                using var s_Reader = s_Resource.FirstVariant.GetReader();
                var s_Data = s_Reader.ReadBytes((int)s_Reader.Length);
                try
                {
                    p_Writer.WriteLine($"{s_Name} ({s_Data.Length} bytes)\n  {s_Builder.Describe(s_Data).Replace("\n", "\n  ")}");
                    var s_Written = s_Builder.RoundTrip(s_Data);
                    if (s_Written.AsSpan().SequenceEqual(s_Data))
                    {
                        s_Same++;
                        continue;
                    }

                    var s_Diff = Enumerable.Range(0, System.Math.Min(s_Data.Length, s_Written.Length)).FirstOrDefault(i => s_Data[i] != s_Written[i], -1);
                    p_Writer.WriteLine($"DIFF {s_Name}: {s_Data.Length} bytes read, {s_Written.Length} written, first difference at {s_Diff}.");
                }
                catch (Exception s_Ex)
                {
                    p_Writer.WriteLine($"FAIL {s_Name}: {s_Ex.Message}");
                }
            }

            p_Writer.WriteLine($"round_trip_shader_databases: {s_Same}/{s_Total} byte-identical.");
            return s_Same == s_Total;
        }
    }
}
