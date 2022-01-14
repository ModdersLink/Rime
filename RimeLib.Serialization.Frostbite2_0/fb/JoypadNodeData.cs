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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 56)]
	public class JoypadNodeData :
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort LeftAnalogX { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort LeftAnalogY { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort RightAnalogX { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public AudioGraphNodePort RightAnalogY { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public AudioGraphNodePort AButton { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public AudioGraphNodePort BButton { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			LeftAnalogX.Serialize(p_Writer, p_EbxWriter);
			LeftAnalogY.Serialize(p_Writer, p_EbxWriter);
			RightAnalogX.Serialize(p_Writer, p_EbxWriter);
			RightAnalogY.Serialize(p_Writer, p_EbxWriter);
			AButton.Serialize(p_Writer, p_EbxWriter);
			BButton.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
