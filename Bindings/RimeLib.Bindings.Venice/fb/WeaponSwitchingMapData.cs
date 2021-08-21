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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class WeaponSwitchingMapData : FrostbiteContainer
	{
		[ContainerField(Name: "FromWeapon", Offset: 0, NameHash: 2475999121, Flags: 137)]
		public WeaponSwitchingEnum FromWeapon { get; set; } = new WeaponSwitchingEnum(); // 0x0 (0)
		
		[ContainerField(Name: "Action", Offset: 4, NameHash: 2484178491, Flags: 137)]
		public EntryInputActionEnum Action { get; set; } = new EntryInputActionEnum(); // 0x4 (4)
		
		[ContainerField(Name: "ToWeapon", Offset: 8, NameHash: 3504623164, Flags: 65)]
		public List<WeaponSwitchingEnum> ToWeapon { get; set; } = new List<WeaponSwitchingEnum>(); // 0x8 (8)
		
		[ContainerField(Name: "FireAndSwitchBackToPrev", Offset: 12, NameHash: 1486658789, Flags: 49325), LayoutImmutable, Blittable]
		public bool FireAndSwitchBackToPrev { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2475999121:
						FromWeapon = (WeaponSwitchingEnum) Enum.ToObject(typeof(WeaponSwitchingEnum), p_Value);
					break;

				case 2484178491:
						Action = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 3504623164:
					if (p_Value.GetType() == typeof (List<uint>))
						ToWeapon = ((List<uint>) p_Value).Select(x => (WeaponSwitchingEnum) Enum.ToObject(typeof(WeaponSwitchingEnum), x)).ToList();
					else
						ToWeapon = (List<WeaponSwitchingEnum>) p_Value;
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
				case 2475999121:
					return FromWeapon;

				case 2484178491:
					return Action;

				case 3504623164:
					return ToWeapon;

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
				case 2475999121:
					return typeof(WeaponSwitchingMapData).GetProperty(nameof(FromWeapon));

				case 2484178491:
					return typeof(WeaponSwitchingMapData).GetProperty(nameof(Action));

				case 3504623164:
					return typeof(WeaponSwitchingMapData).GetProperty(nameof(ToWeapon));

				case 1486658789:
					return typeof(WeaponSwitchingMapData).GetProperty(nameof(FireAndSwitchBackToPrev));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
