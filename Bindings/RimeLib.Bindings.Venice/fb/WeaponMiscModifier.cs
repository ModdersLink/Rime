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
	public class WeaponMiscModifier : 
		WeaponModifierBase
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool EnableBreathControl { get; set; } // 0x8 (8)
		
		[ContainerField(9), LayoutImmutable, Blittable]
		public bool CanBeInSupportedShooting { get; set; } // 0x9 (9)
		
		[ContainerField(10), LayoutImmutable, Blittable]
		public bool UnZoomOnBoltAction { get; set; } // 0xA (10)
		
		[ContainerField(11), LayoutImmutable, Blittable]
		public bool HoldBoltActionUntilZoomRelease { get; set; } // 0xB (11)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool IsSilenced { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 613505579:
					EnableBreathControl = (bool) p_Value;
					break;

				case 2187452328:
					CanBeInSupportedShooting = (bool) p_Value;
					break;

				case 1438634691:
					UnZoomOnBoltAction = (bool) p_Value;
					break;

				case 3133940949:
					HoldBoltActionUntilZoomRelease = (bool) p_Value;
					break;

				case 1644964768:
					IsSilenced = (bool) p_Value;
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
				case 613505579:
					return EnableBreathControl;

				case 2187452328:
					return CanBeInSupportedShooting;

				case 1438634691:
					return UnZoomOnBoltAction;

				case 3133940949:
					return HoldBoltActionUntilZoomRelease;

				case 1644964768:
					return IsSilenced;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 613505579:
					return typeof(WeaponMiscModifier).GetProperty(nameof(EnableBreathControl));

				case 2187452328:
					return typeof(WeaponMiscModifier).GetProperty(nameof(CanBeInSupportedShooting));

				case 1438634691:
					return typeof(WeaponMiscModifier).GetProperty(nameof(UnZoomOnBoltAction));

				case 3133940949:
					return typeof(WeaponMiscModifier).GetProperty(nameof(HoldBoltActionUntilZoomRelease));

				case 1644964768:
					return typeof(WeaponMiscModifier).GetProperty(nameof(IsSilenced));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
