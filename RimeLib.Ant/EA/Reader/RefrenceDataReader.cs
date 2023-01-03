using RimeLib.Ant.EA.GenericData;
using RimeLib.Ant.EA.Reflection;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Ant.EA.Readers
{
    public class RefrenceDataReader
    {
     

        public GenericData.Reflection Reflection { get; set; }


        private Dictionary<uint, string> GuidNameMap = new();

        private Dictionary<string, uint> GuidRefrenceMap = new();


        public RefrenceDataReader(GenericData.Reflection p_Reflection)
        {
            Reflection = p_Reflection;
        }

        public void ProcessGuidRefs()
        {
            foreach(var s_GuidPair in GuidRefrenceMap)
            {
                if (!GuidNameMap.TryGetValue(s_GuidPair.Value, out var s_RefClass))
                {
                    Console.WriteLine($"Invalid ref at [{s_GuidPair.Key}] to [0x{s_GuidPair.Value:X05}");
                    continue;
                }

                RefrenceTypeRegistry.Instance.AddGuidRef(s_GuidPair.Key, s_RefClass);
            }
        }

        public void Parse(RimeReader p_Reader, Data p_Data, long p_Offset=0)
        {

            var s_Offset = p_Offset + p_Data.DataOffset;

            var s_Layout = Reflection.Layouts.Where(x => x.Hash == p_Data.LayoutHash).First();

            ParseLayout(p_Reader, s_Layout, s_Offset);
        }

        void ParseLayout(RimeReader p_Reader, LayoutHeader p_Layout,  long p_Offset = 0)
        {
            if (p_Layout.IsBasicField)
            {
                //ParseField(p_Reader, p_Layout, p_Offset);
            }
            else
            {
                var s_GuidField = p_Layout.FieldById(-3);
                   
                if(s_GuidField != null)
                {
                    var s_ReaderFieldOffset = p_Offset + s_GuidField.AlignedOffset;

                    p_Reader.Seek(s_ReaderFieldOffset, SeekOrigin.Begin);

                    var s_LastEndian = p_Reader.Endianness;
                    p_Reader.Endianness = IO.Conversion.Endianness.BigEndian;

                    var s_GuidRefrence = p_Reader.ReadUInt32();

                    p_Reader.Endianness = s_LastEndian;


                    if (s_GuidRefrence != 0)
                        GuidNameMap.TryAdd(s_GuidRefrence, p_Layout.Name);
                }

                //var s_NameField = p_Layout.FieldById(-2);

                var s_BaseField = p_Layout.FieldById(-1);
                if (s_BaseField != null)
                {
                    var s_ReaderFieldOffset = p_Offset + s_BaseField.AlignedOffset;

                    p_Reader.Seek(s_ReaderFieldOffset, SeekOrigin.Begin);

                    var s_Offset = p_Reader.ReadInt64();

                    if (s_Offset != 0)
                    {
                        p_Reader.Seek(s_Offset, SeekOrigin.Begin);

                        var s_Data = new Data(p_Reader);
                        var s_RefLayout = Reflection.Layouts.Where(x => x.Hash == s_Data.LayoutHash).First();

                        RefrenceTypeRegistry.Instance.AddBase(p_Layout.Name, s_RefLayout.Name);

                        Parse(p_Reader, s_Data, s_Offset);
                    }
                }
                

                for (var s_SlotId = 0; s_SlotId <= p_Layout.MaxSlot; s_SlotId++)
                {
                    var s_Slot = p_Layout.FieldById(s_SlotId);

                    if (s_Slot == null)
                        continue;

                    if (s_Slot.LayoutHash == (uint) LayoutType.Invalid)
                        continue;

                    if (s_Slot.LayoutHash != (uint)LayoutType.DataRef &&
                        s_Slot.LayoutHash != (uint)LayoutType.Guid &&
                        s_Slot.LayoutHash < (uint)LayoutType.LayoutTypeCount)
                        continue;

                    if (s_Slot.IsArray)
                    {
                        for (var i = 0; i < s_Slot.Count; i++)
                        {
                            var s_AlignMask = ~((uint)8 - 1);

                            var s_AlignedFieldOffset = (s_Slot.Offset + s_Slot.ElementSize * i + (8 - 1)) & s_AlignMask;

                            var s_ReaderFieldOffset = p_Offset + s_AlignedFieldOffset;

                            ParseArray(p_Reader, p_Layout, s_Slot, s_ReaderFieldOffset);
                        }
                        continue;
                    }


                    if (s_Slot.Count == 0)
                        continue;

                    //Console.WriteLine($"\tField [{s_Slot.Name}]");
                    for (var i = 0; i < s_Slot.Count; i++)
                    {
                        var s_AlignMask = ~(s_Slot.ElementAlign - 1);

                        var s_AlignedFieldOffset = (s_Slot.Offset + s_Slot.ElementSize*i + (s_Slot.ElementAlign - 1)) & s_AlignMask;

                        var s_ReaderFieldOffset = p_Offset + s_AlignedFieldOffset;

                       

                        p_Reader.Seek(s_ReaderFieldOffset, SeekOrigin.Begin);

                        if ((s_Slot.LayoutHash >= (uint)LayoutType.LayoutTypeCount))
                        {
                            ParseLayout(p_Reader, s_Slot.Layout, s_ReaderFieldOffset);
                        }
                        else
                        {
                            switch (s_Slot.Type)
                            {
                                case LayoutType.Guid:
                                    var s_LastEndian = p_Reader.Endianness;
                                    p_Reader.Endianness = IO.Conversion.Endianness.BigEndian;

                                    var s_GuidRefrence = p_Reader.ReadUInt32();

                                    p_Reader.Endianness = s_LastEndian;

                                    if (s_GuidRefrence == 0)
                                        break;

                                    GuidRefrenceMap.TryAdd($"{p_Layout.Name}.{s_Slot.Name}", s_GuidRefrence);
                                    break;

                                case LayoutType.DataRef:
                                    var s_Offset = p_Reader.ReadInt64();

                                    if (s_Offset == 0)
                                        break;


                                    p_Reader.Seek(s_Offset, SeekOrigin.Begin);

                                    var s_Data = new Data(p_Reader);

                                    var s_RefLayout = Reflection.Layouts.Where(x => x.Hash == s_Data.LayoutHash).First();


                                    RefrenceTypeRegistry.Instance.AddDataRef($"{p_Layout.Name}.{s_Slot.Name}", s_RefLayout.Name);

                                    Parse(p_Reader, s_Data, s_Offset);
                                    break;
                            }
                        }
                    }
                }
            }

        }



        void ParseArray(RimeReader p_Reader, LayoutHeader p_ParentLayout, EntryHeader p_Slot, long p_Offset = 0)
        {
            var s_Layout = p_Slot.Layout;

            p_Reader.Seek(p_Offset, SeekOrigin.Begin);


            var s_Unk = p_Reader.ReadUInt32();
            var s_Count = p_Reader.ReadUInt32();
            var s_Offset = p_Reader.ReadUInt32();

            var s_AlignedSize = (s_Layout.DataSize + (s_Layout.Alignment - 1)) & ~(s_Layout.Alignment - 1);


            for (var i = 0; i < s_Count; i++)
            {
                p_Reader.Seek(s_Offset + s_AlignedSize*i, SeekOrigin.Begin);

                switch (p_Slot.Type)
                {
                    case LayoutType.Guid:
                        var s_LastEndian = p_Reader.Endianness;
                        p_Reader.Endianness = IO.Conversion.Endianness.BigEndian;

                        var s_GuidRefrence = p_Reader.ReadUInt32();

                        p_Reader.Endianness = s_LastEndian;


                        if (s_GuidRefrence == 0)
                            break;

                        GuidRefrenceMap.TryAdd($"{p_ParentLayout.Name}.{p_Slot.Name}", s_GuidRefrence);
                        break;

                    case LayoutType.DataRef:
                        var s_DataRefOffset = p_Reader.ReadInt64();

                        if (s_DataRefOffset == 0)
                            break;

                        p_Reader.Seek(s_DataRefOffset, SeekOrigin.Begin);

                        var s_Data = new Data(p_Reader);
                        var s_RefLayout = Reflection.Layouts.Where(x => x.Hash == s_Data.LayoutHash).First();

                        RefrenceTypeRegistry.Instance.AddDataRef($"{p_ParentLayout.Name}.{p_Slot.Name}", s_RefLayout.Name);
                        break;
                }


                ParseLayout(p_Reader, s_Layout, s_Offset + s_AlignedSize * i);
            }
        }
        void ParseField(RimeReader p_Reader, LayoutHeader p_Layout, long p_Offset = 0)
        {
            p_Reader.Seek(p_Offset, SeekOrigin.Begin);
            switch (p_Layout.Type)
            {
                case LayoutType.Guid:

                    var s_LastEndian = p_Reader.Endianness;
                    p_Reader.Endianness = IO.Conversion.Endianness.BigEndian;

                    var s_GuidRefrence = p_Reader.ReadUInt32();

                    p_Reader.Endianness = s_LastEndian;

                    if (s_GuidRefrence == 0)
                        break;

                    if ((s_GuidRefrence & 0x80000) != 0)
                    {
                        // if current guid 

                        Console.WriteLine($"\t\t Static import [0x{s_GuidRefrence:X05}]");
                    }
                    else
                    {
                        Console.WriteLine($"\t\t Local Import [0x{s_GuidRefrence:X05}]");
                    }
                    break;
                //case LayoutType.String:
                 //   ParseArray(p_Reader, new LayoutHeader("UInt8", 1, 1, LayoutType.UInt8), p_Offset);
                  //  break;

                case LayoutType.DataRef:
                    var s_Offset = p_Reader.ReadInt64();

                    if (s_Offset == 0)
                        break;


                    p_Reader.Seek(s_Offset, SeekOrigin.Begin);

                    var s_Data = new Data(p_Reader);

                    var s_RefLayout = Reflection.Layouts.Where(x => x.Hash == s_Data.LayoutHash).First();

                    Parse(p_Reader, s_Data, s_Offset);
                    break;

                
            }
        }

    }
}
