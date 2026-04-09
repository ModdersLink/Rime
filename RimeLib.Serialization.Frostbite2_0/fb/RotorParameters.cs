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
	[ContainerType(4, 56)]
	public partial class RotorParameters :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _CyclicInputScaleRoll;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _CyclicInputScalePitch;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _CollectiveThrottleInputScale;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _CollectiveBrakeInputScale;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _CollectiveInputIdle;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _HorizontalForceModifier;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private List<Vec2> _AngleOfAttack = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _CyclicFadeOutOffset;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _AdditionalGravityModifier;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _HorisontalMinEffectMod;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _HorisontalMinEffectVelocity;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private bool _EnableHorisontalMinEffect;

		[ObservableProperty]
		[property: ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		private bool _ReverseThrottle;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(CyclicInputScaleRoll);
			p_Writer.Write(CyclicInputScalePitch);
			p_Writer.Write(CollectiveThrottleInputScale);
			p_Writer.Write(CollectiveBrakeInputScale);
			p_Writer.Write(CollectiveInputIdle);
			p_Writer.Write(HorizontalForceModifier);
			(RimeWriter Writer, uint ArrayIndex) s_AngleOfAttack = p_EbxWriter.GetArrayWriter(AngleOfAttack.GetType(), AngleOfAttack.Count);
			p_Writer.Write(s_AngleOfAttack.ArrayIndex);
			foreach (var s_Entry in AngleOfAttack)
			{
				s_Entry.Serialize(s_AngleOfAttack.Writer, p_EbxWriter);
			}
			p_Writer.Write(CyclicFadeOutOffset);
			p_Writer.Write(AdditionalGravityModifier);
			p_Writer.Write(HorisontalMinEffectMod);
			p_Writer.Write(HorisontalMinEffectVelocity);
			p_Writer.Write(EnableHorisontalMinEffect);
			p_Writer.Write(ReverseThrottle);
			p_Writer.WriteNullBytes(2);
		}
	}
}
