using RimeLib.Ant.EA.GenericData;
using RimeLib.Ant.EA.Readers;
using RimeLib.Ant.EA.Reflection;
using RimeLib.Ant.EA.Types;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RimeLib.Ant.EA;
using RimeLib.Ant.EA.Resolver;
using RimeLib.Ant.Frostbite2_0.EA;

namespace RimeLib.Ant.Frostbite2_0.Frostbite
{
    public class ReflectionGeneralDataReader : GeneralDataReader 
    {



        //private Dictionary<uint, string> GuidNameMap = new();

        //private Dictionary<string, PropertyInfo> GuidList = new();
        public struct GuidValuePair
        {
            public object m_Instance;
            public PropertyInfo m_Field;
            public AntGuid m_Guid;
            public IAssetResolver m_Resolver;
        }

        public struct DataRefPair
        {
            public PropertyInfo m_Field;
            public AntObject m_Target;
        }

        public HashSet<GuidValuePair> IdRefFields { get; } = new();
        public HashSet<DataRefPair> DataRefFields { get; } = new();
        public Dictionary<string, string> BaseClasses { get; } = new();

        public  ReflectionGeneralDataReader(AssetBank p_Bank)
            : base(p_Bank)
        {
        }
        protected override void ParseInstance(RimeReader p_Reader, LayoutHeader p_Layout, AntObject p_Instance, Type p_InstanceType, long p_Offset = 0)
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

                    BaseClasses.TryAdd(p_Layout.Name, s_BaseLayout.Name);
                    
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
                            
                            IdRefFields.Add(new ()
                            {
                                m_Instance = p_Instance, 
                                m_Field = s_PropertyType,
                                m_Guid =  s_IdRef!.RefrenceId,
                                m_Resolver = Resolver
                            });
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
                            
                            DataRefFields.Add(new ()
                            {
                                m_Field = s_PropertyType,
                                m_Target = s_Class
                            });
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

        protected override void ParseConstArray(RimeReader p_Reader, EntryHeader p_Slot, PropertyInfo p_PropertyType, object p_Instance, long p_Offset )
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

                    for (var i = 0; i < p_Slot.Count; i++)
                    {
                        p_Reader.Seek(p_Offset + p_Slot.AlignIndexOffset(i), SeekOrigin.Begin);

                        var s_Guid = new AntGuid(p_Reader);
                        
                        IdRefFields.Add(new ()
                        {
                            m_Instance = p_Instance, 
                            m_Field = p_PropertyType,
                            m_Guid =  s_Guid,
                            m_Resolver =  this
                        });
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
                        
                        DataRefFields.Add(new ()
                        {
                            m_Field = p_PropertyType,
                            m_Target = s_Class
                        });
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

        protected override void ParseArray(RimeReader p_Reader, EntryHeader p_Slot, PropertyInfo p_PropertyType, object p_Instance)
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
                        
                        
                        IdRefFields.Add(new ()
                        {
                            m_Instance = p_Instance, 
                            m_Field = p_PropertyType,
                            m_Guid =  s_Guid,
                            m_Resolver = Resolver
                        });
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
                        
                        DataRefFields.Add(new ()
                        {
                            m_Field = p_PropertyType,
                            m_Target = s_Class
                        });
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
    }
}
