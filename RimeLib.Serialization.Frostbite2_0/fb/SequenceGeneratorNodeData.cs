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
	public partial class SequenceGeneratorNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _Trigger = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _Reset = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _Min = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AudioGraphNodePort _Max = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AudioGraphNodePort _Step = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AudioGraphNodePort _Value = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Trigger.Serialize(p_Writer, p_EbxWriter);
			Reset.Serialize(p_Writer, p_EbxWriter);
			Min.Serialize(p_Writer, p_EbxWriter);
			Max.Serialize(p_Writer, p_EbxWriter);
			Step.Serialize(p_Writer, p_EbxWriter);
			Value.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
