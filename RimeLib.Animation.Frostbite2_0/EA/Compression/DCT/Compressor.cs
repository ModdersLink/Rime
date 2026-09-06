using ant;
using RimeLib.Animation.EA.Compression.DCT;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace RimeLib.Animation.Frostbite2_0.EA.Compression.DCT
{
    /// <summary>
    /// The write half of the Ant DCT codec. <see cref="Decompressor"/> could read a clip and
    /// nothing could put one back, so animation was the one asset class in BF3 that exported and
    /// did not return.
    ///
    /// This encodes against the clip's OWN header -- the bit widths, delta bases and quantisation
    /// multipliers the shipped clip already carries -- rather than choosing new ones. That is a
    /// deliberate limit and it is what makes the write safe: every field of the
    /// <see cref="DctAnimationAsset"/> except <c>Data</c> is untouched, <c>Data</c> keeps its exact
    /// byte length, and the edited clip can therefore be patched into the Ant bank's blob in
    /// place, with no Ant GenericData writer (which does not exist) and no relocation of anything
    /// else in the bank.
    ///
    /// The cost is that a clip cannot be given MORE precision or more frames than it shipped with.
    /// A clip needing that should be written as a <c>RawAnimationAsset</c> instead -- BF3 ships
    /// 1,534 of those, so uncompressed float keys are a codec the engine already accepts.
    /// </summary>
    public class Compressor
    {
        /// <summary>
        /// Column energy of <see cref="Decompressor.c_DctCoeffs"/>, i.e. sum over the 8 frames of
        /// coeff[f,i]^2. MEASURED from the table rather than assumed: the basis is orthogonal but
        /// NOT orthonormal -- column 0 comes out at 0.5 and the rest at 1.0 -- and the table's last
        /// row also carries a 0.353554 where every other row has 0.353553, so deriving the norms
        /// from the numbers actually used is the only way the forward and inverse transforms agree.
        /// </summary>
        private static readonly float[] c_ColumnEnergy = ComputeColumnEnergy();

        private static float[] ComputeColumnEnergy()
        {
            var s_Energy = new float[8];

            for (var i = 0; i < 8; i++)
            {
                var s_Sum = 0.0f;

                for (var f = 0; f < 8; f++)
                    s_Sum += Decompressor.c_DctCoeffs[f, i] * Decompressor.c_DctCoeffs[f, i];

                s_Energy[i] = s_Sum;
            }

            return s_Energy;
        }


        /// <summary>
        /// Packs coefficient blocks back into the clip's bitstream. The exact inverse of
        /// <see cref="Decompressor.DecodeBlocks"/>: same block/DOF order, same per-sub-block bit
        /// widths, same big-endian MSB-first packing, and the same rule that block 0 omits
        /// sub-block 0 because that coefficient IS the delta base.
        ///
        /// <paramref name="p_Blocks"/> must be what DecodeBlocks returned -- one entry per
        /// (block, DOF), delta base already folded into components 0..3.
        /// </summary>
        public byte[] EncodeBlocks(DctAnimationAsset p_Dct, List<List<short>> p_Blocks,
                                   out int p_Clamped)
            => EncodeBlocks(p_Dct, p_Blocks, out p_Clamped, out _);

        /// <inheritdoc cref="EncodeBlocks(DctAnimationAsset, List{List{short}}, out int)"/>
        /// <param name="p_Natural">The length the bits alone need, before the shipped payload's
        /// trailing padding is matched. Reported so the padding is a measured number rather than a
        /// guess.</param>
        public byte[] EncodeBlocks(DctAnimationAsset p_Dct, List<List<short>> p_Blocks,
                                   out int p_Clamped, out int p_Natural)
        {
            var s_DofTable = Decompressor.BuildDofTable(p_Dct);
            var s_BlockCount = (p_Dct.NumKeys + 7) / 8;
            var s_Clamped = 0;

            var s_Stream = new MemoryStream();
            using (var s_BitWriter = new BitWriter(s_Stream))
            {
                var s_Index = 0;

                for (var s_BlockFrame = 0; s_BlockFrame < s_BlockCount; s_BlockFrame++)
                {
                    foreach (var s_AnimChannel in s_DofTable)
                    {
                        var s_Block = s_Index < p_Blocks.Count ? p_Blocks[s_Index] : null;
                        s_Index++;

                        var s_Components = s_AnimChannel.BitsPerSubBlock;

                        // Sub-block 0 of the first block is never in the stream; the decoder
                        // substitutes the delta base for it. Everything after it shifts down one
                        // slot in the value array, exactly as the decoder shifts it up.
                        var s_First = s_BlockFrame == 0 ? 1 : 0;

                        for (var s_Sub = s_First; s_Sub < s_Components.Length; s_Sub++)
                        {
                            var s_Component = s_Components[s_Sub];

                            // Position in the decoded block. The decoder writes sub-block k of
                            // block 0 at slot k (it pushed four zeroes in front first), and
                            // sub-block k of any later block at slot k too.
                            var s_Slot = s_Sub * 4;

                            var s_X = ValueAt(s_Block, s_Slot + 0);
                            var s_Y = ValueAt(s_Block, s_Slot + 1);
                            var s_Z = ValueAt(s_Block, s_Slot + 2);
                            var s_W = ValueAt(s_Block, s_Slot + 3);

                            // The delta base is folded into components 0..3 by the decoder, so it
                            // has to come back out before the values are packed.
                            if (s_Sub == 0)
                            {
                                s_X -= s_AnimChannel.DeltaBase[0];
                                s_Y -= s_AnimChannel.DeltaBase[1];
                                s_Z -= s_AnimChannel.DeltaBase[2];
                                s_W -= s_AnimChannel.DeltaBase[3];
                            }

                            s_BitWriter.WriteIntHigh(Fit(s_X, s_Component.SafeBitsX(p_Dct.CatchAllBitCount), ref s_Clamped),
                                                     s_Component.SafeBitsX(p_Dct.CatchAllBitCount));
                            s_BitWriter.WriteIntHigh(Fit(s_Y, s_Component.SafeBitsY(p_Dct.CatchAllBitCount), ref s_Clamped),
                                                     s_Component.SafeBitsY(p_Dct.CatchAllBitCount));
                            s_BitWriter.WriteIntHigh(Fit(s_Z, s_Component.SafeBitsZ(p_Dct.CatchAllBitCount), ref s_Clamped),
                                                     s_Component.SafeBitsZ(p_Dct.CatchAllBitCount));
                            s_BitWriter.WriteIntHigh(Fit(s_W, s_Component.SafeBitsW(p_Dct.CatchAllBitCount), ref s_Clamped),
                                                     s_Component.SafeBitsW(p_Dct.CatchAllBitCount));
                        }
                    }
                }
            }

            p_Clamped = s_Clamped;

            var s_Data = s_Stream.ToArray();

            // The stream is read through a 64-bit-slice BitReader, so it must be a whole number of
            // 8-byte words at minimum.
            var s_Aligned = (s_Data.Length + 7) & ~7;
            p_Natural = s_Aligned;

            // BF3's payloads are LONGER than the bits need -- MEASURED at 16 or 24 bytes over the
            // 8-byte-aligned length across a91's clips, which is read-ahead slack for the bit
            // reader, not data. The trailing bytes are never decoded, so the encode matches the
            // shipped LENGTH rather than trying to re-derive the padding rule: same length is what
            // an in-place patch needs, and a rule guessed from a handful of clips would be wrong
            // on the one that did not fit it.
            var s_Target = System.Math.Max(s_Aligned, p_Dct.Data.Count);

            if (s_Target == s_Data.Length)
                return s_Data;

            Array.Resize(ref s_Data, s_Target);
            return s_Data;
        }


        /// <summary>
        /// Frames -> quantised coefficient blocks, the inverse of
        /// <see cref="Decompressor.UnpackVec"/>.
        ///
        /// The decoder computes value[f] = sum_i coeff[f,i] * mult[i] * v[i]. The basis columns are
        /// orthogonal, so v[i] = (sum_f coeff[f,i] * value[f]) / (energy[i] * mult[i]); nothing
        /// here is a search or an approximation, it is the closed-form inverse followed by a round
        /// to the nearest short.
        /// </summary>
        public List<List<short>> Quantize(DctAnimationAsset p_Dct, Vector4[][] p_Frames,
                                          out short[][] p_DeltaBase)
        {
            var s_DofTable = Decompressor.BuildDofTable(p_Dct);
            var s_BlockCount = (p_Dct.NumKeys + 7) / 8;
            var s_Blocks = new List<List<short>>();

            // The delta base IS block 0's DC coefficient -- that is why the stream omits sub-block
            // 0 of block 0, and it is why re-encoding cannot leave the bases alone. MEASURED the
            // hard way: an edit that shifted a channel by 0.25 came back unchanged, because the
            // shift lands entirely on the DC term and the DC term of the first block is not in the
            // payload at all. Later blocks store their DC as a delta FROM this base, so both move
            // together or the clip tears at the 8-frame boundary.
            var s_DeltaBase = new short[s_DofTable.Length][];

            var s_Mult = new float[8];

            for (var i = 0; i < 8; i++)
                s_Mult[i] = ((float)p_Dct.QuantizeMultSubblock * 0.1f * i + 1.0f)
                            / p_Dct.QuantizeMultBlock;

            for (var s_BlockFrame = 0; s_BlockFrame < s_BlockCount; s_BlockFrame++)
            {
                for (var s_DofIdx = 0; s_DofIdx < s_DofTable.Length; s_DofIdx++)
                {
                    var s_Block = new List<short>();

                    for (var i = 0; i < 8; i++)
                    {
                        var s_Sum = new Vector4(0.0f);

                        for (var f = 0; f < 8; f++)
                        {
                            var s_Frame = s_BlockFrame * 8 + f;

                            // The last block runs past the end of the clip. The decoder never
                            // looks at those frames, so hold the final one rather than invent
                            // motion that would leak into the coefficients if it ever did.
                            if (s_Frame >= p_Frames.Length)
                                s_Frame = p_Frames.Length - 1;

                            var s_Row = p_Frames[s_Frame];

                            if (s_DofIdx >= s_Row.Length)
                                continue;

                            s_Sum += Vector4.Multiply(s_Row[s_DofIdx],
                                                      Decompressor.c_DctCoeffs[f, i]);
                        }

                        var s_Scale = 1.0f / (c_ColumnEnergy[i] * s_Mult[i]);
                        s_Sum = Vector4.Multiply(s_Sum, s_Scale);

                        s_Block.Add(Round(s_Sum.X));
                        s_Block.Add(Round(s_Sum.Y));
                        s_Block.Add(Round(s_Sum.Z));
                        s_Block.Add(Round(s_Sum.W));
                    }

                    // Block 0's DC coefficient is not stored in the stream, so it becomes this
                    // DOF's new delta base and the caller writes it back into the clip's
                    // DeltaBase{X,Y,Z,W} fields.
                    if (s_BlockFrame == 0)
                    {
                        s_DeltaBase[s_DofIdx] = new[]
                        {
                            s_Block[0], s_Block[1], s_Block[2], s_Block[3],
                        };
                    }

                    s_Blocks.Add(s_Block);
                }
            }

            p_DeltaBase = s_DeltaBase;
            return s_Blocks;
        }


        /// <summary>
        /// Frames -> a replacement <c>Data</c> blob AND the delta bases that go with it.
        ///
        /// Both have to be written for an edit to land: <c>Data</c> alone leaves every channel's
        /// first eight frames at whatever DC level the clip shipped with.
        /// </summary>
        public byte[] Encode(DctAnimationAsset p_Dct, Vector4[][] p_Frames,
                             out short[][] p_DeltaBase, out int p_Clamped)
        {
            var s_Blocks = Quantize(p_Dct, p_Frames, out p_DeltaBase);

            // The stream stores every later block's DC as a delta from the NEW base, so the packing
            // has to see the new base, not the one the clip shipped with.
            var s_Rebased = Rebase(p_Dct, p_DeltaBase);

            return EncodeBlocks(s_Rebased, s_Blocks, out p_Clamped);
        }

        /// <summary>
        /// The same clip with different delta bases. A shallow copy of only the fields the encoder
        /// reads -- the caller's asset is not touched, because it is still the record of what the
        /// game currently ships and the patch is compared against it.
        /// </summary>
        private static DctAnimationAsset Rebase(DctAnimationAsset p_Dct, short[][] p_DeltaBase)
        {
            var s_Clone = new DctAnimationAsset
            {
                NumKeys = p_Dct.NumKeys,
                NumQuats = p_Dct.NumQuats,
                NumVec3 = p_Dct.NumVec3,
                NumFloat = p_Dct.NumFloat,
                NumFloatVec = p_Dct.NumFloatVec,
                QuantizeMultBlock = p_Dct.QuantizeMultBlock,
                QuantizeMultSubblock = p_Dct.QuantizeMultSubblock,
                CatchAllBitCount = p_Dct.CatchAllBitCount,
                DofTableDescBytes = p_Dct.DofTableDescBytes,
                BitsPerSubblock = p_Dct.BitsPerSubblock,
                Data = p_Dct.Data,
                DataSize = p_Dct.DataSize,
            };

            for (var i = 0; i < p_DeltaBase.Length; i++)
            {
                s_Clone.DeltaBaseX.Add(p_DeltaBase[i][0]);
                s_Clone.DeltaBaseY.Add(p_DeltaBase[i][1]);
                s_Clone.DeltaBaseZ.Add(p_DeltaBase[i][2]);
                s_Clone.DeltaBaseW.Add(p_DeltaBase[i][3]);
            }

            return s_Clone;
        }


        private static short ValueAt(List<short>? p_Block, int p_Index)
            => p_Block != null && p_Index < p_Block.Count ? p_Block[p_Index] : (short)0;

        private static short Round(float p_Value)
        {
            var s_Rounded = MathF.Round(p_Value, MidpointRounding.AwayFromZero);

            if (s_Rounded > short.MaxValue)
                return short.MaxValue;

            if (s_Rounded < short.MinValue)
                return short.MinValue;

            return (short)s_Rounded;
        }

        /// <summary>
        /// Clamps to what <paramref name="p_Bits"/> of two's complement can hold, counting every
        /// clamp. A clamp is real data loss and the caller has to be able to see it happened --
        /// silently wrapping would turn one out-of-range coefficient into a wild pose.
        /// </summary>
        private static long Fit(int p_Value, ushort p_Bits, ref int p_Clamped)
        {
            if (p_Bits == 0)
            {
                if (p_Value != 0)
                    p_Clamped++;

                return 0;
            }

            if (p_Bits >= 64)
                return p_Value;

            var s_Max = (1L << (p_Bits - 1)) - 1;
            var s_Min = -(1L << (p_Bits - 1));

            if (p_Value > s_Max)
            {
                p_Clamped++;
                return s_Max;
            }

            if (p_Value < s_Min)
            {
                p_Clamped++;
                return s_Min;
            }

            return p_Value;
        }
    }
}
