using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Content.Frostbite2_0.IO;
using RimeLib.IO;
using RimeLib.IO.Conversion;

namespace RimeLib.Content.Frostbite2_0.Building
{
    /// <summary>
    /// Writes a Frostbite delta/patch bundle: a header (runsSize + magic 0xDE17AAAA + padding)
    /// followed by a list of DeltaBundleRuns that splice BASE bundle bytes with NEW (patch) bytes,
    /// then the new bytes appended. The engine reconstructs the patched bundle by following the
    /// runs (RimeMultiplexedReader is the read side). This is the WRITE side that Rime lacked.
    ///
    /// Used to change a few bytes of a base bundle manifest (e.g. repoint an ebx entry's sha1 to
    /// new data in a patch cas) WITHOUT rebuilding the whole bundle.
    /// </summary>
    public static class DeltaBundleWriter
    {
        public const uint c_PatchMagic = 0xDE17AAAA;

        /// <summary>A region of the base bundle to replace with new bytes.</summary>
        public class Replacement
        {
            /// <summary>Offset of the region WITHIN the base bundle (0 = bundle start).</summary>
            public long Offset { get; set; }

            /// <summary>How many base bytes this replaces.</summary>
            public int OldLength { get; set; }

            /// <summary>The new bytes to write in their place.</summary>
            public byte[] NewBytes { get; set; } = Array.Empty<byte>();
        }

        /// <summary>
        /// Builds the delta bundle bytes for a base bundle with the given replacements.
        /// </summary>
        /// <param name="p_BaseBundleLength">Length of the base bundle (bytes).</param>
        /// <param name="p_BaseBundleOffsetInSb">Absolute offset of the base bundle inside the BASE
        /// superbundle (.sb) — the base runs reference this + relative position.</param>
        /// <param name="p_Replacements">Regions to replace (must not overlap).</param>
        /// <param name="p_Endianness">Endianness of the patch stream (LittleEndian for cas).</param>
        public static byte[] BuildDelta(long p_BaseBundleLength, long p_BaseBundleOffsetInSb,
            IEnumerable<Replacement> p_Replacements, Endianness p_Endianness = Endianness.LittleEndian)
        {
            var s_Sorted = p_Replacements.OrderBy(p_R => p_R.Offset).ToList();

            // Validate: no overlap, in bounds.
            long s_Check = 0;
            foreach (var s_R in s_Sorted)
            {
                if (s_R.Offset < s_Check)
                    throw new ArgumentException("Delta replacements overlap or are out of order.");
                if (s_R.Offset + s_R.OldLength > p_BaseBundleLength)
                    throw new ArgumentException("Delta replacement extends past the base bundle.");
                s_Check = s_R.Offset + s_R.OldLength;
            }

            var s_Runs = new List<DeltaBundleRun>();
            var s_PatchData = new MemoryStream();

            long s_Pos = 0;
            foreach (var s_R in s_Sorted)
            {
                // Copy the unchanged base bytes before this replacement.
                if (s_R.Offset > s_Pos)
                    s_Runs.Add(new DeltaBundleRun
                    {
                        FileId = 1, // non-zero = read from base
                        Offset = (ulong)(p_BaseBundleOffsetInSb + s_Pos),
                        CopyBytes = (int)(s_R.Offset - s_Pos),
                    });

                // Insert the new bytes (FileId 0 = read from the appended patch data).
                if (s_R.NewBytes.Length > 0)
                {
                    s_Runs.Add(new DeltaBundleRun { FileId = 0, Offset = 0, CopyBytes = s_R.NewBytes.Length });
                    s_PatchData.Write(s_R.NewBytes, 0, s_R.NewBytes.Length);
                }

                s_Pos = s_R.Offset + s_R.OldLength;
            }

            // Copy the remaining base bytes after the last replacement.
            if (s_Pos < p_BaseBundleLength)
                s_Runs.Add(new DeltaBundleRun
                {
                    FileId = 1,
                    Offset = (ulong)(p_BaseBundleOffsetInSb + s_Pos),
                    CopyBytes = (int)(p_BaseBundleLength - s_Pos),
                });

            // Serialize: int32 runsSize + uint32 magic + uint64 padding + runs[] + patch data.
            using var s_Out = new MemoryStream();
            using (var s_W = new RimeWriter(s_Out, p_Endianness, false))
            {
                s_W.Write((int)(s_Runs.Count * 16));
                s_W.Write(c_PatchMagic);
                s_W.Write((ulong)0); // padding

                foreach (var s_Run in s_Runs)
                {
                    s_W.Write(s_Run.CopyBytes);
                    s_W.Write(s_Run.FileId);
                    s_W.Write(s_Run.Offset);
                }

                s_W.Write(s_PatchData.ToArray());
                s_W.Flush();
            }

            return s_Out.ToArray();
        }
    }
}
