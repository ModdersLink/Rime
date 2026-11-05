using System.Linq;
using RimeLib.Texture.Images;
using Xunit;

namespace RimeLib.Tests.Texture
{
    public class TextureImageTest
    {
        private static TextureImage Image(TexturePixelFormat p_Format, int p_Width, int p_Height, int p_Mips, int p_Slices = 1) => new()
        {
            Kind = p_Slices > 1 ? TextureKind.Texture2DArray : TextureKind.Texture2D,
            Format = p_Format,
            Width = p_Width,
            Height = p_Height,
            Depth = p_Slices,
            SliceCount = p_Slices,
            MipCount = p_Mips,
        };

        [Theory]
        [InlineData(TexturePixelFormat.Dxt1, 256, 256, 32768)]
        [InlineData(TexturePixelFormat.Dxt1, 2, 1, 8)]
        [InlineData(TexturePixelFormat.Dxt5, 4, 4, 16)]
        [InlineData(TexturePixelFormat.Bc7, 1, 1, 16)]
        [InlineData(TexturePixelFormat.Argb8888, 3, 2, 24)]
        [InlineData(TexturePixelFormat.Rgb888, 1, 1, 3)]
        public void SurfacesAreWholeBlocksOrTexels(TexturePixelFormat p_Format, int p_Width, int p_Height, long p_Size)
        {
            Assert.Equal(p_Size, p_Format.SurfaceSize(p_Width, p_Height));
        }

        [Fact]
        public void PaddedRowsRoundUpToTheAlignment()
        {
            Assert.Equal(8, TexturePixelFormat.L8.SurfaceSize(2, 2, 4));
            Assert.Equal(4, TexturePixelFormat.L8.SurfaceSize(2, 1, 4));
            Assert.Equal(16, TexturePixelFormat.L8.SurfaceSize(4, 4, 4));
        }

        [Fact]
        public void ChainIsEveryLevelOfOneSlice()
        {
            var s_Image = Image(TexturePixelFormat.L8, 8, 8, 4, 2);
            Assert.Equal(64 + 16 + 4 + 1, s_Image.ChainSize());
            Assert.Equal(2 * (64 + 16 + 4 + 1), s_Image.DataSize());
            Assert.Equal(2 * (64 + 16 + 8 + 4), s_Image.DataSize(4));
        }

        [Fact]
        public void RealignedRowsComeBackAsTheyWere()
        {
            var s_Image = Image(TexturePixelFormat.L8, 8, 8, 4, 2);
            var s_Tight = Enumerable.Range(0, (int)s_Image.DataSize()).Select(p_I => (byte)p_I).ToArray();

            var s_Padded = s_Image.RealignRows(s_Tight, 1, 4);
            Assert.Equal(s_Image.DataSize(4), s_Padded.Length);

            // The 2x2 level's second row starts after its first row's padding.
            var s_Level2 = 64 + 16;
            Assert.Equal(s_Tight[s_Level2 + 2], s_Padded[s_Level2 + 4]);

            Assert.Equal(s_Tight, s_Image.RealignRows(s_Padded, 4, 1));
        }

        [Fact]
        public void AlignedDataIsNotCopied()
        {
            var s_Image = Image(TexturePixelFormat.Dxt1, 64, 64, 3);
            var s_Data = new byte[s_Image.DataSize()];
            Assert.Same(s_Data, s_Image.RealignRows(s_Data, 1, 4));
        }
    }
}
