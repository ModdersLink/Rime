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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(12), ContainerStruct]
	public class CustomReportValueData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(137)]
		public CustomReportValueKind Kind { get; set; } = new CustomReportValueKind(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(137)]
		public PersistentValueDataType DataType { get; set; } = new PersistentValueDataType(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 2089125261:
						Kind = (CustomReportValueKind) Enum.ToObject(typeof(CustomReportValueKind), p_Value);
					break;

				case 3249006477:
						DataType = (PersistentValueDataType) Enum.ToObject(typeof(PersistentValueDataType), p_Value);
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
				case 2088949890:
					return Name;

				case 2089125261:
					return Kind;

				case 3249006477:
					return DataType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(CustomReportValueData).GetProperty(nameof(Name));

				case 2089125261:
					return typeof(CustomReportValueData).GetProperty(nameof(Kind));

				case 3249006477:
					return typeof(CustomReportValueData).GetProperty(nameof(DataType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
