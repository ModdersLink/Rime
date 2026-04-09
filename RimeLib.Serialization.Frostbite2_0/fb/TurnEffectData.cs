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
	[ContainerType(4, 32)]
	public partial class TurnEffectData :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		private float _MaxRollAngle;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		private float _MaxPitchAngle;
		
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _YawVelocityThreshhold;
		
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _VelocityThreshhold;
		
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _SafeTime;
		
		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _BeginTime;
		
		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _HoldTime;
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _EndTime;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MaxRollAngle);
			p_Writer.Write(MaxPitchAngle);
			p_Writer.Write(YawVelocityThreshhold);
			p_Writer.Write(VelocityThreshhold);
			p_Writer.Write(SafeTime);
			p_Writer.Write(BeginTime);
			p_Writer.Write(HoldTime);
			p_Writer.Write(EndTime);
		}
	}
}
