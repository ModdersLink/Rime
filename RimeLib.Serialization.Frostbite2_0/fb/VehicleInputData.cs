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
	[ContainerType(4, 80)]
	public partial class VehicleInputData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private float _ThrottleDeadzone;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private float _BrakeDeadzone;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _YawDeadzone;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _PitchDeadzone;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _RollDeadzone;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _ThrottleInertiaOutDuration;
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _ThrottleInertiaInDuration;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _ThrottleInertiaMinRatio;
		
		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _BrakeInertiaOutDuration;
		
		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _BrakeInertiaInDuration;
		
		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _BrakeInertiaMinRatio;
		
		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _YawInertiaOutDuration;
		
		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _YawInertiaInDuration;
		
		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _YawInertiaMinRatio;
		
		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _PitchInertiaOutDuration;
		
		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _PitchInertiaInDuration;
		
		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _PitchInertiaMinRatio;
		
		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _RollInertiaOutDuration;
		
		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _RollInertiaInDuration;
		
		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _RollInertiaMinRatio;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ThrottleDeadzone);
			p_Writer.Write(BrakeDeadzone);
			p_Writer.Write(YawDeadzone);
			p_Writer.Write(PitchDeadzone);
			p_Writer.Write(RollDeadzone);
			p_Writer.Write(ThrottleInertiaOutDuration);
			p_Writer.Write(ThrottleInertiaInDuration);
			p_Writer.Write(ThrottleInertiaMinRatio);
			p_Writer.Write(BrakeInertiaOutDuration);
			p_Writer.Write(BrakeInertiaInDuration);
			p_Writer.Write(BrakeInertiaMinRatio);
			p_Writer.Write(YawInertiaOutDuration);
			p_Writer.Write(YawInertiaInDuration);
			p_Writer.Write(YawInertiaMinRatio);
			p_Writer.Write(PitchInertiaOutDuration);
			p_Writer.Write(PitchInertiaInDuration);
			p_Writer.Write(PitchInertiaMinRatio);
			p_Writer.Write(RollInertiaOutDuration);
			p_Writer.Write(RollInertiaInDuration);
			p_Writer.Write(RollInertiaMinRatio);
		}
	}
}
