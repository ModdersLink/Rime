///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class EntryComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SoldierOffset { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112)]
		public CtrRef<GameAIEntryData> AIData { get; set; } = new CtrRef<GameAIEntryData>(); // 0x70 (112)
		
		[ContainerField(116)]
		public EntryClass EntryClass { get; set; } = new EntryClass(); // 0x74 (116)
		
		[ContainerField(120)]
		public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get; set; } = new CtrRef<EntryInputActionMapsData>(); // 0x78 (120)
		
		[ContainerField(124)]
		public CtrRef<InputActionMappingsData> InputMapping { get; set; } = new CtrRef<InputActionMappingsData>(); // 0x7C (124)
		
		[ContainerField(128)]
		public RefArray<InputCurveData> InputCurves { get; set; } = new RefArray<InputCurveData>(); // 0x80 (128)
		
		[ContainerField(132)]
		public EntryComponentHudData HudData { get; set; } = new EntryComponentHudData(); // 0x84 (132)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public int EntryOrderNumber { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float EnterImpulse { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float EntryRadius { get; set; } // 0x98 (152)
		
		[ContainerField(156)]
		public EntryInputActionEnum TriggerEventOnKey { get; set; } = new EntryInputActionEnum(); // 0x9C (156)
		
		[ContainerField(160)]
		public EntrySpottingSettings EntrySpottingSettings { get; set; } = new EntrySpottingSettings(); // 0xA0 (160)
		
		[ContainerField(164)]
		public PoseConstraintsData PoseConstraints { get; set; } = new PoseConstraintsData(); // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float SoldierTransitionInvisbleTime { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public int NumberOfStances { get; set; } // 0xAC (172)
		
		[ContainerField(176)]
		public CtrRef<EntryComponentSoundData> EntryComponentSound { get; set; } = new CtrRef<EntryComponentSoundData>(); // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public bool LockSoldierAimingToEntry { get; set; } // 0xB4 (180)
		
		[ContainerField(181), LayoutImmutable, Blittable]
		public bool IsAllowedToExitInAir { get; set; } // 0xB5 (181)
		
		[ContainerField(182), LayoutImmutable, Blittable]
		public bool Show1pSoldierInEntry { get; set; } // 0xB6 (182)
		
		[ContainerField(183), LayoutImmutable, Blittable]
		public bool StancesEnabled { get; set; } // 0xB7 (183)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public bool Show1pSoldierInEntryForPlayerOnly { get; set; } // 0xB8 (184)
		
		[ContainerField(185), LayoutImmutable, Blittable]
		public bool HideSoldierForPassengers { get; set; } // 0xB9 (185)
		
		[ContainerField(186), LayoutImmutable, Blittable]
		public bool Show3pSoldierWeaponInEntry { get; set; } // 0xBA (186)
		
		[ContainerField(187), LayoutImmutable, Blittable]
		public bool ShowSoldierGearInEntry { get; set; } // 0xBB (187)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public bool IsShielded { get; set; } // 0xBC (188)
		
		[ContainerField(189), LayoutImmutable, Blittable]
		public bool ForbiddenForHuman { get; set; } // 0xBD (189)
		
		[ContainerField(190), LayoutImmutable, Blittable]
		public bool ShowSoldierWeaponInEntry { get; set; } // 0xBE (190)
		
		[ContainerField(191), LayoutImmutable, Blittable]
		public bool ShowSoldierInEntry { get; set; } // 0xBF (191)
		
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
