///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 192)]
	public class EntryComponentData :
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 SoldierOffset { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public CtrRef<GameAIEntryData> AIData { get; set; } = new();

		[ContainerField(116), JsonProperty(Order = 116)]
		public EntryClass EntryClass { get; set; } = new();

		[ContainerField(120), JsonProperty(Order = 120)]
		public CtrRef<EntryInputActionMapsData> InputConceptDefinition { get; set; } = new();

		[ContainerField(124), JsonProperty(Order = 124)]
		public CtrRef<InputActionMappingsData> InputMapping { get; set; } = new();

		[ContainerField(128), JsonProperty(Order = 128)]
		public RefArray<InputCurveData> InputCurves { get; set; } = new();

		[ContainerField(132), JsonProperty(Order = 132)]
		public EntryComponentHudData HudData { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public int EntryOrderNumber { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float EnterImpulse { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float EntryRadius { get; set; }

		[ContainerField(156), JsonProperty(Order = 156)]
		public EntryInputActionEnum TriggerEventOnKey { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public EntrySpottingSettings EntrySpottingSettings { get; set; } = new();

		[ContainerField(164), JsonProperty(Order = 164)]
		public PoseConstraintsData PoseConstraints { get; set; } = new();

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float SoldierTransitionInvisbleTime { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public int NumberOfStances { get; set; }

		[ContainerField(176), JsonProperty(Order = 176)]
		public CtrRef<EntryComponentSoundData> EntryComponentSound { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public bool LockSoldierAimingToEntry { get; set; }

		[ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		public bool IsAllowedToExitInAir { get; set; }

		[ContainerField(182), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
		public bool Show1pSoldierInEntry { get; set; }

		[ContainerField(183), LayoutImmutable, Blittable, JsonProperty(Order = 183)]
		public bool StancesEnabled { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public bool Show1pSoldierInEntryForPlayerOnly { get; set; }

		[ContainerField(185), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
		public bool HideSoldierForPassengers { get; set; }

		[ContainerField(186), LayoutImmutable, Blittable, JsonProperty(Order = 186)]
		public bool Show3pSoldierWeaponInEntry { get; set; }

		[ContainerField(187), LayoutImmutable, Blittable, JsonProperty(Order = 187)]
		public bool ShowSoldierGearInEntry { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public bool IsShielded { get; set; }

		[ContainerField(189), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
		public bool ForbiddenForHuman { get; set; }

		[ContainerField(190), LayoutImmutable, Blittable, JsonProperty(Order = 190)]
		public bool ShowSoldierWeaponInEntry { get; set; }

		[ContainerField(191), LayoutImmutable, Blittable, JsonProperty(Order = 191)]
		public bool ShowSoldierInEntry { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			SoldierOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(AIData));
			p_Writer.Write((int) EntryClass);
			p_Writer.Write(p_EbxWriter.WriteImport(InputConceptDefinition));
			p_Writer.Write(p_EbxWriter.WriteImport(InputMapping));
			(RimeWriter Writer, uint ArrayIndex) s_InputCurves = p_EbxWriter.GetArrayWriter(InputCurves.GetType(), InputCurves.Count);
			p_Writer.Write(s_InputCurves.ArrayIndex);
			foreach (var s_Entry in InputCurves)
			{
				s_InputCurves.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			HudData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(EntryOrderNumber);
			p_Writer.Write(EnterImpulse);
			p_Writer.Write(EntryRadius);
			p_Writer.Write((int) TriggerEventOnKey);
			p_Writer.Write((int) EntrySpottingSettings);
			PoseConstraints.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(1);
			p_Writer.Write(SoldierTransitionInvisbleTime);
			p_Writer.Write(NumberOfStances);
			p_Writer.Write(p_EbxWriter.WriteImport(EntryComponentSound));
			p_Writer.Write(LockSoldierAimingToEntry);
			p_Writer.Write(IsAllowedToExitInAir);
			p_Writer.Write(Show1pSoldierInEntry);
			p_Writer.Write(StancesEnabled);
			p_Writer.Write(Show1pSoldierInEntryForPlayerOnly);
			p_Writer.Write(HideSoldierForPassengers);
			p_Writer.Write(Show3pSoldierWeaponInEntry);
			p_Writer.Write(ShowSoldierGearInEntry);
			p_Writer.Write(IsShielded);
			p_Writer.Write(ForbiddenForHuman);
			p_Writer.Write(ShowSoldierWeaponInEntry);
			p_Writer.Write(ShowSoldierInEntry);
		}
	}
}
