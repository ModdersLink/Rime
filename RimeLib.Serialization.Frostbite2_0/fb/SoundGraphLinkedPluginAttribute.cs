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
	[ContainerType(4, 20)]
	public class SoundGraphLinkedPluginAttribute :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public SoundGraphPluginRef Plugin { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public CtrRef<AudioGraphNodeData> Node { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort Port { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public sbyte AttributeIndex { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
		public bool AllowExtremeValues { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Plugin.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(1);
			p_Writer.Write(p_EbxWriter.WriteImport(Node));
			Port.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(AttributeIndex);
			p_Writer.Write(AllowExtremeValues);
			p_Writer.WriteNullBytes(2);
		}
	}
}
