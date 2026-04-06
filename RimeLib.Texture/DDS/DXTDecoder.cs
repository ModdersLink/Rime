/**
 * Created By: R. Miceli (grimdoomer)
 * By: https://github.com/grimdoomer
 * 
 * https://github.com/grimdoomer/DeadRisingArcTool/blob/master/DeadRisingArcTool/FileFormats/Bitmaps/Color.cs
 */

namespace RimeLib.Texture.DDS
{
    public class DXTDecoder
    {
        public static byte[] DecodeDXT1Texture(int Width, int Height, byte[] SourceData, bool bigEndian)
        {
            Bitmaps.Color.ColorRGBA[] Color = new Bitmaps.Color.ColorRGBA[5];

            Bitmaps.Color.ColorRGBA CColor;
            Bitmaps.Color.ColorRGBA zeroColor;

            int CData;
            int c1;
            int c2;
            int dptr = 0;

            bool trans;
            byte[] DestData = new byte[(Width * Height) * 4];

            int ChunksPerHLine = Width / 4;
            if (ChunksPerHLine == 0) ChunksPerHLine = 1;

            for (int ptr = 0; ptr < (Width * Height); ptr += 16)
            {
                if (bigEndian == true)
                {
                    c1 = (SourceData[dptr] << 8) | (SourceData[dptr + 1]);
                    c2 = (SourceData[dptr + 2] << 8) | (SourceData[dptr + 3]);
                }
                else
                {
                    c1 = (SourceData[dptr + 1] << 8) | (SourceData[dptr]);
                    c2 = (SourceData[dptr + 3] << 8) | (SourceData[dptr + 2]);
                }

                trans = (!(c1 > c2));

                Color[0] = Bitmaps.Color.ShortToColor(c1);
                Color[1] = Bitmaps.Color.ShortToColor(c2);

                if (!trans)
                {
                    Color[2] = Bitmaps.Color.GradientColors(Color[0], Color[1]);
                    Color[3] = Bitmaps.Color.GradientColors(Color[1], Color[0]);
                }
                else
                {
                    zeroColor = Color[0];
                    Color[2] = Bitmaps.Color.GradientColorsHalf(Color[0], Color[1]);
                    Color[3] = zeroColor;
                }

                if (bigEndian == true)
                {
                    CData = (SourceData[dptr + 7] << 0) | (SourceData[dptr + 6] << 8) |
                        (SourceData[dptr + 5] << 16) | (SourceData[dptr + 4] << 24);
                }
                else
                {
                    CData = (SourceData[dptr + 4] << 0) | (SourceData[dptr + 5] << 8) |
                        (SourceData[dptr + 6] << 16) | (SourceData[dptr + 7] << 24);
                }

                int ChunkNum = ptr / 16;
                long XPos = ChunkNum % ChunksPerHLine;
                long YPos = (ChunkNum - XPos) / ChunksPerHLine;

                long tmp1, tmp2;

                int sizeh = Height < 4 ? Height : 4;
                int sizew = Width < 4 ? Width : 4;

                int x, y;
                for (x = 0; x < sizeh; x++)
                {
                    for (y = 0; y < sizew; y++)
                    {
                        CColor = Color[CData & 3];
                        CData >>= 2;
                        tmp1 = ((YPos * 4 + x) * Width + XPos * 4 + y) * 4;
                        tmp2 = Bitmaps.Color.ColorToInt(CColor);
                        DestData[tmp1] = CColor.b;
                        DestData[tmp1 + 1] = CColor.g;
                        DestData[tmp1 + 2] = CColor.r;
                        DestData[tmp1 + 3] = CColor.a;
                    }
                }
                dptr += 8;
            }
            return DestData;
        }

        public static byte[] DecodeDXT23Texture(int Width, int Height, byte[] SourceData, bool bigEndian)
        {
            Bitmaps.Color.ColorRGBA[] Color = new Bitmaps.Color.ColorRGBA[5];

            Bitmaps.Color.ColorRGBA CColor;
            Bitmaps.Color.ColorRGBA c1, c2, c3, c4;
            int CData;
            byte[] DestData = new byte[(Width * Height) * 4];

            int ChunksPerHLine = Width / 4;
            if (ChunksPerHLine == 0) ChunksPerHLine = 1;

            for (int ptr = 0; ptr < (Width * Height); ptr += 16)
            {
                if (bigEndian == true)
                {
                    c1 = Bitmaps.Color.ShortToColor((SourceData[ptr + 9]) | (SourceData[ptr + 8] << 8));
                    c2 = Bitmaps.Color.ShortToColor((SourceData[ptr + 11]) | (SourceData[ptr + 10] << 8));
                }
                else
                {
                    c1 = Bitmaps.Color.ShortToColor((SourceData[ptr + 8]) | (SourceData[ptr + 9] << 8));
                    c2 = Bitmaps.Color.ShortToColor((SourceData[ptr + 10]) | (SourceData[ptr + 11] << 8));
                }

                c3 = Bitmaps.Color.GradientColors(Color[0], Color[1]);
                c4 = Bitmaps.Color.GradientColors(Color[1], Color[0]);
                Color[0] = c1;
                Color[1] = c2;
                Color[2] = c3;
                Color[3] = c4;

                if (bigEndian == true)
                    CData = (SourceData[ptr + 15] << 0) | (SourceData[ptr + 14] << 8) | (SourceData[ptr + 13] << 16) | (SourceData[ptr + 12] << 24);
                else
                    CData = (SourceData[ptr + 12] << 0) | (SourceData[ptr + 13] << 8) | (SourceData[ptr + 14] << 16) | (SourceData[ptr + 15] << 24);

                int ChunkNum = ptr / 16;
                long XPos = ChunkNum % ChunksPerHLine;
                long YPos = (ChunkNum - XPos) / ChunksPerHLine;

                long ttmp;

                int alpha;
                int sizeh = Height < 4 ? Height : 4;
                int sizew = Width < 4 ? Width : 4;
                int x, y;

                for (x = 0; x < sizeh; x++)
                {
                    if (bigEndian == true)
                        alpha = SourceData[ptr + (2 * x) + 1] | (SourceData[ptr + (2 * x)]) << 8;
                    else
                        alpha = SourceData[ptr + (2 * x)] | (SourceData[ptr + (2 * x) + 1]) << 8;

                    for (y = 0; y < sizew; y++)
                    {
                        CColor = Color[CData & 3];
                        CData >>= 2;
                        CColor.a = (byte)((alpha & 15) * 16);
                        alpha >>= 4;
                        ttmp = ((YPos * 4 + x) * Width + XPos * 4 + y) * 4;

                        DestData[ttmp] = CColor.b;
                        DestData[ttmp + 1] = CColor.g;
                        DestData[ttmp + 2] = CColor.r;
                        DestData[ttmp + 3] = CColor.a;
                    }
                }
            }
            return DestData;
        }

        public static byte[] DecodeDXT45Texture(int Width, int Height, byte[] SourceData, bool bigEndian)
        {
            Bitmaps.Color.ColorRGBA[] Color = new Bitmaps.Color.ColorRGBA[4];
            Bitmaps.Color.ColorRGBA CColor;

            int CData;
            byte[] DestData = new byte[(Width * Height) * 4];

            int ChunksPerHLine = Width / 4;
            if (ChunksPerHLine == 0) ChunksPerHLine = 1;

            int xBlocks = Width / 4;
            int yBlocks = Height / 4;

            for (int y = 0; y < yBlocks; y++)
            {
                for (int x = 0; x < xBlocks; x++)
                {
                    byte[] Alpha = new byte[8];

                    int ptr = ((y * xBlocks) + x) * 16;


                    if (bigEndian == false)
                    {
                        Color[0] = Bitmaps.Color.ShortToColor(SourceData[ptr + 8] | (SourceData[ptr + 9] << 8));
                        Color[1] = Bitmaps.Color.ShortToColor(SourceData[ptr + 10] | (SourceData[ptr + 11] << 8));
                        Color[2] = Bitmaps.Color.GradientColors(Color[0], Color[1]);
                        Color[3] = Bitmaps.Color.GradientColors(Color[1], Color[0]);

                        CData = (SourceData[ptr + 12] << 0) | (SourceData[ptr + 13] << 8) | (SourceData[ptr + 14] << 16) | (SourceData[ptr + 15] << 24);

                        Alpha[0] = SourceData[ptr];
                        Alpha[1] = SourceData[ptr + 1];
                    }
                    else
                    {
                        Color[0] = Bitmaps.Color.ShortToColor(SourceData[ptr + 9] | (SourceData[ptr + 8] << 8));
                        Color[1] = Bitmaps.Color.ShortToColor(SourceData[ptr + 11] | (SourceData[ptr + 10] << 8));
                        Color[2] = Bitmaps.Color.GradientColors(Color[0], Color[1]);
                        Color[3] = Bitmaps.Color.GradientColors(Color[1], Color[0]);

                        CData = (SourceData[ptr + 15]) | (SourceData[ptr + 14] << 8) | (SourceData[ptr + 13] << 16) | (SourceData[ptr + 12] << 24);

                        Alpha[0] = SourceData[ptr + 1];
                        Alpha[1] = SourceData[ptr];
                    }

                    //Do the alphas
                    if (Alpha[0] > Alpha[1])
                    {
                        // 8-alpha block:  derive the other six alphas.
                        // Bit code 000 = alpha_0, 001 = alpha_1, others are interpolated.

                        Alpha[2] = (byte)((6 * Alpha[0] + 1 * Alpha[1] + 3) / 7); // bit code 010
                        Alpha[3] = (byte)((5 * Alpha[0] + 2 * Alpha[1] + 3) / 7); // bit code 011
                        Alpha[4] = (byte)((4 * Alpha[0] + 3 * Alpha[1] + 3) / 7); // bit code 100
                        Alpha[5] = (byte)((3 * Alpha[0] + 4 * Alpha[1] + 3) / 7); // bit code 101
                        Alpha[6] = (byte)((2 * Alpha[0] + 5 * Alpha[1] + 3) / 7); // bit code 110
                        Alpha[7] = (byte)((1 * Alpha[0] + 6 * Alpha[1] + 3) / 7); // bit code 111
                    }
                    else
                    {
                        // 6-alpha block.
                        // Bit code 000 = alpha_0, 001 = alpha_1, others are interpolated.
                        Alpha[2] = (byte)((4 * Alpha[0] + 1 * Alpha[1] + 2) / 5); // Bit code 010
                        Alpha[3] = (byte)((3 * Alpha[0] + 2 * Alpha[1] + 2) / 5); // Bit code 011
                        Alpha[4] = (byte)((2 * Alpha[0] + 3 * Alpha[1] + 2) / 5); // Bit code 100
                        Alpha[5] = (byte)((1 * Alpha[0] + 4 * Alpha[1] + 2) / 5); // Bit code 101
                        Alpha[6] = 0;            // Bit code 110
                        Alpha[7] = 255;          // Bit code 111
                    }

                    // Build the alpha mask.
                    long alphaMask = 0;
                    if (bigEndian == false)
                    {
                        alphaMask = SourceData[ptr + 7];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 6];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 5];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 4];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 3];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 2];
                    }
                    else
                    {
                        alphaMask = SourceData[ptr + 6];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 7];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 4];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 5];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 2];
                        alphaMask <<= 8;
                        alphaMask |= SourceData[ptr + 3];
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            int pixelDataStart = (Width * (y * 4 + i) * 4) + ((x * 4 + j) * 4);

                            CColor = Color[CData & 3];
                            CData >>= 2;

                            CColor.a = Alpha[alphaMask & 7];
                            alphaMask >>= 3;

                            DestData[pixelDataStart] = CColor.b;
                            DestData[pixelDataStart + 1] = CColor.g;
                            DestData[pixelDataStart + 2] = CColor.r;
                            DestData[pixelDataStart + 3] = CColor.a;
                        }
                    }
                }
            }
            return DestData;
        }

        public static byte[] DecodeR8G8(float Width, float Height, byte[] SourceData, bool bigEndian)
        {
            // Allocate a new buffer to fit ARGB colors.
            byte[] decodedData = new byte[SourceData.Length * 2];

            // Loop through all of the pixels and convert to ARGB.
            for (int ptr = 0; ptr < SourceData.Length; ptr += 2)
            {
                if (bigEndian == true)
                {
                    decodedData[(ptr * 2)] = 255;
                    decodedData[(ptr * 2) + 1] = CalculateU8V8Color(SourceData[ptr]);
                    decodedData[(ptr * 2) + 2] = CalculateU8V8Color(SourceData[ptr + 1]);
                    decodedData[(ptr * 2) + 3] = 0;
                }
                else
                {
                    decodedData[(ptr * 2)] = 255;
                    decodedData[(ptr * 2) + 1] = CalculateU8V8Color(SourceData[ptr + 1]);
                    decodedData[(ptr * 2) + 2] = CalculateU8V8Color(SourceData[ptr]);
                    decodedData[(ptr * 2) + 3] = 0;
                }
            }

            // Return the new buffer.
            return decodedData;

        }

        public static byte CalculateU8V8Color(byte Color)
        {
            if (Color == 0)
            {
                Color = 127;
                return Color;
            }
            else
            {
                Color += 127;
                return (byte)Color;
            }
        }

        /// <summary>
        /// Decodes BC5 (DXN/ATI2) compressed texture data to BGRA8888 format.
        /// BC5 is a 2-channel format commonly used for normal maps.
        /// </summary>
        public static byte[] DecodeBC5Texture(int width, int height, byte[] sourceData, bool bigEndian)
        {
            byte[] destData = new byte[width * height * 4];
            int blockWidth = (width + 3) / 4;
            int blockHeight = (height + 3) / 4;

            for (int blockY = 0; blockY < blockHeight; blockY++)
            {
                for (int blockX = 0; blockX < blockWidth; blockX++)
                {
                    int blockIndex = (blockY * blockWidth + blockX) * 16;
                    if (blockIndex + 16 <= sourceData.Length)
                    {
                        DecodeBC5Block(sourceData, blockIndex, destData, blockX * 4, blockY * 4, width, height);
                    }
                }
            }

            return destData;
        }

        private static void DecodeBC5Block(byte[] sourceData, int blockOffset, byte[] destData, int blockX, int blockY, int width, int height)
        {
            // Red channel: bytes 0-7
            byte[] redPalette = new byte[8];
            byte red0 = sourceData[blockOffset];
            byte red1 = sourceData[blockOffset + 1];
            GenerateBC5Palette(red0, red1, redPalette);

            // Green channel: bytes 8-15
            byte[] greenPalette = new byte[8];
            byte green0 = sourceData[blockOffset + 8];
            byte green1 = sourceData[blockOffset + 9];
            GenerateBC5Palette(green0, green1, greenPalette);

            // Decode 3-bit indices for red channel (6 bytes = 48 bits for 16 3-bit indices)
            byte[] redIndices = DecodeBC5Indices(sourceData, blockOffset + 2);
            // Decode 3-bit indices for green channel
            byte[] greenIndices = DecodeBC5Indices(sourceData, blockOffset + 10);

            // Map indices to pixels
            for (int i = 0; i < 16; i++)
            {
                int pixelX = blockX + (i % 4);
                int pixelY = blockY + (i / 4);

                if (pixelX >= width || pixelY >= height)
                    continue;

                int destOffset = (pixelY * width + pixelX) * 4;
                
                // BC5 format stores Red in the first channel and Green in the second
                // For normal maps, this represents X (red) and Y (green) components
                byte redValue = redPalette[redIndices[i]];
                byte greenValue = greenPalette[greenIndices[i]];

                destData[destOffset] = redValue;      // B
                destData[destOffset + 1] = greenValue; // G
                destData[destOffset + 2] = redValue;  // R
                destData[destOffset + 3] = 255;       // A
            }
        }

        private static void GenerateBC5Palette(byte endpoint0, byte endpoint1, byte[] palette)
        {
            palette[0] = endpoint0;
            palette[1] = endpoint1;

            if (endpoint0 > endpoint1)
            {
                palette[2] = (byte)((6 * endpoint0 + 1 * endpoint1 + 3) / 7);
                palette[3] = (byte)((5 * endpoint0 + 2 * endpoint1 + 3) / 7);
                palette[4] = (byte)((4 * endpoint0 + 3 * endpoint1 + 3) / 7);
                palette[5] = (byte)((3 * endpoint0 + 4 * endpoint1 + 3) / 7);
                palette[6] = (byte)((2 * endpoint0 + 5 * endpoint1 + 3) / 7);
                palette[7] = (byte)((1 * endpoint0 + 6 * endpoint1 + 3) / 7);
            }
            else
            {
                palette[2] = (byte)((4 * endpoint0 + 1 * endpoint1 + 2) / 5);
                palette[3] = (byte)((3 * endpoint0 + 2 * endpoint1 + 2) / 5);
                palette[4] = (byte)((2 * endpoint0 + 3 * endpoint1 + 2) / 5);
                palette[5] = (byte)((1 * endpoint0 + 4 * endpoint1 + 2) / 5);
                palette[6] = 0;
                palette[7] = 255;
            }
        }

        private static byte[] DecodeBC5Indices(byte[] sourceData, int offset)
        {
            byte[] indices = new byte[16];
            
            // BC5 uses 3-bit indices for each pixel (16 pixels = 48 bits = 6 bytes)
            // The bits are stored in little-endian order
            ulong indexBlock = 0;
            for (int i = 0; i < 6; i++)
            {
                indexBlock |= ((ulong)sourceData[offset + i]) << (i * 8);
            }

            // Extract 3-bit index for each of 16 pixels
            for (int i = 0; i < 16; i++)
            {
                indices[i] = (byte)((indexBlock >> (i * 3)) & 0x7);
            }

            return indices;
        }

        public static byte[] DecodeARGB8888(int width, int height, byte[] sourceData)
        {
            byte[] dest = new byte[width * height * 4];
            for (int i = 0; i < sourceData.Length && i + 3 < dest.Length; i += 4)
            {
                dest[i] = sourceData[i + 3];     // B
                dest[i + 1] = sourceData[i + 2]; // G
                dest[i + 2] = sourceData[i + 1]; // R
                dest[i + 3] = sourceData[i];     // A
            }
            return dest;
        }

        public static byte[] DecodeL8(int width, int height, byte[] sourceData)
        {
            byte[] dest = new byte[width * height * 4];
            for (int i = 0; i < sourceData.Length; i++)
            {
                int destIdx = i * 4;
                if (destIdx + 3 < dest.Length)
                {
                    dest[destIdx] = sourceData[i];     // B (grayscale value)
                    dest[destIdx + 1] = sourceData[i]; // G (grayscale value)
                    dest[destIdx + 2] = sourceData[i]; // R (grayscale value)
                    dest[destIdx + 3] = 255;           // A (fully opaque)
                }
            }
            return dest;
        }

        public static byte[] DecodeBC4(int width, int height, byte[] sourceData)
        {
            byte[] dest = new byte[width * height * 4];
            int destIdx = 0;

            for (int y = 0; y < height; y += 4)
            {
                for (int x = 0; x < width; x += 4)
                {
                    if (destIdx >= sourceData.Length - 7)
                        break;

                    // BC4 block is 8 bytes
                    byte red0 = sourceData[destIdx];
                    byte red1 = sourceData[destIdx + 1];
                    ulong indices = System.BitConverter.ToUInt64(sourceData, destIdx + 2);

                    // Decode the 4x4 block
                    for (int by = 0; by < 4; by++)
                    {
                        for (int bx = 0; bx < 4; bx++)
                        {
                            int px = x + bx;
                            int py = y + by;

                            if (px >= width || py >= height)
                                continue;

                            int idx = by * 4 + bx;
                            int bitIdx = idx * 3;
                            byte palette = (byte)((indices >> bitIdx) & 0x7);

                            byte red = palette == 0 ? red0 : (palette == 1 ? red1 : InterpolateBC4(red0, red1, palette));

                            int pixelOffset = (py * width + px) * 4;
                            dest[pixelOffset] = red;       // B
                            dest[pixelOffset + 1] = red;   // G
                            dest[pixelOffset + 2] = red;   // R
                            dest[pixelOffset + 3] = 255;   // A (fully opaque)
                        }
                    }

                    destIdx += 8;
                }
            }

            return dest;
        }

        private static byte InterpolateBC4(byte red0, byte red1, byte palette)
        {
            if (red0 > red1)
            {
                return palette switch
                {
                    2 => (byte)((6 * red0 + 1 * red1) / 7),
                    3 => (byte)((5 * red0 + 2 * red1) / 7),
                    4 => (byte)((4 * red0 + 3 * red1) / 7),
                    5 => (byte)((3 * red0 + 4 * red1) / 7),
                    6 => (byte)((2 * red0 + 5 * red1) / 7),
                    7 => (byte)((1 * red0 + 6 * red1) / 7),
                    _ => 0
                };
            }
            else
            {
                return palette switch
                {
                    2 => (byte)((4 * red0 + 1 * red1) / 5),
                    3 => (byte)((3 * red0 + 2 * red1) / 5),
                    4 => (byte)((2 * red0 + 3 * red1) / 5),
                    5 => (byte)((1 * red0 + 4 * red1) / 5),
                    6 => (byte)0,
                    7 => (byte)255,
                    _ => 0
                };
            }
        }
    }
}
