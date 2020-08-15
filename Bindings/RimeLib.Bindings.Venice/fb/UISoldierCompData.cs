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
	[ContainerType(4)]
	public class UISoldierCompData : 
		UIComponentData
	{
		protected float m_CriticalHealthThreshold = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(3436084165)]
		public float CriticalHealthThreshold { get { return m_CriticalHealthThreshold; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(CriticalHealthThreshold), this, m_CriticalHealthThreshold, value)) m_CriticalHealthThreshold = value; } } // 0x1C (28)
		
		protected float m_HitShaderDamageMultiplier = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(3340210873)]
		public float HitShaderDamageMultiplier { get { return m_HitShaderDamageMultiplier; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(HitShaderDamageMultiplier), this, m_HitShaderDamageMultiplier, value)) m_HitShaderDamageMultiplier = value; } } // 0x20 (32)
		
		protected float m_HitShaderMinDamage = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(2717077880)]
		public float HitShaderMinDamage { get { return m_HitShaderMinDamage; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(HitShaderMinDamage), this, m_HitShaderMinDamage, value)) m_HitShaderMinDamage = value; } } // 0x24 (36)
		
		protected float m_EKGLineThickness = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(2386310132)]
		public float EKGLineThickness { get { return m_EKGLineThickness; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(EKGLineThickness), this, m_EKGLineThickness, value)) m_EKGLineThickness = value; } } // 0x28 (40)
		
		protected int m_ShockTraumaAbilityIndex = new int();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(1200877787)]
		public int ShockTraumaAbilityIndex { get { return m_ShockTraumaAbilityIndex; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(ShockTraumaAbilityIndex), this, m_ShockTraumaAbilityIndex, value)) m_ShockTraumaAbilityIndex = value; } } // 0x2C (44)
		
		protected int m_RangerPTProgramAbilityIndex = new int();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(1723606308)]
		public int RangerPTProgramAbilityIndex { get { return m_RangerPTProgramAbilityIndex; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(RangerPTProgramAbilityIndex), this, m_RangerPTProgramAbilityIndex, value)) m_RangerPTProgramAbilityIndex = value; } } // 0x30 (48)
		
		protected int m_FocusAbilityIndex = new int();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(1709540821)]
		public int FocusAbilityIndex { get { return m_FocusAbilityIndex; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(FocusAbilityIndex), this, m_FocusAbilityIndex, value)) m_FocusAbilityIndex = value; } } // 0x34 (52)
		
		protected float m_EKGLineAlpha = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(1184876726)]
		public float EKGLineAlpha { get { return m_EKGLineAlpha; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(EKGLineAlpha), this, m_EKGLineAlpha, value)) m_EKGLineAlpha = value; } } // 0x38 (56)
		
		protected float m_HitShaderGradientDurationMultiplier = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(708730442)]
		public float HitShaderGradientDurationMultiplier { get { return m_HitShaderGradientDurationMultiplier; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(HitShaderGradientDurationMultiplier), this, m_HitShaderGradientDurationMultiplier, value)) m_HitShaderGradientDurationMultiplier = value; } } // 0x3C (60)
		
		protected float m_HitShaderMaxDamage = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(4051274470)]
		public float HitShaderMaxDamage { get { return m_HitShaderMaxDamage; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(HitShaderMaxDamage), this, m_HitShaderMaxDamage, value)) m_HitShaderMaxDamage = value; } } // 0x40 (64)
		
		protected float m_HitShaderIndicatorDurationMultiplier = new float();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(714187021)]
		public float HitShaderIndicatorDurationMultiplier { get { return m_HitShaderIndicatorDurationMultiplier; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(HitShaderIndicatorDurationMultiplier), this, m_HitShaderIndicatorDurationMultiplier, value)) m_HitShaderIndicatorDurationMultiplier = value; } } // 0x44 (68)
		
		protected bool m_UseVehicleTeamSpawn = new bool();
		[ContainerField(72), LayoutImmutable, Blittable, ContainerFieldNameHash(2752336856)]
		public bool UseVehicleTeamSpawn { get { return m_UseVehicleTeamSpawn; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(UseVehicleTeamSpawn), this, m_UseVehicleTeamSpawn, value)) m_UseVehicleTeamSpawn = value; } } // 0x48 (72)
		
		protected bool m_UseSquadSpawn = new bool();
		[ContainerField(73), LayoutImmutable, Blittable, ContainerFieldNameHash(1241616175)]
		public bool UseSquadSpawn { get { return m_UseSquadSpawn; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(UseSquadSpawn), this, m_UseSquadSpawn, value)) m_UseSquadSpawn = value; } } // 0x49 (73)
		
		protected bool m_SpawnOnSquadLeaders = new bool();
		[ContainerField(74), LayoutImmutable, Blittable, ContainerFieldNameHash(1524349093)]
		public bool SpawnOnSquadLeaders { get { return m_SpawnOnSquadLeaders; } set { if (OnPropertyChanging("UISoldierCompData." + nameof(SpawnOnSquadLeaders), this, m_SpawnOnSquadLeaders, value)) m_SpawnOnSquadLeaders = value; } } // 0x4A (74)
		
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
