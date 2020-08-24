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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class DirectWeaponSwitchingMapData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(137)]
		public EntryInputActionEnum Action { get; set; } = new EntryInputActionEnum(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(137)]
		public WeaponSwitchingEnum ToWeapon { get; set; } = new WeaponSwitchingEnum(); // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float PreventMeleeRepeatTime { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float SwitchBackToPrevMaxTimePressed { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool UseQuickSwitch { get; set; } // 0x10 (16)
		
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool FireAndSwitchBackToPrev { get; set; } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2484178491:
						Action = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 3504623164:
						ToWeapon = (WeaponSwitchingEnum) Enum.ToObject(typeof(WeaponSwitchingEnum), p_Value);
					break;

				case 4062736589:
					PreventMeleeRepeatTime = (float) p_Value;
					break;

				case 1443716209:
					SwitchBackToPrevMaxTimePressed = (float) p_Value;
					break;

				case 138398865:
					UseQuickSwitch = (bool) p_Value;
					break;

				case 1486658789:
					FireAndSwitchBackToPrev = (bool) p_Value;
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
				case 2484178491:
					return Action;

				case 3504623164:
					return ToWeapon;

				case 4062736589:
					return PreventMeleeRepeatTime;

				case 1443716209:
					return SwitchBackToPrevMaxTimePressed;

				case 138398865:
					return UseQuickSwitch;

				case 1486658789:
					return FireAndSwitchBackToPrev;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2484178491:
					return typeof(DirectWeaponSwitchingMapData).GetProperty(nameof(Action));

				case 3504623164:
					return typeof(DirectWeaponSwitchingMapData).GetProperty(nameof(ToWeapon));

				case 4062736589:
					return typeof(DirectWeaponSwitchingMapData).GetProperty(nameof(PreventMeleeRepeatTime));

				case 1443716209:
					return typeof(DirectWeaponSwitchingMapData).GetProperty(nameof(SwitchBackToPrevMaxTimePressed));

				case 138398865:
					return typeof(DirectWeaponSwitchingMapData).GetProperty(nameof(UseQuickSwitch));

				case 1486658789:
					return typeof(DirectWeaponSwitchingMapData).GetProperty(nameof(FireAndSwitchBackToPrev));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
