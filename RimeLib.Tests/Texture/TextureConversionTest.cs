using System;
using System.IO;
using RimeLib.IO;
using RimeLib.Texture.Images;
using Xunit;

namespace RimeLib.Tests.Texture
{
    public class TextureConversionTest
    {
        private static readonly TexturePixelFormat[] s_Frostbite2Formats = [TexturePixelFormat.Dxt1, TexturePixelFormat.Dxt5, TexturePixelFormat.Abgr16F];

        private static TextureImage Image(TexturePixelFormat p_Format, byte[] p_Data) => new()
        {
            Kind = TextureKind.Texture2D,
            Format = p_Format,
            Width = 1,
            Height = 1,
            MipCount = 1,
            Data = p_Data,
        };

        private static byte[] SharedExponent(uint p_R, uint p_G, uint p_B, uint p_Exponent)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                s_Writer.Write(p_R | p_G << 9 | p_B << 18 | p_Exponent << 27);
            return s_Stream.ToArray();
        }

        private static float[] Halves(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            var s_Values = new float[p_Data.Length / 2];
            for (var i = 0; i < s_Values.Length; i++)
                s_Values[i] = (float)BitConverter.UInt16BitsToHalf(s_Reader.ReadUInt16());
            return s_Values;
        }

        [Fact]
        public void AFormatTheTargetHasIsKept()
        {
            var s_Image = Image(TexturePixelFormat.Dxt5, new byte[16]);
            Assert.Same(s_Image, TextureConversion.ToFormats(s_Image, s_Frostbite2Formats));
        }

        [Fact]
        public void Dxt1AKeepsItsBlocks()
        {
            var s_Data = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var s_Converted = TextureConversion.ToFormats(Image(TexturePixelFormat.Dxt1A, s_Data), s_Frostbite2Formats);

            Assert.Equal(TexturePixelFormat.Dxt1, s_Converted.Format);
            Assert.Same(s_Data, s_Converted.Data);
            Assert.False(TextureConversion.NeedsData(TexturePixelFormat.Dxt1A, s_Frostbite2Formats));
        }

        [Theory]
        [InlineData(256u, 128u, 1u, 15u, 0.5f, 0.25f, 1f / 512)]
        [InlineData(511u, 0u, 1u, 31u, 65408f, 0f, 128f)]
        [InlineData(1u, 0u, 0u, 0u, 1f / (1 << 24), 0f, 0f)]
        public void SharedExponentBecomesExactHalves(uint p_R, uint p_G, uint p_B, uint p_Exponent, float p_ExpectedR, float p_ExpectedG, float p_ExpectedB)
        {
            var s_Converted = TextureConversion.ToFormats(Image(TexturePixelFormat.R9G9B9E5F, SharedExponent(p_R, p_G, p_B, p_Exponent)), s_Frostbite2Formats);

            Assert.Equal(TexturePixelFormat.Abgr16F, s_Converted.Format);
            Assert.Equal(new[] { p_ExpectedR, p_ExpectedG, p_ExpectedB, 1f }, Halves(s_Converted.Data));
            Assert.True(TextureConversion.NeedsData(TexturePixelFormat.R9G9B9E5F, s_Frostbite2Formats));
        }

        [Fact]
        public void AFormatWithoutALosslessConversionIsRefused()
        {
            Assert.Throws<NotSupportedException>(() => TextureConversion.ToFormats(Image(TexturePixelFormat.Bc7, new byte[16]), s_Frostbite2Formats));
        }

        [Theory]
        [InlineData("World", "World")]
        [InlineData("World_Max1024", "World")]
        [InlineData("VehicleNormalMa", "VehicleNormal")]
        [InlineData("SP_Shanghai_Enl", "Default")]
        public void AGroupGoesUnderItsLongestPrefix(string p_Group, string p_Expected)
        {
            Assert.Equal(p_Expected, TextureConversion.ToGroups(p_Group, ["World", "Vehicle", "VehicleNormal", "Default"]));
        }
    }
}
