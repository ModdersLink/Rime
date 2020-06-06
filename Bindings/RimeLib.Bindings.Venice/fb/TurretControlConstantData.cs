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
	public class TurretControlConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SearchLookSpeed { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float SlowLookSpeed { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float NormalLookSpeed { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float FastLookSpeed { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1142077483:
					SearchLookSpeed = (float) p_Value;
					break;

				case 3507040034:
					SlowLookSpeed = (float) p_Value;
					break;

				case 3237374486:
					NormalLookSpeed = (float) p_Value;
					break;

				case 599104037:
					FastLookSpeed = (float) p_Value;
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
				case 1142077483:
					return SearchLookSpeed;

				case 3507040034:
					return SlowLookSpeed;

				case 3237374486:
					return NormalLookSpeed;

				case 599104037:
					return FastLookSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1142077483:
					return typeof(TurretControlConstantData).GetProperty(nameof(SearchLookSpeed));

				case 3507040034:
					return typeof(TurretControlConstantData).GetProperty(nameof(SlowLookSpeed));

				case 3237374486:
					return typeof(TurretControlConstantData).GetProperty(nameof(NormalLookSpeed));

				case 599104037:
					return typeof(TurretControlConstantData).GetProperty(nameof(FastLookSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
