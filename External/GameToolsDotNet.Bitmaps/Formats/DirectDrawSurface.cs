using SharpDX.Direct3D11;
using SharpDX.DXGI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GameToolsDotNet.Bitmaps.Formats
{
    [Flags]
    public enum ResourceMiscFlags
    {
        DDS_RESOURCE_MISC_TEXTURECUBE = 04,
    }

    public struct DDS_HEADER_DXT10
    {
        public Format dxgiFormat;
        public ResourceDimension resourceDimension;
        public ResourceMiscFlags miscFlag;
        public int arraySize;
        public int miscFlags2;
    }

    [Flags]
    public enum DDPF : int
    {
        DDPF_ALPHAPIXELS = 0x1,
        DDPF_ALPHA = 0x2,
        DDPF_FOURCC = 0x4,
        DDPF_RGB = 0x40,
        DDPF_YUV = 0x200,
        DDPF_LUMINANCE = 0x20000,
        DDPF_BUMPDUDV = 0x80000
    }

    public struct DDS_PIXELFORMAT
    {
        public const int kSizeOf = 32;

        public int dwSize;
        public DDPF dwFlags;
        public int dwFourCC;
        public int dwRGBBitCount;
        public uint dwRBitMask;
        public uint dwGBitMask;
        public uint dwBBitMask;
        public uint dwABitMask;
    }

    [Flags]
    public enum DDSCAPS : int
    {
        DDSCAPS_COMPLEX = 0x8,
        DDSCAPS_TEXTURE = 0x1000,
        DDSCAPS_MIPMAP = 0x400000
    }

    [Flags]
    public enum DDSCAPS2 : int
    {
        DDSCAPS2_CUBEMAP = 0x200,
        DDSCAPS2_CUBEMAP_POSITIVEX = 0x400,
        DDSCAPS2_CUBEMAP_NEGATIVEX = 0x800,
        DDSCAPS2_CUBEMAP_POSITIVEY = 0x1000,
        DDSCAPS2_CUBEMAP_NEGATIVEY = 0x2000,
        DDSCAPS2_CUBEMAP_POSITIVEZ = 0x4000,
        DDSCAPS2_CUBEMAP_NEGATIVEZ = 0x8000,
        DDSCAPS2_VOLUME = 0x200000,
        DDSCAPS2_CUBEMAP_ALLFACES = DDSCAPS2_CUBEMAP_POSITIVEX | DDSCAPS2_CUBEMAP_NEGATIVEX |
            DDSCAPS2_CUBEMAP_POSITIVEY | DDSCAPS2_CUBEMAP_NEGATIVEY | DDSCAPS2_CUBEMAP_POSITIVEZ | DDSCAPS2_CUBEMAP_NEGATIVEZ
    }

    [Flags]
    public enum DDSD_FLAGS : int
    {
        DDSD_CAPS = 0x1,
        DDSD_HEIGHT = 0x2,
        DDSD_WIDTH = 0x4,
        DDSD_PITCH = 0x8,
        DDSD_PIXELFORMAT = 0x1000,
        DDSD_MIPMAPCOUNT = 0x20000,
        DDSD_LINEARSIZE = 0x80000,
        DDSD_DEPTH = 0x800000
    }

    public struct DDS_HEADER
    {
        public const int kSizeOf = 124;
        public const int kMagic = 0x20534444;   // 'DDS '

        public int dwMagic;
        public int dwSize;              // Size of the header
        public DDSD_FLAGS dwFlags;      // See DDSD_FLAGS
        public int dwHeight;
        public int dwWidth;
        public int dwPitchOrLinearSize;
        public int dwDepth;
        public int dwMipMapCount;
        public int[] dwReserved1; // 11
        public DDS_PIXELFORMAT ddspf;
        public DDSCAPS dwCaps;
        public DDSCAPS2 dwCaps2;
        public int dwCaps3;
        public int dwCaps4;
        public int dwReserved2;
    }

    public class DirectDrawSurface
    {
        public DDS_HEADER header;
        private DDS_HEADER_DXT10 dxt10header;

        public byte[] PixelBuffer { get; private set; }

        public DDSD_FLAGS Flags { get { return this.header.dwFlags; } }
        public int Width { get { return this.header.dwWidth; } }
        public int Height { get { return this.header.dwHeight; } }
        public int Depth { get { return this.header.dwDepth; } }
        public int MipMapCount { get { return this.header.dwMipMapCount; } }

        private Format format = Format.Unknown;
        public Format Format { get { return this.format; } }
        public DDPF PixelFormatFlags { get { return this.header.ddspf.dwFlags; } }
        public int BitCount { get { return this.header.ddspf.dwRGBBitCount; } }
        public uint RBitMask { get { return this.header.ddspf.dwRBitMask; } }
        public uint GBitMask { get { return this.header.ddspf.dwGBitMask; } }
        public uint BBitMask { get { return this.header.ddspf.dwBBitMask; } }
        public uint ABitMask { get { return this.header.ddspf.dwABitMask; } }
        public DDSCAPS Capabilities { get { return this.header.dwCaps; } }
        public DDSCAPS2 Capabilities2 { get { return this.header.dwCaps2; } }

        protected DirectDrawSurface()
        {

        }

        public bool WriteToFile(string fileName)
        {
            BinaryWriter writer = null;

            try
            {
                // Open the output file in an EndianWriter.
                writer = new BinaryWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None));
            }
            catch (Exception e)
            {
                // Failed to open the output file for writing.
                return false;
            }

            // Write the normal DDS header.
            writer.Write(this.header.dwMagic);
            writer.Write(this.header.dwSize);
            writer.Write((int)this.header.dwFlags);
            writer.Write(this.header.dwHeight);
            writer.Write(this.header.dwWidth);
            writer.Write(this.header.dwPitchOrLinearSize);
            writer.Write(this.header.dwDepth);
            writer.Write(this.header.dwMipMapCount);
            writer.Write(new byte[11 * 4]);
            writer.Write(this.header.ddspf.dwSize);
            writer.Write((int)this.header.ddspf.dwFlags);
            writer.Write(this.header.ddspf.dwFourCC);
            writer.Write(this.header.ddspf.dwRGBBitCount);
            writer.Write(this.header.ddspf.dwRBitMask);
            writer.Write(this.header.ddspf.dwGBitMask);
            writer.Write(this.header.ddspf.dwBBitMask);
            writer.Write(this.header.ddspf.dwABitMask);
            writer.Write((int)this.header.dwCaps);
            writer.Write((int)this.header.dwCaps2);
            writer.Write(this.header.dwCaps3);
            writer.Write(this.header.dwCaps4);
            writer.Write(new byte[4]);

            // Check if we are using a DX10 header and if so write it to file.
            if (this.header.ddspf.dwFourCC == MakeFourCC("DX10"))
            {
                // Write the dx10 header.
                writer.Write((int)this.dxt10header.dxgiFormat);
                writer.Write((int)this.dxt10header.resourceDimension);
                writer.Write((int)this.dxt10header.miscFlag);
                writer.Write(this.dxt10header.arraySize);
                writer.Write(this.dxt10header.miscFlags2);
            }

            // Write the pixel data to file.
            writer.Write(this.PixelBuffer);

            // Close the file and return.
            writer.Close();
            return true;
        }

        public static DirectDrawSurface FromFile(string filePath)
        {
            BinaryReader reader = null;

            try
            {
                // Open the file for reading.
                reader = new BinaryReader(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read));
            }
            catch (Exception e)
            {
                // Failed to open the file for reading.
                return null;
            }

            // Check if the file is large enough to contain the header.
            if (reader.BaseStream.Length < DDS_HEADER.kSizeOf)
            {
                // Image is too small to be valid.
                reader.Close();
                return null;
            }

            // Parse the dds image.
            DirectDrawSurface image = FromStream(reader);

            // Close the reader and return.
            reader.Close();
            return image;
        }

        public static DirectDrawSurface FromBuffer(byte[] data)
        {
            // Create a new memory stream from the buffer.
            using (MemoryStream ms = new MemoryStream(data))
            {
                BinaryReader reader = new BinaryReader(ms);

                // Parse the dds image from memory.
                DirectDrawSurface image = FromStream(reader);

                // Close the reader and return.
                reader.Close();
                return image;
            }
        }

        private static DirectDrawSurface FromStream(BinaryReader reader)
        {
            // Create a new DirectDrawSurface we can populate with info.
            DirectDrawSurface image = new DirectDrawSurface();
            image.header = new DDS_HEADER();
            image.header.dwMagic = reader.ReadInt32();
            image.header.dwSize = reader.ReadInt32();
            image.header.dwFlags = (DDSD_FLAGS)reader.ReadInt32();
            image.header.dwHeight = reader.ReadInt32();
            image.header.dwWidth = reader.ReadInt32();
            image.header.dwPitchOrLinearSize = reader.ReadInt32();
            image.header.dwDepth = reader.ReadInt32();
            image.header.dwMipMapCount = reader.ReadInt32();
            reader.BaseStream.Position += 11 * 4;
            image.header.ddspf = new DDS_PIXELFORMAT();
            image.header.ddspf.dwSize = reader.ReadInt32();
            image.header.ddspf.dwFlags = (DDPF)reader.ReadInt32();
            image.header.ddspf.dwFourCC = reader.ReadInt32();
            image.header.ddspf.dwRGBBitCount = reader.ReadInt32();
            image.header.ddspf.dwRBitMask = reader.ReadUInt32();
            image.header.ddspf.dwGBitMask = reader.ReadUInt32();
            image.header.ddspf.dwBBitMask = reader.ReadUInt32();
            image.header.ddspf.dwABitMask = reader.ReadUInt32();
            image.header.dwCaps = (DDSCAPS)reader.ReadInt32();
            image.header.dwCaps2 = (DDSCAPS2)reader.ReadInt32();
            image.header.dwCaps3 = reader.ReadInt32();
            image.header.dwCaps4 = reader.ReadInt32();
            reader.BaseStream.Position += 4;

            // Check if the header is valid.
            if (image.header.dwMagic != DDS_HEADER.kMagic || image.header.dwSize != DDS_HEADER.kSizeOf)
            {
                // Image header is invalid.
                reader.Close();
                return null;
            }

            // Check if there is a DX10 header.
            if (image.header.ddspf.dwFourCC == MakeFourCC("DX10"))
            {
                // Read the DX10 header.
                image.dxt10header = new DDS_HEADER_DXT10();
                image.dxt10header.dxgiFormat = (Format)reader.ReadInt32();
                image.dxt10header.resourceDimension = (ResourceDimension)reader.ReadInt32();
                image.dxt10header.miscFlag = (ResourceMiscFlags)reader.ReadInt32();
                image.dxt10header.arraySize = reader.ReadInt32();
                image.dxt10header.miscFlags2 = reader.ReadInt32();

                // Set the DXGI format.
                image.format = image.dxt10header.dxgiFormat;
            }
            else
            {
                // Check flags to see if the FOURCC format is being used.
                if (image.header.ddspf.dwFlags.HasFlag(DDPF.DDPF_FOURCC) == true)
                    image.format = DXGIFormatFromFourCC(image.header.ddspf.dwFourCC);
                else
                {
                    // Check the flags to determine the bitmap type.
                    if (image.header.ddspf.dwFlags.HasFlag(DDPF.DDPF_RGB) == true)
                    {
#warning DirectDrawSurface format detection is not complete

                        image.format = Format.B8G8R8A8_UNorm;

                        // Check if there is an alpha channel as well.
                        if (image.header.ddspf.dwFlags.HasFlag(DDPF.DDPF_ALPHA) == true)
                        {

                        }
                        else
                        {

                        }
                    }
                }
            }

            // Read the pixel buffer.
            image.PixelBuffer = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));

            // Return the image.
            return image;
        }

        public static int FourCCFromDXGIFormat(Format format)
        {
            // Check the format and handle accordingly.
            switch (format)
            {
                case SharpDX.DXGI.Format.BC1_UNorm: return MakeFourCC("DXT1");
                case SharpDX.DXGI.Format.BC3_UNorm: return MakeFourCC("DXT3");
                case SharpDX.DXGI.Format.BC5_UNorm: return MakeFourCC("DXT5");
                default: return 0;// MakeFourCC("DX10");
            }
        }

        public static Format DXGIFormatFromFourCC(int fourcc)
        {
            switch (fourcc)
            {
                case 0x31545844: return SharpDX.DXGI.Format.BC1_UNorm;
                case 0x32545844: return SharpDX.DXGI.Format.BC3_UNorm;
                case 0x35545844: return SharpDX.DXGI.Format.BC5_UNorm;
                default: return SharpDX.DXGI.Format.Unknown;
            }
        }

        /// <summary>
        /// Gets the integer representation of the foucc string.
        /// </summary>
        /// <param name="fourcc"></param>
        /// <returns></returns>
        private static int MakeFourCC(string fourcc)
        {
            return (int)(((int)fourcc[0] & 0xFF) | ((int)fourcc[1] & 0xFF) << 8 | ((int)fourcc[2] & 0xFF) << 16 | ((int)fourcc[3] & 0xFF) << 24);
        }
    }
}
