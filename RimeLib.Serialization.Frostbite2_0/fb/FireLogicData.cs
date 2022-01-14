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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 152)]
	public class FireLogicData :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public HoldAndReleaseData HoldAndRelease { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public BoltActionData BoltAction { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public RecoilData Recoil { get; set; } = new();
		
		[ContainerField(80), JsonProperty(Order = 80)]
		public EntryInputActionEnum FireInputAction { get; set; } = new();
		
		[ContainerField(84), JsonProperty(Order = 84)]
		public EntryInputActionEnum ReloadInputAction { get; set; } = new();
		
		[ContainerField(88), JsonProperty(Order = 88)]
		public EntryInputActionEnum CycleFireModeInputAction { get; set; } = new();
		
		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float TriggerPullWeight { get; set; }
		
		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float RateOfFire { get; set; }
		
		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float RateOfFireForBurst { get; set; }
		
		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float ClientFireRateMultiplier { get; set; }
		
		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float ReloadDelay { get; set; }
		
		[ContainerField(112), JsonProperty(Order = 112)]
		public List<FireLogicType> FireLogicTypeArray { get; set; } = new();
		
		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float ReloadThreshold { get; set; }
		
		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float PreFireDelay { get; set; }
		
		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float ReloadTime { get; set; }
		
		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float ReloadTimeBulletsLeft { get; set; }
		
		[ContainerField(132), JsonProperty(Order = 132)]
		public FireLogicType FireLogicType { get; set; } = new();
		
		[ContainerField(136), JsonProperty(Order = 136)]
		public ReloadLogic ReloadLogic { get; set; } = new();
		
		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float AutomaticDelay { get; set; }
		
		[ContainerField(144), JsonProperty(Order = 144)]
		public ReloadType ReloadType { get; set; } = new();
		
		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public bool HoldOffReloadUntilZoomRelease { get; set; }
		
		[ContainerField(149), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
		public bool ForceReloadActionOnFireTrigger { get; set; }
		
		[ContainerField(150), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
		public bool HoldOffReloadUntilFireRelease { get; set; }
		
		[ContainerField(151), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
		public bool AlwaysAutoReload { get; set; }
		
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
