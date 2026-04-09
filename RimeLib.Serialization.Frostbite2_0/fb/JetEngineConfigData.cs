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
	[ContainerType(16, 128)]
	public partial class JetEngineConfigData :
		EngineConfigData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec2 _PowerFadeOutRange = new();

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _ForceMagnitudeMultiplier;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _AngleInputYMultiplier;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _AngleInputPitchMultiplier;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _MaxVelocity;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private uint _DirectionVectorIndex;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private bool _IsWaterJetEngine;

		[ObservableProperty]
		[property: ContainerField(125), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
		private bool _IsTurnable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			PowerFadeOutRange.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ForceMagnitudeMultiplier);
			p_Writer.Write(AngleInputYMultiplier);
			p_Writer.Write(AngleInputPitchMultiplier);
			p_Writer.Write(MaxVelocity);
			p_Writer.Write(DirectionVectorIndex);
			p_Writer.Write(IsWaterJetEngine);
			p_Writer.Write(IsTurnable);
			p_Writer.WriteNullBytes(2);
		}
	}
}
