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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 36)]
	public class PersistentValueTemplateData : FrostbiteContainer
	{
		[ContainerField(Name: "Name", Offset: 0, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "DefaultValue", Offset: 4, NameHash: 2066049125, Flags: 16509), LayoutImmutable]
		public string DefaultValue { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "DefaultFloatValue", Offset: 8, NameHash: 233760917, Flags: 49469), LayoutImmutable, Blittable]
		public float DefaultFloatValue { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "DefaultIntValue", Offset: 12, NameHash: 2653674902, Flags: 49405), LayoutImmutable, Blittable]
		public int DefaultIntValue { get; set; } // 0xC (12)
		
		[ContainerField(Name: "ValueType", Offset: 16, NameHash: 1235276758, Flags: 137)]
		public PersistentValueType ValueType { get; set; } = new PersistentValueType(); // 0x10 (16)
		
		[ContainerField(Name: "DataType", Offset: 20, NameHash: 3249006477, Flags: 137)]
		public PersistentValueDataType DataType { get; set; } = new PersistentValueDataType(); // 0x14 (20)
		
		[ContainerField(Name: "HistoryType", Offset: 24, NameHash: 2541675455, Flags: 137)]
		public PersistentValueHistoryType HistoryType { get; set; } = new PersistentValueHistoryType(); // 0x18 (24)
		
		[ContainerField(Name: "Group", Offset: 28, NameHash: 208130522, Flags: 137)]
		public AwardGroup Group { get; set; } = new AwardGroup(); // 0x1C (28)
		
		[ContainerField(Name: "ClubStat", Offset: 32, NameHash: 1509129999, Flags: 49325), LayoutImmutable, Blittable]
		public bool ClubStat { get; set; } // 0x20 (32)
		
		[ContainerField(Name: "ForceIntoTemplate", Offset: 33, NameHash: 2614855220, Flags: 49325), LayoutImmutable, Blittable]
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
