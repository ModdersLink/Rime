using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using RimeLib.IO;

namespace RimeLib.Frostbite.Db
{
    public class DbObjectTimestamp : IFbSerializable
    {
        public long TimeStamp
        {
            get => BitConverter.ToInt64(m_Time, 0);
            set => m_Time = BitConverter.GetBytes(value);
        }

        public byte[] TimeStampArray
        {
            get => m_Time;
            set
            {
                if (value.Length != 8)
                    throw new ArgumentException("Cannot parse time, size of data does not match class.");

                m_Time = value;
            }
        }

        private byte[] m_Time; // Len8

        public DbObjectTimestamp()
        {
            m_Time = new byte[8];
        }

        public DbObjectTimestamp(byte[] p_Time)
        {
            if (p_Time.Length != 8)
                throw new ArgumentException("Cannot parse time, size of data does not match class.");

            m_Time = p_Time;
        }

        public DbObjectTimestamp(long p_Time)
        {
            m_Time = BitConverter.GetBytes(p_Time);
        }

        public DbObjectTimestamp(int p_Year, int p_Month, int p_Day, int p_Hours = 0, int p_Minutes = 0, int p_Seconds = 0, int p_MicroSeconds = 0)
        {
            int v1 = (p_Year + 4800);
            int v2 = (p_Month - 14) / 12;
            long v3 = ((1461 * (v1 + v2)) >> 2) + ((367 * (p_Month - 2 - 12 * v2)) / 12) - (3 * ((v1 + 100 + v2) / 100) >> 2) + p_Day - 32075;
            long v4 = (v3 * 60 * 60 * 24);
            long v5 = (p_Hours * 60 * 60) + (p_Minutes * 60) + (p_Seconds);
            long v6 = v4 + v5;
            long v7 = v6 - 0x0000003118a41200;
            long v8 = v7 * 1000000 + p_MicroSeconds;
            long v9 = v8 * 10 + 116444736000000000;

            m_Time = BitConverter.GetBytes(v9);
        }

        public DbObjectTimestamp(RimeReader p_Reader)
        {
            m_Time = p_Reader.ReadBytes(8);
        }

        // TODO: Not sure if this works as implemented
        public static long Now()
        {
            var s_FileTime = new FILETIME();
            return (s_FileTime.dwHighDateTime << 32 | s_FileTime.dwLowDateTime);
        }

        public override string ToString()
        {
            return "ToString is not implemented for Timestamp.";
            //throw new NotImplementedException("ToString is not implemented for TimeStamp.");
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            if (m_Time.Length != 8)
                return false;

            p_Writer.Write(m_Time);
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
                    throw new Exception("DbObjectTimestamp serialization failed.");

                s_Writer.Flush();
                return ((MemoryStream) s_Writer.BaseStream).ToArray();
            }
        }

        public void Deserialize(RimeReader p_Reader)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new NotImplementedException();
        }
    }
}
