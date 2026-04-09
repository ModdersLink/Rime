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
	[ContainerType(4, 36)]
	public partial class NumberGeneratorNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _Trigger = new();

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _Min;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _Max;

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private NumberGeneratorMode _Mode = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AudioGraphNodePort _Y = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Trigger.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Min);
			p_Writer.Write(Max);
			p_Writer.Write((int) Mode);
			Y.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
