using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace RimeLib.Cmd
{
    /// <summary>
    /// Runs the shader translator (RimeShaderEditor --retarget-batch) over pairs of a converted shader's g-buffer
    /// pixel shader and a pixel shader of its stand-in: each comes back as the converted shader's maths re-emitted
    /// for the stand-in's contract, compiled, or as nothing where it did not translate.
    /// </summary>
    internal static class ShaderTranslation
    {
        /// <summary>A pair to translate: the source pixel shader, the target pixel shader it is re-emitted for.</summary>
        public sealed record Job(byte[] Source, byte[] Target);

        /// <summary>A translated pixel shader; LightmapTermMissing when the target binds a lightmap its translation does not write.</summary>
        public sealed record Result(byte[] Bytecode, bool LightmapTermMissing);

        /// <summary>The elements of a pixel shader's output signature - four for the g-buffer - or -1 where it has none.</summary>
        public static int Outputs(byte[] p_Dxbc)
        {
            if (p_Dxbc.Length < 32 || Encoding.ASCII.GetString(p_Dxbc, 0, 4) != "DXBC")
                return -1;

            var s_Chunks = BitConverter.ToInt32(p_Dxbc, 28);
            for (var i = 0; i < s_Chunks && 32 + 4 * i + 4 <= p_Dxbc.Length; i++)
            {
                var s_Offset = BitConverter.ToInt32(p_Dxbc, 32 + 4 * i);
                if (s_Offset < 0 || s_Offset + 12 > p_Dxbc.Length)
                    continue;

                var s_Tag = Encoding.ASCII.GetString(p_Dxbc, s_Offset, 4);
                if (s_Tag is "OSGN" or "OSG5" or "OSG1")
                    return BitConverter.ToInt32(p_Dxbc, s_Offset + 8);
            }

            return -1;
        }

        /// <summary>Each job's translation, null where it did not translate; logs how many did.</summary>
        public static IReadOnlyList<Result?> Run(string p_Translator, IReadOnlyList<Job> p_Jobs, TextWriter p_Log)
        {
            var s_Results = new Result?[p_Jobs.Count];
            if (p_Jobs.Count == 0)
                return s_Results;

            var s_Directory = Directory.CreateTempSubdirectory("rime-shader-translation-");
            try
            {
                var s_Lines = new List<string>();
                for (var i = 0; i < p_Jobs.Count; i++)
                {
                    var s_Source = Path.Combine(s_Directory.FullName, $"{i}.source.dxbc");
                    var s_Target = Path.Combine(s_Directory.FullName, $"{i}.target.dxbc");
                    File.WriteAllBytes(s_Source, p_Jobs[i].Source);
                    File.WriteAllBytes(s_Target, p_Jobs[i].Target);
                    s_Lines.Add($"{s_Source}\t{s_Target}\t{Path.Combine(s_Directory.FullName, i.ToString())}");
                }

                // The translator takes its jobs one after another, each independent of the others and
                // writing its own files: a batch per core translates them side by side.
                var s_Batches = System.Math.Clamp(s_Lines.Count / 16, 1, Environment.ProcessorCount);
                System.Threading.Tasks.Parallel.For(0, s_Batches, new System.Threading.Tasks.ParallelOptions { MaxDegreeOfParallelism = s_Batches }, b =>
                {
                    var s_JobFile = Path.Combine(s_Directory.FullName, $"jobs.{b}.tsv");
                    File.WriteAllLines(s_JobFile, s_Lines.Where((_, i) => i % s_Batches == b));

                    var s_Start = new ProcessStartInfo(p_Translator)
                    {
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                    };
                    s_Start.ArgumentList.Add("--retarget-batch");
                    s_Start.ArgumentList.Add(s_JobFile);

                    using var s_Process = Process.Start(s_Start) ?? throw new InvalidOperationException($"could not start {p_Translator}");
                    var s_Error = s_Process.StandardError.ReadToEndAsync();
                    var s_Output = s_Process.StandardOutput.ReadToEnd();
                    s_Process.WaitForExit();
                    File.WriteAllText(Path.Combine(s_Directory.FullName, $"output.{b}.txt"), s_Output + s_Error.Result);
                });

                for (var i = 0; i < p_Jobs.Count; i++)
                {
                    var s_Prefix = Path.Combine(s_Directory.FullName, i.ToString());
                    if (!File.Exists(s_Prefix + ".dxbc") || !File.Exists(s_Prefix + ".json"))
                        continue;

                    using var s_Report = JsonDocument.Parse(File.ReadAllText(s_Prefix + ".json"));
                    var s_Lightmap = s_Report.RootElement.TryGetProperty("LightmapTermMissing", out var s_Value) && s_Value.GetBoolean();
                    s_Results[i] = new Result(File.ReadAllBytes(s_Prefix + ".dxbc"), s_Lightmap);
                }

                p_Log.WriteLine($"Shader translator: {s_Results.Count(p_R => p_R != null)} of {p_Jobs.Count} pixel shader(s) translated.");
                return s_Results;
            }
            finally
            {
                try { s_Directory.Delete(true); } catch (IOException) { }
            }
        }
    }
}
