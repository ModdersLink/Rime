///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoldierWeaponSwitchingData : 
		Asset
	{
		[ContainerField(12)]
		public List<WeaponSwitchingMapData> SwitchMap { get; set; } = new List<WeaponSwitchingMapData>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<DirectWeaponSwitchingMapData> DirectSwitchMap { get; set; } = new List<DirectWeaponSwitchingMapData>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float SwitchToGadgetCooldownTime { get; set; } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 958053643:
					SwitchMap = (List<WeaponSwitchingMapData>) p_Value;
					break;

				case 2207082534:
					DirectSwitchMap = (List<DirectWeaponSwitchingMapData>) p_Value;
					break;

				case 2738447440:
					SwitchToGadgetCooldownTime = (float) p_Value;
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
				case 958053643:
					return SwitchMap;

				case 2207082534:
					return DirectSwitchMap;

				case 2738447440:
					return SwitchToGadgetCooldownTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 958053643:
					return typeof(SoldierWeaponSwitchingData).GetProperty(nameof(SwitchMap));

				case 2207082534:
					return typeof(SoldierWeaponSwitchingData).GetProperty(nameof(DirectSwitchMap));

				case 2738447440:
					return typeof(SoldierWeaponSwitchingData).GetProperty(nameof(SwitchToGadgetCooldownTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
