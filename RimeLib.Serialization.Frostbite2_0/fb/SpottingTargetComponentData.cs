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
	public partial class SpottingTargetComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _ActiveSpottedTime;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _PassiveSpottedTime;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _ActiveSpottedTimeMultiplier;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _PassiveSpottedTimeMultiplier;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _SpotOnFireMultiplier;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private bool _TargetBoundingBoxCenter;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ActiveSpottedTime);
			p_Writer.Write(PassiveSpottedTime);
			p_Writer.Write(ActiveSpottedTimeMultiplier);
			p_Writer.Write(PassiveSpottedTimeMultiplier);
			p_Writer.Write(SpotOnFireMultiplier);
			p_Writer.Write(TargetBoundingBoxCenter);
			p_Writer.WriteNullBytes(11);
		}
	}
}
