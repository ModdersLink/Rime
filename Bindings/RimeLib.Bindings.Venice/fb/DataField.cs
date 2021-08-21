///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class DataField : FrostbiteContainer
	{
		[ContainerField(Name: "Value", Offset: 0, NameHash: 225375086, Flags: 16509), LayoutImmutable]
		public string Value { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "ValueRef", Offset: 4, NameHash: 3291194335, Flags: 53)]
		public CtrRef<DataContainer> ValueRef { get; set; } = new CtrRef<DataContainer>(); // 0x4 (4)
		
		[ContainerField(Name: "Id", Offset: 8, NameHash: 5862152, Flags: 49405), LayoutImmutable, Blittable]
		public int Id { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "AccessType", Offset: 12, NameHash: 2232606137, Flags: 137)]
		public FieldAccessType AccessType { get; set; } = new FieldAccessType(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 225375086:
					Value = (string) p_Value;
					break;

				case 3291194335:
					ValueRef = (CtrRef<DataContainer>) p_Value;
					break;

				case 5862152:
					Id = (int) p_Value;
					break;

				case 2232606137:
						AccessType = (FieldAccessType) Enum.ToObject(typeof(FieldAccessType), p_Value);
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return Value;

				case 3291194335:
					return ValueRef;

				case 5862152:
					return Id;

				case 2232606137:
					return AccessType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 225375086:
					return typeof(DataField).GetProperty(nameof(Value));

				case 3291194335:
					return typeof(DataField).GetProperty(nameof(ValueRef));

				case 5862152:
					return typeof(DataField).GetProperty(nameof(Id));

				case 2232606137:
					return typeof(DataField).GetProperty(nameof(AccessType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
