using System;
using System.IO;
using RimeLib.IO.Conversion;

// lzham
// https://github.com/AndrewSav/Lzham.Net

// lzf
// https://csharplzfcompression.codeplex.com/

namespace RimeLib.IO
{
    /// <summary>
    /// Static class for decoding algorithms used in Frostbite
    /// </summary>
    public class Decoding
    {
        /// <summary>
        /// The encoding types used in the Frostbite engine
        /// </summary>
        public enum CodingTypes
        {
            /// <summary>
            /// Single zlib segment block
            /// </summary>
            Zlib,

            /// <summary>
            /// Multiple zlib block segments with a compressed and decompressed size heading it
            /// </summary>
            ZlibSegmented,

            /// <summary>
            /// Google snappy encoding algoritm
            /// </summary>
            GoogleSnappy,

            /// <summary>
            /// LZF encoding
            /// </summary>
            LZF,

            /// <summary>
            /// LZ4 encoding
            /// </summary>
            LZ4,
            
            /// <summary>
            /// LZO decoding, deprecated (I think in Frostbite 3?)
            /// </summary>
            LZO,

            /// <summary>
            /// LZHAM encoding
            /// </summary>
            LZHAM,

            /// <summary>
            /// Unknown encoding algorithm
            /// </summary>
            Unknown
        }

        /// <summary>
        /// Decodes some shit
        /// </summary>
        /// <param name="p_Type">The encoding type</param>
        /// <param name="p_Data">The input data</param>
        /// <returns>A decoded byte array</returns>
        public static byte[] Decode(CodingTypes p_Type, byte[] p_Data)
        {
            switch (p_Type)
            {
                case CodingTypes.GoogleSnappy:
                    return DecodeSnappy(p_Data);

                case CodingTypes.Zlib:
                    return DecodeZlib(p_Data);

                case CodingTypes.ZlibSegmented:
                    return DecodeZlibSegmented(p_Data);

                case CodingTypes.LZ4:
                    return DecodeLZ4(p_Data);

                default:
                    throw new ArgumentException("Invalid CodingType specified");
            }
        }

        /// <summary>
        /// Decodes snappy data
        /// </summary>
        /// <param name="p_Data">Snappy encoded data</param>
        /// <returns>Snappy decoded data</returns>
        public static byte[] DecodeSnappy(byte[] p_Data)
        {
            throw new NotImplementedException();
            //return SnappyCodec.Uncompress(p_Data);
        }

        /// <summary>
        /// Decodes a single Zlib block with 0x78DA header
        /// </summary>
        /// <param name="p_Data">Zlib encoded data</param>
        /// <returns>Zlib decoded data</returns>
        public static byte[] DecodeZlib(byte[] p_Data)
        {
            throw new NotImplementedException();

            /*using (var s_DecompressedStream = new MemoryStream())
            { 
                using (var s_CompressedStream = new MemoryStream(p_Data))
                {
                    // TODO: Replace dotnetzip with something else.
                    using (var s_Zlib = new Ionic.Zlib.ZlibStream(s_CompressedStream, Ionic.Zlib.CompressionMode.Decompress))
                    {
                        var s_TempBuffer = new byte[short.MaxValue];
                        int s_ReadBytes;

                        while ((s_ReadBytes = s_Zlib.Read(s_TempBuffer, 0, s_TempBuffer.Length)) != 0)
                            s_DecompressedStream.Write(s_TempBuffer, 0, s_ReadBytes);

                        s_DecompressedStream.Flush();
                        return s_DecompressedStream.ToArray();
                    }
                }
            }*/
        }

        /// <summary>
        /// Handle segmented zlib segments that don't fit into one zlib block
        /// </summary>
        /// <param name="p_Data">Input segmented zlib data</param>
        /// <returns></returns>
        public static byte[] DecodeZlibSegmented(byte[] p_Data)
        {
            using (var s_Reader = new RimeReader(new MemoryStream(p_Data), Endianness.BigEndian))
            {
                using (var s_OutStream = new MemoryStream())
                {
                    while (s_Reader.Length - s_Reader.Position > 1)
                    {
                        var s_DecompressedLen = s_Reader.ReadInt32();
                        var s_CompressedLen = s_Reader.ReadInt32();

                        if (s_CompressedLen == s_DecompressedLen)
                        {
                            s_OutStream.Write(s_Reader.ReadBytes(s_CompressedLen), 0, s_CompressedLen);
                        }
                        else
                        {
                            var s_DecompressedData = DecodeZlib(s_Reader.ReadBytes(s_CompressedLen));
                            s_OutStream.Write(s_DecompressedData, 0, s_DecompressedData.Length);
                        }
                    }

                    return s_OutStream.ToArray();
                }
            }
        }

        /// <summary>
        /// Decodes LZ4 compressed data
        /// </summary>
        /// <param name="p_Data">LZ4 compressed data</param>
        /// <returns>LZ4 decoded data</returns>
        public static byte[] DecodeLZ4(byte[] p_Data)
        {
            // TODO: See if this is the right implementation
            throw new NotImplementedException();
            //return LZ4Codec.Decode(p_Data, 0, p_Data.Length, 0);
        }
    }
}
