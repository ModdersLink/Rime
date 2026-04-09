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
	[ContainerType(4, 16)]
	public partial class SoundBusData :
		AudioGraphNodeData
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		private string _BusName = string.Empty;

		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private SoundGraphPluginRef _SubmixPlugin = new();

		[ObservableProperty]
		[property: ContainerField(15), LayoutImmutable, Blittable, JsonProperty(Order = 15)]
		private sbyte _ChannelCount;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(BusName));
			SubmixPlugin.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ChannelCount);
		}
	}
}
