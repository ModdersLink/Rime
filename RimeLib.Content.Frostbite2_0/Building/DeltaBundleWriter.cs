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
    /// Writes a delta bundle, the write side of <see cref="RimeMultiplexedReader"/>: a header, then a
    /// list of runs splicing base bundle bytes together with new ones, then the new bytes themselves.
    /// The engine rebuilds the patched bundle by following the runs.
    ///
    /// This is how a few bytes of a base bundle manifest can be changed, such as repointing an ebx
    /// entry's sha1 at new data in a patch catalogue, without rebuilding the whole bundle.
    /// </summary>
    public static class DeltaBundleWriter
    {
        public const uint c_PatchMagic = 0xDE17AAAA;

        /// <summary>A region of the base bundle to replace with new bytes.</summary>
        public class Replacement
        {
            /// <summary>Offset of the region within the base bundle, counted from the bundle start.</summary>
            public long Offset { get; set; }

            /// <summary>How many base bytes this replaces.</summary>
            public int OldLength { get; set; }

            /// <summary>The new bytes to write in their place.</summary>
            public byte[] NewBytes { get; set; } = Array.Empty<byte>();
        }

        /// <summary>
        /// Builds the delta bundle bytes for a base bundle with the given replacements.
        /// </summary>
        /// <param name="p_BaseBundleLength">Length of the base bundle in bytes.</param>
        /// <param name="p_BaseBundleOffsetInSb">Absolute offset of the base bundle inside the base
        /// superbundle, which the base runs reference plus their relative position.</param>
        /// <param name="p_Replacements">Regions to replace. They must not overlap.</param>
        /// <param name="p_Endianness">Endianness of the patch stream.</param>
        public static byte[] BuildDelta(long p_BaseBundleLength, long p_BaseBundleOffsetInSb,
            IEnumerable<Replacement> p_Replacements, Endianness p_Endianness = Endianness.LittleEndian)
        {
            var s_Sorted = p_Replacements.OrderBy(p_R => p_R.Offset).ToList();

            long s_End = 0;
            foreach (var s_Replacement in s_Sorted)
            {
                if (s_Replacement.Offset < s_End)
                    throw new ArgumentException("Delta replacements overlap or are out of order.");
                if (s_Replacement.Offset + s_Replacement.OldLength > p_BaseBundleLength)
                    throw new ArgumentException("Delta replacement extends past the base bundle.");

                s_End = s_Replacement.Offset + s_Replacement.OldLength;
            }

            var s_Runs = new List<DeltaBundleRun>();
            var s_PatchData = new MemoryStream();

            long s_Position = 0;
            foreach (var s_Replacement in s_Sorted)
            {
                // A non-zero FileId reads from the base bundle.
                if (s_Replacement.Offset > s_Position)
                    s_Runs.Add(new DeltaBundleRun
                    {
                        FileId = 1,
                        Offset = (ulong)(p_BaseBundleOffsetInSb + s_Position),
                        CopyBytes = (int)(s_Replacement.Offset - s_Position),
                    });

                // FileId 0 reads from the patch data appended at the end.
                if (s_Replacement.NewBytes.Length > 0)
                {
                    s_Runs.Add(new DeltaBundleRun { FileId = 0, Offset = 0, CopyBytes = s_Replacement.NewBytes.Length });
                    s_PatchData.Write(s_Replacement.NewBytes, 0, s_Replacement.NewBytes.Length);
                }

                s_Position = s_Replacement.Offset + s_Replacement.OldLength;
            }

            if (s_Position < p_BaseBundleLength)
                s_Runs.Add(new DeltaBundleRun
                {
                    FileId = 1,
                    Offset = (ulong)(p_BaseBundleOffsetInSb + s_Position),
                    CopyBytes = (int)(p_BaseBundleLength - s_Position),
                });

            using var s_Out = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Out, p_Endianness, false))
            {
                s_Writer.Write((int)(s_Runs.Count * 16));
                s_Writer.Write(c_PatchMagic);
                s_Writer.Write((ulong)0);

                foreach (var s_Run in s_Runs)
                {
                    s_Writer.Write(s_Run.CopyBytes);
                    s_Writer.Write(s_Run.FileId);
                    s_Writer.Write(s_Run.Offset);
                }

                s_Writer.Write(s_PatchData.ToArray());
                s_Writer.Flush();
            }

            return s_Out.ToArray();
        }
    }
}
