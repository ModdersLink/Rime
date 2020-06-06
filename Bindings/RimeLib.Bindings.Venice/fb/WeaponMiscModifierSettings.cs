///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(1)]
	public class WeaponMiscModifierSettings : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public bool EnableBreathControl { get; set; } // 0x0 (0)
		
		[ContainerField(1), LayoutImmutable, Blittable]
		public bool CanBeInSupportedShooting { get; set; } // 0x1 (1)
		
		[ContainerField(2), LayoutImmutable, Blittable]
		public bool UnZoomOnBoltAction { get; set; } // 0x2 (2)
		
		[ContainerField(3), LayoutImmutable, Blittable]
		public bool HoldBoltActionUntilZoomRelease { get; set; } // 0x3 (3)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public bool IsSilenced { get; set; } // 0x4 (4)
		
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
					return typeof(WeaponMiscModifierSettings).GetProperty(nameof(EnableBreathControl));

				case 2187452328:
					return typeof(WeaponMiscModifierSettings).GetProperty(nameof(CanBeInSupportedShooting));

				case 1438634691:
					return typeof(WeaponMiscModifierSettings).GetProperty(nameof(UnZoomOnBoltAction));

				case 3133940949:
					return typeof(WeaponMiscModifierSettings).GetProperty(nameof(HoldBoltActionUntilZoomRelease));

				case 1644964768:
					return typeof(WeaponMiscModifierSettings).GetProperty(nameof(IsSilenced));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
