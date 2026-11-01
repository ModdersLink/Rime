using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Is a candidate resource byte-identical to the one the mounted game ships?
    ///
    /// This exists because the question was being answered somewhere it cannot be: against a
    /// directory of previously dumped resources. A dump is a SAMPLE, and a name that is not in it
    /// reads as "no shipped version to compare against", which a caller then has to interpret --
    /// and interpreting it as "changed" is the natural mistake. MEASURED cost of exactly that: of
    /// MP_001's 527 meshes only 65 were present in a 1199-resource sample, so 462 unmodified meshes
    /// were rebuilt and shipped, and the level stopped loading.
    ///
    /// The mounter knows every resource in the game. Asked here, the answer has no third state.
    /// </summary>
    [CommandDescription("Reports whether a file is byte-identical to the mounted game's resource of that name. Also compares the resource meta, which decides how the engine reads the payload.")]
    public class CompareResourceCommand : Command
    {
        [CommandArgument(Description = "The resource name, as the game knows it.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The candidate file to compare against it.")]
        public FileInfo? Candidate { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.", Optional = true)]
        public int Id { get; set; } = 1;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Candidate is null)
            {
                p_Writer.WriteLine("Usage: compare_resource <name> <candidate-file> [id]");
                return false;
            }

            var s_Result = Compare((GameContext)p_Context, Name!, Candidate!.FullName);

            p_Writer.WriteLine(s_Result.Verdict == Verdict.Identical
                ? string.Format("IDENTICAL {0} ({1} bytes, metaIdentical={2})",
                    Name, s_Result.ShippedLength, s_Result.MetaIdentical)
                : string.Format("{0} {1} shipped={2} candidate={3} firstDiff={4} metaIdentical={5}",
                    s_Result.Verdict.ToString().ToUpperInvariant(), Name, s_Result.ShippedLength,
                    s_Result.CandidateLength, s_Result.FirstDiff, s_Result.MetaIdentical));

            return true;
        }

        internal enum Verdict
        {
            Identical,
            Differs,
            NotShipped,
            Unreadable,
        }

        internal class Result
        {
            public Verdict Verdict { get; set; }
            public long ShippedLength { get; set; } = -1;
            public long CandidateLength { get; set; } = -1;

            /// <summary>Offset of the first differing byte, or -1 when they match to the shorter length.</summary>
            public long FirstDiff { get; set; } = -1;

            /// <summary>
            /// Whether the resource META matches too. The meta is not decoration: it carries the
            /// sizes the engine reads the payload with, so a payload that matches under a meta that
            /// does not is still a different resource.
            /// </summary>
            public bool MetaIdentical { get; set; }
        }

        internal static Result Compare(GameContext p_Context, string p_Name, string p_CandidatePath)
        {
            var s_Mounter = p_Context.GetMounter();

            if (!s_Mounter.TryGetResource(p_Name.ToLowerInvariant(), out var s_Resource) ||
                s_Resource.FirstVariant == null)
            {
                return new Result { Verdict = Verdict.NotShipped };
            }

            byte[] s_Shipped;

            try
            {
                using var s_Reader = s_Resource.FirstVariant.GetReader();
                s_Shipped = s_Reader.ReadBytes((int)s_Reader.Length);
            }
            catch (Exception)                                // noqa
            {
                return new Result { Verdict = Verdict.Unreadable };
            }

            if (!File.Exists(p_CandidatePath))
                return new Result { Verdict = Verdict.Unreadable, ShippedLength = s_Shipped.Length };

            var s_Candidate = File.ReadAllBytes(p_CandidatePath);
            var s_MetaSame = MetaMatches(s_Resource.FirstVariant, p_CandidatePath);

            var s_Result = new Result
            {
                ShippedLength = s_Shipped.Length,
                CandidateLength = s_Candidate.Length,
                MetaIdentical = s_MetaSame,
            };

            var s_Common = System.Math.Min(s_Shipped.Length, s_Candidate.Length);

            for (var i = 0; i < s_Common; ++i)
            {
                if (s_Shipped[i] == s_Candidate[i])
                    continue;

                s_Result.Verdict = Verdict.Differs;
                s_Result.FirstDiff = i;
                return s_Result;
            }

            if (s_Shipped.Length != s_Candidate.Length)
            {
                s_Result.Verdict = Verdict.Differs;
                s_Result.FirstDiff = s_Common;
                return s_Result;
            }

            s_Result.Verdict = Verdict.Identical;
            return s_Result;
        }

        /// <summary>
        /// A candidate's meta, where it has one: the same path with '.meta' appended. Absent means
        /// the caller is not asserting a meta, which is reported rather than treated as a match.
        /// </summary>
        private static bool MetaMatches(RimeLib.Content.Mounting.IResourceVariant p_Variant,
            string p_CandidatePath)
        {
            if (!p_Variant.TryGetMeta(out var s_Meta) || s_Meta == null)
                return false;

            var s_Path = p_CandidatePath + ".meta";

            if (!File.Exists(s_Path))
                return false;

            var s_Candidate = File.ReadAllBytes(s_Path);

            if (s_Candidate.Length != s_Meta.Length)
                return false;

            for (var i = 0; i < s_Meta.Length; ++i)
            {
                if (s_Meta[i] != s_Candidate[i])
                    return false;
            }

            return true;
        }
    }
}
