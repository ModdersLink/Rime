using System;
using System.IO;
using RimeLib.Frostbite.Codec;
using RimeLib.IO;
using Xunit;

namespace RimeLib.Tests.IO
{
    /// <summary>What CodecRimeWriter writes reads back through CodecRimeReader.</summary>
    public class CodecRimeWriterTest
    {
        private static byte[] Write(byte[] p_Data, CodecSettings p_Settings)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new CodecRimeWriter(s_Stream, p_Settings))
                s_Writer.Write(p_Data);
            return s_Stream.ToArray();
        }

        private static byte[] Read(byte[] p_Stored)
        {
            using var s_Reader = new CodecRimeReader(new RimeReader(new MemoryStream(p_Stored, false)));
            return s_Reader.ReadBytes((int)s_Reader.Length);
        }

        /// <summary>Three blocks, one packed (zeros) and one stored (noise), and a partial last block.</summary>
        [Fact]
        public void BlocksReadBack()
        {
            var s_Data = new byte[2 * CodecSettings.MaxBlockSize + 100];
            new Random(1).NextBytes(s_Data.AsSpan(CodecSettings.MaxBlockSize));

            var s_Stored = Write(s_Data, CodecSettings.Zlib);

            Assert.Equal(s_Data, Read(s_Stored));
            using var s_Reader = new RimeReader(new MemoryStream(s_Stored, false));
            var s_First = new CodecHeader(s_Reader);
            Assert.Equal(CodecMethod.Zlib, s_First.Method);
            s_Reader.Seek(s_First.PackedSize, SeekOrigin.Current);
            var s_Second = new CodecHeader(s_Reader);
            Assert.Equal(CodecMethod.None, s_Second.Method);
            Assert.Equal((uint)CodecSettings.MaxBlockSize, s_Second.PackedSize);
        }

        [Fact]
        public void FlushEndsABlock()
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new CodecRimeWriter(s_Stream, CodecSettings.Zlib with { Method = CodecMethod.None }))
            {
                s_Writer.Write(new byte[10]);
                s_Writer.Flush();
                s_Writer.Write(new byte[5]);
                Assert.Equal(15, s_Writer.Position);
            }

            Assert.Equal(8 + 10 + 8 + 5, s_Stream.ToArray().Length);
            Assert.Equal(new byte[15], Read(s_Stream.ToArray()));
        }

        [Fact]
        public void NothingWrittenIsOneEmptyBlock()
        {
            var s_Stored = Write(Array.Empty<byte>(), CodecSettings.Zlib);
            Assert.Equal(8, s_Stored.Length);
        }
    }
}
