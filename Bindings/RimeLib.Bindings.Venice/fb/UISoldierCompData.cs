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
	public class UISoldierCompData : 
		UIComponentData
	{
		[ContainerField(28), LayoutImmutable, Blittable]
		public float CriticalHealthThreshold { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float HitShaderDamageMultiplier { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float HitShaderMinDamage { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float EKGLineThickness { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int ShockTraumaAbilityIndex { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public int RangerPTProgramAbilityIndex { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public int FocusAbilityIndex { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float EKGLineAlpha { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float HitShaderGradientDurationMultiplier { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float HitShaderMaxDamage { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float HitShaderIndicatorDurationMultiplier { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public bool UseVehicleTeamSpawn { get; set; } // 0x48 (72)
		
		[ContainerField(73), LayoutImmutable, Blittable]
		public bool UseSquadSpawn { get; set; } // 0x49 (73)
		
		[ContainerField(74), LayoutImmutable, Blittable]
		public bool SpawnOnSquadLeaders { get; set; } // 0x4A (74)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3436084165:
					CriticalHealthThreshold = (float) p_Value;
					break;

				case 3340210873:
					HitShaderDamageMultiplier = (float) p_Value;
					break;

				case 2717077880:
					HitShaderMinDamage = (float) p_Value;
					break;

				case 2386310132:
					EKGLineThickness = (float) p_Value;
					break;

				case 1200877787:
					ShockTraumaAbilityIndex = (int) p_Value;
					break;

				case 1723606308:
					RangerPTProgramAbilityIndex = (int) p_Value;
					break;

				case 1709540821:
					FocusAbilityIndex = (int) p_Value;
					break;

				case 1184876726:
					EKGLineAlpha = (float) p_Value;
					break;

				case 708730442:
					HitShaderGradientDurationMultiplier = (float) p_Value;
					break;

				case 4051274470:
					HitShaderMaxDamage = (float) p_Value;
					break;

				case 714187021:
					HitShaderIndicatorDurationMultiplier = (float) p_Value;
					break;

				case 2752336856:
					UseVehicleTeamSpawn = (bool) p_Value;
					break;

				case 1241616175:
					UseSquadSpawn = (bool) p_Value;
					break;

				case 1524349093:
					SpawnOnSquadLeaders = (bool) p_Value;
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
				case 3436084165:
					return CriticalHealthThreshold;

				case 3340210873:
					return HitShaderDamageMultiplier;

				case 2717077880:
					return HitShaderMinDamage;

				case 2386310132:
					return EKGLineThickness;

				case 1200877787:
					return ShockTraumaAbilityIndex;

				case 1723606308:
					return RangerPTProgramAbilityIndex;

				case 1709540821:
					return FocusAbilityIndex;

				case 1184876726:
					return EKGLineAlpha;

				case 708730442:
					return HitShaderGradientDurationMultiplier;

				case 4051274470:
					return HitShaderMaxDamage;

				case 714187021:
					return HitShaderIndicatorDurationMultiplier;

				case 2752336856:
					return UseVehicleTeamSpawn;

				case 1241616175:
					return UseSquadSpawn;

				case 1524349093:
					return SpawnOnSquadLeaders;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3436084165:
					return typeof(UISoldierCompData).GetProperty(nameof(CriticalHealthThreshold));

				case 3340210873:
					return typeof(UISoldierCompData).GetProperty(nameof(HitShaderDamageMultiplier));

				case 2717077880:
					return typeof(UISoldierCompData).GetProperty(nameof(HitShaderMinDamage));

				case 2386310132:
					return typeof(UISoldierCompData).GetProperty(nameof(EKGLineThickness));

				case 1200877787:
					return typeof(UISoldierCompData).GetProperty(nameof(ShockTraumaAbilityIndex));

				case 1723606308:
					return typeof(UISoldierCompData).GetProperty(nameof(RangerPTProgramAbilityIndex));

				case 1709540821:
					return typeof(UISoldierCompData).GetProperty(nameof(FocusAbilityIndex));

				case 1184876726:
					return typeof(UISoldierCompData).GetProperty(nameof(EKGLineAlpha));

				case 708730442:
					return typeof(UISoldierCompData).GetProperty(nameof(HitShaderGradientDurationMultiplier));

				case 4051274470:
					return typeof(UISoldierCompData).GetProperty(nameof(HitShaderMaxDamage));

				case 714187021:
					return typeof(UISoldierCompData).GetProperty(nameof(HitShaderIndicatorDurationMultiplier));

				case 2752336856:
					return typeof(UISoldierCompData).GetProperty(nameof(UseVehicleTeamSpawn));

				case 1241616175:
					return typeof(UISoldierCompData).GetProperty(nameof(UseSquadSpawn));

				case 1524349093:
					return typeof(UISoldierCompData).GetProperty(nameof(SpawnOnSquadLeaders));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
