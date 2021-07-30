using System;
using System.Collections.Generic;
using System.Text;

namespace AudioExtractor
{
    public class WaveFile
    {
        /// <summary>
        /// Wave format consists of 2 subchunks, format and data
        /// </summary>
        public class Subchunk
        {
            public const int c_DataMagic = 0x61746164; // "data"
            public const int c_FormatMagic = 0x20746D66; // "fmt "

            public uint Id { get; set; } = 0;
            public uint Size { get; set; } = 0;
        }

        /// <summary>
        /// The data subchunk contains the size of the data and the actual sound
        /// </summary>
        public class DataSubchunk : Subchunk
        {
            /// <summary>
            /// Actual sound data
            /// </summary>
            public List<byte> Data { get; set; } = new List<byte>();
        }

        public class FormatSubchunk : Subchunk
        {
            /// <summary>
            /// Audio format
            /// 1 = PCM
            /// ? = ?
            /// </summary>
            public ushort AudioFormat { get; set; } = 1;

            /// <summary>
            /// The channel count
            /// </summary>
            public ushort NumChannels { get; set; } = 0;

            public uint SampleRate { get; set; } = 44100;
           
            /// <summary>
            /// ByteRate = SampleRate * NumChannels * (BitsPerSample / 8)
            /// </summary>
            public uint ByteRate { get; set; } = 0;

            /// <summary>
            /// BlockAlign = NumChannels * (BitsPerSample / 8)
            /// </summary>
            public ushort BlockAlign { get; set; } = 0;

            public ushort BitsPerSample { get; set; } = 0;

        }
        public const int c_Magic = 0x46464952; // "RIFF"

        public uint ChunkId { get; set; } = c_Magic;
        public uint ChunkSize { get; set; } = 0;
        public uint Format { get; set; } = 0;

    }
}
