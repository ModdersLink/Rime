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
	[ContainerType(4, 72)]
	public partial class AdsrNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _Trigger = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _Release = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _A = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AudioGraphNodePort _D = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AudioGraphNodePort _S = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AudioGraphNodePort _R = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AudioGraphNodePort _Value = new();

		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AudioGraphNodePort _Finished = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Trigger.Serialize(p_Writer, p_EbxWriter);
			Release.Serialize(p_Writer, p_EbxWriter);
			A.Serialize(p_Writer, p_EbxWriter);
			D.Serialize(p_Writer, p_EbxWriter);
			S.Serialize(p_Writer, p_EbxWriter);
			R.Serialize(p_Writer, p_EbxWriter);
			Value.Serialize(p_Writer, p_EbxWriter);
			Finished.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
