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
	[ContainerType(4, 48)]
	public partial class CharacterStatePoseInfo :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private CharacterPoseType _PoseType = new();

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _Velocity;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _AccelerationGain;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _DecelerationGain;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _SprintGain;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _SprintMultiplier;

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private SpeedModifierData _SpeedModifier = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write((int) PoseType);
			p_Writer.Write(Velocity);
			p_Writer.Write(AccelerationGain);
			p_Writer.Write(DecelerationGain);
			p_Writer.Write(SprintGain);
			p_Writer.Write(SprintMultiplier);
			SpeedModifier.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
