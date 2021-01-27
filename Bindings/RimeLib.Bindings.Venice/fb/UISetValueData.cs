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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 44)]
	public class UISetValueData : 
		EntityData
	{
		protected UIDataSourceInfo m_DataSource = new UIDataSourceInfo();
		[ContainerField(Name: "DataSource", Offset: 12, NameHash: 3810860200, Flags: 41)]
		public UIDataSourceInfo DataSource { get { return m_DataSource; } set { if (OnPropertyChanging("UISetValueData." + nameof(DataSource), this, m_DataSource, value)) m_DataSource = value; } } // 0xC (12)
		
		protected int m_IntValue = new int();
		[ContainerField(Name: "IntValue", Offset: 28, NameHash: 5685821, Flags: 49405), LayoutImmutable, Blittable]
		public int IntValue { get { return m_IntValue; } set { if (OnPropertyChanging("UISetValueData." + nameof(IntValue), this, m_IntValue, value)) m_IntValue = value; } } // 0x1C (28)
		
		protected float m_FloatValue = new float();
		[ContainerField(Name: "FloatValue", Offset: 32, NameHash: 3123792190, Flags: 49469), LayoutImmutable, Blittable]
		public float FloatValue { get { return m_FloatValue; } set { if (OnPropertyChanging("UISetValueData." + nameof(FloatValue), this, m_FloatValue, value)) m_FloatValue = value; } } // 0x20 (32)
		
		protected string m_StringValue = string.Empty;
		[ContainerField(Name: "StringValue", Offset: 36, NameHash: 1269878171, Flags: 16509), LayoutImmutable]
		public string StringValue { get { return m_StringValue; } set { if (OnPropertyChanging("UISetValueData." + nameof(StringValue), this, m_StringValue, value)) m_StringValue = value; } } // 0x24 (36)
		
		protected bool m_BoolValue = new bool();
		[ContainerField(Name: "BoolValue", Offset: 40, NameHash: 176040160, Flags: 49325), LayoutImmutable, Blittable]
		public bool BoolValue { get { return m_BoolValue; } set { if (OnPropertyChanging("UISetValueData." + nameof(BoolValue), this, m_BoolValue, value)) m_BoolValue = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3810860200:
					DataSource = (UIDataSourceInfo) p_Value;
					break;

				case 5685821:
					IntValue = (int) p_Value;
					break;

				case 3123792190:
					FloatValue = (float) p_Value;
					break;

				case 1269878171:
					StringValue = (string) p_Value;
					break;

				case 176040160:
					BoolValue = (bool) p_Value;
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
				case 3810860200:
					return DataSource;

				case 5685821:
					return IntValue;

				case 3123792190:
					return FloatValue;

				case 1269878171:
					return StringValue;

				case 176040160:
					return BoolValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3810860200:
					return typeof(UISetValueData).GetProperty(nameof(DataSource));

				case 5685821:
					return typeof(UISetValueData).GetProperty(nameof(IntValue));

				case 3123792190:
					return typeof(UISetValueData).GetProperty(nameof(FloatValue));

				case 1269878171:
					return typeof(UISetValueData).GetProperty(nameof(StringValue));

				case 176040160:
					return typeof(UISetValueData).GetProperty(nameof(BoolValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
