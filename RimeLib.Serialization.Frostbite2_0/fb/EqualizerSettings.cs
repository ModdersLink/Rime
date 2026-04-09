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
	[ContainerType(4, 28)]
	public partial class EqualizerSettings :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _LowShelfFrequency;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _LowShelfGain;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _HighShelfFrequency;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _HighShelfGain;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _HpCutoffFrequency;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(LowShelfFrequency);
			p_Writer.Write(LowShelfGain);
			p_Writer.Write(HighShelfFrequency);
			p_Writer.Write(HighShelfGain);
			p_Writer.Write(HpCutoffFrequency);
		}
	}
}
