using RimeLib.Ant.EA.Reflection;
using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.GenericData
{
    public class Data : IFbSerializable
    {
        private const uint c_kIID = 0x030E6205; // EA::GD::DataId const EA::GD::LayoutData::kIID

        public uint LayoutHash { get; set; } = 0;

        public uint DataOffset { get; set; } = 0;

        public bool Mutable { get; set; } = false;



        public Data(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }



        public bool Serialize(RimeWriter p_Writer)
        {
            // vtable / magic
            p_Writer.Write(c_kIID);
            p_Writer.WriteNullBytes(0x4);

            // allocator
            p_Writer.WriteNullBytes(0x8);

            // layout ptr
            p_Writer.Write(LayoutHash);
            p_Writer.WriteNullBytes(0x4);

            // refcount
            p_Writer.WriteNullBytes(0x4);

            // dataoffset
            p_Writer.Write((ushort)DataOffset);
            p_Writer.Write(Mutable);

            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            /*
struct __declspec(align(2)) EA::GD::LayoutData
{
  EA::GD::LayoutDataVtbl *vfptr; //0x0000
  EA::GD::Ptr64<EA::Allocator::ICoreAllocator> mAllocator; 
  EA::GD::Ptr64<EA::GD::Layout const > mLayout;
  EA::Thread::AtomicInt<int> mRefCount;
  unsigned __int16 mDataOffset;
  bool mMutable;
};

            */

            var s_Magic = p_Reader.ReadUInt32();
            p_Reader.Seek(0x4, SeekOrigin.Current);


            if (s_Magic != c_kIID)
                throw new InvalidDataException("Invalid Data magic. Data is either already read or something is wrong!");


            //0x0008 - EA::GD::Ptr64<EA::Allocator::ICoreAllocator> mAllocator;
            p_Reader.Seek(0x8, SeekOrigin.Current);

            //0x0010
            LayoutHash = p_Reader.ReadUInt32();
            p_Reader.Seek(0x4, SeekOrigin.Current);

            //0x0018
            p_Reader.Seek(0x4, SeekOrigin.Current);

            DataOffset = p_Reader.ReadUInt16();
            Mutable = p_Reader.ReadBool();

        }

        

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
        }
    }
}
