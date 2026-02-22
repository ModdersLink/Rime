using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Exports the current bundle contents (EBX, resources, chunks) to a JSON file.")]
    public class ExportBundleContentsCommand : Command
    {
        [CommandArgument(Description = "Path to the output JSON file.")]
        public string OutputPath { get; set; } = string.Empty;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(OutputPath))
            {
                p_Writer.WriteLine("Error: No output path specified.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;

            var s_Ebx = new List<string>();
            foreach (var s_Partition in s_BundleContext.GetPartitions())
                s_Ebx.Add(s_Partition.Key);

            var s_Res = new List<string>();
            foreach (var s_Resource in s_BundleContext.GetResources())
                s_Res.Add(s_Resource.Key);

            var s_Chunks = new List<string>();
            foreach (var s_Chunk in s_BundleContext.GetChunks())
                s_Chunks.Add(s_Chunk.Key.ToString());

            var s_Export = new BundleContentsExport
            {
                Ebx = s_Ebx,
                Res = s_Res,
                Chunks = s_Chunks,
            };

            var s_JsonOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            };

            var s_Json = JsonSerializer.Serialize(s_Export, s_JsonOptions);
            File.WriteAllText(OutputPath, s_Json);

            p_Writer.WriteLine($"Exported bundle contents to '{OutputPath}'.");
            p_Writer.WriteLine($"  EBX partitions : {s_Ebx.Count}");
            p_Writer.WriteLine($"  Resources       : {s_Res.Count}");
            p_Writer.WriteLine($"  Chunks          : {s_Chunks.Count}");

            return true;
        }

        private class BundleContentsExport
        {
            [JsonPropertyName("ebx")]
            public List<string> Ebx { get; set; } = new();

            [JsonPropertyName("res")]
            public List<string> Res { get; set; } = new();

            [JsonPropertyName("chunks")]
            public List<string> Chunks { get; set; } = new();
        }
    }
}
