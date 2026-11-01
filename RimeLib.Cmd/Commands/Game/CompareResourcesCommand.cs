using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// The batch form of <see cref="CompareResourceCommand"/>: given a manifest of
    /// {resource name: candidate file}, report which of them actually differ from the game.
    ///
    /// This is the question an emitter has to answer before it can decide what to ship, and it is
    /// the whole reason the command exists: a level that carries only its CHANGED resources is
    /// kilobytes, and one that carries everything it could not identify is gigabytes.
    /// </summary>
    [CommandDescription("Compares many candidate files against the mounted game's resources of the same names and writes a JSON verdict per name. Input is a JSON object of {resource name: candidate path}.")]
    public class CompareResourcesCommand : Command
    {
        [CommandArgument(Description = "JSON file: an object mapping resource name -> candidate file path.")]
        public FileInfo? Manifest { get; set; }

        [CommandArgument(Description = "The output .json file.")]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (Manifest is null || Destination is null)
            {
                p_Writer.WriteLine("Usage: compare_resources <manifest.json> <destination.json> [id]");
                return false;
            }

            Dictionary<string, string>? s_Input;

            try
            {
                s_Input = JsonConvert.DeserializeObject<Dictionary<string, string>>(
                    File.ReadAllText(Manifest.FullName));
            }
            catch (Exception s_Ex)
            {
                p_Writer.WriteLine("Could not read the manifest: " + s_Ex.Message);
                return false;
            }

            if (s_Input == null)
            {
                p_Writer.WriteLine("The manifest is empty.");
                return false;
            }

            var s_Context = (GameContext)p_Context;
            var s_Rows = new Dictionary<string, object>();
            var s_Counts = new Dictionary<string, int>
            {
                { "identical", 0 }, { "differs", 0 }, { "notShipped", 0 }, { "unreadable", 0 },
            };

            foreach (var s_Pair in s_Input)
            {
                var s_Result = CompareResourceCommand.Compare(s_Context, s_Pair.Key, s_Pair.Value);
                var s_Kind = s_Result.Verdict switch
                {
                    CompareResourceCommand.Verdict.Identical => "identical",
                    CompareResourceCommand.Verdict.Differs => "differs",
                    CompareResourceCommand.Verdict.NotShipped => "notShipped",
                    _ => "unreadable",
                };

                s_Counts[s_Kind] += 1;
                s_Rows[s_Pair.Key] = new
                {
                    verdict = s_Kind,
                    shippedLength = s_Result.ShippedLength,
                    candidateLength = s_Result.CandidateLength,
                    firstDiff = s_Result.FirstDiff,
                    metaIdentical = s_Result.MetaIdentical,
                };
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
            {
                counts = s_Counts,
                resources = s_Rows,
            }));

            // notShipped is called out separately from differs on purpose. A name the game does not
            // have is not a modified resource, it is a resource that will not resolve at load, and
            // conflating the two is how 462 unmodified meshes came to be rebuilt.
            p_Writer.WriteLine(string.Format(
                "compare_resources: identical={0} differs={1} notShipped={2} unreadable={3} -> {4}",
                s_Counts["identical"], s_Counts["differs"], s_Counts["notShipped"],
                s_Counts["unreadable"], Destination.FullName));

            return true;
        }
    }
}
