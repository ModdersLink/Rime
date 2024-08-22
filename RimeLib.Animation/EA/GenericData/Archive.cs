using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace RimeLib.Animation.EA.GenericData
{
    public class Archive : IFbSerializable
    {

        IAssetBankLoader? m_LoaderCallback = null;

        public Archive()
        {
        }
        public Archive(IAssetBankLoader p_Callback)
        {
            m_LoaderCallback = p_Callback;
        }

        public Archive(RimeReader p_Reader, IAssetBankLoader p_Callback)
        {
            m_LoaderCallback = p_Callback;
            Deserialize(p_Reader);
        }

        public Reflection? Reflection { get; set; } = null;
        public List<RelocatableBlob> DataBlobs { get; set; } = new();

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            var s_RootHeader = new Blob(p_Reader);

            if (s_RootHeader.Type == GenericDataBlobType.RefPack)
            {
                throw new NotImplementedException();

                // using var s_Reader = new RefPackRimeReader(s_RootHeader.GetReader());
                // this.Deserialize(s_Reader);
                // return;
            }

            if (s_RootHeader.Type != GenericDataBlobType.Stream)
                throw new InvalidDataException("Unsupported blob format");


            using var s_RootStream = s_RootHeader.GetReader();

            var s_SizeOfLargestBlock = s_RootStream.ReadUInt32();



            var s_ReflHeader = new RelocatableBlob(s_RootStream);

            if (s_ReflHeader.Type == GenericDataBlobType.Reflection)
                Reflection = new Reflection(s_ReflHeader.GetReader());
            else if (s_ReflHeader.Type == GenericDataBlobType.Ref2)
                throw new NotImplementedException("Ref2 not implimented");
            else 
                throw new InvalidDataException($"Expected Reflection block as first block. Got [{s_ReflHeader.Type}]");



            //var s_SymbolResolver = new RefrenceDataReader(Reflection);

            while (s_RootStream.Position < s_RootStream.Length)
            {
                var s_DataHeader = new RelocatableBlob(s_RootStream);

                if (s_DataHeader.Type != GenericDataBlobType.Data)
                    throw new InvalidDataException("Unsupported blob format");

                var s_Reader = s_DataHeader.GetReader();

                var s_Data = new Data(s_Reader);

                m_LoaderCallback?.ParseData(s_Reader, s_Data);
            }
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
