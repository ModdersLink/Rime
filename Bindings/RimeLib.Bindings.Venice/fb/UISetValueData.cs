///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UISetValueData : 
		EntityData
	{
		[ContainerField(12)]
		public UIDataSourceInfo DataSource { get; set; } = new UIDataSourceInfo(); // 0xC (12)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int IntValue { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float FloatValue { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string StringValue { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool BoolValue { get; set; } // 0x28 (40)
		
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
