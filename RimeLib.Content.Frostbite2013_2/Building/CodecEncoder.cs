using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using RimeLib.Frostbite.Codec;
using RimeLib.IO;

namespace RimeLib.Content.Frostbite2013_2.Building;

/// <summary>
/// Writes the codec block format a compressed cas payload is stored in, the inverse of
/// <see cref="CodecRimeReader"/>: blocks of at most 64 KiB, each a codec header (unpacked size,
/// packed size and method) and the zlib-compressed bytes, or the raw bytes when compressing does
/// not shrink the block.
/// </summary>
public static class CodecEncoder
{
    private const int c_BlockSize = 0x10000;

    public static byte[] Encode(byte[] p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
        {
            var s_Offset = 0;
            do
            {
                var s_Size = System.Math.Min(c_BlockSize, p_Data.Length - s_Offset);
                var s_Packed = Deflate(p_Data, s_Offset, s_Size);

                // A block that does not shrink is stored, with the packed size equal to the unpacked one.
                var s_Stored = s_Packed.Length >= s_Size;
                new CodecHeader((uint)(s_Stored ? s_Size : s_Packed.Length), (uint)s_Size, CodecMethod.Zlib).Serialize(s_Writer);
                if (s_Stored)
                    s_Writer.Write(p_Data, s_Offset, s_Size);
                else
                    s_Writer.Write(s_Packed);

                s_Offset += s_Size;
            }
            while (s_Offset < p_Data.Length);
        }

        return s_Stream.ToArray();
    }

    private static byte[] Deflate(byte[] p_Data, int p_Offset, int p_Count)
    {
        var s_Output = new MemoryStream();
        using (var s_Deflate = new DeflaterOutputStream(s_Output, new Deflater(Deflater.BEST_COMPRESSION), 4096) { IsStreamOwner = false })
        {
            s_Deflate.Write(p_Data, p_Offset, p_Count);
            s_Deflate.Finish();
        }

        return s_Output.ToArray();
    }
}
