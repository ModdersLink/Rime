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

namespace fb
{
	[ContainerType(4, 72)]
	public class AdsrNodeData :
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort Trigger { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort Release { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort A { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public AudioGraphNodePort D { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public AudioGraphNodePort S { get; set; } = new();

		[ContainerField(48), JsonProperty(Order = 48)]
		public AudioGraphNodePort R { get; set; } = new();

		[ContainerField(56), JsonProperty(Order = 56)]
		public AudioGraphNodePort Value { get; set; } = new();

		[ContainerField(64), JsonProperty(Order = 64)]
		public AudioGraphNodePort Finished { get; set; } = new();

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
