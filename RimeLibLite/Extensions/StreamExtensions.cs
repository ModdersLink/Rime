using System.IO;

namespace RimeLib.Extensions;

public static class StreamExtensions
{
    public static byte[] ToArray(this Stream p_Stream)
    {
        using var s_MemoryStream = new MemoryStream();
        p_Stream.CopyTo(s_MemoryStream);
        return s_MemoryStream.ToArray();
    }
}
