///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class WeaponEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public List<WeaponStateData> WeaponStates { get; set; } = new List<WeaponStateData>(); // 0x60 (96)
		
		[ContainerField(100)]
		public WeaponClassEnum WeaponClass { get; set; } = new WeaponClassEnum(); // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<GameAIWeaponData> AIData { get; set; } = new CtrRef<GameAIWeaponData>(); // 0x68 (104)
		
		[ContainerField(108)]
		public CtrRef<WeaponFiringData> WeaponFiring { get; set; } = new CtrRef<WeaponFiringData>(); // 0x6C (108)
		
		[ContainerField(112)]
		public CtrRef<WeaponData> CustomWeaponType { get; set; } = new CtrRef<WeaponData>(); // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2607587267:
					WeaponStates = (List<WeaponStateData>) p_Value;
					break;

				case 711657993:
					WeaponClass = (WeaponClassEnum) Enum.ToObject(typeof(WeaponClassEnum), p_Value);
					break;

				case 2529950045:
					AIData = (CtrRef<GameAIWeaponData>) p_Value;
					break;

				case 1823157050:
					WeaponFiring = (CtrRef<WeaponFiringData>) p_Value;
					break;

				case 3603058156:
					CustomWeaponType = (CtrRef<WeaponData>) p_Value;
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
				case 2607587267:
					return WeaponStates;

				case 711657993:
					return WeaponClass;

				case 2529950045:
					return AIData;

				case 1823157050:
					return WeaponFiring;

				case 3603058156:
					return CustomWeaponType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2607587267:
					return typeof(WeaponEntityData).GetProperty(nameof(WeaponStates));

				case 711657993:
					return typeof(WeaponEntityData).GetProperty(nameof(WeaponClass));

				case 2529950045:
					return typeof(WeaponEntityData).GetProperty(nameof(AIData));

				case 1823157050:
					return typeof(WeaponEntityData).GetProperty(nameof(WeaponFiring));

				case 3603058156:
					return typeof(WeaponEntityData).GetProperty(nameof(CustomWeaponType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
