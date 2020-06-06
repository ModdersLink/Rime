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
	public class WeaponSuppressionData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxMultiplier { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinMultiplier { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MinDistance { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 441185306:
					MaxMultiplier = (float) p_Value;
					break;

				case 3723256324:
					MinMultiplier = (float) p_Value;
					break;

				case 1885855628:
					MinDistance = (float) p_Value;
					break;

				case 3520454034:
					MaxDistance = (float) p_Value;
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
				case 441185306:
					return MaxMultiplier;

				case 3723256324:
					return MinMultiplier;

				case 1885855628:
					return MinDistance;

				case 3520454034:
					return MaxDistance;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 441185306:
					return typeof(WeaponSuppressionData).GetProperty(nameof(MaxMultiplier));

				case 3723256324:
					return typeof(WeaponSuppressionData).GetProperty(nameof(MinMultiplier));

				case 1885855628:
					return typeof(WeaponSuppressionData).GetProperty(nameof(MinDistance));

				case 3520454034:
					return typeof(WeaponSuppressionData).GetProperty(nameof(MaxDistance));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
