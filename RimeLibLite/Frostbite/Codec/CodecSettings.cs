using ICSharpCode.SharpZipLib.Zip.Compression;

namespace RimeLib.Frostbite.Codec
{
    /// <summary>How a <see cref="RimeLib.IO.CodecRimeWriter"/> packs its blocks.</summary>
    public readonly struct CodecSettings
    {
        /// <summary>The largest block a codec header describes.</summary>
        public const int MaxBlockSize = 0x10000;

        /// <summary>Zlib or None; a block that does not shrink is stored either way.</summary>
        public CodecMethod Method { get; init; } = CodecMethod.Zlib;

        public int BlockSize { get; init; } = MaxBlockSize;

        /// <summary>The zlib level, 0 to 9.</summary>
        public int Level { get; init; } = Deflater.BEST_COMPRESSION;

        public CodecSettings()
        {
        }

        public static CodecSettings Zlib => new();
    }
}
