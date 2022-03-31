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
	[ContainerType(4, 24)]
	public class MapRotationConfig :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public int MapRotationId { get; set; }
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string NameSid { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string DescSid { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string Mod { get; set; } = string.Empty;
		
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string GameMode { get; set; } = string.Empty;
		
		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool RandomizeStartingMap { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MapRotationId);
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
			p_Writer.Write(p_EbxWriter.WriteString(DescSid));
			p_Writer.Write(p_EbxWriter.WriteString(Mod));
			p_Writer.Write(p_EbxWriter.WriteString(GameMode));
			p_Writer.Write(RandomizeStartingMap);
			p_Writer.WriteNullBytes(3);
		}
	}
}
