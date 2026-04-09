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
	[ContainerType(4, 52)]
	public partial class TimerNodeData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AudioGraphNodePort _Start = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AudioGraphNodePort _Stop = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AudioGraphNodePort _Period = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AudioGraphNodePort _Tick = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AudioGraphNodePort _Progress = new();

		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private TimerMode _Mode = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Start.Serialize(p_Writer, p_EbxWriter);
			Stop.Serialize(p_Writer, p_EbxWriter);
			Period.Serialize(p_Writer, p_EbxWriter);
			Tick.Serialize(p_Writer, p_EbxWriter);
			Progress.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Mode);
		}
	}
}
