using fb;
using RimeLib.Animation.EA;
using RimeLib.Animation.EA.GenericData;
using RimeLib.Animation.EA.Reflection;
using RimeLib.Animation.EA.Resolver;
using RimeLib.Animation.EA.Types;
using RimeLib.Animation.Frostbite.Resolver;
using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Rimelib.Animation.Frostbite2_0.Frostbite
{
    public class AssetBank
        : IAssetBankLoader
    {
        private IAssetResolver? LocalResolver { get; set; } = null;


        public PackageMeta? Meta { get; set; } = null;
        public RimeLib.Animation.EA.GenericData.Archive Archive { get; set; } = new();


        public List<AntObject> Objects { get; set; } = new();

        public IAssetResolver Resolver => (LocalResolver != null) ? LocalResolver : AssetResolver.Instance;

        public AssetBank()
        {
        }

        public void Load(RimeReader p_Reader, IAssetBankLoader p_Loader)
        {
            var s_LastEndianess = p_Reader.Endianness;
            p_Reader.Endianness = RimeLib.IO.Conversion.Endianness.BigEndian;

            var s_Type = (AntPackagingType)p_Reader.ReadUInt32();

            if (s_Type == AntPackagingType.AntPackagingType_AnimationSet)
                LocalResolver = new SimpleAssetResolver();
            else
                Meta = new PackageMeta(p_Reader);


            //TODO: this should be better structured
            Archive = new Archive(p_Loader);
            Archive.Deserialize(p_Reader);

            p_Reader.Endianness = s_LastEndianess;
        }


        public void ParseData(RimeReader p_Reader, RimeLib.Animation.EA.GenericData.Data p_Data)
        {
            var s_Class = ParseClass(p_Reader, p_Data);


            Resolver.RegisterObject(s_Class);
            Objects.Add(s_Class);
        }


        protected AntObject CreateObject(LayoutHeader p_Layout)
        {
            var s_ContainerType = Type.GetType($"ant.{p_Layout.Name.Replace(":", "_")}");

            if (s_ContainerType == null)
                throw new Exception($"Couldnt not find class for type [{p_Layout.Name}]. Is this not dumped? try manually creating the class");

            return (AntObject)Activator.CreateInstance(s_ContainerType)!;
        }


        public  AntObject ParseClass(RimeReader p_Reader, RimeLib.Animation.EA.GenericData.Data p_Data, long p_Offset = 0)
        {
            var s_Layout = Archive.Reflection?.Layouts.Where(x => x.Hash == p_Data.LayoutHash).First();

            if (s_Layout == null)
                throw new InvalidDataException($"Couldnt not find layout for type hash {p_Data.LayoutHash:X08}.");

            var s_Instance = CreateObject(s_Layout!);

            if (!s_Instance.ContainsHash(p_Data.LayoutHash))
                throw new InvalidDataException($"type {s_Instance.GetType().Name} does not contain {p_Data.LayoutHash:X08}. Is there a change or undumped thing?");

            //TODO: add limitedreader
            var s_Offset = p_Offset + p_Data.DataOffset;

            ParseInstance(p_Reader, s_Layout, s_Instance, s_Instance.GetType(), s_Offset);

            return s_Instance;
        }

        protected AntObject ParseStruct(RimeReader p_Reader, LayoutHeader p_Layout, long p_Offset = 0)
        {
            var s_Instance = CreateObject(p_Layout);

            //TODO: add limitedreader
            ParseInstance(p_Reader, p_Layout, s_Instance, s_Instance.GetType(), p_Offset);

            return s_Instance;
        }

        protected virtual void ParseInstance(RimeReader p_Reader, LayoutHeader p_Layout, AntObject p_Instance, Type p_InstanceType, long p_Offset = 0)
        {
            if (p_Layout.IsBasicField)
            {
                throw new Exception($"cannot parse basicfield as instance!");
                return;
                //ParseField(p_Reader, p_Layout, p_Offset);
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

                    if (!p_Instance.ContainsHash(s_Data.LayoutHash))
                        throw new Exception("Base class invalid!");

                    var s_BaseLayout = Archive.Reflection?.Layouts.Where(x => x.Hash == s_Data.LayoutHash).First();

                    if (s_BaseLayout == null)
                        throw new InvalidDataException($"Couldnt not find layout for base class type hash {s_Data.LayoutHash:X08}.");

                    p_Reader.Seek(s_BaseOffset + s_Data.DataOffset, SeekOrigin.Begin);
                    ParseInstance(p_Reader, s_BaseLayout, p_Instance, p_InstanceType, s_BaseOffset + s_Data.DataOffset);
                }
            }


            // this guid field can sometimes become corrupted???
            var s_GuidField = p_Layout.FieldById(-3);
            if (s_GuidField != null)
            {
                p_Reader.Seek(p_Offset + s_GuidField.AlignedOffset, SeekOrigin.Begin);

                // there should be only 1 guid per instance. base class guids would be null
                p_Instance.InstanceId = new AntGuid(p_Reader);
            }

            var s_NameField = p_Layout.FieldById(-2);
            if (s_NameField != null)
            {
                p_Reader.Seek(p_Offset + s_NameField.AlignedOffset, SeekOrigin.Begin);

                var s_Capacity = p_Reader.ReadUInt32();
                var s_Count = p_Reader.ReadUInt32();
                var s_Offset = p_Reader.ReadUInt32();
                p_Reader.Seek(s_Offset, SeekOrigin.Begin);

                // strings should ne null terminated as game doesnt check length on strings

                if (s_Offset != 0)
                    p_Instance.ObjectName = p_Reader.ReadNullTerminatedString();
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

                var s_PropertyType = p_InstanceType.GetProperty(s_Slot.Name);

                if (s_PropertyType == null)
                    throw new InvalidDataException($"Class has non existing type [{s_Slot.Name}]. (in instanced class {p_InstanceType.Name}) (in class {p_Layout.Name})");


                if (s_Slot.Count > 1)
                {
                    ParseConstArray(p_Reader, s_Slot, s_PropertyType, p_Instance, p_Offset);
                    continue;
                }
                else if (s_Slot.IsArray)
                {
                    p_Reader.Seek(p_Offset + s_Slot.AlignedOffset, SeekOrigin.Begin);

                    ParseArray(p_Reader, s_Slot, s_PropertyType, p_Instance);
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
                        s_PropertyType.SetValue(p_Instance, ParseStruct(p_Reader, s_Slot.Layout!, p_Offset + s_Slot.AlignedOffset));
                        continue;
                    }

                    switch (s_Slot.Type)
                    {
                        case LayoutType.Guid:
                        {

                            var s_IdRef = s_PropertyType.GetValue(p_Instance) as IdRefBase;
                            s_IdRef!.RefrenceId = new AntGuid(p_Reader);
                            s_IdRef!.Resolver = Resolver;
                        }
                        break;

                        case LayoutType.String:
                        {
                            var s_Capacity = p_Reader.ReadUInt32();
                            var s_Count = p_Reader.ReadUInt32();
                            var s_Offset = p_Reader.ReadUInt32();
                            p_Reader.Seek(s_Offset, SeekOrigin.Begin);

                            // strings should ne null terminated as game doesnt check length on strings
                            s_PropertyType.SetValue(p_Instance, p_Reader.ReadNullTerminatedString());
                        }
                        break;

                        case LayoutType.DataRef:
                        {
                            var s_Offset = p_Reader.ReadInt64();

                            if (s_Offset == 0)
                            {
                                s_PropertyType.SetValue(p_Instance, null);
                                break;
                            }

                            p_Reader.Seek(s_Offset, SeekOrigin.Begin);

                            var s_Data = new Data(p_Reader);
                            var s_Class = ParseClass(p_Reader, s_Data, s_Offset);

                            s_PropertyType.SetValue(p_Instance, s_Class);
                            //Parse(p_Reader, s_Data, s_Offset);
                        }
                        break;


                        default:
                        {
                            var s_Value = ParseSimpleType(p_Reader, s_Slot.Type);
                            s_PropertyType.SetValue(p_Instance, s_Value);
                        }
                        break;
                    }
                }
            }
        }


        protected virtual void ParseConstArray(RimeReader p_Reader, EntryHeader p_Slot, PropertyInfo p_PropertyType, object p_Instance, long p_Offset )
        {
            var s_Array = p_PropertyType.GetValue(p_Instance) as Array;

            if (s_Array == null)
                throw new Exception("Array is null!");


            var s_Layout = p_Slot.Layout;

            if (s_Layout == null)
                throw new Exception("Array layout is null!");

            

            // valuetype
            if (p_Slot.LayoutHash >= (uint)LayoutType.LayoutTypeCount_FB2)
            {
                for (var i = 0; i < p_Slot.Count; i++)
                {
                    p_Reader.Seek(p_Offset + p_Slot.AlignIndexOffset(i), SeekOrigin.Begin);

                    var s_Struct = ParseStruct(p_Reader, s_Layout, p_Offset + p_Slot.AlignIndexOffset(i));


                    s_Array!.SetValue(s_Struct, i);
                    //s_Array![i] = s_Struct;
                }
                return;
            }

            switch (p_Slot.Type)
            {
                case LayoutType.Guid:
                {

                    throw new Exception("This isnt working properly!");
                    for (var i = 0; i < p_Slot.Count; i++)
                    {
                        p_Reader.Seek(p_Offset + p_Slot.AlignIndexOffset(i), SeekOrigin.Begin);

                        var s_Guid = new AntGuid(p_Reader);

                            //TODO: fix..
                        s_Array!.SetValue(new IdRef<AntObject>() { RefrenceId = s_Guid, Resolver = Resolver }, i);

                            //s_Array![i] = new IdRef<AntObject>() { RefrenceId = s_Guid };
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
                        {
                            s_Array!.SetValue(null, i);

                            //s_Array![i] = null;
                            continue;
                        }

                        p_Reader.Seek(s_DataRefOffset, SeekOrigin.Begin);

                        var s_Data = new Data(p_Reader);
                        var s_Class = ParseClass(p_Reader, s_Data, s_DataRefOffset);

                        s_Array!.SetValue(s_Class, i);
                        //s_Array![i] = s_Class;
                    }

                    break;
                }
                default:
                {

                    for (var i = 0; i < p_Slot.Count; i++)
                    {
                        p_Reader.Seek(p_Offset + p_Slot.AlignIndexOffset(i), SeekOrigin.Begin);

                        s_Array!.SetValue(ParseSimpleType(p_Reader, p_Slot.Type), i);
                        //s_Array![i] = ParseSimpleType(p_Reader, p_Slot.Type);
                    }

                    break;
                }
            }

        }

        protected virtual void ParseArray(RimeReader p_Reader, EntryHeader p_Slot, PropertyInfo p_PropertyType, object p_Instance)
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
            if( p_Slot.LayoutHash >= (uint)LayoutType.LayoutTypeCount_FB2)
            {
                var s_List = p_PropertyType.GetValue(p_Instance) as System.Collections.IList;


                for (var i = 0; i < s_Count; i++)
                {
                    p_Reader.Seek(s_Offset + s_AlignedSize * i, SeekOrigin.Begin);

                    var s_Struct = ParseStruct(p_Reader, s_Layout, s_Offset + s_AlignedSize * i);

                    s_List!.Add(s_Struct);
                }
                return;
            }

            switch (p_Slot.Type)
            {
                case LayoutType.Guid:
                {
                    var s_List = p_PropertyType.GetValue(p_Instance);

                    //var s_AddRef = s_List!.GetType().GetMethod("AddRef")!;

                    var s_AddRef = s_List!.GetType().GetMethod("AddRef")!;

                    for (var i = 0; i < s_Count; i++)
                    {
                        p_Reader.Seek(s_Offset + s_AlignedSize * i, SeekOrigin.Begin);

                        var s_Guid = new AntGuid(p_Reader);
                        s_AddRef.Invoke(s_List, new object[] { s_Guid, Resolver });
                    }
                    break;
                }
                case LayoutType.DataRef:
                {
                    var s_List = p_PropertyType.GetValue(p_Instance) as System.Collections.IList;


                    for (var i = 0; i < s_Count; i++)
                    {
                        p_Reader.Seek(s_Offset + s_AlignedSize * i, SeekOrigin.Begin);

                        var s_DataRefOffset = p_Reader.ReadInt64();

                        if (s_DataRefOffset == 0)
                        {
                            s_List!.Add(null);
                            continue;
                        }

                        p_Reader.Seek(s_DataRefOffset, SeekOrigin.Begin);

                        var s_Data = new Data(p_Reader);
                        var s_Class = ParseClass(p_Reader, s_Data, s_DataRefOffset);

                        s_List!.Add(s_Class);
                    }

                    break;
                }
                default:
                {
                    var s_List = p_PropertyType.GetValue(p_Instance) as System.Collections.IList;

                    for (var i = 0; i < s_Count; i++)
                    {
                        p_Reader.Seek(s_Offset + s_AlignedSize * i, SeekOrigin.Begin);

                        s_List!.Add(ParseSimpleType(p_Reader, p_Slot.Type));
                    }

                    break;
                }
            }

        }

        protected object ParseSimpleType(RimeReader p_Reader, LayoutType p_Type)
        {
            switch (p_Type)
            {
                case LayoutType.Bool:
                    return p_Reader.ReadBool();
                case LayoutType.Int8:
                    return p_Reader.ReadSByte();
                case LayoutType.UInt8:
                    return p_Reader.ReadUByte();
                case LayoutType.Int16:
                    return p_Reader.ReadInt16();
                case LayoutType.UInt16:
                    return p_Reader.ReadUInt16();
                case LayoutType.Int32:
                    return p_Reader.ReadInt32();
                case LayoutType.UInt32:
                    return p_Reader.ReadUInt32();
                case LayoutType.Int64:
                    return p_Reader.ReadInt64();
                case LayoutType.UInt64:
                    return p_Reader.ReadUInt64();
                case LayoutType.Float:
                    return p_Reader.ReadSingle();
                case LayoutType.Vector2:
                    return new AntVector2(p_Reader);
                case LayoutType.Vector3:
                    return new AntVector3(p_Reader);
                case LayoutType.Vector4:
                    return new AntVector4(p_Reader);
                case LayoutType.Quaternion:
                    return new AntQuaternion(p_Reader);
                case LayoutType.Matrix44:
                    return new AntMatrix44(p_Reader);
                default:
                    throw new Exception($"Unsupported field type {p_Type}.");
            }

        }

        public void Load(RimeReader s_DataReader)
        {
            throw new NotImplementedException();
        }

        // check EA::GD::LayoutConstValue functions for type readers
    }
}
