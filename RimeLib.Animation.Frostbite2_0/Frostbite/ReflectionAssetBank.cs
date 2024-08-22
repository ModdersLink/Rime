using RimeLib.Animation.EA.GenericData;
using RimeLib.Animation.EA.Readers;
using RimeLib.Animation.EA.Reflection;
using RimeLib.Animation.EA.Types;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rimelib.Animation.Frostbite2_0.Frostbite
{
    public class ReflectionAssetBank : AssetBank
    {



        private Dictionary<uint, string> GuidNameMap = new();

        private Dictionary<string, AntGuid> GuidRefrenceMap = new();


        public ReflectionAssetBank()
            : base()
        {
        }


        public void ProcessGuidRefs()
        {
            foreach (var s_GuidPair in GuidRefrenceMap)
            {
                if (!GuidNameMap.TryGetValue(s_GuidPair.Value.SimpleRefrenceIndex, out var s_RefClass))
                {
                    Console.WriteLine($"Invalid ref at [{s_GuidPair.Key}] to [0x{s_GuidPair.Value:X05}");
                    continue;
                }

                RefrenceTypeRegistry.Instance.AddGuidRef(s_GuidPair.Key, s_RefClass);
            }
        }


        public new void ParseData(RimeReader p_Reader, RimeLib.Animation.EA.GenericData.Data p_Data)
        {
            //var s_Class = ParseClass(p_Reader, p_Data);

            //Resolver.RegisterObject(s_Class);
            //Objects.Add(s_Class);
        }



        public new void ParseClass(RimeReader p_Reader, RimeLib.Animation.EA.GenericData.Data p_Data, long p_Offset = 0)
        {
            var s_Layout = Archive.Reflection?.Layouts.Where(x => x.Hash == p_Data.LayoutHash).First();

            if (s_Layout == null)
                throw new InvalidDataException($"Couldnt not find layout for type hash {p_Data.LayoutHash:X08}.");

            //TODO: add limitedreader
            var s_Offset = p_Offset + p_Data.DataOffset;

            ParseInstance(p_Reader, s_Layout, s_Offset);
        }

        private void ParseStruct(RimeReader p_Reader, LayoutHeader p_Layout, long p_Offset = 0)
        {
            //TODO: add limitedreader
            ParseInstance(p_Reader, p_Layout, p_Offset);
        }

        private void ParseInstance(RimeReader p_Reader, LayoutHeader p_Layout, long p_Offset = 0)
        {
            if (p_Layout.IsBasicField)
            {
                throw new Exception($"cannot parse basicfield as instance!");
                // return;
                // ParseField(p_Reader, p_Layout, p_Offset);
            }

            // read base first, so guid will be proper
            var s_BaseField = p_Layout.FieldById(-1);
            if (s_BaseField != null)
            {
                p_Reader.Seek(p_Offset + s_BaseField.AlignedOffset, SeekOrigin.Begin);

                // 64 bits in size, but can be broken, use 32 for now!
                var s_BaseOffset = p_Reader.ReadInt64();

                if (s_BaseOffset != 0)
                {
                    p_Reader.Seek(s_BaseOffset, SeekOrigin.Begin);

                    var s_Data = new Data(p_Reader);
                    var s_BaseLayout = Archive.Reflection?.Layouts.Where(x => x.Hash == s_Data.LayoutHash).First();

                    if (s_BaseLayout == null)
                        throw new InvalidDataException($"Couldnt not find layout for base class type hash {s_Data.LayoutHash:X08}.");

                    RefrenceTypeRegistry.Instance.AddBase(p_Layout.Name, s_BaseLayout.Name);

                    p_Reader.Seek(s_BaseOffset + s_Data.DataOffset, SeekOrigin.Begin);

                    ParseInstance(p_Reader, s_BaseLayout, s_BaseOffset + s_Data.DataOffset);
                }
            }

            for (var s_SlotId = 0; s_SlotId <= p_Layout.MaxSlot; s_SlotId++)
            {
                var s_Slot = p_Layout.FieldById(s_SlotId);

                if (s_Slot == null)
                    continue;

                if (s_Slot.LayoutHash == (uint)LayoutType.Invalid)
                    continue;

                if (s_Slot.Count == 0)
                    continue;


                if (s_Slot.Count > 1)
                {
                    ParseConstArray(p_Reader, p_Layout, s_Slot, p_Offset);
                    continue;
                }
                else if (s_Slot.IsArray)
                {
                    p_Reader.Seek(p_Offset + s_Slot.AlignedOffset, SeekOrigin.Begin);

                    ParseArray(p_Reader, p_Layout, s_Slot);
                    continue;
                }
                else
                {
                    if (s_Slot.Count == 0 ||
                        s_Slot.Count > 1)
                        throw new InvalidDataException("Cannot parse multiple instances as a single type!");

                    //Console.WriteLine($"\tField [{s_Slot.Name}]");

                    p_Reader.Seek(p_Offset + s_Slot.AlignedOffset, SeekOrigin.Begin);

                    if ((s_Slot.LayoutHash >= (uint)LayoutType.LayoutTypeCount_FB2))
                    {
                        ParseStruct(p_Reader, s_Slot.Layout!, p_Offset + s_Slot.AlignedOffset);
                        continue;
                    }

                    switch (s_Slot.Type)
                    {
                    case LayoutType.Guid:
                        {
                            var s_GuidRef =  new AntGuid(p_Reader);

                            GuidRefrenceMap.TryAdd($"{p_Layout.Name}.{s_Slot.Name}", s_GuidRef);

                        }
                        break;


                    case LayoutType.DataRef:
                        {
                            var s_Offset = p_Reader.ReadInt64();

                            if (s_Offset == 0)
                                break;

                            p_Reader.Seek(s_Offset, SeekOrigin.Begin);

                            var s_Data = new Data(p_Reader);
                            var s_RefLayout = Archive.Reflection?.Layouts.Where(x => x.Hash == s_Data.LayoutHash).First();
                            if (s_RefLayout != null)
                                RefrenceTypeRegistry.Instance.AddDataRef($"{p_Layout.Name}.{s_Slot.Name}", s_RefLayout!.Name);


                            ParseClass(p_Reader, s_Data, s_Offset);
                        }
                        break;


                    default:
                        break;
                    }
                }
            }
        }


        private void ParseConstArray(RimeReader p_Reader, LayoutHeader p_Layout, EntryHeader p_Slot, long p_Offset)
        {
            var s_Layout = p_Slot.Layout;

            if (s_Layout == null)
                throw new Exception("Array layout is null!");



            // valuetype
            if (p_Slot.LayoutHash >= (uint)LayoutType.LayoutTypeCount_FB2)
            {
                for (var i = 0; i < p_Slot.Count; i++)
                {
                    p_Reader.Seek(p_Offset + p_Slot.AlignIndexOffset(i), SeekOrigin.Begin);

                    ParseStruct(p_Reader, s_Layout, p_Offset + p_Slot.AlignIndexOffset(i));
                }
                return;
            }

            switch (p_Slot.Type)
            {
            case LayoutType.Guid:
                {
                    for (var i = 0; i < p_Slot.Count; i++)
                    {
                        p_Reader.Seek(p_Offset + p_Slot.AlignIndexOffset(i), SeekOrigin.Begin);

                        var s_Guid = new AntGuid(p_Reader);

                        GuidRefrenceMap.TryAdd($"{p_Layout.Name}.{p_Slot.Name}", s_Guid);

                    }
                    break;
                }
            case LayoutType.DataRef:
                {
                    for (var i = 0; i < p_Slot.Count; i++)
                    {
                        p_Reader.Seek(p_Offset + p_Slot.AlignIndexOffset(i), SeekOrigin.Begin);

                        var s_DataRefOffset = p_Reader.ReadInt64();

                        if (s_DataRefOffset == 0)
                            continue;

                        p_Reader.Seek(s_DataRefOffset, SeekOrigin.Begin);

                        var s_Data = new Data(p_Reader);

                        var s_RefLayout = Archive.Reflection?.Layouts.Where(x => x.Hash == s_Data.LayoutHash).First();
                        if (s_RefLayout != null)
                            RefrenceTypeRegistry.Instance.AddDataRef($"{p_Layout.Name}.{p_Slot.Name}", s_RefLayout!.Name);


                        ParseClass(p_Reader, s_Data, s_DataRefOffset);
                    }
                    break;
                }
            default:
                    break;
            }

        }

        void ParseArray(RimeReader p_Reader, LayoutHeader p_Layout, EntryHeader p_Slot)
        {
            var s_Layout = p_Slot.Layout;

            if (s_Layout == null)
                throw new Exception("Array layout is null!");

            //p_Reader.Seek(p_Offset, SeekOrigin.Begin);


            var s_Capacity = p_Reader.ReadUInt32();
            var s_Count = p_Reader.ReadUInt32();
            var s_Offset = p_Reader.ReadUInt32();

            var s_AlignedSize = (s_Layout.DataSize + (s_Layout.Alignment - 1)) & ~(s_Layout.Alignment - 1);


            // valuetype
            if (p_Slot.LayoutHash >= (uint)LayoutType.LayoutTypeCount_FB2)
            {


                for (var i = 0; i < s_Count; i++)
                {
                    ParseStruct(p_Reader, s_Layout, s_Offset + s_AlignedSize * i);
                }
                return;
            }

            switch (p_Slot.Type)
            {
            case LayoutType.Guid:
                {

                    for (var i = 0; i < s_Count; i++)
                    {
                        p_Reader.Seek(s_Offset + s_AlignedSize * i, SeekOrigin.Begin);

                        var s_Guid = new AntGuid(p_Reader);

                        GuidRefrenceMap.TryAdd($"{p_Layout.Name}.{p_Slot.Name}", s_Guid);

                    }
                    break;
                }
            case LayoutType.DataRef:
                {
                    for (var i = 0; i < s_Count; i++)
                    {
                        p_Reader.Seek(s_Offset + s_AlignedSize * i, SeekOrigin.Begin);

                        var s_DataRefOffset = p_Reader.ReadInt64();

                        if (s_DataRefOffset == 0)
                            continue;

                        p_Reader.Seek(s_DataRefOffset, SeekOrigin.Begin);

                        var s_Data = new Data(p_Reader);

                        var s_RefLayout = Archive.Reflection?.Layouts.Where(x => x.Hash == s_Data.LayoutHash).First();
                        if (s_RefLayout != null)
                            RefrenceTypeRegistry.Instance.AddDataRef($"{p_Layout.Name}.{p_Slot.Name}", s_RefLayout!.Name);



                        ParseClass(p_Reader, s_Data, s_DataRefOffset);

                    }

                    break;
                }
            }
        }
    }
}
