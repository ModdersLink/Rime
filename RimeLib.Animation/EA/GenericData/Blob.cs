using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Animation.EA.GenericData
{
    public class Blob : IFbSerializable
    {

        // FOrmat is similar to a "RIFF" format.
        // https://en.wikipedia.org/wiki/Resource_Interchange_File_Format


        public GenericDataBlobType Type { get; set; } = GenericDataBlobType.Invalid;

        public bool BigEndian { get; set; } = false;

        public byte[] Data { get; set; } = new byte[0];


        public Blob()
        {
        }
            public Blob(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }



        public virtual RimeReader GetReader()
        {
            var s_Reader =  new RimeReader(new MemoryStream(Data), BigEndian ? IO.Conversion.Endianness.BigEndian : IO.Conversion.Endianness.LittleEndian);

            s_Reader.Seek(0, SeekOrigin.Begin);

            return s_Reader;
        }



        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(SerializeId());
            
            var s_LastEndianess = p_Writer.Endianness;
            p_Writer.Endianness = BigEndian ? IO.Conversion.Endianness.BigEndian : IO.Conversion.Endianness.LittleEndian;

            p_Writer.Write((uint)(Data.Length + 0xC));
            p_Writer.Write(Data);

            p_Writer.Endianness = s_LastEndianess;

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            ParseId(p_Reader);

            var s_LastEndianess = p_Reader.Endianness;
            p_Reader.Endianness = BigEndian ? IO.Conversion.Endianness.BigEndian : IO.Conversion.Endianness.LittleEndian;


            // 0xC is sizeof(EA::GD::Serialization::Header) which is "GenericDataBlob" in this case.

            var s_Size = p_Reader.ReadUInt32() - 0xC;
            Data = p_Reader.ReadBytes((int)s_Size);


            p_Reader.Endianness = s_LastEndianess;
        }


        protected void ParseId(RimeReader p_Reader)
        {
            var s_Id = Encoding.ASCII.GetString(p_Reader.ReadBytes(7));

            switch (s_Id)
            {
                case "GD.DATA":
                    Type = GenericDataBlobType.Data;
                    break;
                case "GD.STRM":
                    Type = GenericDataBlobType.Stream;
                    break;
                case "GD.REFL":
                    Type = GenericDataBlobType.Reflection;
                    break;
                case "REFPACK":
                    Type = GenericDataBlobType.RefPack;
                    break;

                case "DAT2":
                    Type = GenericDataBlobType.Data2;
                    break;
                case "REF2":
                    Type = GenericDataBlobType.Ref2;
                    break;
                case "INFO":
                    Type = GenericDataBlobType.Info;
                    break;
                default:
                    throw new Exception($"Invaid GenericData format! newer ANT or something else is wrong. [{s_Id}]");
            }


            BigEndian = p_Reader.ReadSByte() == 'b';

           
        }

        protected byte[] SerializeId()
        {
            string? s_String = null;  
    
            switch (Type)
            {
                case GenericDataBlobType.Data:
                    s_String = "GD.DATA";
                    break;
                case GenericDataBlobType.Stream:
                    s_String = "GD.STRM";
                    break;
                case GenericDataBlobType.Reflection:
                    s_String = "GD.REFL";
                    break;
                case GenericDataBlobType.RefPack:
                    s_String = "REFPACK";
                    break;

                case GenericDataBlobType.Data2:
                    s_String = "DAT2";
                    break;
                case GenericDataBlobType.Ref2:
                    s_String = "REF2";
                    break;
                case GenericDataBlobType.Info:
                    s_String = "INFO";
                    break;
                default:
                    throw new Exception($"Invaid GenericData format! newer ANT or something else is wrong. [{Type}]");
            }

            if (BigEndian)
                s_String += "b";
            else
                s_String += " "; //TODO: i dont remember what this was 

            return Encoding.ASCII.GetBytes(s_String);
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
