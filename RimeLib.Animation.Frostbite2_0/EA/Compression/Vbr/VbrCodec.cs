using ant;
using System;
using System.Collections.Generic;

namespace RimeLib.Animation.Frostbite2_0.EA.Compression.Vbr
{
    /// <summary>
    /// What the Ant VBR container is made of, and the half of it that can be read and written.
    ///
    /// BF3 ships 2,225 VBR clips and nothing could read one -- <c>dump_animation_bank</c> did not
    /// even have a branch for the type. The header names its sections by SIZE, which is what made
    /// the layout checkable without the game running:
    ///
    ///   Data = KeyTimes[KeyTimeSize]
    ///        + ConstIndices[ConstQuaternionCount*4 + ConstVector3Count*3 + ConstFloatCount]
    ///        + ConstChanMap[ConstChanMapSize]
    ///        + VectorOffsets[VectorOffsetSize] + FloatOffsets[FloatOffsetSize]
    ///        + Descriptors[(QuaternionCount*4 + Vector3Count*3 + FloatCount) * 4]
    ///        + FrameBlocks[sum(FrameBlockSizes)]
    ///
    /// MEASURED: that sum equals <c>Data.Count</c> on 2,225 of 2,225 clips, and on no clip is it
    /// off by a byte. The four bytes per ANIMATED component are what pinned the last unknown --
    /// a constant channel costs one byte per component and an animated one costs four plus its
    /// share of the blocks.
    ///
    /// A constant channel is a palette reference: one byte per component indexing
    /// <c>ConstantPalette</c>, whose entries are NORMALISED into the clip's own range, so the
    /// value is <c>min + palette[i] * (max - min)</c> with min/max taken per channel kind.
    /// Confirmed by an oracle the format cannot fake: read that way, 14,102 of 14,891 constant
    /// quaternions across the whole game come out UNIT to within 6e-3, and no index is out of
    /// range. Read any other way -- palette entries as raw values, or the sections in any other
    /// order -- the figure collapses to 63-72%.
    ///
    /// Also measured, and the reason a nearest-entry encode is exact rather than approximate: NO
    /// clip's palette contains a duplicate finite entry, so a decoded constant has exactly one
    /// index that could have produced it.
    ///
    /// WHAT THIS DOES NOT DO: the per-frame blocks are NOT decoded. Their size is data-dependent
    /// -- across 2,225 clips no function of the per-component descriptors predicts a block's
    /// length, and only 42 clips have all their blocks the same size -- so the animated channels
    /// carry a per-block adaptive coding that has not been recovered. 133,985 of the 307,530 VBR
    /// channel components (43.6%) are animated and stay read-only; the 173,545 constant ones
    /// (56.4%) read and write.
    /// </summary>
    public class VbrCodec
    {
        /// <summary>Byte offsets of each section within <c>Data</c>.</summary>
        public sealed class Sections
        {
            public int KeyTimes { get; set; }
            public int ConstIndices { get; set; }
            public int ConstChanMap { get; set; }
            public int VectorOffsets { get; set; }
            public int FloatOffsets { get; set; }
            public int Descriptors { get; set; }
            public int Blocks { get; set; }

            /// <summary>Palette-index bytes: one per constant channel COMPONENT.</summary>
            public int ConstIndexCount { get; set; }

            /// <summary>Animated channel components; each owns four descriptor bytes.</summary>
            public int AnimatedComponents { get; set; }

            /// <summary>The length the sections account for. Equal to Data.Count on every clip BF3
            /// ships; a clip where it is not is refused rather than half-parsed.</summary>
            public int Accounted { get; set; }
        }


        /// <summary>Where each section starts. Throws when the sections do not account for the
        /// payload exactly -- an in-place writer must never work from a guessed offset.</summary>
        public static Sections Split(VbrAnimationAsset p_Clip)
        {
            var s_ConstIndices = p_Clip.ConstQuaternionCount * 4 + p_Clip.ConstVector3Count * 3
                                 + p_Clip.ConstFloatCount;
            var s_Animated = p_Clip.QuaternionCount * 4 + p_Clip.Vector3Count * 3
                             + p_Clip.FloatCount;

            var s_Out = new Sections
            {
                KeyTimes = 0,
                ConstIndices = p_Clip.KeyTimeSize,
                ConstIndexCount = s_ConstIndices,
                AnimatedComponents = s_Animated,
            };

            s_Out.ConstChanMap = s_Out.ConstIndices + s_ConstIndices;
            s_Out.VectorOffsets = s_Out.ConstChanMap + p_Clip.ConstChanMapSize;
            s_Out.FloatOffsets = s_Out.VectorOffsets + p_Clip.VectorOffsetSize;
            s_Out.Descriptors = s_Out.FloatOffsets + p_Clip.FloatOffsetSize;
            s_Out.Blocks = s_Out.Descriptors + s_Animated * 4;

            var s_BlockBytes = 0;

            foreach (var s_Size in p_Clip.FrameBlockSizes)
                s_BlockBytes += s_Size;

            s_Out.Accounted = s_Out.Blocks + s_BlockBytes;

            if (s_Out.Accounted != p_Clip.Data.Count)
            {
                throw new InvalidOperationException(
                    $"VBR sections account for {s_Out.Accounted} byte(s), Data holds "
                    + $"{p_Clip.Data.Count}.");
            }

            return s_Out;
        }


        /// <summary>What kind of channel a constant component belongs to, in payload order.</summary>
        public enum ConstKind
        {
            Quaternion,
            Vector3,
            Float,
        }

        /// <inheritdoc cref="ConstKind"/>
        public static ConstKind KindOf(VbrAnimationAsset p_Clip, int p_Component)
        {
            if (p_Component < p_Clip.ConstQuaternionCount * 4)
                return ConstKind.Quaternion;

            return p_Component < p_Clip.ConstQuaternionCount * 4 + p_Clip.ConstVector3Count * 3
                ? ConstKind.Vector3
                : ConstKind.Float;
        }

        /// <summary>
        /// The clip's quantisation window for a component kind.
        ///
        /// TrajMin/TrajMax exist beside Vec3Min/Vec3Max and would be the obvious place for a
        /// trajectory channel to differ -- MEASURED, they are equal to the Vec3 pair on 2,225 of
        /// 2,225 clips, so which vector channel is the trajectory never has to be decided.
        /// </summary>
        public static void RangeOf(VbrAnimationAsset p_Clip, ConstKind p_Kind, out float p_Min,
                                   out float p_Max)
        {
            switch (p_Kind)
            {
                case ConstKind.Quaternion:
                    p_Min = p_Clip.QuatMin;
                    p_Max = p_Clip.QuatMax;
                    break;

                case ConstKind.Vector3:
                    p_Min = p_Clip.Vec3Min;
                    p_Max = p_Clip.Vec3Max;
                    break;

                default:
                    p_Min = p_Clip.FloatMin;
                    p_Max = p_Clip.FloatMax;
                    break;
            }
        }


        /// <summary>
        /// Every constant channel component as a value, in payload order: the constant
        /// quaternions' xyzw, then the constant vectors' xyz, then the constant scalars.
        /// </summary>
        public static float[] DecodeConstants(VbrAnimationAsset p_Clip)
        {
            var s_Sections = Split(p_Clip);
            var s_Out = new float[s_Sections.ConstIndexCount];

            for (var i = 0; i < s_Out.Length; i++)
            {
                var s_Index = p_Clip.Data[s_Sections.ConstIndices + i];

                if (s_Index >= p_Clip.ConstantPalette.Count)
                {
                    throw new InvalidOperationException(
                        $"Constant component {i} indexes palette entry {s_Index} of "
                        + $"{p_Clip.ConstantPalette.Count}.");
                }

                RangeOf(p_Clip, KindOf(p_Clip, i), out var s_Min, out var s_Max);
                s_Out[i] = s_Min + p_Clip.ConstantPalette[s_Index] * (s_Max - s_Min);
            }

            return s_Out;
        }


        /// <summary>
        /// Values back into palette indices, and from there into a replacement <c>Data</c> of
        /// exactly the shipped length -- only the constant-index bytes move.
        ///
        /// A value the palette cannot express is NOT silently snapped: the nearest entry is used
        /// and <paramref name="p_Approximated"/> counts it, so the caller can see that an edit
        /// landed somewhere other than where it was aimed. Arbitrary values are reachable the
        /// other way round, by editing <c>ConstantPalette</c> itself, which is a float array of
        /// fixed length and patches in place like any other -- at the cost that a palette entry is
        /// SHARED by every component that references it.
        /// </summary>
        public static byte[] EncodeConstants(VbrAnimationAsset p_Clip, float[] p_Values,
                                             out int p_Approximated, out double p_MaxError)
        {
            var s_Sections = Split(p_Clip);

            if (p_Values.Length != s_Sections.ConstIndexCount)
            {
                throw new InvalidOperationException(
                    $"The clip holds {s_Sections.ConstIndexCount} constant component(s), the edit "
                    + $"supplies {p_Values.Length}.");
            }

            var s_Data = p_Clip.Data.ToArray();
            var s_Approximated = 0;
            var s_MaxError = 0.0;

            for (var i = 0; i < p_Values.Length; i++)
            {
                RangeOf(p_Clip, KindOf(p_Clip, i), out var s_Min, out var s_Max);

                // A zero-width window makes every palette entry decode to the same value, so the
                // index cannot be recovered from the value and the shipped one is kept. Real:
                // FloatMin == FloatMax == 0 on every clip with no scalar channels.
                var s_Span = s_Max - s_Min;

                if (s_Span == 0.0f)
                    continue;

                var s_Wanted = (p_Values[i] - s_Min) / s_Span;
                var s_Best = -1;
                var s_BestError = double.PositiveInfinity;

                for (var e = 0; e < p_Clip.ConstantPalette.Count; e++)
                {
                    var s_Entry = p_Clip.ConstantPalette[e];

                    // 242 palette entries across the game are NaN. Distance cannot order them, so
                    // NaN is matched to NaN by kind and never chosen for a finite value.
                    if (float.IsNaN(s_Entry) || float.IsNaN(s_Wanted))
                    {
                        if (float.IsNaN(s_Entry) && float.IsNaN(s_Wanted))
                        {
                            s_Best = e;
                            s_BestError = 0.0;
                            break;
                        }

                        continue;
                    }

                    var s_Error = System.Math.Abs((double)s_Entry - s_Wanted);

                    if (s_Error >= s_BestError)
                        continue;

                    s_BestError = s_Error;
                    s_Best = e;
                }

                if (s_Best < 0)
                {
                    throw new InvalidOperationException(
                        $"Constant component {i} wants {p_Values[i]}, which no palette entry can "
                        + "express.");
                }

                // Measured against the VALUE, not the normalised fraction, so the number means the
                // same thing as every other error in this pipeline.
                var s_ValueError = s_BestError * System.Math.Abs(s_Span);

                if (s_ValueError > 0.0)
                {
                    s_Approximated += 1;
                    s_MaxError = System.Math.Max(s_MaxError, s_ValueError);
                }

                s_Data[s_Sections.ConstIndices + i] = (byte)s_Best;
            }

            p_Approximated = s_Approximated;
            p_MaxError = s_MaxError;

            return s_Data;
        }
    }
}
