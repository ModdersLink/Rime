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
	[ContainerType(4, 12)]
	public class SoundGraphPluginInfo :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public uint Id { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public uint EnableAttributeReadMask { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public sbyte ConnectionIndex { get; set; }
		
		[ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		public sbyte OutputChannelCount { get; set; }
		
		[ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		public sbyte ConstructParamsIndex { get; set; }
		
		[ContainerField(11), LayoutImmutable, Blittable, JsonProperty(Order = 11)]
		public sbyte ConstructParamCount { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Id);
			p_Writer.Write(EnableAttributeReadMask);
			p_Writer.Write(ConnectionIndex);
			p_Writer.Write(OutputChannelCount);
			p_Writer.Write(ConstructParamsIndex);
			p_Writer.Write(ConstructParamCount);
		}
	}
}
