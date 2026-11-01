using ant;
using System;
using System.Collections.Generic;

namespace RimeLib.Animation.Frostbite2_0.EA.Compression.Curve
{
    /// <summary>
    /// The Ant CURV codec, read and write. BF3 ships 775 of these clips and nothing could read one:
    /// <c>dump_animation_bank</c> reported a <c>CurveAnimationAsset</c>'s array COUNTS and called
    /// that "decoded", which is how 775 clips could look handled and be untouchable.
    ///
    /// Unlike DCT there is no bitstream here at all -- a CURV clip's payload IS float32 keys, and
    /// the work was never a bit packer, it was the LAYOUT. That layout is now measured over every
    /// clip BF3 ships:
    ///
    ///   channel slots      NumRotations*3 + NumVectors*3 + NumFloats
    ///                      A rotation occupies THREE slots, not four. Measured: over all 775
    ///                      clips, len(ChannelOffsets) + len(ConstOffsets) equals that sum on 770
    ///                      of them and equals nothing else -- at four slots per rotation it
    ///                      matches none.
    ///   ChannelGroups      one {NumKeys, NumChannels} per group; the groups CONCATENATE, taking
    ///                      NumChannels entries from ChannelOffsets and NumKeys entries from Keys
    ///                      in order. 682 clips have one group, 46 have two, 30 have four.
    ///   Values             per group, NumKeys x NumChannels floats, KEY-MAJOR. Measured rather
    ///                      than assumed: read key-major a channel's samples are a smooth series
    ///                      on 672 clips against 5 the other way round, and
    ///                      sum(NumKeys*NumChannels) accounts for Values exactly on 775 of 775.
    ///   Consts/ConstOffsets  the slots that never move, value and slot index, same length on
    ///                      775 of 775.
    ///
    /// The write is the same trick the DCT encoder uses and for the same reason: the element
    /// COUNTS are fixed by the header, so re-encoding produces exactly the shipped byte count and
    /// the arrays are overwritten where they already lie. No Ant GenericData archive writer is
    /// needed and nothing else in the bank moves.
    ///
    /// Being plain about what "byte-identical" means here: a CURV round trip is exact because the
    /// codec stores raw float32 and nothing is quantised. That is a statement about the LAYOUT
    /// being right -- decode picks the values apart into groups, keys and channels and encode puts
    /// them back in the same order -- not about a bit packer having been reproduced.
    /// </summary>
    public class CurveCodec
    {
        /// <summary>One group of channels sampled at its own set of key times.</summary>
        public sealed class Group
        {
            /// <summary>Frame number of each key, from the clip's Keys array.</summary>
            public ushort[] KeyTimes { get; set; } = Array.Empty<ushort>();

            /// <summary>Channel slot each column drives, from the clip's ChannelOffsets.</summary>
            public int[] ChannelSlots { get; set; } = Array.Empty<int>();

            /// <summary>[key][channel], key-major exactly as the blob stores it.</summary>
            public float[][] Values { get; set; } = Array.Empty<float[]>();
        }

        /// <summary>A whole decoded clip: the moving groups plus the slots that never move.</summary>
        public sealed class Clip
        {
            public List<Group> Groups { get; } = new();

            public int[] ConstSlots { get; set; } = Array.Empty<int>();
            public float[] Consts { get; set; } = Array.Empty<float>();

            /// <summary>Total channel slots, NumRotations*3 + NumVectors*3 + NumFloats.</summary>
            public int SlotCount { get; set; }

            /// <summary>Slots below this index belong to rotations, three per rotation.</summary>
            public int RotationSlots { get; set; }

            /// <summary>Slots below this index belong to rotations or vectors.</summary>
            public int VectorSlotEnd { get; set; }

            /// <summary>Whether the Keys array accounts for every group's key count. FALSE on 23
            /// of BF3's 775 clips, which is reported rather than papered over -- see
            /// <see cref="Decode"/>.</summary>
            public bool KeyTimesAccounted { get; set; }
        }


        /// <summary>
        /// Splits a clip's flat arrays into groups, keys and channels.
        ///
        /// Throws when the header does not account for the arrays, because the alternative -- a
        /// decode that silently shortens a group -- would produce an encode of the wrong length
        /// and an in-place patch is exactly the thing that must not guess.
        /// </summary>
        public static Clip Decode(CurveAnimationAsset p_Clip)
        {
            var s_Rot = p_Clip.NumRotations * 3;
            var s_Vec = p_Clip.NumVectors * 3;

            var s_Out = new Clip
            {
                SlotCount = s_Rot + s_Vec + p_Clip.NumFloats,
                RotationSlots = s_Rot,
                VectorSlotEnd = s_Rot + s_Vec,
            };

            var s_Channels = 0;
            var s_Keys = 0;
            var s_Values = 0;

            foreach (var s_Group in p_Clip.ChannelGroups)
            {
                s_Channels += s_Group.NumChannels;
                s_Keys += s_Group.NumKeys;
                s_Values += s_Group.NumKeys * s_Group.NumChannels;
            }

            if (s_Channels != p_Clip.ChannelOffsets.Count)
            {
                throw new InvalidOperationException(
                    $"ChannelGroups claim {s_Channels} channel(s), ChannelOffsets holds "
                    + $"{p_Clip.ChannelOffsets.Count}.");
            }

            if (s_Values != p_Clip.Values.Count)
            {
                throw new InvalidOperationException(
                    $"ChannelGroups claim {s_Values} value(s), Values holds {p_Clip.Values.Count}.");
            }

            if (p_Clip.Consts.Count != p_Clip.ConstOffsets.Count)
            {
                throw new InvalidOperationException(
                    $"Consts holds {p_Clip.Consts.Count} value(s) against {p_Clip.ConstOffsets.Count}"
                    + " offset(s).");
            }

            // 23 of 775 clips carry a Keys array that does not add up to the groups' key counts
            // (15 of them have no groups at all). The values still account for themselves, so the
            // clip is decodable and WRITABLE -- what is missing is the frame number of each key,
            // and saying so is better than handing back invented times.
            s_Out.KeyTimesAccounted = s_Keys == p_Clip.Keys.Count;

            var s_ChannelAt = 0;
            var s_KeyAt = 0;
            var s_ValueAt = 0;

            foreach (var s_Group in p_Clip.ChannelGroups)
            {
                var s_Slots = new int[s_Group.NumChannels];

                for (var i = 0; i < s_Group.NumChannels; i++)
                    s_Slots[i] = p_Clip.ChannelOffsets[s_ChannelAt + i];

                var s_Times = new ushort[s_Group.NumKeys];

                if (s_Out.KeyTimesAccounted)
                {
                    for (var i = 0; i < s_Group.NumKeys; i++)
                        s_Times[i] = p_Clip.Keys[s_KeyAt + i];
                }

                var s_Rows = new float[s_Group.NumKeys][];

                for (var k = 0; k < s_Group.NumKeys; k++)
                {
                    var s_Row = new float[s_Group.NumChannels];

                    for (var ch = 0; ch < s_Group.NumChannels; ch++)
                        s_Row[ch] = p_Clip.Values[s_ValueAt + k * s_Group.NumChannels + ch];

                    s_Rows[k] = s_Row;
                }

                s_Out.Groups.Add(new Group
                {
                    KeyTimes = s_Times,
                    ChannelSlots = s_Slots,
                    Values = s_Rows,
                });

                s_ChannelAt += s_Group.NumChannels;
                s_KeyAt += s_Group.NumKeys;
                s_ValueAt += s_Group.NumKeys * s_Group.NumChannels;
            }

            s_Out.ConstSlots = new int[p_Clip.ConstOffsets.Count];
            s_Out.Consts = new float[p_Clip.Consts.Count];

            for (var i = 0; i < p_Clip.ConstOffsets.Count; i++)
            {
                s_Out.ConstSlots[i] = p_Clip.ConstOffsets[i];
                s_Out.Consts[i] = p_Clip.Consts[i];
            }

            return s_Out;
        }


        /// <summary>
        /// Groups, keys and channels back into the flat Values array, in the clip's own order.
        ///
        /// The shape is checked against the clip rather than against the decoded object, so an
        /// edit that added a key or a channel is refused here instead of producing an array of the
        /// wrong length that an in-place patch would then reject further downstream with a less
        /// useful message.
        /// </summary>
        public static float[] EncodeValues(CurveAnimationAsset p_Clip, Clip p_Decoded)
        {
            if (p_Decoded.Groups.Count != p_Clip.ChannelGroups.Count)
            {
                throw new InvalidOperationException(
                    $"The clip has {p_Clip.ChannelGroups.Count} group(s), the edit has "
                    + $"{p_Decoded.Groups.Count}. Re-encoding against the clip's own header cannot "
                    + "change its grouping.");
            }

            var s_Out = new float[p_Clip.Values.Count];
            var s_At = 0;

            for (var g = 0; g < p_Clip.ChannelGroups.Count; g++)
            {
                var s_Group = p_Clip.ChannelGroups[g];
                var s_Edit = p_Decoded.Groups[g];

                if (s_Edit.Values.Length != s_Group.NumKeys)
                {
                    throw new InvalidOperationException(
                        $"Group {g} has {s_Group.NumKeys} key(s), the edit supplies "
                        + $"{s_Edit.Values.Length}.");
                }

                for (var k = 0; k < s_Group.NumKeys; k++)
                {
                    if (s_Edit.Values[k].Length != s_Group.NumChannels)
                    {
                        throw new InvalidOperationException(
                            $"Group {g} key {k} has {s_Group.NumChannels} channel(s), the edit "
                            + $"supplies {s_Edit.Values[k].Length}.");
                    }

                    for (var ch = 0; ch < s_Group.NumChannels; ch++)
                        s_Out[s_At + k * s_Group.NumChannels + ch] = s_Edit.Values[k][ch];
                }

                s_At += s_Group.NumKeys * s_Group.NumChannels;
            }

            return s_Out;
        }


        /// <summary>The constant slots back as a flat array, same length as the clip's own.</summary>
        public static float[] EncodeConsts(CurveAnimationAsset p_Clip, Clip p_Decoded)
        {
            if (p_Decoded.Consts.Length != p_Clip.Consts.Count)
            {
                throw new InvalidOperationException(
                    $"The clip holds {p_Clip.Consts.Count} constant(s), the edit supplies "
                    + $"{p_Decoded.Consts.Length}.");
            }

            return (float[])p_Decoded.Consts.Clone();
        }


        /// <summary>
        /// What each slot is for. A rotation takes three consecutive slots, then vectors take
        /// three each, then the scalars take one each -- so slot 5 of a clip with two rotations is
        /// the second component of the first VECTOR, not a rotation's w.
        /// </summary>
        public enum SlotKind
        {
            Rotation,
            Vector,
            Float,
        }

        /// <inheritdoc cref="SlotKind"/>
        public static SlotKind KindOf(Clip p_Clip, int p_Slot)
            => p_Slot < p_Clip.RotationSlots ? SlotKind.Rotation
             : p_Slot < p_Clip.VectorSlotEnd ? SlotKind.Vector
             : SlotKind.Float;
    }
}
