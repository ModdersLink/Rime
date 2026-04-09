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
	[ContainerType(4, 152)]
	public partial class FireLogicData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private HoldAndReleaseData _HoldAndRelease = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private BoltActionData _BoltAction = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private RecoilData _Recoil = new();
		
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private EntryInputActionEnum _FireInputAction = new();
		
		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private EntryInputActionEnum _ReloadInputAction = new();
		
		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private EntryInputActionEnum _CycleFireModeInputAction = new();
		
		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _TriggerPullWeight;
		
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _RateOfFire;
		
		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _RateOfFireForBurst;
		
		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _ClientFireRateMultiplier;
		
		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _ReloadDelay;
		
		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private List<FireLogicType> _FireLogicTypeArray = new();
		
		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _ReloadThreshold;
		
		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _PreFireDelay;
		
		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _ReloadTime;
		
		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _ReloadTimeBulletsLeft;
		
		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private FireLogicType _FireLogicType = new();
		
		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private ReloadLogic _ReloadLogic = new();
		
		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _AutomaticDelay;
		
		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private ReloadType _ReloadType = new();
		
		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private bool _HoldOffReloadUntilZoomRelease;
		
		[ObservableProperty]
		[property: ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		private bool _ForceReloadActionOnFireTrigger;
		
		[ObservableProperty]
		[property: ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		private bool _HoldOffReloadUntilFireRelease;
		
		[ObservableProperty]
		[property: ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		private bool _AlwaysAutoReload;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			HoldAndRelease.Serialize(p_Writer, p_EbxWriter);
			BoltAction.Serialize(p_Writer, p_EbxWriter);
			Recoil.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) FireInputAction);
			p_Writer.Write((int) ReloadInputAction);
			p_Writer.Write((int) CycleFireModeInputAction);
			p_Writer.Write(TriggerPullWeight);
			p_Writer.Write(RateOfFire);
			p_Writer.Write(RateOfFireForBurst);
			p_Writer.Write(ClientFireRateMultiplier);
			p_Writer.Write(ReloadDelay);
			(RimeWriter Writer, uint ArrayIndex) s_FireLogicTypeArray = p_EbxWriter.GetArrayWriter(FireLogicTypeArray.GetType(), FireLogicTypeArray.Count);
			p_Writer.Write(s_FireLogicTypeArray.ArrayIndex);
			foreach (var s_Entry in FireLogicTypeArray)
			{
				s_FireLogicTypeArray.Writer.Write((int) s_Entry);
			}
			p_Writer.Write(ReloadThreshold);
			p_Writer.Write(PreFireDelay);
			p_Writer.Write(ReloadTime);
			p_Writer.Write(ReloadTimeBulletsLeft);
			p_Writer.Write((int) FireLogicType);
			p_Writer.Write((int) ReloadLogic);
			p_Writer.Write(AutomaticDelay);
			p_Writer.Write((int) ReloadType);
			p_Writer.Write(HoldOffReloadUntilZoomRelease);
			p_Writer.Write(ForceReloadActionOnFireTrigger);
			p_Writer.Write(HoldOffReloadUntilFireRelease);
			p_Writer.Write(AlwaysAutoReload);
		}
	}
}
