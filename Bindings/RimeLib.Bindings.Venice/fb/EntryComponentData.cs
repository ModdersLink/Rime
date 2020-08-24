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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class EntryComponentData : 
		ComponentData
	{
		protected Vec3 m_SoldierOffset = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1109239746)]
		public Vec3 SoldierOffset { get { return m_SoldierOffset; } set { if (OnPropertyChanging("EntryComponentData." + nameof(SoldierOffset), this, m_SoldierOffset, value)) m_SoldierOffset = value; } } // 0x60 (96)
		
		protected CtrRef<GameAIEntryData> m_AIData = new CtrRef<GameAIEntryData>();
		[ContainerField(112), MemberInfoFlag(53), ContainerFieldNameHash(2529950045), ContainerCtrRef]
		public CtrRef<GameAIEntryData> AIData { get { return m_AIData; } set { if (OnPropertyChanging("EntryComponentData." + nameof(AIData), this, m_AIData, value)) m_AIData = value; } } // 0x70 (112)
		
		protected EntryClass m_EntryClass = new EntryClass();
		[ContainerField(116), MemberInfoFlag(137), ContainerFieldNameHash(292493759)]
		public EntryClass EntryClass { get { return m_EntryClass; } set { if (OnPropertyChanging("EntryComponentData." + nameof(EntryClass), this, m_EntryClass, value)) m_EntryClass = value; } } // 0x74 (116)
		
		protected CtrRef<EntryInputActionMapsData> m_InputConceptDefinition = new CtrRef<EntryInputActionMapsData>();
		[ContainerField(120), MemberInfoFlag(53), ContainerFieldNameHash(1770668454), ContainerCtrRef]
		public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get { return m_InputConceptDefinition; } set { if (OnPropertyChanging("EntryComponentData." + nameof(InputConceptDefinition), this, m_InputConceptDefinition, value)) m_InputConceptDefinition = value; } } // 0x78 (120)
		
		protected CtrRef<InputActionMappingsData> m_InputMapping = new CtrRef<InputActionMappingsData>();
		[ContainerField(124), MemberInfoFlag(53), ContainerFieldNameHash(1744270687), ContainerCtrRef]
		public CtrRef<InputActionMappingsData> InputMapping { get { return m_InputMapping; } set { if (OnPropertyChanging("EntryComponentData." + nameof(InputMapping), this, m_InputMapping, value)) m_InputMapping = value; } } // 0x7C (124)
		
		protected RefArray<InputCurveData> m_InputCurves = new RefArray<InputCurveData>();
		[ContainerField(128), MemberInfoFlag(65), ContainerFieldNameHash(1465820471), ContainerRefArray]
		public RefArray<InputCurveData> InputCurves { get { return m_InputCurves; } set { if (OnPropertyChanging("EntryComponentData." + nameof(InputCurves), this, m_InputCurves, value)) m_InputCurves = value; } } // 0x80 (128)
		
		protected EntryComponentHudData m_HudData = new EntryComponentHudData();
		[ContainerField(132), MemberInfoFlag(41), ContainerFieldNameHash(2639805868)]
		public EntryComponentHudData HudData { get { return m_HudData; } set { if (OnPropertyChanging("EntryComponentData." + nameof(HudData), this, m_HudData, value)) m_HudData = value; } } // 0x84 (132)
		
		protected int m_EntryOrderNumber = new int();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4225856860)]
		public int EntryOrderNumber { get { return m_EntryOrderNumber; } set { if (OnPropertyChanging("EntryComponentData." + nameof(EntryOrderNumber), this, m_EntryOrderNumber, value)) m_EntryOrderNumber = value; } } // 0x90 (144)
		
		protected float m_EnterImpulse = new float();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3008280342)]
		public float EnterImpulse { get { return m_EnterImpulse; } set { if (OnPropertyChanging("EntryComponentData." + nameof(EnterImpulse), this, m_EnterImpulse, value)) m_EnterImpulse = value; } } // 0x94 (148)
		
		protected float m_EntryRadius = new float();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(386452841)]
		public float EntryRadius { get { return m_EntryRadius; } set { if (OnPropertyChanging("EntryComponentData." + nameof(EntryRadius), this, m_EntryRadius, value)) m_EntryRadius = value; } } // 0x98 (152)
		
		protected EntryInputActionEnum m_TriggerEventOnKey = new EntryInputActionEnum();
		[ContainerField(156), MemberInfoFlag(137), ContainerFieldNameHash(1329740711)]
		public EntryInputActionEnum TriggerEventOnKey { get { return m_TriggerEventOnKey; } set { if (OnPropertyChanging("EntryComponentData." + nameof(TriggerEventOnKey), this, m_TriggerEventOnKey, value)) m_TriggerEventOnKey = value; } } // 0x9C (156)
		
		protected EntrySpottingSettings m_EntrySpottingSettings = new EntrySpottingSettings();
		[ContainerField(160), MemberInfoFlag(137), ContainerFieldNameHash(811356248)]
		public EntrySpottingSettings EntrySpottingSettings { get { return m_EntrySpottingSettings; } set { if (OnPropertyChanging("EntryComponentData." + nameof(EntrySpottingSettings), this, m_EntrySpottingSettings, value)) m_EntrySpottingSettings = value; } } // 0xA0 (160)
		
		protected PoseConstraintsData m_PoseConstraints = new PoseConstraintsData();
		[ContainerField(164), MemberInfoFlag(41), ContainerFieldNameHash(4147330298)]
		public PoseConstraintsData PoseConstraints { get { return m_PoseConstraints; } set { if (OnPropertyChanging("EntryComponentData." + nameof(PoseConstraints), this, m_PoseConstraints, value)) m_PoseConstraints = value; } } // 0xA4 (164)
		
		protected float m_SoldierTransitionInvisbleTime = new float();
		[ContainerField(168), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1720869397)]
		public float SoldierTransitionInvisbleTime { get { return m_SoldierTransitionInvisbleTime; } set { if (OnPropertyChanging("EntryComponentData." + nameof(SoldierTransitionInvisbleTime), this, m_SoldierTransitionInvisbleTime, value)) m_SoldierTransitionInvisbleTime = value; } } // 0xA8 (168)
		
		protected int m_NumberOfStances = new int();
		[ContainerField(172), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3289223154)]
		public int NumberOfStances { get { return m_NumberOfStances; } set { if (OnPropertyChanging("EntryComponentData." + nameof(NumberOfStances), this, m_NumberOfStances, value)) m_NumberOfStances = value; } } // 0xAC (172)
		
		protected CtrRef<EntryComponentSoundData> m_EntryComponentSound = new CtrRef<EntryComponentSoundData>();
		[ContainerField(176), MemberInfoFlag(53), ContainerFieldNameHash(248283805), ContainerCtrRef]
		public CtrRef<EntryComponentSoundData> EntryComponentSound { get { return m_EntryComponentSound; } set { if (OnPropertyChanging("EntryComponentData." + nameof(EntryComponentSound), this, m_EntryComponentSound, value)) m_EntryComponentSound = value; } } // 0xB0 (176)
		
		protected bool m_LockSoldierAimingToEntry = new bool();
		[ContainerField(180), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(506867918)]
		public bool LockSoldierAimingToEntry { get { return m_LockSoldierAimingToEntry; } set { if (OnPropertyChanging("EntryComponentData." + nameof(LockSoldierAimingToEntry), this, m_LockSoldierAimingToEntry, value)) m_LockSoldierAimingToEntry = value; } } // 0xB4 (180)
		
		protected bool m_IsAllowedToExitInAir = new bool();
		[ContainerField(181), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4064693665)]
		public bool IsAllowedToExitInAir { get { return m_IsAllowedToExitInAir; } set { if (OnPropertyChanging("EntryComponentData." + nameof(IsAllowedToExitInAir), this, m_IsAllowedToExitInAir, value)) m_IsAllowedToExitInAir = value; } } // 0xB5 (181)
		
		protected bool m_Show1pSoldierInEntry = new bool();
		[ContainerField(182), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1428104062)]
		public bool Show1pSoldierInEntry { get { return m_Show1pSoldierInEntry; } set { if (OnPropertyChanging("EntryComponentData." + nameof(Show1pSoldierInEntry), this, m_Show1pSoldierInEntry, value)) m_Show1pSoldierInEntry = value; } } // 0xB6 (182)
		
		protected bool m_StancesEnabled = new bool();
		[ContainerField(183), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(955154621)]
		public bool StancesEnabled { get { return m_StancesEnabled; } set { if (OnPropertyChanging("EntryComponentData." + nameof(StancesEnabled), this, m_StancesEnabled, value)) m_StancesEnabled = value; } } // 0xB7 (183)
		
		protected bool m_Show1pSoldierInEntryForPlayerOnly = new bool();
		[ContainerField(184), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1703931682)]
		public bool Show1pSoldierInEntryForPlayerOnly { get { return m_Show1pSoldierInEntryForPlayerOnly; } set { if (OnPropertyChanging("EntryComponentData." + nameof(Show1pSoldierInEntryForPlayerOnly), this, m_Show1pSoldierInEntryForPlayerOnly, value)) m_Show1pSoldierInEntryForPlayerOnly = value; } } // 0xB8 (184)
		
		protected bool m_HideSoldierForPassengers = new bool();
		[ContainerField(185), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2768385101)]
		public bool HideSoldierForPassengers { get { return m_HideSoldierForPassengers; } set { if (OnPropertyChanging("EntryComponentData." + nameof(HideSoldierForPassengers), this, m_HideSoldierForPassengers, value)) m_HideSoldierForPassengers = value; } } // 0xB9 (185)
		
		protected bool m_Show3pSoldierWeaponInEntry = new bool();
		[ContainerField(186), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(240179134)]
		public bool Show3pSoldierWeaponInEntry { get { return m_Show3pSoldierWeaponInEntry; } set { if (OnPropertyChanging("EntryComponentData." + nameof(Show3pSoldierWeaponInEntry), this, m_Show3pSoldierWeaponInEntry, value)) m_Show3pSoldierWeaponInEntry = value; } } // 0xBA (186)
		
		protected bool m_ShowSoldierGearInEntry = new bool();
		[ContainerField(187), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1847936462)]
		public bool ShowSoldierGearInEntry { get { return m_ShowSoldierGearInEntry; } set { if (OnPropertyChanging("EntryComponentData." + nameof(ShowSoldierGearInEntry), this, m_ShowSoldierGearInEntry, value)) m_ShowSoldierGearInEntry = value; } } // 0xBB (187)
		
		protected bool m_IsShielded = new bool();
		[ContainerField(188), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2971034625)]
		public bool IsShielded { get { return m_IsShielded; } set { if (OnPropertyChanging("EntryComponentData." + nameof(IsShielded), this, m_IsShielded, value)) m_IsShielded = value; } } // 0xBC (188)
		
		protected bool m_ForbiddenForHuman = new bool();
		[ContainerField(189), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(606394362)]
		public bool ForbiddenForHuman { get { return m_ForbiddenForHuman; } set { if (OnPropertyChanging("EntryComponentData." + nameof(ForbiddenForHuman), this, m_ForbiddenForHuman, value)) m_ForbiddenForHuman = value; } } // 0xBD (189)
		
		protected bool m_ShowSoldierWeaponInEntry = new bool();
		[ContainerField(190), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4236823389)]
		public bool ShowSoldierWeaponInEntry { get { return m_ShowSoldierWeaponInEntry; } set { if (OnPropertyChanging("EntryComponentData." + nameof(ShowSoldierWeaponInEntry), this, m_ShowSoldierWeaponInEntry, value)) m_ShowSoldierWeaponInEntry = value; } } // 0xBE (190)
		
		protected bool m_ShowSoldierInEntry = new bool();
		[ContainerField(191), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2961492191)]
		public bool ShowSoldierInEntry { get { return m_ShowSoldierInEntry; } set { if (OnPropertyChanging("EntryComponentData." + nameof(ShowSoldierInEntry), this, m_ShowSoldierInEntry, value)) m_ShowSoldierInEntry = value; } } // 0xBF (191)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1109239746:
					SoldierOffset = (Vec3) p_Value;
					break;

				case 2529950045:
					AIData = (CtrRef<GameAIEntryData>) p_Value;
					break;

				case 292493759:
					EntryClass = (EntryClass) Enum.ToObject(typeof(EntryClass), p_Value);
					break;

				case 1770668454:
					InputConceptDefinition = (CtrRef<EntryInputActionMapsData>) p_Value;
					break;

				case 1744270687:
					InputMapping = (CtrRef<InputActionMappingsData>) p_Value;
					break;

				case 1465820471:
					InputCurves = (RefArray<InputCurveData>) p_Value;
					break;

				case 2639805868:
					HudData = (EntryComponentHudData) p_Value;
					break;

				case 4225856860:
					EntryOrderNumber = (int) p_Value;
					break;

				case 3008280342:
					EnterImpulse = (float) p_Value;
					break;

				case 386452841:
					EntryRadius = (float) p_Value;
					break;

				case 1329740711:
					TriggerEventOnKey = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 811356248:
					EntrySpottingSettings = (EntrySpottingSettings) Enum.ToObject(typeof(EntrySpottingSettings), p_Value);
					break;

				case 4147330298:
					PoseConstraints = (PoseConstraintsData) p_Value;
					break;

				case 1720869397:
					SoldierTransitionInvisbleTime = (float) p_Value;
					break;

				case 3289223154:
					NumberOfStances = (int) p_Value;
					break;

				case 248283805:
					EntryComponentSound = (CtrRef<EntryComponentSoundData>) p_Value;
					break;

				case 506867918:
					LockSoldierAimingToEntry = (bool) p_Value;
					break;

				case 4064693665:
					IsAllowedToExitInAir = (bool) p_Value;
					break;

				case 1428104062:
					Show1pSoldierInEntry = (bool) p_Value;
					break;

				case 955154621:
					StancesEnabled = (bool) p_Value;
					break;

				case 1703931682:
					Show1pSoldierInEntryForPlayerOnly = (bool) p_Value;
					break;

				case 2768385101:
					HideSoldierForPassengers = (bool) p_Value;
					break;

				case 240179134:
					Show3pSoldierWeaponInEntry = (bool) p_Value;
					break;

				case 1847936462:
					ShowSoldierGearInEntry = (bool) p_Value;
					break;

				case 2971034625:
					IsShielded = (bool) p_Value;
					break;

				case 606394362:
					ForbiddenForHuman = (bool) p_Value;
					break;

				case 4236823389:
					ShowSoldierWeaponInEntry = (bool) p_Value;
					break;

				case 2961492191:
					ShowSoldierInEntry = (bool) p_Value;
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
				case 1109239746:
					return SoldierOffset;

				case 2529950045:
					return AIData;

				case 292493759:
					return EntryClass;

				case 1770668454:
					return InputConceptDefinition;

				case 1744270687:
					return InputMapping;

				case 1465820471:
					return InputCurves;

				case 2639805868:
					return HudData;

				case 4225856860:
					return EntryOrderNumber;

				case 3008280342:
					return EnterImpulse;

				case 386452841:
					return EntryRadius;

				case 1329740711:
					return TriggerEventOnKey;

				case 811356248:
					return EntrySpottingSettings;

				case 4147330298:
					return PoseConstraints;

				case 1720869397:
					return SoldierTransitionInvisbleTime;

				case 3289223154:
					return NumberOfStances;

				case 248283805:
					return EntryComponentSound;

				case 506867918:
					return LockSoldierAimingToEntry;

				case 4064693665:
					return IsAllowedToExitInAir;

				case 1428104062:
					return Show1pSoldierInEntry;

				case 955154621:
					return StancesEnabled;

				case 1703931682:
					return Show1pSoldierInEntryForPlayerOnly;

				case 2768385101:
					return HideSoldierForPassengers;

				case 240179134:
					return Show3pSoldierWeaponInEntry;

				case 1847936462:
					return ShowSoldierGearInEntry;

				case 2971034625:
					return IsShielded;

				case 606394362:
					return ForbiddenForHuman;

				case 4236823389:
					return ShowSoldierWeaponInEntry;

				case 2961492191:
					return ShowSoldierInEntry;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1109239746:
					return typeof(EntryComponentData).GetProperty(nameof(SoldierOffset));

				case 2529950045:
					return typeof(EntryComponentData).GetProperty(nameof(AIData));

				case 292493759:
					return typeof(EntryComponentData).GetProperty(nameof(EntryClass));

				case 1770668454:
					return typeof(EntryComponentData).GetProperty(nameof(InputConceptDefinition));

				case 1744270687:
					return typeof(EntryComponentData).GetProperty(nameof(InputMapping));

				case 1465820471:
					return typeof(EntryComponentData).GetProperty(nameof(InputCurves));

				case 2639805868:
					return typeof(EntryComponentData).GetProperty(nameof(HudData));

				case 4225856860:
					return typeof(EntryComponentData).GetProperty(nameof(EntryOrderNumber));

				case 3008280342:
					return typeof(EntryComponentData).GetProperty(nameof(EnterImpulse));

				case 386452841:
					return typeof(EntryComponentData).GetProperty(nameof(EntryRadius));

				case 1329740711:
					return typeof(EntryComponentData).GetProperty(nameof(TriggerEventOnKey));

				case 811356248:
					return typeof(EntryComponentData).GetProperty(nameof(EntrySpottingSettings));

				case 4147330298:
					return typeof(EntryComponentData).GetProperty(nameof(PoseConstraints));

				case 1720869397:
					return typeof(EntryComponentData).GetProperty(nameof(SoldierTransitionInvisbleTime));

				case 3289223154:
					return typeof(EntryComponentData).GetProperty(nameof(NumberOfStances));

				case 248283805:
					return typeof(EntryComponentData).GetProperty(nameof(EntryComponentSound));

				case 506867918:
					return typeof(EntryComponentData).GetProperty(nameof(LockSoldierAimingToEntry));

				case 4064693665:
					return typeof(EntryComponentData).GetProperty(nameof(IsAllowedToExitInAir));

				case 1428104062:
					return typeof(EntryComponentData).GetProperty(nameof(Show1pSoldierInEntry));

				case 955154621:
					return typeof(EntryComponentData).GetProperty(nameof(StancesEnabled));

				case 1703931682:
					return typeof(EntryComponentData).GetProperty(nameof(Show1pSoldierInEntryForPlayerOnly));

				case 2768385101:
					return typeof(EntryComponentData).GetProperty(nameof(HideSoldierForPassengers));

				case 240179134:
					return typeof(EntryComponentData).GetProperty(nameof(Show3pSoldierWeaponInEntry));

				case 1847936462:
					return typeof(EntryComponentData).GetProperty(nameof(ShowSoldierGearInEntry));

				case 2971034625:
					return typeof(EntryComponentData).GetProperty(nameof(IsShielded));

				case 606394362:
					return typeof(EntryComponentData).GetProperty(nameof(ForbiddenForHuman));

				case 4236823389:
					return typeof(EntryComponentData).GetProperty(nameof(ShowSoldierWeaponInEntry));

				case 2961492191:
					return typeof(EntryComponentData).GetProperty(nameof(ShowSoldierInEntry));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
