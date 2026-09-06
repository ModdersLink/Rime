using System.Collections.Generic;
using System.Numerics;
using RimeLib.Animation.Frostbite2_0.EA.Compression.DCT;
using Xunit;

namespace RimeLib.Tests.Animation
{
    /// <summary>
    /// The Ant DCT encoder against its own decoder, on a synthetic clip. The real proof is
    /// <c>check_animation_codec</c> re-encoding BF3's shipped banks byte for byte, but that needs a
    /// game mount; this runs anywhere and pins the two things a bit-packing codec gets wrong
    /// silently -- the block-0 special case, where sub-block 0 is not in the stream at all and the
    /// delta base stands in for it, and the per-component bit widths.
    /// </summary>
    public class DctCodecTest
    {
        /// <summary>A clip with awkward-on-purpose bit widths: unequal per component, a zero-width
        /// component, and the 0xF catch-all escape that redirects to CatchAllBitCount.</summary>
        private static ant.DctAnimationAsset MakeClip(ushort p_Keys, int p_Quats, int p_Vec3s)
        {
            var s_Clip = new ant.DctAnimationAsset
            {
                NumKeys = p_Keys,
                NumQuats = (ushort)p_Quats,
                NumVec3 = (ushort)p_Vec3s,
                NumFloatVec = 0,
                QuantizeMultBlock = 2000,
                QuantizeMultSubblock = 7,
                CatchAllBitCount = 11,
            };

            var s_Widths = new ushort[]
            {
                0xCCCC, 0xBA98, 0xF987, 0x8765, 0x6543, 0x4321, 0x3210, 0x2100,
            };

            for (var i = 0; i < p_Quats + p_Vec3s; i++)
            {
                s_Clip.DofTableDescBytes.Add((byte)(8 << 4));
                s_Clip.DeltaBaseX.Add((short)(100 + i));
                s_Clip.DeltaBaseY.Add((short)(-200 - i));
                s_Clip.DeltaBaseZ.Add((short)(300 + i));
                s_Clip.DeltaBaseW.Add((short)(-400 - i));

                foreach (var s_Width in s_Widths)
                    s_Clip.BitsPerSubblock.Add(s_Width);
            }

            return s_Clip;
        }

        /// <summary>Coefficients small enough that every one of them fits its own bit width, so a
        /// difference in the round trip is a packing bug and not a clamp.</summary>
        private static List<List<short>> MakeBlocks(ant.DctAnimationAsset p_Clip)
        {
            var s_Table = Decompressor.BuildDofTable(p_Clip);
            var s_Blocks = new List<List<short>>();
            var s_Seed = 1;

            for (var s_Block = 0; s_Block < (p_Clip.NumKeys + 7) / 8; s_Block++)
            {
                for (var s_Dof = 0; s_Dof < s_Table.Length; s_Dof++)
                {
                    var s_Values = new List<short>();

                    for (var s_Sub = 0; s_Sub < 8; s_Sub++)
                    {
                        var s_Bits = s_Table[s_Dof].BitsPerSubBlock[s_Sub];

                        s_Values.Add(Fit(s_Bits.SafeBitsX(p_Clip.CatchAllBitCount), ref s_Seed));
                        s_Values.Add(Fit(s_Bits.SafeBitsY(p_Clip.CatchAllBitCount), ref s_Seed));
                        s_Values.Add(Fit(s_Bits.SafeBitsZ(p_Clip.CatchAllBitCount), ref s_Seed));
                        s_Values.Add(Fit(s_Bits.SafeBitsW(p_Clip.CatchAllBitCount), ref s_Seed));
                    }

                    // Block 0 has no sub-block 0 in the stream; its coefficient IS the delta base,
                    // and that is what the decoder will hand back.
                    if (s_Block == 0)
                    {
                        s_Values[0] = s_Table[s_Dof].DeltaBase[0];
                        s_Values[1] = s_Table[s_Dof].DeltaBase[1];
                        s_Values[2] = s_Table[s_Dof].DeltaBase[2];
                        s_Values[3] = s_Table[s_Dof].DeltaBase[3];
                    }
                    else
                    {
                        // Later blocks store coefficient 0 as a delta, so the value the decoder
                        // reports is the stored delta PLUS the base and has to be built that way.
                        s_Values[0] = (short)(s_Values[0] + s_Table[s_Dof].DeltaBase[0]);
                        s_Values[1] = (short)(s_Values[1] + s_Table[s_Dof].DeltaBase[1]);
                        s_Values[2] = (short)(s_Values[2] + s_Table[s_Dof].DeltaBase[2]);
                        s_Values[3] = (short)(s_Values[3] + s_Table[s_Dof].DeltaBase[3]);
                    }

                    s_Blocks.Add(s_Values);
                }
            }

            return s_Blocks;
        }

        private static short Fit(ushort p_Bits, ref int p_Seed)
        {
            p_Seed = p_Seed * 1103515245 + 12345;

            if (p_Bits < 2)
                return 0;

            // Exactly the two's-complement range the width can hold: [-2^(b-1), 2^(b-1)-1]. A
            // value one outside it would be clamped, and the test would then be measuring the
            // clamp instead of the packing.
            var s_Span = 1 << p_Bits;
            var s_Value = ((p_Seed >> 8) & int.MaxValue) % s_Span;

            return (short)(s_Value - (1 << (p_Bits - 1)));
        }


        /// <summary>What a patch does to a bank: the payload AND the delta bases, together.</summary>
        private static void Apply(ant.DctAnimationAsset p_Clip, byte[] p_Data, short[][] p_Bases)
        {
            p_Clip.Data = new List<byte>(p_Data);
            p_Clip.DataSize = (uint)p_Data.Length;

            for (var i = 0; i < p_Bases.Length; i++)
            {
                p_Clip.DeltaBaseX[i] = p_Bases[i][0];
                p_Clip.DeltaBaseY[i] = p_Bases[i][1];
                p_Clip.DeltaBaseZ[i] = p_Bases[i][2];
                p_Clip.DeltaBaseW[i] = p_Bases[i][3];
            }
        }


        [Theory]
        [InlineData(8, 2, 1)]
        [InlineData(17, 3, 2)]
        [InlineData(64, 1, 1)]
        public void BitstreamRoundTripsExactly(ushort p_Keys, int p_Quats, int p_Vec3s)
        {
            var s_Clip = MakeClip(p_Keys, p_Quats, p_Vec3s);
            var s_Compressor = new Compressor();
            var s_Decompressor = new Decompressor();

            var s_Blocks = MakeBlocks(s_Clip);
            var s_Data = s_Compressor.EncodeBlocks(s_Clip, s_Blocks, out var s_Clamped);

            Assert.Equal(0, s_Clamped);
            Assert.True(s_Data.Length > 0, "the encoder produced no bytes at all");

            s_Clip.Data = new List<byte>(s_Data);
            s_Clip.DataSize = (uint)s_Data.Length;

            var s_Back = s_Decompressor.DecodeBlocks(s_Clip, out var s_DofCount);

            Assert.Equal(p_Quats + p_Vec3s, s_DofCount);
            Assert.Equal(s_Blocks.Count, s_Back.Count);

            for (var i = 0; i < s_Blocks.Count; i++)
            {
                for (var j = 0; j < 32; j++)
                    Assert.Equal(s_Blocks[i][j], s_Back[i][j]);
            }

            // And the bytes themselves, which is what an in-place patch has to reproduce.
            var s_Again = s_Compressor.EncodeBlocks(s_Clip, s_Back, out _);
            Assert.Equal(s_Data, s_Again);
        }


        [Fact]
        public void FrameValuesSurviveTheTransform()
        {
            var s_Clip = MakeClip(24, 2, 2);
            var s_Compressor = new Compressor();
            var s_Decompressor = new Decompressor();

            s_Clip.Data = new List<byte>(s_Compressor.EncodeBlocks(s_Clip, MakeBlocks(s_Clip), out _));

            var s_Frames = s_Decompressor.Decode(s_Clip);

            Assert.Equal(24, s_Frames.Length);
            Assert.Equal(4, s_Frames[0].Length);

            var s_Encoded = s_Compressor.Encode(s_Clip, s_Frames, out var s_Bases, out _);
            Apply(s_Clip, s_Encoded, s_Bases);

            var s_Back = s_Decompressor.Decode(s_Clip);

            // Only the vector channels: the decoder normalises quaternions, so a quat's magnitude
            // is gone before the encoder ever sees it and no encoder can put it back.
            var s_Compared = 0;

            for (var f = 0; f < s_Frames.Length; f++)
            {
                for (var d = s_Clip.NumQuats; d < s_Frames[f].Length; d++)
                {
                    var s_Delta = s_Frames[f][d] - s_Back[f][d];
                    Assert.True(s_Delta.Length() < 1e-3f,
                                $"frame {f} dof {d} moved by {s_Delta.Length()}");
                    s_Compared += 1;
                }
            }

            Assert.True(s_Compared > 0, "no vector channels were compared");
        }


        /// <summary>An edit has to actually reach the values, or "writable" means nothing.</summary>
        [Fact]
        public void AnEditedFrameComesBackEdited()
        {
            var s_Clip = MakeClip(16, 1, 1);
            var s_Compressor = new Compressor();
            var s_Decompressor = new Decompressor();

            s_Clip.Data = new List<byte>(s_Compressor.EncodeBlocks(s_Clip, MakeBlocks(s_Clip), out _));

            var s_Frames = s_Decompressor.Decode(s_Clip);
            var s_Before = s_Frames[5][1];

            for (var f = 0; f < s_Frames.Length; f++)
                s_Frames[f][1] = new Vector4(s_Frames[f][1].X + 0.25f, s_Frames[f][1].Y,
                                             s_Frames[f][1].Z, s_Frames[f][1].W);

            var s_Encoded = s_Compressor.Encode(s_Clip, s_Frames, out var s_Bases, out _);

            // The payload must keep its length, or it cannot be patched over the original.
            Assert.Equal(s_Clip.Data.Count, s_Encoded.Length);

            Apply(s_Clip, s_Encoded, s_Bases);
            var s_After = s_Decompressor.Decode(s_Clip)[5][1];

            Assert.True(System.Math.Abs((s_After.X - s_Before.X) - 0.25f) < 1e-2f,
                        $"the edit did not land: {s_Before.X} -> {s_After.X}");
        }
    }
}
