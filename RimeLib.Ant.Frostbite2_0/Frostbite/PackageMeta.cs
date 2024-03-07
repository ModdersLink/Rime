using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.Frostbite2_0.Frostbite
{
    public class PackageMeta : IFbSerializable
    {
        

        public class ImportNode
        {
            public uint Key { get; set; }
            public uint Ptr { get; set; }

            public int Tid { get; set; }
        }


        uint PackageType { get; set; }
        uint AssetCount { get; set; }
        uint ImportCount { get; set; }
        uint AssetBytes { get; set; }


        uint TotalNonStaticAssetCount { get; set; }
        uint MaxNonStaticAssetCount { get; set; }
        uint MaxNonStaticImportCount { get; set; }
        uint StaticBundleImportBucketSize { get; set; }
        uint StaticBundleImportBucketEntries { get; set; }
        uint StaticBundleFlatImportCount { get; set; }
        uint StaticBundleImportCountInSlots { get; set; }
        uint StaticGuidToIntSize { get; set; }


        ImportNode[] Nodes = new ImportNode[0];


        public PackageMeta(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }



        public void Deserialize(RimeReader p_Reader)
        {
            var s_LastEndianess = p_Reader.Endianness;
            p_Reader.Endianness = RimeLib.IO.Conversion.Endianness.BigEndian;


            var s_MetaBytes = p_Reader.ReadUInt32();
            PackageType = p_Reader.ReadUInt32();
            AssetCount = p_Reader.ReadUInt32();
            ImportCount = p_Reader.ReadUInt32();
            AssetBytes = p_Reader.ReadUInt32();

            var s_ExtraBytes = p_Reader.ReadUInt32();

            if (s_ExtraBytes == 0)
                return;

            var s_ExtraStartPos = p_Reader.Position;

            //if (PackageType != 3)
            //    throw new Exception("Extrabytes is only in static package");

            TotalNonStaticAssetCount = p_Reader.ReadUInt32();
            MaxNonStaticAssetCount = p_Reader.ReadUInt32();
            MaxNonStaticImportCount = p_Reader.ReadUInt32();
            StaticBundleImportBucketSize = p_Reader.ReadUInt32();
            StaticBundleImportBucketEntries = p_Reader.ReadUInt32();
            StaticBundleFlatImportCount = p_Reader.ReadUInt32();
            StaticBundleImportCountInSlots = p_Reader.ReadUInt32();
            StaticGuidToIntSize = p_Reader.ReadUInt32();

            p_Reader.Seek(s_ExtraStartPos + s_ExtraBytes, SeekOrigin.Begin);

            LoadGuidToIntMap(p_Reader);
            LoadStaticImportMap(p_Reader);

            p_Reader.Endianness = s_LastEndianess;
        }


        void LoadGuidToIntMap(RimeReader p_Reader)
        {
            if (StaticGuidToIntSize < 8)
                return;

            var s_GuidToIntMap = p_Reader.ReadBytes((int)StaticGuidToIntSize);

        }
        void LoadStaticImportMap(RimeReader p_Reader)
        {
           
            if (StaticBundleImportCountInSlots == 0)
                return;

            // this is probably a serialized linear probed hash map?
            // 

            Nodes = new ImportNode[StaticBundleImportCountInSlots];
            for (var i = 0; i < StaticBundleImportCountInSlots; i++)
            {
                p_Reader.Endianness = RimeLib.IO.Conversion.Endianness.BigEndian;
                var s_Key = p_Reader.ReadUInt32();
                p_Reader.Endianness = RimeLib.IO.Conversion.Endianness.LittleEndian;
                var s_Ptr = p_Reader.ReadUInt32(); // this shouldnt be set at this stage
                var s_Tid = p_Reader.ReadInt32();

                Nodes[i] = new ImportNode()
                {
                    Key = s_Key,
                    Ptr = s_Ptr,
                    Tid = s_Tid,
                };
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
