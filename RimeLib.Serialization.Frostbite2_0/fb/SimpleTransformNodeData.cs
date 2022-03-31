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
	[ContainerType(4, 40)]
	public class SimpleTransformNodeData :
		AudioGraphNodeData
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort X { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public AudioGraphNodePort Y { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public AudioGraphNodePort Z { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public SimpleTransformOperation Operation { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public AngleUnit AngleUnit { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			X.Serialize(p_Writer, p_EbxWriter);
			Y.Serialize(p_Writer, p_EbxWriter);
			Z.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Operation);
			p_Writer.Write((int) AngleUnit);
		}
	}
}
