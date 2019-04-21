using System;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Frostbite.Db
{
    public class DbObjectTimespan : IFbSerializable
    {
        public long TimeSpan { get; private set; }

        public DbObjectTimespan()
        {
            TimeSpan = 0;
        }

        public DbObjectTimespan(long p_Timespan)
        {
            TimeSpan = p_Timespan;
        }

        public DbObjectTimespan(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public void Deserialize(RimeReader p_Reader)
        {
            TimeSpan = p_Reader.DecodeZigZag64(out _);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }

        public DbObjectTimespan(byte[] p_Timespan)
        {
            if (p_Timespan.Length < 8)
                throw new ArgumentException("Cannot parse Timespan, too few bytes for the class.");

            TimeSpan = BitConverter.ToInt64(p_Timespan, 0);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.EncodeZigZag(TimeSpan);
            return true;
        }

        void IFbSerializable.Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public byte[] Serialize()
        {
            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                if (!Serialize(s_Writer))
                    throw new Exception("DbObjectTimespan serialization failed.");

                s_Writer.Flush();
                return ((MemoryStream) s_Writer.BaseStream).ToArray();
            }
        }
    }
}
