using System.IO;
using RimeLib.Frostbite;

namespace RimeLib.Content.Mounting
{
    /// <summary>
    /// Reads structures the mounted game ships, writes them back and reports per structure how many
    /// of them are byte-identical to the game's own bytes. Several subsystems implement it side by
    /// side, each for its own structures.
    /// </summary>
    public interface IWriterRoundTrip : IEngineInterface
    {
        /// <summary>Round-trips at most <paramref name="p_Limit"/> objects per structure (0 for all).</summary>
        void Run(IEngineMounter p_Mounter, int p_Limit, TextWriter p_Writer);
    }

    /// <summary>Helpers for comparing written bytes with the shipped ones.</summary>
    public static class WriterRoundTrip
    {
        public static byte[] ReadAll(IReadableObject p_Object)
        {
            using var s_Reader = p_Object.GetReader();
            using var s_Stream = new MemoryStream();

            s_Reader.CopyTo(s_Stream);

            return s_Stream.ToArray();
        }

        /// <summary>Index of the first differing byte, or -1 when the spans match.</summary>
        public static int FirstDiff(byte[] p_Left, int p_Offset, byte[] p_Right)
        {
            for (var i = 0; i < p_Right.Length; ++i)
                if (p_Left[p_Offset + i] != p_Right[i])
                    return i;

            return -1;
        }
    }
}
