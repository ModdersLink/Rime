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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 192)]
	public partial class EntryComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _SoldierOffset = new();

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CtrRef<GameAIEntryData> _AIData = new();

		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private EntryClass _EntryClass = new();

		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private CtrRef<EntryInputActionMapsData> _InputConceptDefinition = new();

		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private CtrRef<InputActionMappingsData> _InputMapping = new();

		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private RefArray<InputCurveData> _InputCurves = new();

		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private EntryComponentHudData _HudData = new();

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private int _EntryOrderNumber;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _EnterImpulse;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _EntryRadius;

		[ObservableProperty]
		[property: ContainerField(156), JsonProperty(Order = 156)]
		private EntryInputActionEnum _TriggerEventOnKey = new();

		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private EntrySpottingSettings _EntrySpottingSettings = new();

		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private PoseConstraintsData _PoseConstraints = new();

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _SoldierTransitionInvisbleTime;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private int _NumberOfStances;

		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private CtrRef<EntryComponentSoundData> _EntryComponentSound = new();

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private bool _LockSoldierAimingToEntry;

		[ObservableProperty]
		[property: ContainerField(181), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
		private bool _IsAllowedToExitInAir;

		[ObservableProperty]
		[property: ContainerField(182), LayoutImmutable, Blittable, JsonProperty(Order = 182)]
		private bool _Show1pSoldierInEntry;

		[ObservableProperty]
		[property: ContainerField(183), LayoutImmutable, Blittable, JsonProperty(Order = 183)]
		private bool _StancesEnabled;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private bool _Show1pSoldierInEntryForPlayerOnly;

		[ObservableProperty]
		[property: ContainerField(185), LayoutImmutable, Blittable, JsonProperty(Order = 185)]
		private bool _HideSoldierForPassengers;

		[ObservableProperty]
		[property: ContainerField(186), LayoutImmutable, Blittable, JsonProperty(Order = 186)]
		private bool _Show3pSoldierWeaponInEntry;

		[ObservableProperty]
		[property: ContainerField(187), LayoutImmutable, Blittable, JsonProperty(Order = 187)]
		private bool _ShowSoldierGearInEntry;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private bool _IsShielded;

		[ObservableProperty]
		[property: ContainerField(189), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
		private bool _ForbiddenForHuman;

		[ObservableProperty]
		[property: ContainerField(190), LayoutImmutable, Blittable, JsonProperty(Order = 190)]
		private bool _ShowSoldierWeaponInEntry;

		[ObservableProperty]
		[property: ContainerField(191), LayoutImmutable, Blittable, JsonProperty(Order = 191)]
		private bool _ShowSoldierInEntry;

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
