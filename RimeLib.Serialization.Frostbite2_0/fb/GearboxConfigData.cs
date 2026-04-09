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
	[ContainerType(4, 64)]
	public partial class GearboxConfigData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private List<float> _ForwardGearRatios = new();

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<float> _ForwardGearSpeeds = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<float> _ReverseGearRatios = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<float> _ReverseGearSpeeds = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private int _GearboxType;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private int _GearboxMode;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _GearChangeTime;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _GearDownSpeedFactor;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _OppositeDirGearChangeMaxSpeed;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _OppositeDirGearChangeTime;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _ClutchSpeedFactor;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _TransmissionEfficiency;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _BackwardThrottleLimit;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _UseClassicGearBoxAutoClutch;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _UseNeutralGear;

		[ObservableProperty]
		[property: ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		private bool _LimitBackwardThrottle;

		[ObservableProperty]
		[property: ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		private bool _UseAutoClutch;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			(RimeWriter Writer, uint ArrayIndex) s_ForwardGearRatios = p_EbxWriter.GetArrayWriter(ForwardGearRatios.GetType(), ForwardGearRatios.Count);
			p_Writer.Write(s_ForwardGearRatios.ArrayIndex);
			foreach (var s_Entry in ForwardGearRatios)
			{
				s_ForwardGearRatios.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ForwardGearSpeeds = p_EbxWriter.GetArrayWriter(ForwardGearSpeeds.GetType(), ForwardGearSpeeds.Count);
			p_Writer.Write(s_ForwardGearSpeeds.ArrayIndex);
			foreach (var s_Entry in ForwardGearSpeeds)
			{
				s_ForwardGearSpeeds.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ReverseGearRatios = p_EbxWriter.GetArrayWriter(ReverseGearRatios.GetType(), ReverseGearRatios.Count);
			p_Writer.Write(s_ReverseGearRatios.ArrayIndex);
			foreach (var s_Entry in ReverseGearRatios)
			{
				s_ReverseGearRatios.Writer.Write(s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_ReverseGearSpeeds = p_EbxWriter.GetArrayWriter(ReverseGearSpeeds.GetType(), ReverseGearSpeeds.Count);
			p_Writer.Write(s_ReverseGearSpeeds.ArrayIndex);
			foreach (var s_Entry in ReverseGearSpeeds)
			{
				s_ReverseGearSpeeds.Writer.Write(s_Entry);
			}
			p_Writer.Write(GearboxType);
			p_Writer.Write(GearboxMode);
			p_Writer.Write(GearChangeTime);
			p_Writer.Write(GearDownSpeedFactor);
			p_Writer.Write(OppositeDirGearChangeMaxSpeed);
			p_Writer.Write(OppositeDirGearChangeTime);
			p_Writer.Write(ClutchSpeedFactor);
			p_Writer.Write(TransmissionEfficiency);
			p_Writer.Write(BackwardThrottleLimit);
			p_Writer.Write(UseClassicGearBoxAutoClutch);
			p_Writer.Write(UseNeutralGear);
			p_Writer.Write(LimitBackwardThrottle);
			p_Writer.Write(UseAutoClutch);
		}
	}
}
