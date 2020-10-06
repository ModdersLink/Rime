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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(36), ContainerStruct]
	public class PersistentValueTemplateData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string DefaultValue { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float DefaultFloatValue { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int DefaultIntValue { get; set; } // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(137)]
		public PersistentValueType ValueType { get; set; } = new PersistentValueType(); // 0x10 (16)
		
		[ContainerField(20), MemberInfoFlag(137)]
		public PersistentValueDataType DataType { get; set; } = new PersistentValueDataType(); // 0x14 (20)
		
		[ContainerField(24), MemberInfoFlag(137)]
		public PersistentValueHistoryType HistoryType { get; set; } = new PersistentValueHistoryType(); // 0x18 (24)
		
		[ContainerField(28), MemberInfoFlag(137)]
		public AwardGroup Group { get; set; } = new AwardGroup(); // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool ClubStat { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool ForceIntoTemplate { get; set; } // 0x21 (33)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 2066049125:
					DefaultValue = (string) p_Value;
					break;

				case 233760917:
					DefaultFloatValue = (float) p_Value;
					break;

				case 2653674902:
					DefaultIntValue = (int) p_Value;
					break;

				case 1235276758:
						ValueType = (PersistentValueType) Enum.ToObject(typeof(PersistentValueType), p_Value);
					break;

				case 3249006477:
						DataType = (PersistentValueDataType) Enum.ToObject(typeof(PersistentValueDataType), p_Value);
					break;

				case 2541675455:
						HistoryType = (PersistentValueHistoryType) Enum.ToObject(typeof(PersistentValueHistoryType), p_Value);
					break;

				case 208130522:
						Group = (AwardGroup) Enum.ToObject(typeof(AwardGroup), p_Value);
					break;

				case 1509129999:
					ClubStat = (bool) p_Value;
					break;

				case 2614855220:
					ForceIntoTemplate = (bool) p_Value;
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

				case 2066049125:
					return DefaultValue;

				case 233760917:
					return DefaultFloatValue;

				case 2653674902:
					return DefaultIntValue;

				case 1235276758:
					return ValueType;

				case 3249006477:
					return DataType;

				case 2541675455:
					return HistoryType;

				case 208130522:
					return Group;

				case 1509129999:
					return ClubStat;

				case 2614855220:
					return ForceIntoTemplate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(Name));

				case 2066049125:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(DefaultValue));

				case 233760917:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(DefaultFloatValue));

				case 2653674902:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(DefaultIntValue));

				case 1235276758:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(ValueType));

				case 3249006477:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(DataType));

				case 2541675455:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(HistoryType));

				case 208130522:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(Group));

				case 1509129999:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(ClubStat));

				case 2614855220:
					return typeof(PersistentValueTemplateData).GetProperty(nameof(ForceIntoTemplate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
