using System.Collections.Generic;
using RimeLib.Animation.Frostbite2_0.EA.Compression.Curve;
using RimeLib.Animation.Frostbite2_0.EA.Compression.Vbr;
using Xunit;

namespace RimeLib.Tests.Animation
{
    /// <summary>
    /// The CURV and VBR codecs on synthetic clips. The real proof is <c>check_animation_codec *</c>
    /// over BF3's 322 banks, but that needs a game mount; this runs anywhere and pins the two
    /// things these codecs get wrong SILENTLY, because neither failure changes an array's length:
    ///
    ///   CURV  the group/key/channel walk. Values is key-major and the groups concatenate, so a
    ///         layout read the other way round still produces the right number of floats and puts
    ///         every one of them in the wrong column.
    ///   VBR   the section offsets. The payload is one byte array with six sections in it named
    ///         only by SIZE, and a constant read from the wrong offset is still a valid byte.
    /// </summary>
    public class CurveVbrCodecTest
    {
        /// <summary>Two groups with different key and channel counts, so a walk that assumed one
        /// group -- or assumed both groups share a key count -- cannot pass.</summary>
        private static ant.CurveAnimationAsset MakeCurve()
        {
            var s_Clip = new ant.CurveAnimationAsset
            {
                FPS = 30.0f,
                NumRotations = 2,
                NumVectors = 1,
                NumFloats = 2,
            };

            s_Clip.KeysBlocks.Add(new ant.CurveAnimationAsset__KeysBlock
            {
                NumChannelGroups = 2,
                KeysCount = 7,
            });

            s_Clip.ChannelGroups.Add(new ant.CurveAnimationAsset__ChannelGroup
            {
                NumKeys = 4,
                NumChannels = 3,
            });

            s_Clip.ChannelGroups.Add(new ant.CurveAnimationAsset__ChannelGroup
            {
                NumKeys = 3,
                NumChannels = 2,
            });

            foreach (var s_Time in new ushort[] { 0, 4, 9, 15, 0, 8, 15 })
                s_Clip.Keys.Add(s_Time);

            // Slots 0..10 are 2 rotations (3 each), 1 vector (3) and 2 scalars; the five animated
            // ones below and the six constants together have to account for all eleven.
            foreach (var s_Slot in new ushort[] { 0, 4, 7, 2, 9 })
                s_Clip.ChannelOffsets.Add(s_Slot);

            foreach (var s_Slot in new ushort[] { 1, 3, 5, 6, 8, 10 })
                s_Clip.ConstOffsets.Add(s_Slot);

            for (var i = 0; i < 6; i++)
                s_Clip.Consts.Add(i * 0.5f - 1.0f);

            // 4*3 + 3*2 == 18, key-major within each group.
            for (var i = 0; i < 18; i++)
                s_Clip.Values.Add(i * 1.25f);

            return s_Clip;
        }


        [Fact]
        public void CurveGroupsSplitAndRebuildExactly()
        {
            var s_Clip = MakeCurve();
            var s_Decoded = CurveCodec.Decode(s_Clip);

            Assert.Equal(2, s_Decoded.Groups.Count);
            Assert.Equal(11, s_Decoded.SlotCount);
            Assert.True(s_Decoded.KeyTimesAccounted);

            // The walk, spelled out: group 1 starts at value 12 and key 4, and its channels are
            // the LAST two of ChannelOffsets. An off-by-one group cursor passes every length
            // check and fails exactly here.
            Assert.Equal(new ushort[] { 0, 8, 15 }, s_Decoded.Groups[1].KeyTimes);
            Assert.Equal(new[] { 2, 9 }, s_Decoded.Groups[1].ChannelSlots);
            Assert.Equal(12 * 1.25f, s_Decoded.Groups[1].Values[0][0]);
            Assert.Equal(13 * 1.25f, s_Decoded.Groups[1].Values[0][1]);
            Assert.Equal(17 * 1.25f, s_Decoded.Groups[1].Values[2][1]);

            var s_Values = CurveCodec.EncodeValues(s_Clip, s_Decoded);
            var s_Consts = CurveCodec.EncodeConsts(s_Clip, s_Decoded);

            Assert.Equal(s_Clip.Values.Count, s_Values.Length);
            Assert.Equal(s_Clip.Values, s_Values);
            Assert.Equal(s_Clip.Consts, s_Consts);
        }


        [Fact]
        public void ACurveEditLandsOnExactlyOneValue()
        {
            var s_Clip = MakeCurve();
            var s_Decoded = CurveCodec.Decode(s_Clip);

            s_Decoded.Groups[1].Values[2][1] += 0.25f;

            var s_Values = CurveCodec.EncodeValues(s_Clip, s_Decoded);
            var s_Moved = 0;

            for (var i = 0; i < s_Values.Length; i++)
            {
                if (s_Values[i] != s_Clip.Values[i])
                    s_Moved += 1;
            }

            // One value in, one value out. Byte equality alone cannot tell a writer from a copier;
            // this is the half that can.
            Assert.Equal(1, s_Moved);
            Assert.Equal(17 * 1.25f + 0.25f, s_Values[17]);
        }


        [Fact]
        public void CurveRefusesAShapeTheClipCannotHold()
        {
            var s_Clip = MakeCurve();
            var s_Decoded = CurveCodec.Decode(s_Clip);

            s_Decoded.Groups[0].Values = new[] { new[] { 1.0f, 2.0f, 3.0f } };

            Assert.Throws<System.InvalidOperationException>(
                () => CurveCodec.EncodeValues(s_Clip, s_Decoded));
        }


        /// <summary>A clip with every section non-empty, so a decoder that forgot one lands in the
        /// wrong place instead of coincidentally landing at zero.</summary>
        private static ant.VbrAnimationAsset MakeVbr()
        {
            var s_Clip = new ant.VbrAnimationAsset
            {
                QuatMin = -1.0f,
                QuatMax = 1.0f,
                TrajMin = -2.0f,
                TrajMax = 2.0f,
                Vec3Min = -2.0f,
                Vec3Max = 2.0f,
                FloatMin = 0.0f,
                FloatMax = 10.0f,
                QuaternionCount = 1,
                Vector3Count = 1,
                FloatCount = 1,
                ConstQuaternionCount = 1,
                ConstVector3Count = 1,
                ConstFloatCount = 2,
                KeyTimeSize = 3,
                NumKeys = 8,
                ConstChanMapSize = 5,
                VectorOffsetSize = 2,
                FloatOffsetSize = 1,
                ConstPaletteSize = 4,
            };

            foreach (var s_Entry in new[] { 0.0f, 0.5f, 1.0f, 0.25f })
                s_Clip.ConstantPalette.Add(s_Entry);

            s_Clip.FrameBlockSizes.Add(6);

            // 3 key-time + 9 constant index + 5 chan map + 2 + 1 + (4+3+1)*4 descriptor + 6 block.
            var s_Length = 3 + 9 + 5 + 2 + 1 + 8 * 4 + 6;

            for (var i = 0; i < s_Length; i++)
                s_Clip.Data.Add((byte)(200 + i));

            // The constant indices, at their own offset: quat xyzw, vec3 xyz, then two scalars.
            var s_Indices = new byte[] { 1, 0, 0, 2, 1, 3, 1, 0, 2 };

            for (var i = 0; i < s_Indices.Length; i++)
                s_Clip.Data[3 + i] = s_Indices[i];

            return s_Clip;
        }


        [Fact]
        public void VbrSectionsAccountForThePayload()
        {
            var s_Clip = MakeVbr();
            var s_Sections = VbrCodec.Split(s_Clip);

            Assert.Equal(s_Clip.Data.Count, s_Sections.Accounted);
            Assert.Equal(3, s_Sections.ConstIndices);
            Assert.Equal(9, s_Sections.ConstIndexCount);
            Assert.Equal(8, s_Sections.AnimatedComponents);
            Assert.Equal(3 + 9 + 5 + 2 + 1, s_Sections.Descriptors);
            Assert.Equal(3 + 9 + 5 + 2 + 1 + 32, s_Sections.Blocks);
        }


        [Fact]
        public void VbrRefusesAPayloadTheHeaderDoesNotAccountFor()
        {
            var s_Clip = MakeVbr();
            s_Clip.Data.Add(0);

            Assert.Throws<System.InvalidOperationException>(() => VbrCodec.Split(s_Clip));
        }


        [Fact]
        public void VbrConstantsDecodeThroughTheClipsOwnRange()
        {
            var s_Values = VbrCodec.DecodeConstants(MakeVbr());

            // Indices 1,0,0,2 through the quaternion window [-1,1]: 0.5 -> 0, 0 -> -1, 1 -> 1.
            Assert.Equal(new[] { 0.0f, -1.0f, -1.0f, 1.0f }, new[]
            {
                s_Values[0], s_Values[1], s_Values[2], s_Values[3],
            });

            // Indices 1,3,1 through the vector window [-2,2].
            Assert.Equal(new[] { 0.0f, -1.0f, 0.0f }, new[]
            {
                s_Values[4], s_Values[5], s_Values[6],
            });

            // Indices 0,2 through the scalar window [0,10].
            Assert.Equal(new[] { 0.0f, 10.0f }, new[] { s_Values[7], s_Values[8] });
        }


        [Fact]
        public void VbrConstantsReEncodeToTheSameBytes()
        {
            var s_Clip = MakeVbr();
            var s_Values = VbrCodec.DecodeConstants(s_Clip);
            var s_Data = VbrCodec.EncodeConstants(s_Clip, s_Values, out var s_Approx, out var s_Err);

            Assert.Equal(0, s_Approx);
            Assert.Equal(0.0, s_Err);
            Assert.Equal(s_Clip.Data, new List<byte>(s_Data));
        }


        [Fact]
        public void AVbrConstantEditMovesExactlyOneByte()
        {
            var s_Clip = MakeVbr();
            var s_Values = VbrCodec.DecodeConstants(s_Clip);

            // A value the palette already carries, so the write is an index change and not a snap.
            s_Values[5] = 2.0f;

            var s_Data = VbrCodec.EncodeConstants(s_Clip, s_Values, out var s_Approx, out _);
            var s_Moved = 0;

            for (var i = 0; i < s_Data.Length; i++)
            {
                if (s_Data[i] != s_Clip.Data[i])
                    s_Moved += 1;
            }

            Assert.Equal(0, s_Approx);
            Assert.Equal(1, s_Moved);
            Assert.Equal(2, s_Data[3 + 5]);

            // And the frame blocks -- which this codec does NOT decode -- came through untouched.
            var s_Sections = VbrCodec.Split(s_Clip);

            for (var i = s_Sections.Blocks; i < s_Data.Length; i++)
                Assert.Equal(s_Clip.Data[i], s_Data[i]);
        }
    }
}
