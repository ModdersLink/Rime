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
	public class UIWeaponCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinHitIndicatorLimit { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float MaxHitIndicatorLimit { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float NormalHitIndicatorLimit { get; set; } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2846241422:
					MinHitIndicatorLimit = (float) p_Value;
					break;

				case 3944764752:
					MaxHitIndicatorLimit = (float) p_Value;
					break;

				case 2004036151:
					NormalHitIndicatorLimit = (float) p_Value;
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
				case 2846241422:
					return MinHitIndicatorLimit;

				case 3944764752:
					return MaxHitIndicatorLimit;

				case 2004036151:
					return NormalHitIndicatorLimit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2846241422:
					return typeof(UIWeaponCompData).GetProperty(nameof(MinHitIndicatorLimit));

				case 3944764752:
					return typeof(UIWeaponCompData).GetProperty(nameof(MaxHitIndicatorLimit));

				case 2004036151:
					return typeof(UIWeaponCompData).GetProperty(nameof(NormalHitIndicatorLimit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
