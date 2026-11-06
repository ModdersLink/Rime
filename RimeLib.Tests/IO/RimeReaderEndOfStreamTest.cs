using System;
using System.IO;
using RimeLib.IO;
using Xunit;

namespace RimeLib.Tests.IO
{
    public class RimeReaderEndOfStreamTest
    {
        /// <summary>A stream that hands out at most one byte per read, as the Stream contract allows.</summary>
        private sealed class TrickleStream : MemoryStream
        {
            public TrickleStream(byte[] p_Data) : base(p_Data, false)
            {
            }

            public override int Read(byte[] p_Buffer, int p_Offset, int p_Count) => base.Read(p_Buffer, p_Offset, System.Math.Min(p_Count, 1));
        }

        private static RimeReader Reader(params byte[] p_Data) => new(new MemoryStream(p_Data, false));

        [Fact]
        public void ReadUByteThrowsAtTheEnd()
        {
            using var s_Reader = Reader(0x2A);
            Assert.Equal(0x2A, s_Reader.ReadUByte());
            Assert.Throws<EndOfStreamException>(() => s_Reader.ReadUByte());
        }

        [Fact]
        public void ReadUInt32ThrowsOnAShortValue()
        {
            using var s_Reader = Reader(1, 2, 3);
            Assert.Throws<EndOfStreamException>(() => s_Reader.ReadUInt32());
        }

        [Fact]
        public void ReadByteReturnsMinusOneAtTheEnd()
        {
            using var s_Reader = Reader(0x2A);
            Assert.Equal(0x2A, s_Reader.ReadByte());
            Assert.Equal(-1, s_Reader.ReadByte());
        }

        [Fact]
        public void UnterminatedStringThrowsInsteadOfLooping()
        {
            using var s_Reader = Reader((byte)'a', (byte)'b');
            Assert.Throws<EndOfStreamException>(() => s_Reader.ReadNullTerminatedString());
        }

        [Fact]
        public void ValuesReadWholeFromAStreamThatReturnsLess()
        {
            using var s_Reader = new RimeReader(new TrickleStream([0x78, 0x56, 0x34, 0x12, 0xAA, 0xBB]));
            Assert.Equal(0x12345678u, s_Reader.ReadUInt32());
            Assert.Equal(new byte[] { 0xAA, 0xBB }, s_Reader.ReadBytes(2));
        }
    }
}
